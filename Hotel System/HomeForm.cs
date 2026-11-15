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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }



        private void linkLabel_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel_logout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // labelDateTime.Text = DateTime.Now.ToString("dd-MMM_yyyy hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            RoomForm rooms= new RoomForm();
            rooms.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
           ReservationForm reservation= new ReservationForm();
            reservation.Show();
        }

        //add and search
        private void client_btn_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }
    }
}
