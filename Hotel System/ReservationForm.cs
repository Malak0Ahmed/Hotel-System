using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            comboBox_food.Items.AddRange(new string[] { "Breakfast", "All Inclusive" });
            comboBox_pay.Items.AddRange(new string[] { "Visa", "Cash" });
            comboBox_checkin_month.Items.AddRange(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });

            // Add numeric values for days, years, number of days, and number of adults
            for (int i = 1; i <= 31; i++)
            {
                comboBox_checkin_day.Items.Add(i);
            }

            for (int i = DateTime.Now.Year; i <= DateTime.Now.Year + 5; i++)
            {
                comboBox_checkin_year.Items.Add(i);
            }

            for (int i = 1; i <= 30; i++)
            {
                comboBox_num_days.Items.Add(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                comboBox_num_adults.Items.Add(i);
            }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
        }
        private void done_btn_Click(object sender, EventArgs e)
        {
            //Reservation reservation = new Reservation();
            //reservation.CheckInDate_day = (int)comboBoxd_Day.SelectedItem;
            //reservation.CheckInDate_month = comboBox_Months.SelectedItem.ToString();
            //reservation.CheckInDate_year = (int)comboBox_Year.SelectedItem;
            //reservation.NumDays = (int)comboBox_NumberOfDays.SelectedItem;
            //reservation.NumAdults = (int)comboBox_AdultNo.SelectedItem;


            //MessageBox.Show(reservation.DisplayReservationDetails()+reservation.CalculateTotalAmount());

        }

        private void comboBox_PayCash_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            if (comboBox_food.SelectedItem == null || comboBox_pay.SelectedItem == null ||comboBox_checkin_day.SelectedItem == null || comboBox_checkin_month.SelectedItem == null ||comboBox_checkin_year.SelectedItem == null || comboBox_num_days.SelectedItem == null ||comboBox_num_adults.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reservation reservation = new Reservation
            {
                Food = comboBox_food.SelectedItem.ToString(),
                PayMethod = comboBox_pay.SelectedItem.ToString(),
                CheckInDay = int.Parse(comboBox_checkin_day.SelectedItem.ToString()),
                CheckInMonth = comboBox_checkin_month.SelectedItem.ToString(),
                CheckInYear = int.Parse(comboBox_checkin_year.SelectedItem.ToString()),
                NumDays = int.Parse(comboBox_num_days.SelectedItem.ToString()),
                NumAdults = int.Parse(comboBox_num_adults.SelectedItem.ToString())
            };

            double totalAmount = reservation.CalculateTotalAmount();

            MessageBox.Show(reservation.GetDetails(), "Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

