using Guna.UI2.WinForms;
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

namespace Semesterproject.User_Controls
{
    public partial class Collection : UserControl
    {
        private readonly IMongoCollection<Report> _reportscollection;

        public Collection()
        {
            InitializeComponent();
            var mongoService = new MongoDBservices();
            _reportscollection = mongoService.GetReportsCollection();
        }

        public event EventHandler DataUpdated;
        protected virtual void OnDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string reportId = txt_Id.Text;

            var filter = Builders<Report>.Filter.Eq("ReportId", reportId);

            var update = Builders<Report>.Update
                .Set("ReportDate", txt_date.Text)
                .Set("ReportType", txt_type.Text)
                .Set("ReportData", txt_content.Text);

            var existingReport = _reportscollection.Find(filter).FirstOrDefault();
            if (existingReport != null)
            {
                _reportscollection.UpdateOne(filter, update);
                MessageBox.Show("Report updated successfully.");

                OnDataUpdated();
            }
            else
            {
                MessageBox.Show("Report not found!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "")
            {
                MessageBox.Show("Missing Information !!");
            }
            else
            {
                var filter = Builders<Report>.Filter.Eq("ReportId", txt_Id.Text);
                var result = _reportscollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    var delete = _reportscollection.DeleteOne(filter);

                    if (delete.DeletedCount > 0)
                    {
                        MessageBox.Show("Report Removed!!");
                        OnDataUpdated();
                    }
                    else
                    {
                        MessageBox.Show("Report Cancellation Failed!!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Information OR Invalid ReportId");
                }

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_content.Clear();
            txt_date.Clear();
            txt_Id.Clear();
            txt_type.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Reports R = new Reports();
            R.Show();
            this.Hide();
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            string ID = txt_Id.Text;

            var filter = Builders<Report>.Filter.Eq("ReportId", txt_Id.Text);
            var result = _reportscollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                txt_content.Text = result.ReportData;
                txt_type.Text = result.ReportType;
                txt_date.Text = result.ReportDate.ToString();
            }
            else
            {
                MessageBox.Show("Report Not Found!!");
            }
        }
    }


}
