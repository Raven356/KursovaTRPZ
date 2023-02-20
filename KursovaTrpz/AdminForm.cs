using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KursovaTrpz
{
    public partial class AdminForm : Form
    {
        string connectionString;

        int iDolphin = 0;
        int maxDolphin = 0;

        int iShow = 0;
        int maxShow = 0;

        public AdminForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            ChangeDolphMax();
            ChangeShowMax();
            ShowEmployees();
        }

        private void ChangeDolphMax()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select count(Id) from Dolphins";
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                    maxDolphin = sqlDataReader.GetInt32(0);
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            Close();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = Application.OpenForms[0];
            if (!form.Visible)
                form.Close();
        }

        private void AddDophinButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Insert into Dolphins values (@Name, @Country, @Photo)";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Country", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Photo", SqlDbType.Image, 1000000);

                ImageConverter converter = new ImageConverter();
                sqlCommand.Parameters["@Name"].Value = NameDolphText.Text;
                sqlCommand.Parameters["@Country"].Value = CountryText.Text;
                sqlCommand.Parameters["@Photo"].Value = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                sqlCommand.ExecuteNonQuery();
                ClearDoplhins();
                ChangeDolphMax();
                iDolphin = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void ChangePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files (*.*) | *.* ";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(open_dialog.FileName);
                    pictureBox1.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити даний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteDolphinButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                List<int> ids = GetDolphinIds(sqlConnection);

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = @"DELETE Dolphins WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = ids[iDolphin - 1];
                command.ExecuteNonQuery();
                ClearDoplhins();
                ChangeDolphMax();
                iDolphin = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void ClearDoplhins()
        {
            NameDolphText.Text = "";
            CountryText.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void NextDolphin_Click(object sender, EventArgs e)
        {
            if(iDolphin + 1 <= maxDolphin)
            {
                GetDolphinById(++iDolphin);
            }
        }

        private void GetDolphinById(int id)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                
                List<int> ids = GetDolphinIds(sqlConnection);
                

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select Name, Country, Photo from Dolphins where Id = @Id";
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                sqlCommand.Parameters["@Id"].Value = ids[id - 1];
                using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    NameDolphText.Text = sqlDataReader.GetString(0);
                    CountryText.Text = sqlDataReader.GetString(1);
                    byte[] data = (byte[])sqlDataReader.GetValue(2);
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
            if(iDolphin - 1 > 0)
            {
                GetDolphinById(--iDolphin);
            }
        }

        private List<int> GetDolphinIds(SqlConnection sqlConnection)
        {
            SqlCommand getId = new SqlCommand();
            getId.Connection = sqlConnection;
            getId.CommandText = @"Select Id from dolphins";
            List<int> ids = new List<int>();
            using SqlDataReader idReader = getId.ExecuteReader();
            while (idReader.Read())
            {
                ids.Add(idReader.GetInt32(0));
            }
            return ids;
        }

        private void EditDolphinButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                List<int> ids = GetDolphinIds(sqlConnection);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Update Dolphins set Name = @Name, Country = @Country, Photo = @Photo where Id = @Id";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Country", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Photo", SqlDbType.Image, 1000000);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);

                sqlCommand.Parameters["@Name"].Value = NameDolphText.Text;
                sqlCommand.Parameters["@Country"].Value = CountryText.Text;
                ImageConverter converter = new ImageConverter();
                sqlCommand.Parameters["@Photo"].Value = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                sqlCommand.Parameters["@Id"].Value = ids[iDolphin - 1];
                sqlCommand.ExecuteNonQuery();
                ClearDoplhins();
                iDolphin = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void AddShowButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Insert into Show values (@Name, @Cost, @Duration, @Location)";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Cost", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@Duration", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50);

                sqlCommand.Parameters["@Name"].Value = ShowNameText.Text;
                sqlCommand.Parameters["@Cost"].Value = CostText.Text;
                sqlCommand.Parameters["@Duration"].Value = DurationText.Text;
                sqlCommand.Parameters["@Location"].Value = LocationText.Text;
                sqlCommand.ExecuteNonQuery();
                ClearShow();
                ChangeShowMax();
                iShow = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void ClearShow()
        {
            ShowNameText.Text = "";
            CostText.Text = "";
            DurationText.Text = "";
            LocationText.Text = "";
        }

        private void DeleteShowButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                List<int> ids = GetShowIds(sqlConnection);

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = @"DELETE Show WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = ids[iShow - 1];
                command.ExecuteNonQuery();
                ClearShow();
                ChangeShowMax();
                iShow = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void NextShow_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void PrevShow_Click(object sender, EventArgs e)
        {
            if (iShow - 1 > 0)
            {
                GetShowById(--iShow);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                List<int> ids = GetShowIds(sqlConnection);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Update Show set Name = @Name, Cost = @Cost, Duration = @Duration, Location = @Location where Id = @Id";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Cost", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@Duration", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);

                sqlCommand.Parameters["@Name"].Value = ShowNameText.Text;
                sqlCommand.Parameters["@Cost"].Value = CostText.Text;
                sqlCommand.Parameters["@Duration"].Value = DurationText.Text;
                sqlCommand.Parameters["@Location"].Value = LocationText.Text;
                sqlCommand.Parameters["@Id"].Value = ids[iShow - 1];
                sqlCommand.ExecuteNonQuery();
                ClearShow();
                ChangeShowMax();
                iShow = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void AddDolphToShow_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                
                sqlConnection.Open();
                int showId = GetIdByName(NameShow.Text, "Show", sqlConnection);
                int dolphinId = GetIdByName(NameDolph.Text, "Dolphins", sqlConnection);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                
                sqlCommand.CommandText = @"Insert into Show_Dolphin values (@DolphinId, @ShowId)";
                sqlCommand.Parameters.Add("@DolphinId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@ShowId", SqlDbType.Int);

                sqlCommand.Parameters["@DolphinId"].Value = dolphinId;
                sqlCommand.Parameters["@ShowId"].Value = showId;
                sqlCommand.ExecuteNonQuery();
                NameDolph.Text = "";
                NameShow.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private int GetIdByName(string name, string table, SqlConnection sqlConnection)
        {
            int result = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"Select Id from {table} where Name = @Name";
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            sqlCommand.Parameters["@Name"].Value = name;
            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                result = sqlDataReader.GetInt32(0);
            }
            return result;
        }

        private void DeleteDolphinFromShow_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {

                sqlConnection.Open();
                int showId = GetIdByName(NameShow.Text, "Show", sqlConnection);
                int dolphinId = GetIdByName(NameDolph.Text, "Dolphins", sqlConnection);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = @"Delete from Show_Dolphin where DolphinId = @DolphinId and ShowId = @ShowId";
                sqlCommand.Parameters.Add("@DolphinId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@ShowId", SqlDbType.Int);

                sqlCommand.Parameters["@DolphinId"].Value = dolphinId;
                sqlCommand.Parameters["@ShowId"].Value = showId;
                sqlCommand.ExecuteNonQuery();
                NameDolph.Text = "";
                NameShow.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void ShowEmployees()
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Select Employee.Id, Employee.Name, Surname, Patronymic, Position.Name, Show.Name from Employee
                join Position on Position.Id = PositionId join Show on Show.Id = ShowId";
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();
                }
                foreach(var x in data)
                {
                    dataGridView1.Rows.Add(x);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                List<string> data = new List<string>();
                for(int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    if(dataGridView1[i, dataGridView1.RowCount - 2].Value is null)
                    {
                        MessageBox.Show("Blank Imput!");
                        return;
                    }
                    data.Add(dataGridView1[i, dataGridView1.RowCount - 2].Value.ToString());
                }
                int positionId = GetIdByName(data[3], "Position", sqlConnection);
                int showId = GetIdByName(data[4], "Show", sqlConnection);
                sqlCommand.CommandText = @"Insert into Employee (Name, Surname, Patronymic, PositionId, ShowId) values (@Name, @Surname, @Patronymic, @PositionId, @ShowId)";

                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@Patronymic", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@PositionId", SqlDbType.Int);
                sqlCommand.Parameters.Add("@ShowId", SqlDbType.Int);


                sqlCommand.Parameters["@Name"].Value = data[0];
                sqlCommand.Parameters["@Surname"].Value = data[1];
                sqlCommand.Parameters["@Patronymic"].Value = data[2];
                sqlCommand.Parameters["@PositionId"].Value = positionId;
                sqlCommand.Parameters["@ShowId"].Value = showId;

                sqlCommand.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                ShowEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Delete Employee where Id = @Id";
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                sqlCommand.Parameters["@Id"].Value = textBox1.Text;
                sqlCommand.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                ShowEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation didn't succeed because of {ex.Message}");
            }
        }
    }
}
