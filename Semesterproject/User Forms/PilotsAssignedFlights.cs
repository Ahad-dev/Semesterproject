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
using System.Net;
using System.Net.Mail;

namespace Semesterproject.User_Forms
{
    public partial class PilotsAssignedFlights : Form
    {
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;
        public string pilotid;
        public PilotsAssignedFlights(string id)
        {
            InitializeComponent();
            var mongoServices = new MongoDBservices();
            _flightsCollection = mongoServices.GetFlightsCollection();

            pilotid = id;
        }

        private void PilotsAssignedFlights_Load(object sender, EventArgs e)
        {
            try
            {
                var flights = _flightsCollection.Find(flight => flight.PilotID == pilotid).ToList();
                guna2DataGridView1.DataSource = flights;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            ContactStaff CS = new ContactStaff();
            CS.Show();
            this.Hide();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
