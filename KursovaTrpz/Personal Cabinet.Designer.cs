
namespace KursovaTrpz
{
    partial class PersonalCabinetForm
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
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowSearch = new System.Windows.Forms.TextBox();
            this.findShows = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RightButton.Location = new System.Drawing.Point(258, 197);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(43, 43);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LeftButton.Location = new System.Drawing.Point(35, 197);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(43, 43);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "<";
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер квитка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назва шоу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Час вистави";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адреса";
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(163, 13);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(125, 27);
            this.NumberText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(163, 58);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 8;
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(163, 103);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(125, 27);
            this.TimeText.TabIndex = 9;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(163, 141);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(125, 27);
            this.AddressText.TabIndex = 10;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(625, 14);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 29);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "На головну";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 402);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Передивитись квитки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ShowName});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(793, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // ShowName
            // 
            this.ShowName.HeaderText = "Show Name";
            this.ShowName.MinimumWidth = 6;
            this.ShowName.Name = "ShowName";
            this.ShowName.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.findShows);
            this.tabPage2.Controls.Add(this.ShowSearch);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RightButton);
            this.tabPage2.Controls.Add(this.AddressText);
            this.tabPage2.Controls.Add(this.LeftButton);
            this.tabPage2.Controls.Add(this.TimeText);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NameText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.NumberText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Квитки по шоу";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введіть шоу";
            // 
            // ShowSearch
            // 
            this.ShowSearch.Location = new System.Drawing.Point(513, 48);
            this.ShowSearch.Name = "ShowSearch";
            this.ShowSearch.Size = new System.Drawing.Size(125, 27);
            this.ShowSearch.TabIndex = 12;
            // 
            // findShows
            // 
            this.findShows.Location = new System.Drawing.Point(450, 118);
            this.findShows.Name = "findShows";
            this.findShows.Size = new System.Drawing.Size(165, 29);
            this.findShows.TabIndex = 13;
            this.findShows.Text = "Знайти шоу";
            this.findShows.UseVisualStyleBackColor = true;
            this.findShows.Click += new System.EventHandler(this.findShows_Click);
            // 
            // PersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Name = "PersonalCabinetForm";
            this.Text = "Personal Cabinet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonalCabinetForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowName;
        private System.Windows.Forms.Button findShows;
        private System.Windows.Forms.TextBox ShowSearch;
        private System.Windows.Forms.Label label5;
    }
}