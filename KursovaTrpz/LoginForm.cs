using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KursovaTrpz
{
    public partial class LoginForm : Form
    {
        string connectionString;
        public LoginForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> auth = new Dictionary<string, string>();
            List<int> ids = new List<int>();
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select Login, Password, Id from Auth";
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    auth.Add(sqlDataReader.GetString(0), sqlDataReader.GetString(1));
                    ids.Add(sqlDataReader.GetInt32(2));
                }
                int i = 0;
                foreach (var x in auth)
                {
                    if(x.Key.Equals(loginText.Text) && x.Value.Equals(PasswordText.Text))
                    {
                        if (loginText.Text.Equals("admin"))
                        {
                            LoginClass.admin = true;
                        }
                        LoginClass.logined = true;
                        LoginClass.currentId = ids[i];
                        Form form = Application.OpenForms[0];
                        form.Show();
                        Close();
                        break;
                    }
                    i++;
                }
                if (!LoginClass.logined)
                {
                    MessageBox.Show("Невірний логін або пароль!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form form = Application.OpenForms[0];
            if(!form.Visible)
                form.Close();
        }

        private void RegistryButton_Click(object sender, EventArgs e)
        {
            EnterButton.Visible = false;
            RegistryButton.Visible = false;
            ConfirmButton.Visible = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!CheckForSameLogin())
            {
                using SqlConnection sqlConnection = new SqlConnection(connectionString);
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = @"Insert into Auth values (@Login, @Password)";
                    sqlCommand.Parameters.Add("@Login", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50);

                    if(loginText.Text.Length < 1)
                        throw new ApplicationException("Login couldn't be empty");
                    sqlCommand.Parameters["@Login"].Value = loginText.Text;
                    if(PasswordText.Text.Length <= 4)
                    {
                        throw new ApplicationException("Password should have more than 4 characters");
                    }
                    sqlCommand.Parameters["@Password"].Value = PasswordText.Text;
                    sqlCommand.ExecuteNonQuery();
                    EnterButton.Visible = true;
                    RegistryButton.Visible = true;
                    ConfirmButton.Visible = false;
                    loginText.Text = "";
                    PasswordText.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("This login is already exists");
            }
        }

        private bool CheckForSameLogin()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = @"Select Login from Auth";
            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader.GetValue(0).Equals(loginText.Text))
                    return true;
            }
            return false;
        }
    }
}
