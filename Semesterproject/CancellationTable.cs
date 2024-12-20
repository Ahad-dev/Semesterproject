using Guna.UI2.WinForms;
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
    public partial class CancellationTable : Form
    {
        private readonly IMongoCollection<Cancellation> _cancelTicketCollection;
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;
        private readonly IMongoCollection<TicketsTable> _ticketsCollection;

        public CancellationTable()
        {
            InitializeComponent();

            var mongoService = new MongoDBservices();
            _cancelTicketCollection = mongoService.GetCancelTicketCollection();
            _flightsCollection = mongoService.GetFlightsCollection();
            _ticketsCollection = mongoService.GetTicketsCollection();

            guna2DataGridView1.EnableHeadersVisualStyles = false;
            guna2DataGridView1.BackgroundColor = ColorTranslator.FromHtml("#FFC0CB");
            panel3.BackColor = ColorTranslator.FromHtml("#C71585");
            panel5.BackColor = ColorTranslator.FromHtml("#C71585");
            btn_record.BackColor = ColorTranslator.FromHtml("#C71585");
            btn_back.BackColor = ColorTranslator.FromHtml("#C71585");
            btn_reset.BackColor = ColorTranslator.FromHtml("#C71585");
            lbl_exit.BackColor = ColorTranslator.FromHtml("#C71585");

            guna2DataGridView1.GridColor = ColorTranslator.FromHtml("#C71585");
            guna2DataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE4E1");
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE4E1");
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#C71585");
            guna2DataGridView1.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#C71585");
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FADADD");
            
            populate();
        }

        private void CancellationTable_Load(object sender, EventArgs e)
        {        }

        private void populate()
        {
            try
            {
                var canTickets = _cancelTicketCollection.Find(_ => true).ToList();
                guna2DataGridView1.DataSource = canTickets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filed To Load Data..");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            txt_flightcode.ReadOnly = false;
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_ticketid_Leave(object sender, EventArgs e)
        {
            var ticket = Builders<TicketsTable>.Filter.Eq("TicketId", txt_ticketid.Text);
            var Found = _ticketsCollection.Find(ticket).FirstOrDefault();

            if (Found != null)
            {
                txt_flightcode.Text = Found.FlCode;
                txt_flightcode.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No Ticket Found With this Record!!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Cancelid.Text = "";
            txt_ticketid.Text = "";
            txt_flightcode.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Tickets T = new Tickets();
            T.Show();
            this.Hide();
        }

        private void btn_record_Click_1(object sender, EventArgs e)
        {

            if (txt_flightcode.Text == "" || txt_ticketid.Text == "" || txt_Cancelid.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Incomplete Information !!");
            }
            else
            {
                var ticket1 = Builders<TicketsTable>.Filter.Eq("TicketId", txt_ticketid.Text);
                var Found1 = _ticketsCollection.Find(ticket1).FirstOrDefault();
                if (Found1 == null)
                {
                    try
                    {
                        // Collect data from the form
                        string id = txt_Cancelid.Text;
                        int CID = int.Parse(id);
                        string ticketId = txt_ticketid.Text;
                        string Fid = txt_flightcode.Text;
                        string date = dateTimePicker1.Text;


                        // Create a new Signup record
                        var newCancel = new Cancellation
                        {
                            CancelId = CID,
                            TicketId = ticketId,
                            FlightCode = Fid,
                            Date = date
                        };

                        // Insert the record into the collection
                        _cancelTicketCollection.InsertOne(newCancel);


                        var ticket = Builders<TicketsTable>.Filter.Eq("TicketId", txt_ticketid.Text);
                        var Found = _ticketsCollection.Find(ticket).FirstOrDefault();
                        populate();


                        if (Found != null)
                        {
                            var delete = _ticketsCollection.DeleteOne(ticket);

                            if (delete.DeletedCount > 0)
                            {
                                MessageBox.Show("Ticket Cancelled Successfully!");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("CancelId Already In Use, Kindly Reallocate!!");
                }
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear previous values
            txt_Cancelid.Text = "";
            txt_ticketid.Text = "";
            txt_flightcode.Text = "";
            dateTimePicker1.Text = "";

            // Check if the clicked cell belongs to a valid row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Safely set values from the row's cells
                txt_Cancelid.Text = row.Cells[0].Value.ToString();
                txt_ticketid.Text = row.Cells[1].Value.ToString();
                txt_flightcode.Text = row.Cells[3].Value.ToString();
            }
        }

        private void txt_ticketid_Enter(object sender, EventArgs e)
        {
            txt_flightcode.Text = "";
            txt_flightcode.ReadOnly = false;
        }
    }
}
