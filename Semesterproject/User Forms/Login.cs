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
    public partial class Login : Form
    {
        private readonly IMongoCollection<Passengers> _passengersCollection;

        public Login()
        {
            InitializeComponent();

            var mongoService = new MongoDBservices();
            _passengersCollection = mongoService.GetPassengersCollection();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            btn_login.Enabled = true;

            if (txt_role.Text == "" || txt_pass.Text == "" || txt_user.Text == "")
            {
                MessageBox.Show("First, Fill All Fields !");
            }
            else if (txt_role.Text != "Admin" && txt_role.Text != "Customer")
            {
                MessageBox.Show("Type Role as Admin/Customer.");
            }
            else if (txt_role.Text == "Admin")
            {
                MessageBox.Show("Sorry, Admins Can't SignUp!!");
                btn_login.Enabled = false;
            }
            else
            {
                SignUp SP = new SignUp(txt_user.Text, txt_pass.Text, txt_role.Text);
                SP.Show();
                this.Hide();
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_user.Text == "" || txt_CNIC.Text == "" || txt_role.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                var ticketFilter = Builders<Passengers>.Filter.Eq("CNIC", txt_CNIC.Text);
                var Found = _passengersCollection.Find(ticketFilter).FirstOrDefault();

                if (Found != null)
                {
                    if (txt_user.Text == Found.PassName && txt_pass.Text == Found.Password && txt_role.Text == Found.Role && txt_CNIC.Text == Found.CNIC)
                    {

                        if (Found.Role == "Customer")
                        {
                            btn_update BU = new btn_update();
                            BU.Show();
                            this.Hide();
                        }
                        else if (Found.Role == "Admin")
                        {
                            Home BU = new Home();
                            BU.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Authentication Failed: Incorrect username, password, or role not empty.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CNIC !!!");
                }
            }
        }

        private void txt_role_Leave(object sender, EventArgs e)
        {

        }

        private void txt_role_Enter(object sender, EventArgs e)
        {
            lbl_signUp.Enabled = true;
            btn_login.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt_CNIC.Text = "";
            txt_pass.Text = "";
            txt_role.Text = "";
            txt_user.Text = "";
        }
    }
}
