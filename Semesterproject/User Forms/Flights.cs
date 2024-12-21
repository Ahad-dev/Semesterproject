using MongoDB.Bson;
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
    public partial class lbl_flights : Form
    {
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;

        public lbl_flights()
        {
            InitializeComponent();

            var mongoServices = new MongoDBservices();
            _flightsCollection = mongoServices.GetFlightsCollection();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_FlCode.Text, out int Fld))
            {
                MessageBox.Show("Invalid Flight Code. Please enter a numeric value.");
                return;
            }

            if (txt_FlCode.Text == "" || txt_FlCode.Text == "Enter Flight Code.." || cmx_date.Text == "" || cmx_source.Text == "Enter Source..." || cmx_destination.Text == "" || cmx_destination.Text == "Enter Destination..." || cmx_source.Text == "" || txt_seats.Text == "" || txt_seats.Text == "Enter Total Seats")
            {
                MessageBox.Show("Missing Information...");
            }
            else
            {
                try
                {
                    string id = txt_FlCode.Text;
                    int FlId = int.Parse(id);
                    string source = cmx_source.Text;
                    string destination = cmx_destination.Text;
                    string date = cmx_date.Text;
                    string totalSeats = txt_seats.Text;
                    int Total = int.Parse(totalSeats);

                    var newFlightRecord = new FlightsRecords
                    {
                        FlightCode = FlId,
                        Source = source,
                        Destination = destination,
                        TotalSeats = Total,
                        TakeofDate = date
                    };


                    _flightsCollection.InsertOne(newFlightRecord);

                    MessageBox.Show("Inserted Successfully....");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_FlCode_Enter(object sender, EventArgs e)
        {
            if (txt_FlCode.Text == "Enter Flight Code...")
            {
                txt_FlCode.Text = "";

                txt_FlCode.ForeColor = Color.Black;
            };
        }

        private void txt_FlCode_Leave(object sender, EventArgs e)
        {
            if (txt_FlCode.Text == "")
            {
                txt_FlCode.Text = "Enter Flight Code...";
                txt_FlCode.ForeColor = Color.Silver;
            }
        }

        private void cmx_source_Enter(object sender, EventArgs e)
        {
            if (cmx_source.Text == "Enter Source...")
            {
                cmx_source.Text = "";

                cmx_source.ForeColor = Color.Black;
            };
        }

        private void cmx_source_Leave(object sender, EventArgs e)
        {
            if (cmx_source.Text == "")
            {
                cmx_source.Text = "Enter Source...";
                cmx_source.ForeColor = Color.Silver;
            }
        }

        private void cmx_destination_Enter(object sender, EventArgs e)
        {
            if (cmx_destination.Text == "Enter Destination...")
            {
                cmx_destination.Text = "";

                cmx_destination.ForeColor = Color.Black;
            };
        }

        private void cmx_destination_Leave(object sender, EventArgs e)
        {
            if (cmx_destination.Text == "")
            {
                cmx_destination.Text = "Enter Destination...";
                cmx_destination.ForeColor = Color.Silver;
            }
        }

        private void txt_seats_Enter(object sender, EventArgs e)
        {
            if (txt_seats.Text == "Enter Total Seats...")
            {
                txt_seats.Text = "";

                txt_seats.ForeColor = Color.Black;
            };
        }

        private void txt_seats_Leave(object sender, EventArgs e)
        {
            if (txt_seats.Text == "")
            {
                txt_seats.Text = "Enter Total Seats...";
                txt_seats.ForeColor = Color.Silver;
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txt_FlCode.Text = "Enter Flight Code...";
            txt_FlCode.ForeColor = Color.Silver;
            txt_seats.Text = "Enter Total Seats...";
            txt_seats.ForeColor = Color.Silver;
            cmx_date.Text = "";
            cmx_destination.Text = "Enter Destination...";
            cmx_destination.ForeColor = Color.Silver;
            cmx_source.Text = "Enter Source...s";
            cmx_source.ForeColor = Color.Silver;
        }

        private void btn_viewFlights_Click(object sender, EventArgs e)
        {
            ViewFlights VF = new ViewFlights();
            VF.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void lbl_view_Click(object sender, EventArgs e)
        {
            ViewFlights VF = new ViewFlights();
            VF.Show();
            this.Hide();
        }
    }
}
