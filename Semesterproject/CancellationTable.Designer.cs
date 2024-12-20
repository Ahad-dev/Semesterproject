namespace Semesterproject
{
    partial class CancellationTable
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
            lbl_cancel = new Label();
            label8 = new Label();
            lbl_canelid = new Label();
            lbl_ticketid = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_record = new Button();
            btn_back = new Button();
            btn_reset = new Button();
            panel3 = new Panel();
            lbl_exit = new Label();
            panel5 = new Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            txt_flightcode = new TextBox();
            txt_Cancelid = new TextBox();
            txt_ticketid = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_cancel
            // 
            lbl_cancel.AutoSize = true;
            lbl_cancel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            lbl_cancel.Location = new Point(289, 68);
            lbl_cancel.Name = "lbl_cancel";
            lbl_cancel.Size = new Size(177, 27);
            lbl_cancel.TabIndex = 89;
            lbl_cancel.Text = "Cancel Tickets";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label8.Location = new Point(225, 41);
            label8.Name = "label8";
            label8.Size = new Size(331, 27);
            label8.TabIndex = 88;
            label8.Text = "AirLine Management System";
            // 
            // lbl_canelid
            // 
            lbl_canelid.AutoSize = true;
            lbl_canelid.Font = new Font("Century Gothic", 12F);
            lbl_canelid.Location = new Point(44, 136);
            lbl_canelid.Name = "lbl_canelid";
            lbl_canelid.Size = new Size(103, 23);
            lbl_canelid.TabIndex = 100;
            lbl_canelid.Text = "CancelID";
            // 
            // lbl_ticketid
            // 
            lbl_ticketid.AutoSize = true;
            lbl_ticketid.Font = new Font("Century Gothic", 12F);
            lbl_ticketid.Location = new Point(408, 139);
            lbl_ticketid.Name = "lbl_ticketid";
            lbl_ticketid.Size = new Size(84, 23);
            lbl_ticketid.TabIndex = 103;
            lbl_ticketid.Text = "TicketID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(44, 197);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 104;
            label1.Text = "FlightCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(410, 198);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 105;
            label2.Text = "Date";
            // 
            // btn_record
            // 
            btn_record.BackColor = Color.SaddleBrown;
            btn_record.Cursor = Cursors.AppStarting;
            btn_record.FlatStyle = FlatStyle.Flat;
            btn_record.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_record.ForeColor = Color.Linen;
            btn_record.Location = new Point(191, 265);
            btn_record.Name = "btn_record";
            btn_record.Size = new Size(119, 41);
            btn_record.TabIndex = 108;
            btn_record.Text = "Cancel";
            btn_record.UseVisualStyleBackColor = false;
            btn_record.Click += btn_record_Click_1;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SaddleBrown;
            btn_back.Cursor = Cursors.AppStarting;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Linen;
            btn_back.Location = new Point(333, 266);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(119, 41);
            btn_back.TabIndex = 109;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.SaddleBrown;
            btn_reset.Cursor = Cursors.AppStarting;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = Color.Linen;
            btn_reset.Location = new Point(476, 265);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(119, 41);
            btn_reset.TabIndex = 110;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Controls.Add(lbl_exit);
            panel3.Location = new Point(-2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 24);
            panel3.TabIndex = 111;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.BackColor = Color.SaddleBrown;
            lbl_exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_exit.ForeColor = SystemColors.ButtonHighlight;
            lbl_exit.Location = new Point(772, -1);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(24, 23);
            lbl_exit.TabIndex = 114;
            lbl_exit.Text = "X";
            lbl_exit.Click += label3_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SaddleBrown;
            panel5.Location = new Point(0, 595);
            panel5.Name = "panel5";
            panel5.Size = new Size(850, 22);
            panel5.TabIndex = 115;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            guna2DataGridView1.Location = new Point(-1, 340);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(810, 253);
            guna2DataGridView1.TabIndex = 116;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.DeepPink;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // txt_flightcode
            // 
            txt_flightcode.Font = new Font("Century Gothic", 12F);
            txt_flightcode.Location = new Point(166, 194);
            txt_flightcode.Name = "txt_flightcode";
            txt_flightcode.Size = new Size(187, 32);
            txt_flightcode.TabIndex = 117;
            txt_flightcode.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Cancelid
            // 
            txt_Cancelid.Font = new Font("Century Gothic", 12F);
            txt_Cancelid.Location = new Point(166, 133);
            txt_Cancelid.Name = "txt_Cancelid";
            txt_Cancelid.Size = new Size(187, 32);
            txt_Cancelid.TabIndex = 118;
            txt_Cancelid.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ticketid
            // 
            txt_ticketid.Font = new Font("Century Gothic", 12F);
            txt_ticketid.Location = new Point(504, 131);
            txt_ticketid.Name = "txt_ticketid";
            txt_ticketid.Size = new Size(187, 32);
            txt_ticketid.TabIndex = 119;
            txt_ticketid.TextAlign = HorizontalAlignment.Center;
            txt_ticketid.Enter += txt_ticketid_Enter;
            txt_ticketid.Leave += txt_ticketid_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(504, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 32);
            dateTimePicker1.TabIndex = 120;
            // 
            // CancellationTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(801, 617);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_ticketid);
            Controls.Add(txt_Cancelid);
            Controls.Add(txt_flightcode);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(btn_reset);
            Controls.Add(btn_back);
            Controls.Add(btn_record);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_ticketid);
            Controls.Add(lbl_canelid);
            Controls.Add(lbl_cancel);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancellationTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTable";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_cancel;
        private Label label8;
        private Label lbl_canelid;
        private Label lbl_ticketid;
        private Label label1;
        private Label label2;
        private Button btn_record;
        private Button btn_back;
        private Button btn_reset;
        private Panel panel3;
        private Label lbl_exit;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TextBox txt_flightcode;
        private TextBox txt_Cancelid;
        private TextBox txt_ticketid;
        private DateTimePicker dateTimePicker1;
    }
}