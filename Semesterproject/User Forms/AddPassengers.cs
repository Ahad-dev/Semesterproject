using DnsClient.Protocol;
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
        private readonly IMongoCollection<CustomersPasswords> _passwordsCollection;
        public AddPassengers()
        {
            InitializeComponent();

            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();
            _passwordsCollection = mongoService.GetPasswordsCollection();
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
            var total = _passwordsCollection.Find(_ => true).ToList();
            int count = total.Count();
            lbl_count.Text = count.ToString();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {

            if (txt_passengerid.Text == "" || txt_passName.Text == "" || txt_passAddress.Text == "" || txt_nationality.Text == "" || txt_passGender.Text == "" || txt_phone.Text == "" || txt_Passport.Text == "")
            {
                MessageBox.Show("Incomplete Information !!");
            }
            else if (txt_passGender.Text != "Male" && txt_passGender.Text != "Female" && txt_passGender.Text != "None")
            {
                MessageBox.Show("Gender can be only Male/Female or None");
            }
            else
            {
                try
                {
                    var filter = Builders<CustomersPasswords>.Filter.Eq("CNIC", txt_CNIC.Text);
                    var result = _passwordsCollection.Find(filter).FirstOrDefault();

                    string id = txt_passengerid.Text;
                    int passengerId = int.Parse(id);
                    string name = txt_passName.Text;
                    string address = txt_passAddress.Text;
                    string nationality = txt_nationality.Text;
                    string gender = txt_passGender.Text;
                    string phone = txt_phone.Text;
                    string passport = txt_Passport.Text;
                    string cnic = txt_CNIC.Text;

                    string role = result.Role;
                    string password = result.Password;

                    var newPassengerRecord = new Passengers
                    {
                        PassId = passengerId, 
                        PassName = name,
                        Passport = passport,
                        PassAddress = address,
                        PassNationality = nationality,
                        PassGender = gender,
                        PassPhone = phone,
                        Password = password,
                        Role = role,
                        CNIC = cnic
                    };

                    // Insert the record into the collection
                    _passengersCollection.InsertOne(newPassengerRecord);

                    //Now deleting passenger
                    DeletePassengers(txt_CNIC.Text);
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

        private void txt_CNIC_Leave(object sender, EventArgs e)
        {
            var filter = Builders<CustomersPasswords>.Filter.Eq("CNIC", txt_CNIC.Text);
            var result = _passwordsCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                txt_passName.Text = result.UserName;
                txt_Passport.Text = result.Passport;
                txt_nationality.Text = result.PassNationality;
                txt_passAddress.Text = result.PassAddress;
                txt_phone.Text = result.PassPhone;
                txt_passGender.Text = result.PassGender;

                txt_passName.ReadOnly = true;
                txt_Passport.ReadOnly = true;
                txt_nationality.ReadOnly = true;
                txt_passAddress.ReadOnly = true;
                txt_phone.ReadOnly = true;
                txt_passGender.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Passenger Not Registered!!");
                btn_record.Enabled = false;
            }
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txt_passName.ReadOnly = false;
            txt_Passport.ReadOnly = false;
            txt_nationality.ReadOnly = false;
            txt_passAddress.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_passGender.ReadOnly = false;

            txt_passName.Text = "";
            txt_Passport.Text = "";
            txt_nationality.Text = "";
            txt_passAddress.Text = "";
            txt_phone.Text = "";
            txt_passGender.Text = "";
            txt_CNIC.Text = "";
            txt_passengerid.Text = "";
        }

        private void DeletePassengers(string CNIC)
        {
            var filter = Builders<CustomersPasswords>.Filter.Eq("CNIC", CNIC);
            var result = _passwordsCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                var delete = _passwordsCollection.DeleteOne(filter);

                if (delete.DeletedCount > 0)
                {
                    MessageBox.Show("Passenger Approved and Confirmed..");
                    lbl_count.Text = (int.Parse(lbl_count.Text)-1).ToString();
                }
            }
        }
    }
}
