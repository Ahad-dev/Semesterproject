using MongoDB.Driver;
using Semesterproject.Models;
using Semesterproject.Services;
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

    public partial class AirLineStaffDashboard : Form
    {
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;

        public AirLineStaffDashboard()
        {
            InitializeComponent();

            var mongoServices = new MongoDBservices();
            _flightsCollection = mongoServices.GetFlightsCollection();
            var flights = _flightsCollection.Find(flight => flight.TakeofDate == "N/A").ToList();
            flightsnotassigned.Text = flights.Count.ToString();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            ViewFeedBack VF = new ViewFeedBack();
            VF.Show();
            this.Hide();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            ViewPassengers VP = new ViewPassengers();
            VP.Show();
            this.Close();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            ViewFlights VF = new ViewFlights();
            VF.Show();
            this.Hide();
        }
    }
}
