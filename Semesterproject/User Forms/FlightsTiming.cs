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

namespace Semesterproject.User_Forms
{
    public partial class FlightsTiming : Form
    {
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;

        public FlightsTiming()
        {
            InitializeComponent();
            var mongoServices = new MongoDBservices();
            _flightsCollection = mongoServices.GetFlightsCollection();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_PassId_Leave(object sender, EventArgs e)
        {
            var filter = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_flightid.Text);
            var result = _flightsCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                txt_seats.Text = result.TotalSeats.ToString();
                txt_source.Text = result.Source;
                txt_destination.Text = result.Destination;
                txt_pilotid.Text = result.PilotID;

                txt_seats.ReadOnly = false;
                txt_source.Enabled = false;
                txt_destination.Enabled = false;
                txt_pilotid.Enabled = false;
            }
            else
            {
                MessageBox.Show("No flight found!!");
            }
        }

        private void FlightsTiming_Load(object sender, EventArgs e)
        {
            var flights = _flightsCollection.Find(flight => flight.TakeofDate == "N/A").ToList();
            guna2DataGridView1.DataSource = flights;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var filter = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_flightid.Text);
            var update = Builders<FlightsRecords>.Update
                .Set("Source", txt_source.Text)
                .Set("Destination", txt_destination.Text)
                .Set("TotalSeats", txt_seats.Text)
                .Set("TakeofDate", txt_date.Text)
                .Set("PilotID", txt_pilotid.Text);

            if (filter != null)
            {
                _flightsCollection.UpdateOne(filter, update);
                MessageBox.Show("Assigned Successfully");

                var flights = _flightsCollection.Find(_ => true).ToList();
                guna2DataGridView1.DataSource = flights;
            }
            else
            {
                MessageBox.Show("Flight Not Found...");
            }
        }
    }
}
