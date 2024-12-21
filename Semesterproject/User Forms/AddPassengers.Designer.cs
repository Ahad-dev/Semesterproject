namespace Semesterproject
{
    partial class AddPassengers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassengers));
            label2 = new Label();
            label1 = new Label();
            btn_record = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lbl_Clear = new Label();
            txt_phone = new TextBox();
            txt_nationality = new TextBox();
            txt_Passport = new TextBox();
            txt_passGender = new TextBox();
            txt_passAddress = new TextBox();
            txt_passName = new TextBox();
            txt_passengerid = new TextBox();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox9 = new PictureBox();
            llb_view = new Label();
            lbl_home = new Label();
            panel9 = new Panel();
            pictureBox8 = new PictureBox();
            txt_CNIC = new TextBox();
            pictureBox10 = new PictureBox();
            lbl_count = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(511, 61);
            label2.Name = "label2";
            label2.Size = new Size(222, 27);
            label2.TabIndex = 29;
            label2.Text = "Record Passengers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 34);
            label1.Name = "label1";
            label1.Size = new Size(331, 27);
            label1.TabIndex = 28;
            label1.Text = "AirLine Management System";
            // 
            // btn_record
            // 
            btn_record.BackColor = Color.FromArgb(13, 17, 55);
            btn_record.Cursor = Cursors.AppStarting;
            btn_record.FlatStyle = FlatStyle.Flat;
            btn_record.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_record.ForeColor = SystemColors.Info;
            btn_record.Location = new Point(489, 630);
            btn_record.Name = "btn_record";
            btn_record.Size = new Size(252, 42);
            btn_record.TabIndex = 38;
            btn_record.Text = "Record";
            btn_record.UseVisualStyleBackColor = false;
            btn_record.Click += btn_record_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.pexels_timmossholder_15939942;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 724);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Cornsilk;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(13, 17, 55);
            label10.Location = new Point(796, 4);
            label10.Name = "label10";
            label10.Size = new Size(34, 34);
            label10.TabIndex = 41;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // lbl_Clear
            // 
            lbl_Clear.AutoSize = true;
            lbl_Clear.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Clear.Location = new Point(646, 571);
            lbl_Clear.Name = "lbl_Clear";
            lbl_Clear.Size = new Size(94, 20);
            lbl_Clear.TabIndex = 99;
            lbl_Clear.Text = "Clear Fields";
            lbl_Clear.Click += lbl_Clear_Click;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.Cornsilk;
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.Font = new Font("Century Gothic", 13.8F);
            txt_phone.Location = new Point(524, 522);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(198, 34);
            txt_phone.TabIndex = 97;
            // 
            // txt_nationality
            // 
            txt_nationality.BackColor = Color.Cornsilk;
            txt_nationality.BorderStyle = BorderStyle.None;
            txt_nationality.Font = new Font("Century Gothic", 13.8F);
            txt_nationality.Location = new Point(524, 471);
            txt_nationality.Multiline = true;
            txt_nationality.Name = "txt_nationality";
            txt_nationality.Size = new Size(198, 34);
            txt_nationality.TabIndex = 96;
            // 
            // txt_Passport
            // 
            txt_Passport.BackColor = Color.Cornsilk;
            txt_Passport.BorderStyle = BorderStyle.None;
            txt_Passport.Font = new Font("Century Gothic", 13.8F);
            txt_Passport.Location = new Point(524, 420);
            txt_Passport.Multiline = true;
            txt_Passport.Name = "txt_Passport";
            txt_Passport.Size = new Size(198, 34);
            txt_Passport.TabIndex = 95;
            // 
            // txt_passGender
            // 
            txt_passGender.BackColor = Color.Cornsilk;
            txt_passGender.BorderStyle = BorderStyle.None;
            txt_passGender.Font = new Font("Century Gothic", 13.8F);
            txt_passGender.Location = new Point(524, 370);
            txt_passGender.Multiline = true;
            txt_passGender.Name = "txt_passGender";
            txt_passGender.Size = new Size(198, 34);
            txt_passGender.TabIndex = 94;
            // 
            // txt_passAddress
            // 
            txt_passAddress.BackColor = Color.Cornsilk;
            txt_passAddress.BorderStyle = BorderStyle.None;
            txt_passAddress.Font = new Font("Century Gothic", 13.8F);
            txt_passAddress.Location = new Point(524, 324);
            txt_passAddress.Multiline = true;
            txt_passAddress.Name = "txt_passAddress";
            txt_passAddress.Size = new Size(198, 34);
            txt_passAddress.TabIndex = 93;
            // 
            // txt_passName
            // 
            txt_passName.BackColor = Color.Cornsilk;
            txt_passName.BorderStyle = BorderStyle.None;
            txt_passName.Font = new Font("Century Gothic", 13.8F);
            txt_passName.Location = new Point(524, 274);
            txt_passName.Multiline = true;
            txt_passName.Name = "txt_passName";
            txt_passName.Size = new Size(198, 34);
            txt_passName.TabIndex = 92;
            // 
            // txt_passengerid
            // 
            txt_passengerid.BackColor = Color.Cornsilk;
            txt_passengerid.BorderStyle = BorderStyle.None;
            txt_passengerid.Font = new Font("Century Gothic", 13.8F);
            txt_passengerid.Location = new Point(524, 222);
            txt_passengerid.Multiline = true;
            txt_passengerid.Name = "txt_passengerid";
            txt_passengerid.Size = new Size(198, 34);
            txt_passengerid.TabIndex = 91;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.ForeColor = SystemColors.MenuHighlight;
            panel7.Location = new Point(488, 559);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 3);
            panel7.TabIndex = 84;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(488, 523);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 83;
            pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.ForeColor = SystemColors.MenuHighlight;
            panel6.Location = new Point(488, 508);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 3);
            panel6.TabIndex = 85;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(488, 472);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 82;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.ForeColor = SystemColors.MenuHighlight;
            panel5.Location = new Point(488, 457);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 3);
            panel5.TabIndex = 86;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(488, 421);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 81;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.ForeColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(488, 407);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 3);
            panel4.TabIndex = 87;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(489, 275);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 80;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.ForeColor = SystemColors.MenuHighlight;
            panel3.Location = new Point(488, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 3);
            panel3.TabIndex = 88;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(488, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 79;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.ForeColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(488, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 3);
            panel2.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.ForeColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(488, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 3);
            panel1.TabIndex = 76;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(489, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 100;
            pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(488, 371);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 101;
            pictureBox9.TabStop = false;
            // 
            // llb_view
            // 
            llb_view.AutoSize = true;
            llb_view.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            llb_view.Location = new Point(654, 677);
            llb_view.Name = "llb_view";
            llb_view.Size = new Size(85, 20);
            llb_view.TabIndex = 102;
            llb_view.Text = "View Now";
            llb_view.Click += llb_view_Click;
            // 
            // lbl_home
            // 
            lbl_home.AutoSize = true;
            lbl_home.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_home.Location = new Point(489, 676);
            lbl_home.Name = "lbl_home";
            lbl_home.Size = new Size(53, 20);
            lbl_home.TabIndex = 103;
            lbl_home.Text = "Home";
            lbl_home.Click += lbl_home_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Controls.Add(pictureBox8);
            panel9.Location = new Point(483, 209);
            panel9.Name = "panel9";
            panel9.Size = new Size(251, 3);
            panel9.TabIndex = 133;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(135, -13);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 80;
            pictureBox8.TabStop = false;
            // 
            // txt_CNIC
            // 
            txt_CNIC.BackColor = Color.Cornsilk;
            txt_CNIC.BorderStyle = BorderStyle.None;
            txt_CNIC.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CNIC.ForeColor = Color.Black;
            txt_CNIC.Location = new Point(527, 176);
            txt_CNIC.Name = "txt_CNIC";
            txt_CNIC.Size = new Size(212, 29);
            txt_CNIC.TabIndex = 132;
            txt_CNIC.Leave += txt_CNIC_Leave;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(488, 173);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 131;
            pictureBox10.TabStop = false;
            // 
            // lbl_count
            // 
            lbl_count.AutoSize = true;
            lbl_count.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_count.Location = new Point(662, 111);
            lbl_count.Name = "lbl_count";
            lbl_count.Size = new Size(32, 23);
            lbl_count.TabIndex = 134;
            lbl_count.Text = "23";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(516, 111);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 135;
            label4.Text = "UnApproved :";
            // 
            // AddPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(844, 724);
            Controls.Add(label4);
            Controls.Add(lbl_count);
            Controls.Add(panel9);
            Controls.Add(txt_CNIC);
            Controls.Add(pictureBox10);
            Controls.Add(lbl_home);
            Controls.Add(llb_view);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_Clear);
            Controls.Add(txt_phone);
            Controls.Add(txt_nationality);
            Controls.Add(txt_Passport);
            Controls.Add(txt_passGender);
            Controls.Add(txt_passAddress);
            Controls.Add(txt_passName);
            Controls.Add(txt_passengerid);
            Controls.Add(panel7);
            Controls.Add(pictureBox7);
            Controls.Add(panel6);
            Controls.Add(pictureBox6);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(btn_record);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassengers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPassengers";
            Load += AddPassengers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btn_record;
        private PictureBox pictureBox1;
        private Label label10;
        private Label lbl_Clear;
        private TextBox txt_phone;
        private TextBox txt_nationality;
        private TextBox txt_Passport;
        private TextBox txt_passGender;
        private TextBox txt_passAddress;
        private TextBox txt_passName;
        private TextBox txt_passengerid;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox9;
        private Label llb_view;
        private Label lbl_home;
        private Panel panel9;
        private PictureBox pictureBox8;
        private TextBox txt_CNIC;
        private PictureBox pictureBox10;
        private Label lbl_count;
        private Label label4;
    }
}