using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaTrpz
{
    public partial class Form1 : Form
    {
        string connectionString;
        int iShow = 2;
        int maxShow = 0;
        int iDolphin = 1;
        int maxDolphin = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (!LoginClass.logined)
            {
                Hide();
                LoginForm loginForm = new LoginForm(connectionString);
                loginForm.Show();
            }
            else
            {
                LoginClass.logined = false;
                LoginClass.admin = false;
                LoginClass.currentId = 0;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoginClass.logined)
            {
                login.Text = "Вийти";
                PersonalButton.Visible = true;
                if(!LoginClass.admin)
                    button1.Visible = true;
            }
            else
            {
                login.Text = "Увійти в акаунт";
                PersonalButton.Visible = false;
                button1.Visible = false;
            }
            
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            if (!LoginClass.admin)
            {
                PersonalCabinetForm personalCabinetForm = new PersonalCabinetForm(connectionString);
                personalCabinetForm.Show();
            }
            else
            {
                AdminForm adminForm = new AdminForm(connectionString);
                adminForm.Show();
            }
            Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder["Data Source"] = @".\SQLEXPRESS";
            connectionStringBuilder["Initial Catalog"] = "Dolphinarium_KR";
            connectionStringBuilder["Integrated Security"] = true;
            connectionStringBuilder["MultipleActiveResultSets"] = true;
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    connectionString = connectionStringBuilder.ConnectionString;

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            ChangeShowMax();
            GetShowById(iShow);
            GetDolphinById(iDolphin, iShow);
            ChangeDolphinMax();
        }

        private void RightShow_Click(object sender, EventArgs e)
        {
            if (iShow + 1 <= maxShow)
            {
                GetShowById(++iShow);
            }
        }
        private List<int> GetShowIds(SqlConnection sqlConnection)
        {
            SqlCommand getId = new SqlCommand();
            getId.Connection = sqlConnection;
            getId.CommandText = @"Select Id from Show";
            List<int> ids = new List<int>();
            using SqlDataReader idReader = getId.ExecuteReader();
            while (idReader.Read())
            {
                ids.Add(idReader.GetInt32(0));
            }
            return ids;
        }

        private void GetShowById(int id)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();


                List<int> ids = GetShowIds(sqlConnection);


                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select Name, Cost, Duration, Location from Show where Id = @Id";
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                sqlCommand.Parameters["@Id"].Value = ids[id - 1];
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    ShowNameText.Text = sqlDataReader.GetString(0);
                    CostText.Text = sqlDataReader.GetDecimal(1).ToString();
                    DurationText.Text = sqlDataReader.GetString(2);
                    LocationText.Text = sqlDataReader.GetString(3);
                }
                iDolphin = 1;
                ChangeDolphinMax();
                GetDolphinById(iDolphin, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }
        private void ChangeShowMax()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select count(Id) from Show";
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                    maxShow = sqlDataReader.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void LeftShow_Click(object sender, EventArgs e)
        {
            if (iShow - 1 > 1)
            {
                GetShowById(--iShow);
            }
        }

        private void NextDolphin_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (iDolphin + 1 <= maxDolphin)
            {
                GetDolphinById(++iDolphin, iShow);
            }
            timer1.Start();
        }

        private List<int> GetDolphinIds(SqlConnection sqlConnection, int showId)
        {
            SqlCommand getId = new SqlCommand();
            getId.Connection = sqlConnection;
            getId.CommandText = @"Select DolphinId from Show_Dolphin where ShowId = @ShowId";
            getId.Parameters.Add("@ShowId", SqlDbType.Int);
            getId.Parameters["@ShowId"].Value = GetShowIds(sqlConnection)[showId - 1];
            List<int> ids = new List<int>();
            using SqlDataReader idReader = getId.ExecuteReader();
            while (idReader.Read())
            {
                ids.Add(idReader.GetInt32(0));
            }
            return ids;
        }

        private void ChangeDolphinMax()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            maxDolphin = GetDolphinIds(sqlConnection, iShow).Count;
        }
        private void GetDolphinById(int id, int showId)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();


                List<int> ids = GetDolphinIds(sqlConnection, showId);
                maxDolphin = ids.Count;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select Photo from Dolphins where Id = @Id";
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                sqlCommand.Parameters["@Id"].Value = ids[id - 1];
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    byte[] data = (byte[])sqlDataReader.GetValue(0);
                    using (MemoryStream inStream = new MemoryStream())
                    {
                        inStream.Write(data, 0, data.Length);
                        Image image = Image.FromStream(inStream);
                        pictureBox1.Image = new Bitmap(image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void PrevDolphin_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (iDolphin - 1 > 0)
            {
                GetDolphinById(--iDolphin, iShow);
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!PersonalButton.Visible)
            {
                MessageBox.Show("Ви маєте авторизуватися щоб замовити квиток!");
                return;
            }
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Insert into Tickets values(@Number, @ShowId, @AuthId)";
                sqlCommand.Parameters.Add("@Number", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@ShowId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@AuthId", SqlDbType.Int);
                Random random = new Random();
                sqlCommand.Parameters["@Number"].Value = random.Next().ToString();
                SqlCommand getShowId = new SqlCommand();
                getShowId.Connection = sqlConnection;
                getShowId.CommandText = @"Select Id from Show where Name = @Name";
                getShowId.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                getShowId.Parameters["@Name"].Value = ShowNameText.Text;
                using SqlDataReader idReader = getShowId.ExecuteReader();
                if(idReader.Read())
                {
                    sqlCommand.Parameters["@ShowId"].Value = idReader.GetValue(0);
                }
                sqlCommand.Parameters["@AuthId"].Value = LoginClass.currentId;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успішно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeShowMax();
            GetShowById(iShow);
            GetDolphinById(iDolphin, iShow);
            ChangeDolphinMax();
        }
    }
}
