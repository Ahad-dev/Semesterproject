using MongoDB.Driver;
using Semesterproject.Models;
using Semesterproject.Services;
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
    public partial class ViewBookings : Form
    {
        private readonly IMongoCollection<TicketsTable> _ticketsCollection;
        private readonly IMongoCollection<Passengers> _passengersCollection;
        public ViewBookings()
        {
            InitializeComponent();

            var monService = new MongoDBservices();
            _ticketsCollection = monService.GetTicketsCollection();
            _passengersCollection = monService.GetPassengersCollection();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets T = new Tickets();
            T.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_flight.Text = "";
            txt_PassId.Text = "";
            txt_PassName.Text = "";
            txt_PassNation.Text = "";
            txt_Phone.Text = "";
            txt_ticketid.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = Builders<TicketsTable>.Filter.Eq("TicketId", txt_ticketid.Text);
            var result = _ticketsCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                var delete = _ticketsCollection.DeleteOne(filter);

                if (delete.DeletedCount > 0)
                {
                    MessageBox.Show("Ticket Cancelled");
                }
                else
                {
                    MessageBox.Show("Cancellation Failed.");
                }
            }
            else
            {
                MessageBox.Show("Record Not Found.");
            }

            var tickets = _ticketsCollection.Find(_ => true).ToList();
            guna2DataGridView1.DataSource = tickets;

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            try
            {
                var tickets = _ticketsCollection.Find(_ => true).ToList();
                guna2DataGridView1.DataSource = tickets;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_PassId_Leave(object sender, EventArgs e)
        {
            var passengers = _passengersCollection.Find(_ => true).ToList();

            var filter = Builders<Passengers>.Filter.Eq("PassId", txt_PassId.Text);
            var Pass = _passengersCollection.Find(filter).FirstOrDefault();

            if (Pass != null)
            {
                txt_PassName.Text = Pass.PassName;
                txt_Phone.Text = Pass.PassPhone;
                txt_PassNation.Text = Pass.PassNationality;

                txt_Phone.ReadOnly = true;
                txt_PassName.ReadOnly = true;
                txt_PassNation.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Passenger Is Not Recorded!!");
            }
        }

        private void txt_PassId_Enter(object sender, EventArgs e)
        {
            txt_PassName.Text = "";
            txt_Phone.Text = "";
            txt_PassNation.Text = "";

            txt_Phone.ReadOnly = false;
            txt_PassName.ReadOnly = false;
            txt_PassNation.ReadOnly = false;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
