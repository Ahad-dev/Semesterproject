using Semesterproject.User_Forms;
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
    public partial class btn_update : Form
    {
        string Id;
        public btn_update(string ID)
        {
            Id = ID;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            ChangeInfo CI = new ChangeInfo(Id);
            CI.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_viewFlights_Click(object sender, EventArgs e)
        {
            ViewFlights VF = new ViewFlights();
            VF.btn_back.Enabled = false;
            VF.btn_update.Enabled = false;
            VF.btn_delete.Enabled = false;

            VF.Show();
            this.Hide();
        }

        private void btn_CancelTickets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We recieved Your Call, Admin Will Cancel Your Ticket Soon. Payemnt Refunded.");
        }

        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We recieved Your Call, Admin Will Book Your Ticket Soon.");
        }
    }
}
