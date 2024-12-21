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
    public partial class SignUp : Form
    {
        private readonly IMongoCollection<CustomersPasswords> _passwordsCollection;
        public SignUp(string a, string b, string c)
        {
            InitializeComponent();
            var mongoService = new MongoDBservices();
            _passwordsCollection = mongoService.GetPasswordsCollection();

            txt_user.Text = a;
            txt_pass.Text = b;
            txt_role.Text = c;

            txt_user.ReadOnly = true;
            txt_pass.ReadOnly = true;
            txt_role.ReadOnly = true;
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void lbl_reset_Click(object sender, EventArgs e)
        {
            txt_gender.Text = "";
            txt_address.Text = "";
            txt_nationality.Text = "";
            txt_passport.Text = "";
            txt_phone.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            var filter = Builders<CustomersPasswords>.Filter.Eq("CNIC", txt_CNIC.Text);
            var result = _passwordsCollection.Find(filter).FirstOrDefault();

            if (txt_gender.Text == "" || txt_address.Text == "" || txt_nationality.Text == "" || txt_passport.Text == "" || txt_phone.Text == "" || txt_CNIC.Text == "")
            {
                MessageBox.Show("Any missing, Review once!!");
            }
            else if (txt_gender.Text != "Male" && txt_gender.Text != "Female" && txt_gender.Text != "None")
            {
                MessageBox.Show("Gender can be only Male/Female/None");
            }
            else if (txt_phone.Text.Length != 12)
            {
                MessageBox.Show("Invalid Phone Number, Remove Spaces!!");
            }
            else if (txt_CNIC.Text.Length != 15)
            {
                MessageBox.Show("Follow CNIC Format : XXXXX-XXXXXXX-X");
            }
            else if (result != null)
            {
                MessageBox.Show("CNIC is in use already!!");
                btn_signup.Enabled = false;
            }
            else
            {
                btn_signup.Enabled = true;
                string a = txt_user.Text;
                string b = txt_passport.Text;
                string c = txt_phone.Text;
                string d = txt_gender.Text;
                string h = txt_address.Text;
                string f = txt_nationality.Text;
                string g = txt_pass.Text;
                string i = txt_role.Text;
                string j = txt_CNIC.Text;

                var newUnconfirmedPassenger = new CustomersPasswords
                {
                    CNIC = j,
                    UserName = a,
                    PassAddress = h,
                    PassNationality = f,
                    PassGender = d,
                    PassPhone = c,
                    Passport = b,
                    Password = g,
                    Role = i
                };

                _passwordsCollection.InsertOne(newUnconfirmedPassenger);

                MessageBox.Show("Thank you! Wait till approved by administration.");

                Login L = new Login();
                L.Show();
                this.Hide();
            }
        }

        private void txt_CNIC_Enter(object sender, EventArgs e)
        {
            btn_signup.Enabled = true;
        }
    }
}
