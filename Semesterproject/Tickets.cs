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

    public partial class Tickets : Form
    {
        private readonly IMongoCollection<TicketsTable> _ticketsCollection;
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;
        private readonly IMongoCollection<Passengers> _passengersCollection;

        public Tickets()
        {
            InitializeComponent();

            var mongoDbService = new MongoDBservices();
            _ticketsCollection = mongoDbService.GetTicketsCollection();
            _flightsCollection = mongoDbService.GetFlightsCollection();
            _passengersCollection = mongoDbService.GetPassengersCollection();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Text = "";
            txt_FLCode.Text = "";
            txt_Nation.Text = "";
            txt_PassId.Text = "";
            txt_PassName.Text = "";
            txt_Passport.Text = "";
            txt_Phone.Text = "";
            txt_Ticket.Text = "";
            MessageBox.Show("Reset Done. Enter Now!!");
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Amount.Text == "" || txt_FLCode.Text == "" || txt_Nation.Text == "" || txt_PassId.Text == "" || txt_PassName.Text == "" || txt_Passport.Text == "" || txt_Phone.Text == "" || txt_Ticket.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else if (txt_Phone.Text.Length != 14)
            {
                MessageBox.Show("Invalid PhoneNumber.");
            }

            else
            {
                bool Insert = true;

                if (txt_FLCode.Text != "")
                {

                    var flight = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_FLCode.Text);
                    var Found = _flightsCollection.Find(flight);

                    if (Found.FirstOrDefault() == null)
                    {
                        MessageBox.Show("No Flight Found with this FlightCode.");
                        Insert = false;
                    }
                }
                if (txt_PassId.Text != "")
                {
                    var passenger = Builders<Passengers>.Filter.Eq("PassId", txt_PassId.Text);
                    var Found = _passengersCollection.Find(passenger);

                    if (Found.FirstOrDefault() == null)
                    {
                        MessageBox.Show("Passenger With This Record, Not Found, Sorry!");
                        Insert = false;
                    }
                }
                if (Insert)
                {
                    string Tid = txt_Ticket.Text;
                    string Fid = txt_FLCode.Text;
                    string Nation = txt_Nation.Text;
                    string PassId = txt_PassId.Text;
                    int amount = int.Parse(txt_Amount.Text);
                    string passport = txt_Passport.Text;
                    string Phone = txt_Phone.Text;
                    string PassName = txt_PassName.Text;

                    var newData = new TicketsTable
                    {
                        TicketId = Tid,
                        FlCode = Fid,
                        PassId = PassId,
                        Passname = PassName,
                        PassNation = Nation,
                        Passport = passport,
                        Amount = amount,
                        Phone = Phone
                    };

                    _ticketsCollection.InsertOne(newData);

                    MessageBox.Show("Ticket Booked Successfully.");
                }

            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ViewBookings VB = new ViewBookings();
            VB.Show();
            this.Hide();
        }

        private void txt_PassId_Leave(object sender, EventArgs e)
        {
            var flight = Builders<Passengers>.Filter.Eq("PassId", txt_PassId.Text);
            var Found = _passengersCollection.Find(flight).FirstOrDefault();

            if (Found != null)
            {
                txt_Phone.Text = Found.PassPhone;
                txt_Passport.Text = Found.Passport;
                txt_Nation.Text = Found.PassNationality;
                txt_PassName.Text = Found.PassName;

                txt_Phone.ReadOnly = true;
                txt_Passport.ReadOnly = true;
                txt_Nation.ReadOnly = true;
                txt_PassName.ReadOnly = true;

                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Passenger not found.");
                button1.Enabled = false;
            }
        }

        private void txt_PassId_Enter(object sender, EventArgs e)
        {
            button1.Enabled = true;
            txt_Phone.ReadOnly = false;
            txt_Passport.ReadOnly = false;
            txt_Nation.ReadOnly = false;
            txt_PassName.ReadOnly = false;
        }

        private void txt_FLCode_Leave(object sender, EventArgs e)
        {
            var flight = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_FLCode.Text);
            var Found = _flightsCollection.Find(flight).FirstOrDefault();

            if (Found == null)
            {
                {
                    MessageBox.Show("Flight not found.");
                    button1.Enabled = false;
                }
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void txt_FLCode_Enter(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void txt_Ticket_Leave(object sender, EventArgs e)
        {
            var flight = Builders<TicketsTable>.Filter.Eq("TicketId", txt_FLCode.Text);
            var Found = _ticketsCollection.Find(flight).FirstOrDefault();

            if (Found != null)
            {
                {
                    MessageBox.Show("Ticket already booked.");
                    button1.Enabled = false;
                }
            }
        }

        private void txt_Ticket_Enter(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }


        private void txt_Amount_Enter(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void txt_Amount_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txt_Phone.Text) < 50)
            {
                button1.Enabled = false;
                MessageBox.Show("Amount can't be les than 50$.");
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
