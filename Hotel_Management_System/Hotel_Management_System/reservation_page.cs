using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class reservation_page : Form
    {
        Reservation res = new Reservation();
        string reservationSearchID = "";
        public reservation_page()
        {
            InitializeComponent();
            res.startDate = startDatePicker.Value;
            res.endDate = endDatePicker.Value;
            res.hotel = "";
            res.roomType = "";
            res.numGuests = 0;
            res.cardNum = 0;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.startDate = startDatePicker.Value;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.endDate = endDatePicker.Value;
        }

        private void hotelLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            res.hotel = hotelLocationBox.Text;
        }

        private void roomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            res.roomType = roomTypeBox.Text;
        }

        private void numberOfGuestsBox_TextChanged(object sender, EventArgs e)
        {
            try { res.numGuests = Int32.Parse(numberOfGuestsBox.Text); }
            catch (FormatException _e) { Console.WriteLine(_e.Message); }
        }

        private void creditCardNumberBox_TextChanged(object sender, EventArgs e)
        {
            try { res.cardNum = Int32.Parse(creditCardNumberBox.Text); }
            catch (FormatException _e) { Console.WriteLine(_e.Message); }
        }

        private void submitUpdateButton_Click(object sender, EventArgs e)
        {
            //test line to show values when submitted. delete before turning in
            MessageBox.Show(res.startDate.ToString() + "\n" + res.endDate.ToString() + "\n" + res.hotel + "\n" + res.roomType + "\n" + res.numGuests + "\n" + res.cardNum);
            //reward points dialogue box
            var confirmRewards = MessageBox.Show("Would you like to use 50 reward points to get a 10% discount?", "Reward Points", MessageBoxButtons.YesNo);
            if(confirmRewards == DialogResult.Yes)
            {
                //apply rewards
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //reset all fields. eventually this button will probably just return the user to the previous page though
            res = new Reservation(); //reset reservation object
            startDatePicker.ResetText();
            endDatePicker.ResetText();
            hotelLocationBox.ResetText();
            roomTypeBox.ResetText();
            numberOfGuestsBox.ResetText();
            creditCardNumberBox.ResetText();
        }

        private void reservationIdBox_TextChanged(object sender, EventArgs e)
        {
            reservationSearchID = reservationIdBox.Text;
        }

        private void reservationSearchButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class Reservation
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string hotel { get; set; }
        public string roomType { get; set; }
        public int numGuests { get; set; }
        public int cardNum { get; set; }
    }
}
