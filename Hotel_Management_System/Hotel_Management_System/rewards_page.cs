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
    public partial class rewards_page : Form
    {
        rewardType reward = new rewardType();
        public rewards_page()
        {
            InitializeComponent();
        }

        private void rewardNameBox_TextChanged(object sender, EventArgs e)
        {
            reward.name = rewardNameBox.Text;
        }

        private void rewardTypeBox_TextChanged(object sender, EventArgs e)
        {
            reward.type = rewardTypeBox.Text;
        }

        private void rewardDetailsBox_TextChanged(object sender, EventArgs e)
        {
            reward.type = rewardDetailsBox.Text;
        }

        private void pointAmountBox_TextChanged(object sender, EventArgs e)
        {
            reward.amount = Int32.Parse(pointAmountBox.Text);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }

    public struct rewardType
    {
        public string name { get; set; }
        public string type { get; set; }
        public string details { get; set; }
        public int amount { get; set; }
    }
}
