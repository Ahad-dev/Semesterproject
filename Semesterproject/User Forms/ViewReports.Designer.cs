namespace Semesterproject
{
    partial class ViewReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            lbl_exit = new Label();
            label2 = new Label();
            label8 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            collection1 = new User_Controls.Collection();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(164, 56, 32);
            panel2.Location = new Point(-28, 645);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 26);
            panel2.TabIndex = 105;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 33, 26);
            panel1.Controls.Add(lbl_exit);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 26);
            panel1.TabIndex = 103;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_exit.ForeColor = Color.Honeydew;
            lbl_exit.Location = new Point(781, 1);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(24, 23);
            lbl_exit.TabIndex = 61;
            lbl_exit.Text = "X";
            lbl_exit.Click += lbl_exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 58);
            label2.Name = "label2";
            label2.Size = new Size(155, 27);
            label2.TabIndex = 84;
            label2.Text = "View Reports";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(244, 34);
            label8.Name = "label8";
            label8.Size = new Size(331, 27);
            label8.TabIndex = 83;
            label8.Text = "AirLine Management System";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.FromArgb(70, 33, 26);
            guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 35;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(241, 211, 178);
            guna2DataGridView1.Location = new Point(0, 380);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 32;
            guna2DataGridView1.Size = new Size(822, 267);
            guna2DataGridView1.TabIndex = 106;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(241, 211, 178);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(70, 33, 26);
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(241, 211, 178);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(164, 56, 32);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(70, 33, 26);
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(241, 211, 178);
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.None;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(70, 33, 26);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 32;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(70, 33, 26);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(241, 211, 178);
            // 
            // collection1
            // 
            collection1.BackColor = Color.FromArgb(241, 211, 178);
            collection1.Location = new Point(0, 86);
            collection1.Name = "collection1";
            collection1.Size = new Size(822, 271);
            collection1.TabIndex = 107;
            // 
            // ViewReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 211, 178);
            ClientSize = new Size(820, 670);
            Controls.Add(collection1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewReports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox txt_flight;
        private Panel panel1;
        private Label lbl_exit;
        private TextBox txt_ticketid;
        private TextBox txt_amount;
        private TextBox txt_PassNation;
        private Label label1;
        private Label label9;
        private Label label6;
        private Label label2;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private User_Controls.Collection collection1;
    }
}