using MongoDB.Driver;
using Semesterproject.Models;
using Semesterproject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterproject
{
    public partial class ViewFlights : Form
    {
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;

        public ViewFlights()
        {
            InitializeComponent();

            var mongoServices = new MongoDBservices();
            _flightsCollection = mongoServices.GetFlightsCollection();
            btn_back.Enabled = true;

            guna2DataGridView1.DefaultCellStyle.BackColor = Color.Honeydew;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            guna2DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            guna2DataGridView1.RowHeadersWidth = 35;
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            var flights = _flightsCollection.Find(_ => true).ToList();
            guna2DataGridView1.DataSource = flights;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            lbl_flights FL = new lbl_flights();
            FL.Show();
            this.Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_numberofseats.Text = "";
            cmb_source.Text = "";
            cmd_destination.Text = "";
            txt_flightcode.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_numberofseats.Text == "" || txt_flightcode.Text == "" || cmb_source.Text == "" || cmd_destination.Text == "")
            {
                MessageBox.Show("Missing Information !!");
            }
            else
            {
                var filter = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_flightcode.Text);
                var result = _flightsCollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    var delete = _flightsCollection.DeleteOne(filter);

                    if (delete.DeletedCount > 0)
                    {
                        MessageBox.Show("Flight Cancelled SuccessFully...");

                        var Flights = _flightsCollection.Find(_ => true).ToList();
                        guna2DataGridView1.DataSource = Flights;
                    }
                    else
                    {
                        MessageBox.Show("Flight Cancellation Failed...");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Information OR Invalid FlightCode");
                }

            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are giving you access to re-edit to update!!");
            txt_flightcode.ReadOnly = false;
            txt_numberofseats.ReadOnly = false;
            cmb_source.Enabled = true;
            cmd_destination.Enabled = true;


            if (txt_numberofseats.Text == "" || txt_flightcode.Text == "" || cmb_source.Text == "" || cmd_destination.Text == "")
            {
                MessageBox.Show("Missing Information !!");
            }
            else
            {
                var filter = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_flightcode.Text);
                var update = Builders<FlightsRecords>.Update
                    .Set("Source", cmb_source.Text)
                    .Set("Destination", cmd_destination.Text)
                    .Set("TotalSeats", txt_numberofseats.Text)
                    .Set("TakeofDate", dateTimePicker1.Text);

                if (filter != null)
                {
                    _flightsCollection.UpdateOne(filter, update);
                    MessageBox.Show("Update Records Successfully..");

                    var flights = _flightsCollection.Find(_ => true).ToList();
                    guna2DataGridView1.DataSource = flights;
                }
                else
                {
                    MessageBox.Show("Flight Not Found...");
                }
            }

            txt_flightcode.ReadOnly = true;
            txt_numberofseats.ReadOnly = true;
            cmb_source.Enabled = false;
            cmd_destination.Enabled = false;

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            btn_back.Enabled = true;
            btn_delete.Enabled = true;
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_numberofseats.Text = "";
            cmb_source.Text = "";
            cmd_destination.Text = "";
            txt_flightcode.Text = "";
            dateTimePicker1.Text = "";

            txt_numberofseats.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmb_source.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmd_destination.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_flightcode.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dateTimePicker1.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void txt_flightcode_Leave(object sender, EventArgs e)
        {
            var filter = Builders<FlightsRecords>.Filter.Eq("FlightCode", txt_flightcode.Text);
            var result = _flightsCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                txt_numberofseats.Text = result.TotalSeats.ToString();
                cmb_source.Text = result.Source;
                cmd_destination.Text = result.Destination;

                txt_numberofseats.ReadOnly = true;
                cmd_destination.Enabled = false;
                cmb_source.Enabled = false;
            }
            else
            {
                btn_delete.Enabled = false;
                btn_reset.Enabled = false;
                btn_update.Enabled = false;

                MessageBox.Show("Can't allow you to make updations, as we are not able you to find this flight.");
            }
        }

        private void txt_flightcode_Enter(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
            btn_reset.Enabled = true;
            btn_update.Enabled = true;

            txt_numberofseats.Text = "";
            cmb_source.Text = "";
            cmd_destination.Text = "";

            txt_numberofseats.ReadOnly = false;
            cmd_destination.Enabled = true;
            cmb_source.Enabled = true;
        }

        private void txt_flightcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
