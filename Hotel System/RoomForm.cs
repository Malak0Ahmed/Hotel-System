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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if (comboBox_roomtype.SelectedItem == null || comboBox_roomview.SelectedItem == null || comboBox_extra.SelectedItem == null)
            {
                MessageBox.Show("Please select all options for room type, view, and extra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Room room = new Room
            {
                RoomType = comboBox_roomtype.SelectedItem.ToString(),
                RoomView = comboBox_roomview.SelectedItem.ToString(),
                RoomExtra = comboBox_extra.SelectedItem.ToString()
            };
            int totalAmount = room.CalculateTotalAmount();
            if (totalAmount == 0)
            {
                MessageBox.Show("Total amount is 0. Please check the room details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(room.GetDetails(), "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_extra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
