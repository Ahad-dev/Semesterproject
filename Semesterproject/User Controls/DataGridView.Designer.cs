using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Semesterproject.User_Controls
{
    partial class DataGridView
    {

        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView guna2DataGridView1;

        public Guna.UI2.WinForms.Guna2DataGridView DataGrid => guna2DataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Guna2DataGridView guna2DataGridView2;

        public void BindData<T>(IEnumerable<T> data)
        {
            try
            {
                DataGrid.DataSource = null; // Reset DataSource
                DataGrid.DataSource = data; // Bind new data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error binding data: {ex.Message}");
            }
        }

        public T GetSelectedRow<T>() where T : class
        {
            if (DataGrid.SelectedRows.Count > 0)
            {
                return DataGrid.SelectedRows[0].DataBoundItem as T;
            }
            return null;
        }
    }
}
