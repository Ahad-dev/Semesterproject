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

namespace Semesterproject.User_Forms
{

    public partial class ViewFeedBack : Form
    {
        private readonly IMongoCollection<FeedbackModel> _feedbacksCollection;
        public ViewFeedBack()
        {
            InitializeComponent();

            var mongoServices = new MongoDBservices();
            _feedbacksCollection = mongoServices.GetFeedbackCollection();

            var tickets = _feedbacksCollection.Find(_ => true).ToList();
            guna2DataGridView1.DataSource = tickets;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirLineStaffDashboard AD = new AirLineStaffDashboard();
            AD.Show();
            this.Hide();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewFeedBack_Load(object sender, EventArgs e)
        {

        }
    }
}
