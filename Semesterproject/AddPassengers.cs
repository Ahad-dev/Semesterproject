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
    public partial class AddPassengers : Form
    {
        private readonly IMongoCollection<Passengers> _passengersCollection;

        public AddPassengers()
        {
            InitializeComponent();

            // Initialize the MongoDB service
            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPassengers_Load(object sender, EventArgs e)
        {

        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            string Phone = txt_phone.Text;

            if (txt_passengerid.Text == "" || txt_passName.Text == "" || txt_passAddress.Text == "" || txt_nationality.Text == "" || txt_passGender.Text == "" || txt_phone.Text == "" || txt_Passport.Text == "")
            {
                MessageBox.Show("Incomplete Information !!");
            }
            else if (txt_passGender.Text != "Male" && txt_passGender.Text != "Female" && txt_passGender.Text != "None")
            {
                MessageBox.Show("Gender can be only Male/Female or None");
            }
            else if (Phone.Length != 14)
            {
                MessageBox.Show("Invalid Phone Formate !!");
            }
            else
            {
                try
                {
                    // Collect data from the form
                    string id = txt_passengerid.Text;
                    int passengerId = int.Parse(id);
                    string name = txt_passName.Text;
                    string address = txt_passAddress.Text;
                    string nationality = txt_nationality.Text;
                    string gender = txt_passGender.Text;
                    string phone = txt_phone.Text;
                    string passport = txt_Passport.Text;


                    // Create a new Signup record
                    var newPassengerRecord = new Passengers
                    {
                        PassId = passengerId, // Generate a unique ObjectId
                        PassName = name,
                        Passport = passport,
                        PassAddress = address,
                        PassNationality = nationality,
                        PassGender = gender,
                        PassPhone = phone,
                    };

                    // Insert the record into the collection
                    _passengersCollection.InsertOne(newPassengerRecord);

                    MessageBox.Show("Passenger Recorded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llb_view_Click(object sender, EventArgs e)
        {
            ViewPassengers VP = new ViewPassengers();
            VP.Show();
            this.Close();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            Home VP = new Home();
            VP.Show();
            this.Close();
        }
    }
}
