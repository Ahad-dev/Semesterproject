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

namespace Semesterproject.User_Forms
{
    public partial class ChangeInfo : Form
    {
        private readonly IMongoCollection<Passengers> _passengersCollection;
        public ChangeInfo(string ID)
        {
            InitializeComponent();
            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();

            var filter = Builders<Passengers>.Filter.Eq("PassId", ID);
            var result = _passengersCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                txt_address1.Text = result.PassAddress;
                txt_gender1.Text = result.PassGender;
                txt_name1.Text = result.PassName;
                txt_nation1.Text = result.PassNationality;
                txt_phone1.Text = result.PassPhone;
                txt_password1.Text = result.Password;
                txt_passport1.Text = result.Passport;
                txt_ID1.Text = result.PassId.ToString();
                txt_CNIC1.Text = result.CNIC;

                txt_passengerid.Text = result.PassId.ToString();
                txt_CNIC2.Text = result.CNIC;
            }

            txt_ID1.ReadOnly = true;
            txt_passengerid.ReadOnly = true;
            txt_CNIC1.ReadOnly = true;
            txt_CNIC2.ReadOnly = true;
        }

        private void lbl_clear1_Click(object sender, EventArgs e)
        {
            txt_address1.Text = "";
            txt_gender1.Text = "";
            txt_name1.Text = "";
            txt_nation1.Text = "";
            txt_phone1.Text = "";
            txt_password1.Text = "";
            txt_passport1.Text = "";
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txt_passGender.Text = "";
            txt_nationality.Text = "";
            txt_passAddress.Text = "";
            txt_passName.Text = "";
            txt_Passport.Text = "";
            txt_phone.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_passGender.Text = txt_gender1.Text;
            txt_nationality.Text = txt_nation1.Text;
            txt_passAddress.Text = txt_address1.Text;
            txt_passName.Text = txt_name1.Text;
            txt_Passport.Text = txt_passport1.Text;
            txt_phone.Text = txt_phone1.Text;
            textBox2.Text = txt_password1.Text;

            MessageBox.Show("Updations Saved!! Confirm Now!!");
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            var filter = Builders<Passengers>.Filter.Eq("PassId", txt_passengerid.Text);
            var update = Builders<Passengers>.Update
            .Set("PassNationality", txt_nationality.Text)
            .Set("PassGender", txt_passGender.Text)
            .Set("PassName", txt_passName.Text)
            .Set("PassPhone", txt_phone.Text)
            .Set("Password", textBox2.Text)
            .Set("PassAddress", txt_passAddress.Text)
            .Set("Passport", txt_Passport.Text);

            _passengersCollection.UpdateOne(filter, update);

            MessageBox.Show("Information Updated Successfully!!");

            btn_update PD = new btn_update(txt_passengerid.Text);
            PD.Show();
            this.Hide();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            btn_update PD = new btn_update(txt_passengerid.Text);
            PD.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            btn_update PD = new btn_update(txt_passengerid.Text);
            PD.Show();
            this.Hide();
        }
    }
}
