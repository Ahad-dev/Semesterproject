using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterproject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            Tickets TI = new Tickets();
            TI.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            AddPassengers addPassengers = new AddPassengers();
            addPassengers.Show();
            this.Hide();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            lbl_flights FL = new lbl_flights();
            FL.Show();
            this.Hide();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            CancellationTable FL = new CancellationTable();
            FL.Show();
            this.Hide();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            Reports R = new Reports();
            R.Show();
            this.Hide();
        }
    }
}
