namespace Semesterproject.User_Forms
{
    partial class FlightsTiming
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
            txt_pilotid = new TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            txt_destination = new TextBox();
            txt_seats = new TextBox();
            txt_date = new TextBox();
            label1 = new Label();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_source = new TextBox();
            txt_flightid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_pilotid
            // 
            txt_pilotid.Font = new Font("Century Gothic", 12F);
            txt_pilotid.Location = new Point(584, 204);
            txt_pilotid.Name = "txt_pilotid";
            txt_pilotid.Size = new Size(187, 32);
            txt_pilotid.TabIndex = 103;
            txt_pilotid.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.FromArgb(255, 228, 236);
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
            guna2DataGridView1.GridColor = Color.White;
            guna2DataGridView1.Location = new Point(2, 340);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 30;
            guna2DataGridView1.Size = new Size(797, 239);
            guna2DataGridView1.TabIndex = 102;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(255, 228, 236);
            guna2DataGridView1.ThemeStyle.GridColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.PaleTurquoise;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(192, 255, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.Bisque;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // txt_destination
            // 
            txt_destination.Font = new Font("Century Gothic", 12F);
            txt_destination.Location = new Point(181, 157);
            txt_destination.Name = "txt_destination";
            txt_destination.Size = new Size(187, 32);
            txt_destination.TabIndex = 101;
            txt_destination.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_seats
            // 
            txt_seats.Font = new Font("Century Gothic", 12F);
            txt_seats.Location = new Point(584, 157);
            txt_seats.Name = "txt_seats";
            txt_seats.Size = new Size(187, 32);
            txt_seats.TabIndex = 100;
            txt_seats.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_date
            // 
            txt_date.Font = new Font("Century Gothic", 12F);
            txt_date.Location = new Point(181, 200);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(187, 32);
            txt_date.TabIndex = 99;
            txt_date.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 204);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 97;
            label1.Text = "Pilot Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 201);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 96;
            label9.Text = "Date";
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Snow;
            button4.Location = new Point(136, 266);
            button4.Name = "button4";
            button4.Size = new Size(119, 42);
            button4.TabIndex = 95;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(431, 266);
            button3.Name = "button3";
            button3.Size = new Size(119, 40);
            button3.TabIndex = 94;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(573, 266);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 93;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(283, 266);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 92;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_source
            // 
            txt_source.Font = new Font("Century Gothic", 12F);
            txt_source.Location = new Point(584, 112);
            txt_source.Name = "txt_source";
            txt_source.Size = new Size(187, 32);
            txt_source.TabIndex = 90;
            txt_source.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_flightid
            // 
            txt_flightid.Font = new Font("Century Gothic", 12F);
            txt_flightid.Location = new Point(181, 110);
            txt_flightid.Name = "txt_flightid";
            txt_flightid.Size = new Size(187, 32);
            txt_flightid.TabIndex = 89;
            txt_flightid.TextAlign = HorizontalAlignment.Center;
            txt_flightid.Leave += txt_PassId_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(435, 159);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 88;
            label6.Text = "Total Seats";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(434, 113);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 87;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(32, 111);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 86;
            label4.Text = "Flight. Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 158);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 85;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 53);
            label2.Name = "label2";
            label2.Size = new Size(174, 27);
            label2.TabIndex = 84;
            label2.Text = "View Bookings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(239, 20);
            label8.Name = "label8";
            label8.Size = new Size(331, 27);
            label8.TabIndex = 83;
            label8.Text = "AirLine Management System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(760, 9);
            label7.Name = "label7";
            label7.Size = new Size(28, 27);
            label7.TabIndex = 104;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // FlightsTiming
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 580);
            Controls.Add(label7);
            Controls.Add(txt_pilotid);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txt_destination);
            Controls.Add(txt_seats);
            Controls.Add(txt_date);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_source);
            Controls.Add(txt_flightid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightsTiming";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightsTiming";
            Load += FlightsTiming_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_pilotid;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TextBox txt_destination;
        private TextBox txt_seats;
        private TextBox txt_date;
        private Label label1;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txt_source;
        private TextBox txt_flightid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
    }
}