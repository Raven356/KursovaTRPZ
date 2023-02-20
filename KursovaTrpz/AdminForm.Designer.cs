
namespace KursovaTrpz
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddShowButton = new System.Windows.Forms.Button();
            this.DeleteShowButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowNameText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameDolphText = new System.Windows.Forms.TextBox();
            this.CountryText = new System.Windows.Forms.TextBox();
            this.EditDolphinButton = new System.Windows.Forms.Button();
            this.DeleteDolphinButton = new System.Windows.Forms.Button();
            this.AddDophinButton = new System.Windows.Forms.Button();
            this.PrevDolphin = new System.Windows.Forms.Button();
            this.NextDolphin = new System.Windows.Forms.Button();
            this.PrevShow = new System.Windows.Forms.Button();
            this.NextShow = new System.Windows.Forms.Button();
            this.ChangePhotoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CostText = new System.Windows.Forms.TextBox();
            this.DurationText = new System.Windows.Forms.TextBox();
            this.LocationText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameShow = new System.Windows.Forms.TextBox();
            this.NameDolph = new System.Windows.Forms.TextBox();
            this.AddDolphToShow = new System.Windows.Forms.Button();
            this.DeleteDolphinFromShow = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddShowButton
            // 
            this.AddShowButton.Location = new System.Drawing.Point(67, 240);
            this.AddShowButton.Name = "AddShowButton";
            this.AddShowButton.Size = new System.Drawing.Size(138, 35);
            this.AddShowButton.TabIndex = 0;
            this.AddShowButton.Text = "Додати шоу";
            this.AddShowButton.UseVisualStyleBackColor = true;
            this.AddShowButton.Click += new System.EventHandler(this.AddShowButton_Click);
            // 
            // DeleteShowButton
            // 
            this.DeleteShowButton.Location = new System.Drawing.Point(67, 331);
            this.DeleteShowButton.Name = "DeleteShowButton";
            this.DeleteShowButton.Size = new System.Drawing.Size(138, 35);
            this.DeleteShowButton.TabIndex = 1;
            this.DeleteShowButton.Text = "Видалити шоу";
            this.DeleteShowButton.UseVisualStyleBackColor = true;
            this.DeleteShowButton.Click += new System.EventHandler(this.DeleteShowButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(67, 281);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(138, 35);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Редагувати шоу";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва";
            // 
            // ShowNameText
            // 
            this.ShowNameText.Location = new System.Drawing.Point(163, 17);
            this.ShowNameText.Name = "ShowNameText";
            this.ShowNameText.Size = new System.Drawing.Size(125, 27);
            this.ShowNameText.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(967, 11);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 29);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "На головну";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(733, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Країна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Фото";
            // 
            // NameDolphText
            // 
            this.NameDolphText.Location = new System.Drawing.Point(466, 17);
            this.NameDolphText.Name = "NameDolphText";
            this.NameDolphText.Size = new System.Drawing.Size(125, 27);
            this.NameDolphText.TabIndex = 17;
            // 
            // CountryText
            // 
            this.CountryText.Location = new System.Drawing.Point(466, 96);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(125, 27);
            this.CountryText.TabIndex = 18;
            // 
            // EditDolphinButton
            // 
            this.EditDolphinButton.Location = new System.Drawing.Point(408, 281);
            this.EditDolphinButton.Name = "EditDolphinButton";
            this.EditDolphinButton.Size = new System.Drawing.Size(181, 35);
            this.EditDolphinButton.TabIndex = 21;
            this.EditDolphinButton.Text = "Редагувати дельфіна";
            this.EditDolphinButton.UseVisualStyleBackColor = true;
            this.EditDolphinButton.Click += new System.EventHandler(this.EditDolphinButton_Click);
            // 
            // DeleteDolphinButton
            // 
            this.DeleteDolphinButton.Location = new System.Drawing.Point(408, 331);
            this.DeleteDolphinButton.Name = "DeleteDolphinButton";
            this.DeleteDolphinButton.Size = new System.Drawing.Size(181, 35);
            this.DeleteDolphinButton.TabIndex = 20;
            this.DeleteDolphinButton.Text = "Видалити дельфіна";
            this.DeleteDolphinButton.UseVisualStyleBackColor = true;
            this.DeleteDolphinButton.Click += new System.EventHandler(this.DeleteDolphinButton_Click);
            // 
            // AddDophinButton
            // 
            this.AddDophinButton.Location = new System.Drawing.Point(408, 230);
            this.AddDophinButton.Name = "AddDophinButton";
            this.AddDophinButton.Size = new System.Drawing.Size(181, 35);
            this.AddDophinButton.TabIndex = 19;
            this.AddDophinButton.Text = "Додати дельфіна";
            this.AddDophinButton.UseVisualStyleBackColor = true;
            this.AddDophinButton.Click += new System.EventHandler(this.AddDophinButton_Click);
            // 
            // PrevDolphin
            // 
            this.PrevDolphin.Location = new System.Drawing.Point(340, 276);
            this.PrevDolphin.Name = "PrevDolphin";
            this.PrevDolphin.Size = new System.Drawing.Size(53, 44);
            this.PrevDolphin.TabIndex = 22;
            this.PrevDolphin.Text = "<";
            this.PrevDolphin.UseVisualStyleBackColor = true;
            this.PrevDolphin.Click += new System.EventHandler(this.PrevDolphin_Click);
            // 
            // NextDolphin
            // 
            this.NextDolphin.Location = new System.Drawing.Point(603, 276);
            this.NextDolphin.Name = "NextDolphin";
            this.NextDolphin.Size = new System.Drawing.Size(53, 44);
            this.NextDolphin.TabIndex = 23;
            this.NextDolphin.Text = ">";
            this.NextDolphin.UseVisualStyleBackColor = true;
            this.NextDolphin.Click += new System.EventHandler(this.NextDolphin_Click);
            // 
            // PrevShow
            // 
            this.PrevShow.Location = new System.Drawing.Point(7, 276);
            this.PrevShow.Name = "PrevShow";
            this.PrevShow.Size = new System.Drawing.Size(53, 44);
            this.PrevShow.TabIndex = 24;
            this.PrevShow.Text = "<";
            this.PrevShow.UseVisualStyleBackColor = true;
            this.PrevShow.Click += new System.EventHandler(this.PrevShow_Click);
            // 
            // NextShow
            // 
            this.NextShow.Location = new System.Drawing.Point(211, 276);
            this.NextShow.Name = "NextShow";
            this.NextShow.Size = new System.Drawing.Size(53, 44);
            this.NextShow.TabIndex = 25;
            this.NextShow.Text = ">";
            this.NextShow.UseVisualStyleBackColor = true;
            this.NextShow.Click += new System.EventHandler(this.NextShow_Click);
            // 
            // ChangePhotoButton
            // 
            this.ChangePhotoButton.Location = new System.Drawing.Point(847, 372);
            this.ChangePhotoButton.Name = "ChangePhotoButton";
            this.ChangePhotoButton.Size = new System.Drawing.Size(188, 40);
            this.ChangePhotoButton.TabIndex = 26;
            this.ChangePhotoButton.Text = "Змінити фото";
            this.ChangePhotoButton.UseVisualStyleBackColor = true;
            this.ChangePhotoButton.Click += new System.EventHandler(this.ChangePhotoButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Довжина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ціна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Адреса";
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(163, 64);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(125, 27);
            this.CostText.TabIndex = 30;
            // 
            // DurationText
            // 
            this.DurationText.Location = new System.Drawing.Point(163, 124);
            this.DurationText.Name = "DurationText";
            this.DurationText.Size = new System.Drawing.Size(125, 27);
            this.DurationText.TabIndex = 31;
            // 
            // LocationText
            // 
            this.LocationText.Location = new System.Drawing.Point(163, 180);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(125, 27);
            this.LocationText.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Назва";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ім\'я";
            // 
            // NameShow
            // 
            this.NameShow.Location = new System.Drawing.Point(163, 411);
            this.NameShow.Name = "NameShow";
            this.NameShow.Size = new System.Drawing.Size(125, 27);
            this.NameShow.TabIndex = 35;
            // 
            // NameDolph
            // 
            this.NameDolph.Location = new System.Drawing.Point(439, 411);
            this.NameDolph.Name = "NameDolph";
            this.NameDolph.Size = new System.Drawing.Size(125, 27);
            this.NameDolph.TabIndex = 36;
            // 
            // AddDolphToShow
            // 
            this.AddDolphToShow.Location = new System.Drawing.Point(99, 444);
            this.AddDolphToShow.Name = "AddDolphToShow";
            this.AddDolphToShow.Size = new System.Drawing.Size(198, 32);
            this.AddDolphToShow.TabIndex = 37;
            this.AddDolphToShow.Text = "Додати дельфіна на шоу";
            this.AddDolphToShow.UseVisualStyleBackColor = true;
            this.AddDolphToShow.Click += new System.EventHandler(this.AddDolphToShow_Click);
            // 
            // DeleteDolphinFromShow
            // 
            this.DeleteDolphinFromShow.Location = new System.Drawing.Point(385, 444);
            this.DeleteDolphinFromShow.Name = "DeleteDolphinFromShow";
            this.DeleteDolphinFromShow.Size = new System.Drawing.Size(198, 32);
            this.DeleteDolphinFromShow.TabIndex = 38;
            this.DeleteDolphinFromShow.Text = "Видалити дельфіна з шоу";
            this.DeleteDolphinFromShow.UseVisualStyleBackColor = true;
            this.DeleteDolphinFromShow.Click += new System.EventHandler(this.DeleteDolphinFromShow_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 573);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteEmployee);
            this.tabPage2.Controls.Add(this.AddEmployee);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Робота з персоналом";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Location = new System.Drawing.Point(635, 454);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(159, 57);
            this.DeleteEmployee.TabIndex = 5;
            this.DeleteEmployee.Text = "Видалити працівника";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(254, 454);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(159, 57);
            this.AddEmployee.TabIndex = 3;
            this.AddEmployee.Text = "Додати працівника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameEmployee,
            this.Surname,
            this.Patronymic,
            this.Position,
            this.Show});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(944, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // NameEmployee
            // 
            this.NameEmployee.HeaderText = "Name";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Patronymic";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 125;
            // 
            // Show
            // 
            this.Show.HeaderText = "Show";
            this.Show.MinimumWidth = 6;
            this.Show.Name = "Show";
            this.Show.Width = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteDolphinFromShow);
            this.tabPage1.Controls.Add(this.BackButton);
            this.tabPage1.Controls.Add(this.AddDolphToShow);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.NameDolph);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.NameShow);
            this.tabPage1.Controls.Add(this.ChangePhotoButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.NextShow);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.PrevShow);
            this.tabPage1.Controls.Add(this.LocationText);
            this.tabPage1.Controls.Add(this.NextDolphin);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.PrevDolphin);
            this.tabPage1.Controls.Add(this.CountryText);
            this.tabPage1.Controls.Add(this.EditDolphinButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.DeleteDolphinButton);
            this.tabPage1.Controls.Add(this.DurationText);
            this.tabPage1.Controls.Add(this.AddDophinButton);
            this.tabPage1.Controls.Add(this.NameDolphText);
            this.tabPage1.Controls.Add(this.ChangeButton);
            this.tabPage1.Controls.Add(this.DeleteShowButton);
            this.tabPage1.Controls.Add(this.CostText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddShowButton);
            this.tabPage1.Controls.Add(this.ShowNameText);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Робота з шоу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddShowButton;
        private System.Windows.Forms.Button DeleteShowButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShowNameText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameDolphText;
        private System.Windows.Forms.TextBox CountryText;
        private System.Windows.Forms.Button EditDolphinButton;
        private System.Windows.Forms.Button DeleteDolphinButton;
        private System.Windows.Forms.Button AddDophinButton;
        private System.Windows.Forms.Button PrevDolphin;
        private System.Windows.Forms.Button NextDolphin;
        private System.Windows.Forms.Button PrevShow;
        private System.Windows.Forms.Button NextShow;
        private System.Windows.Forms.Button ChangePhotoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CostText;
        private System.Windows.Forms.TextBox DurationText;
        private System.Windows.Forms.TextBox LocationText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameShow;
        private System.Windows.Forms.TextBox NameDolph;
        private System.Windows.Forms.Button AddDolphToShow;
        private System.Windows.Forms.Button DeleteDolphinFromShow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Show;
    }
}