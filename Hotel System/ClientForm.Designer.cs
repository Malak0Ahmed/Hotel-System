namespace Hotel_System
{
    partial class ClientForm
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
            this.done_btn = new System.Windows.Forms.Button();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.Column_Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ShearchID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_age = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            this.tabPageAddClient.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.ForeColor = System.Drawing.Color.White;
            this.done_btn.Location = new System.Drawing.Point(1619, 968);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(159, 56);
            this.done_btn.TabIndex = 15;
            this.done_btn.Text = "Back";
            this.done_btn.UseVisualStyleBackColor = false;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.buttonDelete);
            this.tabPageSearchClient.Controls.Add(this.search_btn);
            this.tabPageSearchClient.Controls.Add(this.dataGridView_Client);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Controls.Add(this.textBox_ShearchID);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1496, 654);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search Client";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(832, 101);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 51);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(621, 101);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(159, 51);
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.AllowUserToAddRows = false;
            this.dataGridView_Client.AllowUserToDeleteRows = false;
            this.dataGridView_Client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Firstname,
            this.Column_LastName,
            this.Column_ID,
            this.Column1,
            this.Column2});
            this.dataGridView_Client.Location = new System.Drawing.Point(25, 198);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.RowHeadersWidth = 62;
            this.dataGridView_Client.RowTemplate.Height = 28;
            this.dataGridView_Client.Size = new System.Drawing.Size(1446, 392);
            this.dataGridView_Client.TabIndex = 18;
            // 
            // Column_Firstname
            // 
            this.Column_Firstname.HeaderText = "First Name";
            this.Column_Firstname.MinimumWidth = 8;
            this.Column_Firstname.Name = "Column_Firstname";
            this.Column_Firstname.ReadOnly = true;
            // 
            // Column_LastName
            // 
            this.Column_LastName.DataPropertyName = "Client_FirstName";
            this.Column_LastName.HeaderText = "Last Name";
            this.Column_LastName.MinimumWidth = 8;
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            // 
            // Column_ID
            // 
            this.Column_ID.DataPropertyName = "Client_LastName";
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.MinimumWidth = 8;
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_Phone";
            this.Column1.HeaderText = "Phone No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_Address";
            this.Column2.HeaderText = "Address";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search Client:";
            // 
            // textBox_ShearchID
            // 
            this.textBox_ShearchID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ShearchID.Location = new System.Drawing.Point(193, 109);
            this.textBox_ShearchID.Name = "textBox_ShearchID";
            this.textBox_ShearchID.Size = new System.Drawing.Size(366, 31);
            this.textBox_ShearchID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.textBox_age);
            this.tabPageAddClient.Controls.Add(this.textBoxid);
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageAddClient.Controls.Add(this.textBoxLastName);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.comboBox_gender);
            this.tabPageAddClient.Controls.Add(this.label_age);
            this.tabPageAddClient.Controls.Add(this.label_id);
            this.tabPageAddClient.Controls.Add(this.label_gender);
            this.tabPageAddClient.Controls.Add(this.label_phone);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.save_btn);
            this.tabPageAddClient.Controls.Add(this.label_lastname);
            this.tabPageAddClient.Controls.Add(this.label_firstname);
            this.tabPageAddClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1496, 654);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            // 
            // textBox_age
            // 
            this.textBox_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_age.Location = new System.Drawing.Point(892, 366);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(366, 31);
            this.textBox_age.TabIndex = 26;
            // 
            // textBoxid
            // 
            this.textBoxid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxid.Location = new System.Drawing.Point(892, 263);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(366, 31);
            this.textBoxid.TabIndex = 22;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(213, 263);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(366, 31);
            this.textBoxPhoneNumber.TabIndex = 18;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Location = new System.Drawing.Point(892, 171);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(366, 31);
            this.textBoxLastName.TabIndex = 14;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(213, 171);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(366, 31);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(213, 366);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(366, 31);
            this.comboBox_gender.TabIndex = 25;
            // 
            // label_age
            // 
            this.label_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(887, 312);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(55, 26);
            this.label_age.TabIndex = 23;
            this.label_age.Text = "Age";
            // 
            // label_id
            // 
            this.label_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(887, 222);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 26);
            this.label_id.TabIndex = 21;
            this.label_id.Text = "ID";
            // 
            // label_gender
            // 
            this.label_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(215, 312);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(92, 26);
            this.label_gender.TabIndex = 19;
            this.label_gender.Text = "Gender";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(208, 222);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(171, 26);
            this.label_phone.TabIndex = 17;
            this.label_phone.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add Client:";
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(220, 545);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(301, 45);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label_lastname
            // 
            this.label_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.Location = new System.Drawing.Point(887, 130);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(126, 26);
            this.label_lastname.TabIndex = 13;
            this.label_lastname.Text = "Last Name";
            // 
            // label_firstname
            // 
            this.label_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.Location = new System.Drawing.Point(208, 130);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(129, 26);
            this.label_firstname.TabIndex = 11;
            this.label_firstname.Text = "First Name";
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlClient.Location = new System.Drawing.Point(122, 85);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1504, 687);
            this.tabControlClient.TabIndex = 14;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.tabControlClient);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabControlClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button done_btn;

        private void ClientInitializeComponent()
        {

            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBoxFirstName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(260, 20);
            this.textBoxFirstName.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBox_age);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ShearchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TabControl tabControlClient;
    }
}