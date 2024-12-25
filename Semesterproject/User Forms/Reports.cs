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
    public partial class Reports : Form
    {
        private readonly IMongoCollection<Report> _reportscollection;
        DateTime DT;
        public Reports()
        {
            var mongoService = new MongoDBservices();
            _reportscollection = mongoService.GetReportsCollection();
            InitializeComponent();

            DT = DateTime.Now;
            txt_date.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewReports VR = new ViewReports();
            VR.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (cmb_type.Text == "" || txt_content.Text == "" || txt_reportID.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                string a = txt_reportID.Text;
                string b = txt_content.Text;
                string c = cmb_type.Text;

                var report = new Report()
                {
                    ReportDate = DT,
                    ReportId = a,
                    ReportData = b,
                    ReportType = c
                };

                _reportscollection.InsertOne(report);

                MessageBox.Show("Report Saved Successfully!!");
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void lbl_clears_Click(object sender, EventArgs e)
        {
            txt_reportID.Text = "";
            txt_content.Text = "";
            cmb_type.Text = "";
        }
    }
}
