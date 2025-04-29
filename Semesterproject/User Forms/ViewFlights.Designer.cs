namespace Semesterproject
{
    partial class ViewFlights
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            label8 = new Label();
            btn_back = new Button();
            btn_delete = new Button();
            btn_reset = new Button();
            btn_update = new Button();
            txt_numberofseats = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmb_source = new ComboBox();
            cmd_destination = new ComboBox();
            panel1 = new Panel();
            lbl_exit = new Label();
            label4 = new Label();
            label1 = new Label();
            txt_flightcode = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.LightGreen;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(2, 386);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(815, 267);
            guna2DataGridView1.TabIndex = 30;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.LightGreen;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(279, 66);
            label2.Name = "label2";
            label2.Size = new Size(269, 27);
            label2.TabIndex = 32;
            label2.Text = "View Scheduled Flights";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label8.Location = new Point(254, 40);
            label8.Name = "label8";
            label8.Size = new Size(331, 27);
            label8.TabIndex = 31;
            label8.Text = "AirLine Management System";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DarkGreen;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(562, 303);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(119, 42);
            btn_back.TabIndex = 34;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkGreen;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(272, 303);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 42);
            btn_delete.TabIndex = 33;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.DarkGreen;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_reset.ForeColor = SystemColors.ButtonHighlight;
            btn_reset.Location = new Point(420, 303);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(119, 42);
            btn_reset.TabIndex = 35;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DarkGreen;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(130, 303);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 42);
            btn_update.TabIndex = 36;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // txt_numberofseats
            // 
            txt_numberofseats.BackColor = Color.White;
            txt_numberofseats.Font = new Font("Century Gothic", 12F);
            txt_numberofseats.Location = new Point(535, 126);
            txt_numberofseats.Multiline = true;
            txt_numberofseats.Name = "txt_numberofseats";
            txt_numberofseats.Size = new Size(198, 34);
            txt_numberofseats.TabIndex = 79;
            txt_numberofseats.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ButtonFace;
            dateTimePicker1.CalendarTrailingForeColor = Color.Gainsboro;
            dateTimePicker1.Font = new Font("Century Gothic", 12F);
            dateTimePicker1.Location = new Point(376, 234);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 32);
            dateTimePicker1.TabIndex = 85;
            // 
            // cmb_source
            // 
            cmb_source.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_source.BackColor = Color.White;
            cmb_source.FlatStyle = FlatStyle.System;
            cmb_source.Font = new Font("Century Gothic", 12F);
            cmb_source.FormattingEnabled = true;
            cmb_source.Location = new Point(189, 180);
            cmb_source.Name = "cmb_source";
            cmb_source.Size = new Size(198, 31);
            cmb_source.TabIndex = 86;
            // 
            // cmd_destination
            // 
            cmd_destination.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmd_destination.BackColor = Color.White;
            cmd_destination.FlatStyle = FlatStyle.System;
            cmd_destination.Font = new Font("Century Gothic", 12F);
            cmd_destination.FormattingEnabled = true;
            cmd_destination.Location = new Point(535, 180);
            cmd_destination.Name = "cmd_destination";
            cmd_destination.Size = new Size(198, 31);
            cmd_destination.TabIndex = 87;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(lbl_exit);
            panel1.Location = new Point(-22, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 25);
            panel1.TabIndex = 88;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.BackColor = Color.DarkGreen;
            lbl_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exit.ForeColor = SystemColors.ButtonHighlight;
            lbl_exit.Location = new Point(811, -5);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(24, 28);
            lbl_exit.TabIndex = 90;
            lbl_exit.Text = "X";
            lbl_exit.Click += lbl_exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(76, 130);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 92;
            label4.Text = "FlightId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(419, 131);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 94;
            label1.Text = "TotalSeats";
            // 
            // txt_flightcode
            // 
            txt_flightcode.BackColor = Color.White;
            txt_flightcode.Font = new Font("Century Gothic", 12F);
            txt_flightcode.Location = new Point(189, 126);
            txt_flightcode.Multiline = true;
            txt_flightcode.Name = "txt_flightcode";
            txt_flightcode.Size = new Size(198, 34);
            txt_flightcode.TabIndex = 95;
            txt_flightcode.TextAlign = HorizontalAlignment.Center;
            txt_flightcode.TextChanged += txt_flightcode_TextChanged;
            txt_flightcode.Enter += txt_flightcode_Enter;
            txt_flightcode.Leave += txt_flightcode_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(421, 185);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 96;
            label3.Text = "Dest.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(76, 185);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 97;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(296, 237);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 98;
            label6.Text = "Date";
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(820, 657);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_flightcode);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(cmd_destination);
            Controls.Add(cmb_source);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_numberofseats);
            Controls.Add(btn_update);
            Controls.Add(btn_reset);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(guna2DataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label label2;
        private Label label8;
        public Button btn_back;
        public Button btn_delete;
        public Button btn_reset;
        public Button btn_update;
        private TextBox txb_flightcode;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private TextBox txt_numberofseats;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmb_source;
        private ComboBox cmd_destination;
        private Panel panel1;
        private Label lbl_exit;
        private Label label4;
        private TextBox txt_flightcode;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}