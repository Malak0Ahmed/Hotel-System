using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_System
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void LoadAllData()
        {
            dataGridView_Client.Rows.Clear();
            dataGridView_Client.Columns.Clear();
            dataGridView_Client.Columns.Add("FirstName", "First Name");
            dataGridView_Client.Columns.Add("LastName", "Last Name");
            dataGridView_Client.Columns.Add("ID", "ID");
            dataGridView_Client.Columns.Add("Gender", "Gender");
            dataGridView_Client.Columns.Add("Phone", "Phone Number");
            dataGridView_Client.Columns.Add("Age", "Age");

            // Load all data from file and display in dataGridView_Client
            if (File.Exists("data.csv"))
            {
                string[] lines = File.ReadAllLines("data.csv");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        dataGridView_Client.Rows.Add(parts);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm= new HomeForm();
            homeForm.Show();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) ||string.IsNullOrEmpty(textBoxLastName.Text) ||string.IsNullOrEmpty(textBoxid.Text) ||comboBox_gender.SelectedItem == null ||string.IsNullOrEmpty(textBoxPhoneNumber.Text) ||string.IsNullOrEmpty(textBox_age.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Client person = new Client();
            person.firstName = textBoxFirstName.Text;
            person.lastName = textBoxLastName.Text;
            person.Phone= int.Parse(textBoxPhoneNumber.Text);
            person.ID = int.Parse(textBoxid.Text);
            person.Gender = comboBox_gender.SelectedItem.ToString();
            person.Age = int.Parse(textBox_age.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (StreamWriter writer = File.AppendText("data.csv"))
                    {
                        writer.WriteLine($"{person.firstName},{person.lastName},{person.ID},{person.Gender},{person.Phone},{person.Age}");
                    }
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxid.Text = "";
                    comboBox_gender.SelectedIndex = -1;
                    textBoxPhoneNumber.Text = "";
                    textBox_age.Text = "";
                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            LoadAllData();
            string searchId = textBox_ShearchID.Text;
            dataGridView_Client.Rows.Clear();
            dataGridView_Client.Columns.Clear();
            dataGridView_Client.Columns.Add("FirstName", "First Name");
            dataGridView_Client.Columns.Add("LastName", "Last Name");
            dataGridView_Client.Columns.Add("ID", "ID");
            dataGridView_Client.Columns.Add("Gender", "Gender");
            dataGridView_Client.Columns.Add("Phone", "Phone Number");
            dataGridView_Client.Columns.Add("Age", "Age");
            if (File.Exists("data.csv"))
            {
                string[] lines = File.ReadAllLines("data.csv");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6 && (string.IsNullOrEmpty(searchId) || parts[2] == searchId))
                    {
                        dataGridView_Client.Rows.Add(parts);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("data.csv", string.Empty);
                dataGridView_Client.Rows.Clear();
                MessageBox.Show("Data cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
