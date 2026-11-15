using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            comboBox_position.Items.AddRange(new string[] { "Concierge", "Housekeeper", "Executive Chef", "Waiter/Waitress" });

            for (int i = 1; i <= 31; i++)
            {
                comboBox_workingDays.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (comboBox_workingDays.SelectedItem == null || comboBox_position.SelectedItem == null)
            {
                MessageBox.Show("Please select both working days and position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee
            {
                WorkingDays = int.Parse(comboBox_workingDays.SelectedItem.ToString()),
                Position = comboBox_position.SelectedItem.ToString()
            };

            employee.CalculateSalary();

            MessageBox.Show(employee.GetDetails(), "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_done_Click(object sender, EventArgs e)
        {
           // PersonForm form = new PersonForm();
           // form.Show();
        }

        private void linkLabel_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
