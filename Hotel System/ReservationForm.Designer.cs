namespace Hotel_System
{
    partial class ReservationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_num_adults = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_checkin_year = new System.Windows.Forms.ComboBox();
            this.comboBox_checkin_month = new System.Windows.Forms.ComboBox();
            this.comboBox_checkin_day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_pay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_num_days = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.comboBox_food = new System.Windows.Forms.ComboBox();
            this.button_calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_System.Properties.Resources.Should_I_Make_My_Hotel_Reservation_Ahead_of_Time;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 350);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(915, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 37);
            this.label8.TabIndex = 37;
            // 
            // comboBox_num_adults
            // 
            this.comboBox_num_adults.FormattingEnabled = true;
            this.comboBox_num_adults.Location = new System.Drawing.Point(761, 520);
            this.comboBox_num_adults.Name = "comboBox_num_adults";
            this.comboBox_num_adults.Size = new System.Drawing.Size(254, 28);
            this.comboBox_num_adults.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(754, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Number of adult";
            // 
            // comboBox_checkin_year
            // 
            this.comboBox_checkin_year.FormattingEnabled = true;
            this.comboBox_checkin_year.Location = new System.Drawing.Point(622, 827);
            this.comboBox_checkin_year.Name = "comboBox_checkin_year";
            this.comboBox_checkin_year.Size = new System.Drawing.Size(101, 28);
            this.comboBox_checkin_year.TabIndex = 34;
            // 
            // comboBox_checkin_month
            // 
            this.comboBox_checkin_month.FormattingEnabled = true;
            this.comboBox_checkin_month.Location = new System.Drawing.Point(484, 827);
            this.comboBox_checkin_month.Name = "comboBox_checkin_month";
            this.comboBox_checkin_month.Size = new System.Drawing.Size(132, 28);
            this.comboBox_checkin_month.TabIndex = 33;
            // 
            // comboBox_checkin_day
            // 
            this.comboBox_checkin_day.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_checkin_day.FormattingEnabled = true;
            this.comboBox_checkin_day.Location = new System.Drawing.Point(419, 827);
            this.comboBox_checkin_day.Name = "comboBox_checkin_day";
            this.comboBox_checkin_day.Size = new System.Drawing.Size(59, 26);
            this.comboBox_checkin_day.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 771);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of Check In";
            // 
            // comboBox_pay
            // 
            this.comboBox_pay.FormattingEnabled = true;
            this.comboBox_pay.Location = new System.Drawing.Point(762, 106);
            this.comboBox_pay.Name = "comboBox_pay";
            this.comboBox_pay.Size = new System.Drawing.Size(254, 28);
            this.comboBox_pay.TabIndex = 30;
            this.comboBox_pay.SelectedIndexChanged += new System.EventHandler(this.comboBox_PayCash_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pay Cash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 37);
            this.label6.TabIndex = 27;
            this.label6.Text = "Food";
            // 
            // comboBox_num_days
            // 
            this.comboBox_num_days.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_num_days.FormattingEnabled = true;
            this.comboBox_num_days.Location = new System.Drawing.Point(419, 518);
            this.comboBox_num_days.Name = "comboBox_num_days";
            this.comboBox_num_days.Size = new System.Drawing.Size(254, 26);
            this.comboBox_num_days.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 37);
            this.label5.TabIndex = 39;
            this.label5.Text = "Number of days";
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
            this.panel1.Size = new System.Drawing.Size(330, 904);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reservation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_System.Properties.Resources._489848;
            this.pictureBox2.Location = new System.Drawing.Point(66, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(1534, 883);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(159, 56);
            this.back_btn.TabIndex = 43;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // comboBox_food
            // 
            this.comboBox_food.FormattingEnabled = true;
            this.comboBox_food.Location = new System.Drawing.Point(419, 106);
            this.comboBox_food.Name = "comboBox_food";
            this.comboBox_food.Size = new System.Drawing.Size(254, 28);
            this.comboBox_food.TabIndex = 44;
            // 
            // button_calculate
            // 
            this.button_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.button_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate.ForeColor = System.Drawing.Color.White;
            this.button_calculate.Location = new System.Drawing.Point(1358, 883);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(159, 56);
            this.button_calculate.TabIndex = 45;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = false;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1641, 904);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.comboBox_food);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_num_days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_num_adults);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_checkin_year);
            this.Controls.Add(this.comboBox_checkin_month);
            this.Controls.Add(this.comboBox_checkin_day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_pay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_num_adults;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_checkin_year;
        private System.Windows.Forms.ComboBox comboBox_checkin_month;
        private System.Windows.Forms.ComboBox comboBox_checkin_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_num_days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ComboBox comboBox_food;
        private System.Windows.Forms.Button button_calculate;
    }
}