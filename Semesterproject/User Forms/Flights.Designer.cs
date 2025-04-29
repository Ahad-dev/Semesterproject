namespace Semesterproject
{
    partial class lbl_flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbl_flights));
            label1 = new Label();
            label2 = new Label();
            btn_Record = new Button();
            pictureBox1 = new PictureBox();
            txt_FlCode = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            cmx_source = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            cmx_destination = new TextBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            txt_seats = new TextBox();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            lbl_exit = new Label();
            label3 = new Label();
            lbl_view = new Label();
            lbl_back = new Label();
            txt_pilot = new TextBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(331, 27);
            label1.TabIndex = 3;
            label1.Text = "AirLine Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(111, 85);
            label2.Name = "label2";
            label2.Size = new Size(167, 27);
            label2.TabIndex = 4;
            label2.Text = "Record Flights";
            // 
            // btn_Record
            // 
            btn_Record.BackColor = Color.DarkSlateBlue;
            btn_Record.FlatStyle = FlatStyle.Flat;
            btn_Record.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Record.ForeColor = SystemColors.ButtonFace;
            btn_Record.Location = new Point(77, 576);
            btn_Record.Name = "btn_Record";
            btn_Record.Size = new Size(249, 45);
            btn_Record.TabIndex = 13;
            btn_Record.Text = "Record";
            btn_Record.UseVisualStyleBackColor = false;
            btn_Record.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_matthardy_1928067;
            pictureBox1.Location = new Point(401, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txt_FlCode
            // 
            txt_FlCode.AccessibleRole = AccessibleRole.TitleBar;
            txt_FlCode.BackColor = Color.Lavender;
            txt_FlCode.BorderStyle = BorderStyle.None;
            txt_FlCode.Font = new Font("Century Gothic", 13.8F);
            txt_FlCode.ForeColor = Color.Indigo;
            txt_FlCode.Location = new Point(115, 155);
            txt_FlCode.Multiline = true;
            txt_FlCode.Name = "txt_FlCode";
            txt_FlCode.Size = new Size(198, 34);
            txt_FlCode.TabIndex = 94;
            txt_FlCode.Text = "Flight Code";
            txt_FlCode.TextAlign = HorizontalAlignment.Center;
            txt_FlCode.Enter += txt_FlCode_Enter;
            txt_FlCode.Leave += txt_FlCode_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(77, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 93;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.ForeColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(77, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 92;
            // 
            // cmx_source
            // 
            cmx_source.AccessibleRole = AccessibleRole.TitleBar;
            cmx_source.BackColor = Color.Lavender;
            cmx_source.BorderStyle = BorderStyle.None;
            cmx_source.Font = new Font("Century Gothic", 13.8F);
            cmx_source.ForeColor = Color.Indigo;
            cmx_source.Location = new Point(115, 232);
            cmx_source.Multiline = true;
            cmx_source.Name = "cmx_source";
            cmx_source.Size = new Size(198, 34);
            cmx_source.TabIndex = 97;
            cmx_source.Text = "Source";
            cmx_source.TextAlign = HorizontalAlignment.Center;
            cmx_source.Enter += cmx_source_Enter;
            cmx_source.Leave += cmx_source_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 96;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.ForeColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(77, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 2);
            panel2.TabIndex = 95;
            // 
            // cmx_destination
            // 
            cmx_destination.AccessibleRole = AccessibleRole.TitleBar;
            cmx_destination.BackColor = Color.Lavender;
            cmx_destination.BorderStyle = BorderStyle.None;
            cmx_destination.Font = new Font("Century Gothic", 13.8F);
            cmx_destination.ForeColor = Color.Indigo;
            cmx_destination.Location = new Point(113, 304);
            cmx_destination.Multiline = true;
            cmx_destination.Name = "cmx_destination";
            cmx_destination.Size = new Size(198, 34);
            cmx_destination.TabIndex = 100;
            cmx_destination.Text = "Destination";
            cmx_destination.TextAlign = HorizontalAlignment.Center;
            cmx_destination.Enter += cmx_destination_Enter;
            cmx_destination.Leave += cmx_destination_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(77, 304);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 99;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.ForeColor = SystemColors.MenuHighlight;
            panel3.Location = new Point(79, 342);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 2);
            panel3.TabIndex = 98;
            panel3.Paint += panel3_Paint;
            // 
            // txt_seats
            // 
            txt_seats.AccessibleRole = AccessibleRole.TitleBar;
            txt_seats.BackColor = Color.Lavender;
            txt_seats.BorderStyle = BorderStyle.None;
            txt_seats.Font = new Font("Century Gothic", 13.8F);
            txt_seats.ForeColor = Color.Indigo;
            txt_seats.Location = new Point(113, 375);
            txt_seats.Multiline = true;
            txt_seats.Name = "txt_seats";
            txt_seats.Size = new Size(198, 34);
            txt_seats.TabIndex = 103;
            txt_seats.Text = "Total Seats";
            txt_seats.TextAlign = HorizontalAlignment.Center;
            txt_seats.Enter += txt_seats_Enter;
            txt_seats.Leave += txt_seats_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(77, 375);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 102;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.ForeColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(77, 414);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 2);
            panel4.TabIndex = 101;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.BackColor = Color.Black;
            lbl_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exit.ForeColor = SystemColors.ButtonHighlight;
            lbl_exit.Location = new Point(741, -3);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(44, 28);
            lbl_exit.TabIndex = 108;
            lbl_exit.Text = "  X  ";
            lbl_exit.Click += lbl_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Underline);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(234, 491);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 109;
            label3.Text = "Clear Fields";
            label3.Click += label3_Click;
            // 
            // lbl_view
            // 
            lbl_view.AutoSize = true;
            lbl_view.Font = new Font("Century Gothic", 9F, FontStyle.Underline);
            lbl_view.ForeColor = SystemColors.ActiveCaptionText;
            lbl_view.Location = new Point(238, 624);
            lbl_view.Name = "lbl_view";
            lbl_view.Size = new Size(86, 20);
            lbl_view.TabIndex = 110;
            lbl_view.Text = "View Now";
            lbl_view.Click += lbl_view_Click;
            // 
            // lbl_back
            // 
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Century Gothic", 9F, FontStyle.Underline);
            lbl_back.ForeColor = SystemColors.ActiveCaptionText;
            lbl_back.Location = new Point(81, 624);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(52, 20);
            lbl_back.TabIndex = 111;
            lbl_back.Text = "Home";
            lbl_back.Click += lbl_back_Click;
            // 
            // txt_pilot
            // 
            txt_pilot.AccessibleRole = AccessibleRole.TitleBar;
            txt_pilot.BackColor = Color.Lavender;
            txt_pilot.BorderStyle = BorderStyle.None;
            txt_pilot.Font = new Font("Century Gothic", 13.8F);
            txt_pilot.ForeColor = Color.Indigo;
            txt_pilot.Location = new Point(115, 445);
            txt_pilot.Multiline = true;
            txt_pilot.Name = "txt_pilot";
            txt_pilot.Size = new Size(198, 34);
            txt_pilot.TabIndex = 114;
            txt_pilot.Text = "PilotId";
            txt_pilot.TextAlign = HorizontalAlignment.Center;
            txt_pilot.Leave += txt_pilot_Leave;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.ForeColor = SystemColors.MenuHighlight;
            panel6.Location = new Point(79, 484);
            panel6.Name = "panel6";
            panel6.Size = new Size(246, 2);
            panel6.TabIndex = 112;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(79, 445);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 115;
            pictureBox6.TabStop = false;
            // 
            // lbl_flights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(782, 688);
            Controls.Add(pictureBox6);
            Controls.Add(txt_pilot);
            Controls.Add(panel6);
            Controls.Add(lbl_back);
            Controls.Add(lbl_view);
            Controls.Add(label3);
            Controls.Add(lbl_exit);
            Controls.Add(txt_seats);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(cmx_destination);
            Controls.Add(pictureBox4);
            Controls.Add(panel3);
            Controls.Add(cmx_source);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(txt_FlCode);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Record);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "lbl_flights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flights";
            Load += Flights_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Record;
        private PictureBox pictureBox1;
        private TextBox txt_FlCode;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox cmx_source;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox cmx_destination;
        private PictureBox pictureBox4;
        private Panel panel3;
        private TextBox txt_seats;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label lbl_exit;
        private Label label3;
        private Label lbl_view;
        private Label lbl_back;
        private TextBox txt_pilot;
        private Panel panel6;
        private PictureBox pictureBox6;
    }
}