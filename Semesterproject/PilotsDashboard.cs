using AirLineService;
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
    public partial class PilotsDashboard : Form
    {
        public string PilotId;
        private readonly IMongoCollection<Passengers> _passengersCollection;

        public PilotsDashboard(string ID)
        {
            PilotId = ID;
            InitializeComponent();

            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();

            var filter = Builders<Passengers>.Filter.Eq("PassId", PilotId);
            var result = _passengersCollection.Find(filter).FirstOrDefault();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            ChangeInfo CI = new ChangeInfo(PilotId);
            CI.Show();
            this.Hide();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            ChangeInfo CI = new ChangeInfo(PilotId);
            CI.Show();
            this.Hide();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            PilotsAssignedFlights PAF = new PilotsAssignedFlights(PilotId);
            PAF.Show();
            this.Hide();
        }
    }
}
