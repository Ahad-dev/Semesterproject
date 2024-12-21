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
    public partial class ViewReports : Form
    {
        private readonly IMongoCollection<Report> _reportscollection;

        public ViewReports()
        {
            InitializeComponent();
            var mongoService = new MongoDBservices();
            _reportscollection = mongoService.GetReportsCollection();
            collection1.DataUpdated += CollectionControl_DataUpdated;

            guna2DataGridView1.EnableHeadersVisualStyles = false;

            guna2DataGridView1.GridColor = ColorTranslator.FromHtml("#F1D3B2");
            guna2DataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#efc292");
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F1D3B2");
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#46211A");
            guna2DataGridView1.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#46211A");
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F1D3B2");
            LoadPassengers();
        }

        private void CollectionControl_DataUpdated(object sender, EventArgs e)
        {
            LoadPassengers(); 
        }

        private void LoadPassengers()
        {
            try
            {
                var reports = _reportscollection.Find(_ => true).ToList();
                guna2DataGridView1.DataSource = reports;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
