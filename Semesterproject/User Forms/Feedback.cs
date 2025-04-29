using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Driver;
using Semesterproject.Models;
using Semesterproject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterproject.User_Forms
{
    public partial class Feedback : Form
    {
        public string userid = "";
        public string flightid = "";
        public string cnic = "";
        public string name = "";

        private readonly IMongoCollection<FeedbackModel> _feedbacksCollection;
        private readonly IMongoCollection<Passengers> _passengersCollection;
        private readonly IMongoCollection<TicketsTable> _ticketsCollection;

        public Feedback(string id)
        {
            InitializeComponent();
            var mongoServices = new MongoDBservices();
            _feedbacksCollection = mongoServices.GetFeedbackCollection();
            _passengersCollection = mongoServices.GetPassengersCollection();
            _ticketsCollection = mongoServices.GetTicketsCollection();

            var filter = Builders<Passengers>.Filter.Eq("PassId", id);
            var result = _passengersCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                userid = id;
                cnic = result.CNIC;
                name = result.PassName;
                txt_userid.Text = id;


                var filter2 = Builders<TicketsTable>.Filter.Eq("PassId", id);
                var result2 = _ticketsCollection.Find(filter2).FirstOrDefault();

                if (result2 != null)
                {
                    txt_flightid.Text = result2.FlCode;
                    flightid = txt_flightid.Text;
                }
            }


            txt_cnic.Text = cnic;
            txt_name.Text = name;

            txt_cnic.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_flightid.ReadOnly = true;
            txt_userid.ReadOnly = true;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (txt_rating.Text == "" || comments.Text == "")
            {
                MessageBox.Show("Missing Ratings OR Comments!!");
            }
            else
            {
                var newFeed = new FeedbackModel()
                {
                    Rating = txt_rating.Text,
                    Comment = comments.Text,
                    UserId = userid,
                    UserName = name,
                    FlightID = flightid,
                    CNIC = cnic,
                };


                _feedbacksCollection.InsertOne(newFeed);

                MessageBox.Show("Thank You!!");
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
