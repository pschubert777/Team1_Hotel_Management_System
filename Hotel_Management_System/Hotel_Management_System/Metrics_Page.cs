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
    public partial class Metrics_Page : Form
    {
        public Metrics_Page()
        {
            InitializeComponent();
        }

        private void Generate_Report_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{start_date_picker.Text} and {end_date_picker.Text}");
        }
    }
}
