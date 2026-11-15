namespace Hotel_System
{
    partial class EmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_position = new System.Windows.Forms.Label();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.comboBox_workingDays = new System.Windows.Forms.ComboBox();
            this.label_workingDay = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1000);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 717);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_System.Properties.Resources._118798430_hotel_receptionist_in_lobby_at_front_desk_woman_in_reception_area_greets_deals_with_clients_visitors;
            this.pictureBox2.Location = new System.Drawing.Point(69, 521);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label_position
            // 
            this.label_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(522, 325);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(125, 32);
            this.label_position.TabIndex = 12;
            this.label_position.Text = "Position";
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(593, 423);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(366, 28);
            this.comboBox_position.TabIndex = 26;
            // 
            // comboBox_workingDays
            // 
            this.comboBox_workingDays.FormattingEnabled = true;
            this.comboBox_workingDays.Location = new System.Drawing.Point(593, 934);
            this.comboBox_workingDays.Name = "comboBox_workingDays";
            this.comboBox_workingDays.Size = new System.Drawing.Size(366, 28);
            this.comboBox_workingDays.TabIndex = 28;
            // 
            // label_workingDay
            // 
            this.label_workingDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_workingDay.AutoSize = true;
            this.label_workingDay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_workingDay.Location = new System.Drawing.Point(522, 838);
            this.label_workingDay.Name = "label_workingDay";
            this.label_workingDay.Size = new System.Drawing.Size(332, 32);
            this.label_workingDay.TabIndex = 27;
            this.label_workingDay.Text = "Number of working day";
            // 
            // calculate_btn
            // 
            this.calculate_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.calculate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_btn.ForeColor = System.Drawing.Color.White;
            this.calculate_btn.Location = new System.Drawing.Point(1628, 980);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(184, 52);
            this.calculate_btn.TabIndex = 29;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel_logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel_logout.Location = new System.Drawing.Point(1715, 31);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(71, 18);
            this.linkLabel_logout.TabIndex = 31;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "Log Out";
            this.linkLabel_logout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_logout_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hotel_System.Properties.Resources.hotel_employee_secrets_0_1506613247;
            this.pictureBox4.Location = new System.Drawing.Point(1021, 521);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(626, 377);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel_System.Properties.Resources.download__1_;
            this.pictureBox3.Location = new System.Drawing.Point(1333, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(453, 267);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel_System.Properties.Resources.png_transparent_computer_icons_logout_angle_text_black_thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(1654, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkLabel_logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.comboBox_workingDays);
            this.Controls.Add(this.label_workingDay);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.ComboBox comboBox_workingDays;
        private System.Windows.Forms.Label label_workingDay;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}