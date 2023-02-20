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
    public partial class PersonalCabinetForm : Form
    {
        string connectionString;
        int prev = 0;
        public PersonalCabinetForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            ShowTickets();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            Close();
        }

        private void PersonalCabinetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = Application.OpenForms[0];
            if (!form.Visible)
                form.Close();
        }

        private void ShowTickets()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $@"Select Number, Show.Name from Tickets
                join Show on Show.Id = ShowId where AuthId = {LoginClass.currentId}";
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[2]);
                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                }
                foreach (var x in data)
                {
                    dataGridView1.Rows.Add(x);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        

        private void RightButton_Click(object sender, EventArgs e)
        {
            if(ShowSearch.Text != "")
                GetTickets(">");
            else
                MessageBox.Show("Неможливо шукати по порожньому полю");
        }

        private void GetTickets(string symb)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $@"Select Tickets.Id, Number, Name, Duration, Location from Tickets join Show on Show.Id = ShowId where AuthId = @AuthId and Tickets.Id {symb} {prev} and Name = @Name";
                sqlCommand.Parameters.Add("@AuthId", SqlDbType.Int);
                sqlCommand.Parameters["@AuthId"].Value = LoginClass.currentId;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters["@Name"].Value = ShowSearch.Text;
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    prev = sqlDataReader.GetInt32(0);
                    NumberText.Text = sqlDataReader.GetString(1);
                    NameText.Text = sqlDataReader.GetString(2);
                    TimeText.Text = sqlDataReader.GetString(3);
                    AddressText.Text = sqlDataReader.GetString(4);
                }
                else
                    MessageBox.Show("Квитків по даному шоу не знайдено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {

            if (ShowSearch.Text != "")
                GetTickets("<");
            else
                MessageBox.Show("Неможливо шукати по порожньому полю");
        }

        private void findShows_Click(object sender, EventArgs e)
        {
            if(ShowSearch.Text != "")
                GetTickets(">");
            else
                MessageBox.Show("Неможливо шукати по порожньому полю");
        }
    }
}
