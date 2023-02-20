
namespace KursovaTrpz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login = new System.Windows.Forms.Button();
            this.PersonalButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LocationText = new System.Windows.Forms.TextBox();
            this.DurationText = new System.Windows.Forms.TextBox();
            this.CostText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftShow = new System.Windows.Forms.Button();
            this.RightShow = new System.Windows.Forms.Button();
            this.PrevDolphin = new System.Windows.Forms.Button();
            this.NextDolphin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(768, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 29);
            this.login.TabIndex = 2;
            this.login.Text = "Увійти в акаунт";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // PersonalButton
            // 
            this.PersonalButton.Location = new System.Drawing.Point(587, 12);
            this.PersonalButton.Name = "PersonalButton";
            this.PersonalButton.Size = new System.Drawing.Size(159, 29);
            this.PersonalButton.TabIndex = 5;
            this.PersonalButton.Text = "Особистий кабінет";
            this.PersonalButton.UseVisualStyleBackColor = true;
            this.PersonalButton.Visible = false;
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LocationText
            // 
            this.LocationText.Location = new System.Drawing.Point(190, 253);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(125, 27);
            this.LocationText.TabIndex = 40;
            // 
            // DurationText
            // 
            this.DurationText.Location = new System.Drawing.Point(190, 197);
            this.DurationText.Name = "DurationText";
            this.DurationText.Size = new System.Drawing.Size(125, 27);
            this.DurationText.TabIndex = 39;
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(190, 137);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(125, 27);
            this.CostText.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Адреса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ціна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Довжина";
            // 
            // ShowNameText
            // 
            this.ShowNameText.Location = new System.Drawing.Point(190, 90);
            this.ShowNameText.Name = "ShowNameText";
            this.ShowNameText.Size = new System.Drawing.Size(125, 27);
            this.ShowNameText.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Вистави";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Дельфін";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // LeftShow
            // 
            this.LeftShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LeftShow.Location = new System.Drawing.Point(12, 31);
            this.LeftShow.Name = "LeftShow";
            this.LeftShow.Size = new System.Drawing.Size(55, 53);
            this.LeftShow.TabIndex = 44;
            this.LeftShow.Text = "<";
            this.LeftShow.UseVisualStyleBackColor = false;
            this.LeftShow.Click += new System.EventHandler(this.LeftShow_Click);
            // 
            // RightShow
            // 
            this.RightShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RightShow.Location = new System.Drawing.Point(247, 31);
            this.RightShow.Name = "RightShow";
            this.RightShow.Size = new System.Drawing.Size(55, 53);
            this.RightShow.TabIndex = 45;
            this.RightShow.Text = ">";
            this.RightShow.UseVisualStyleBackColor = false;
            this.RightShow.Click += new System.EventHandler(this.RightShow_Click);
            // 
            // PrevDolphin
            // 
            this.PrevDolphin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrevDolphin.Location = new System.Drawing.Point(131, 406);
            this.PrevDolphin.Name = "PrevDolphin";
            this.PrevDolphin.Size = new System.Drawing.Size(32, 37);
            this.PrevDolphin.TabIndex = 46;
            this.PrevDolphin.Text = "<";
            this.PrevDolphin.UseVisualStyleBackColor = false;
            this.PrevDolphin.Click += new System.EventHandler(this.PrevDolphin_Click);
            // 
            // NextDolphin
            // 
            this.NextDolphin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextDolphin.Location = new System.Drawing.Point(489, 406);
            this.NextDolphin.Name = "NextDolphin";
            this.NextDolphin.Size = new System.Drawing.Size(32, 37);
            this.NextDolphin.TabIndex = 47;
            this.NextDolphin.Text = ">";
            this.NextDolphin.UseVisualStyleBackColor = false;
            this.NextDolphin.Click += new System.EventHandler(this.NextDolphin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 48;
            this.button1.Text = "Замовити квиток";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 29);
            this.button2.TabIndex = 49;
            this.button2.Text = "Оновити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NextDolphin);
            this.Controls.Add(this.PrevDolphin);
            this.Controls.Add(this.RightShow);
            this.Controls.Add(this.LeftShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.DurationText);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonalButton);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Дельфінарій";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button PersonalButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox LocationText;
        private System.Windows.Forms.TextBox DurationText;
        private System.Windows.Forms.TextBox CostText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ShowNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LeftShow;
        private System.Windows.Forms.Button RightShow;
        private System.Windows.Forms.Button PrevDolphin;
        private System.Windows.Forms.Button NextDolphin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

