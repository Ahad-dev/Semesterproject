using AirLineService;
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
    public partial class AirLineServices : Form
    {
        private readonly IMongoCollection<Passengers> _passengersCollection;
        AirLineService.Service1Client myserver = new AirLineService.Service1Client();


        public AirLineServices()
        {
            InitializeComponent();
            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();



            var filter = Builders<Passengers>.Filter.Eq("PassId", "1");
            var passenger = _passengersCollection.Find(filter).FirstOrDefault();

            AirLineService.Passenger myPassengers = new AirLineService.Passenger();
            myPassengers.PassengerAddress = passenger.PassAddress;
            myPassengers.PassengerGender = passenger.PassGender;
            myPassengers.PassengerId = passenger.PassId.ToString();
            myPassengers.PassengerName = passenger.PassName;
            myPassengers.PassengerNationality = passenger.PassNationality;
            myPassengers.PassengerPhone = passenger.Passport;
            myPassengers.PassengerPhone = passenger.PassPhone;


            myserver.AddPassAsync(myPassengers);


            lbl_1.Text = "Name";
            lbl_2.Text = "CNIC";
            lbl_3.Text = "Gender";
            lbl_4.Text = "Address";
            lbl_5.Text = "Natioanlity";

            lbl_6.Text = "Passport";
            lbl_7.Text = "PhoneNo.";

            txt_6.Visible = true;
            txt_7.Visible = true;
        }

        private void AirLineServices_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_choice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void cmb_choice_Leave(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && cmb_choice.Text != "")
            {
                var passengerDetails = await myserver.GetPassengerDetailsAsync(int.Parse(txt_id.Text));

                txt_1.Text = passengerDetails.PassengerName;
                txt_2.Text = passengerDetails.Cnic;
                txt_3.Text = passengerDetails.PassengerGender;
                txt_4.Text = passengerDetails.PassengerAddress;
                txt_5.Text = passengerDetails.PassengerNationality;
                txt_6.Text = passengerDetails.PassengerPassport;
                txt_7.Text = passengerDetails.PassengerPhone;
            }
        }
    }
}
