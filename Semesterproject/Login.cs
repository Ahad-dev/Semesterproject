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
        private readonly IMongoCollection<CustomersPasswords> _passwordsCollection;

        public Login()
        {
            InitializeComponent();

            var mongoService = new MongoDBservices();
            _passwordsCollection = mongoService.GetPasswordsCollection();
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

            if (txt_role.Text != "Customer" && txt_role.Text != "Admin")
            {
                MessageBox.Show("Role is only Customer OR Admin.");
            }
            else if (txt_role.Text == "Admin")
            {
                MessageBox.Show("Admin Can't SingUp");
            }
            else if (txt_pass.Text == "" || txt_user.Text == "" || txt_role.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                string user = txt_user.Text;
                string pass = txt_pass.Text;
                string role = txt_role.Text;

                var passwords = new CustomersPasswords
                {
                    Password = pass,
                    UserName = user,
                    Role = role
                };

                _passwordsCollection.InsertOne(passwords);

                MessageBox.Show("Successfully SignUp.! Now Login Again.");

                txt_pass.Text = "";
                txt_user.Text = "";
                txt_role.Text = "";
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_user.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                var ticketFilter = Builders<CustomersPasswords>.Filter.Eq("UserName", txt_user.Text);
                var Found = _passwordsCollection.Find(ticketFilter).FirstOrDefault();

                if (Found != null)
                {
                    if (txt_user.Text == Found.UserName && txt_pass.Text == Found.Password && txt_role.Text == Found.Role)
                    {

                        if (Found.Role == "Customer")
                        {

                            btn_update BU = new btn_update();
                            BU.Show();
                            this.Hide();
                        }
                        else if(Found.Role == "Admin")
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
                    MessageBox.Show("Passenger Not Found: Check the username entered.");
                }

            }
        }
    }
}
