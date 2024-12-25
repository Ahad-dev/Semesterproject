namespace Semesterproject
{
    partial class AirLineServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirLineServices));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txt_id = new TextBox();
            panel1 = new Panel();
            cmb_choice = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            lbl_1 = new Label();
            txt_1 = new TextBox();
            txt_2 = new TextBox();
            lbl_5 = new Label();
            txt_3 = new TextBox();
            lbl_4 = new Label();
            txt_4 = new TextBox();
            lbl_2 = new Label();
            txt_5 = new TextBox();
            lbl_3 = new Label();
            txt_6 = new TextBox();
            lbl_6 = new Label();
            txt_7 = new TextBox();
            lbl_7 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 628);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "SERVICES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 63);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter ID";
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.Control;
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_id.Location = new Point(428, 95);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(320, 25);
            txt_id.TabIndex = 3;
            txt_id.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(428, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 3);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // cmb_choice
            // 
            cmb_choice.BackColor = SystemColors.Control;
            cmb_choice.FlatStyle = FlatStyle.Flat;
            cmb_choice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_choice.FormattingEnabled = true;
            cmb_choice.Items.AddRange(new object[] { "View Flight", "View Passenger", "View Booking" });
            cmb_choice.Location = new Point(428, 170);
            cmb_choice.Name = "cmb_choice";
            cmb_choice.Size = new Size(320, 31);
            cmb_choice.TabIndex = 5;
            cmb_choice.SelectedIndexChanged += cmb_choice_SelectedIndexChanged;
            cmb_choice.Leave += cmb_choice_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(428, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 3);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 141);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 5;
            label3.Text = "Select Service";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_1.Location = new Point(425, 292);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(71, 23);
            lbl_1.TabIndex = 8;
            lbl_1.Text = "Name";
            lbl_1.Click += label4_Click;
            // 
            // txt_1
            // 
            txt_1.BackColor = SystemColors.Control;
            txt_1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_1.Location = new Point(571, 288);
            txt_1.Name = "txt_1";
            txt_1.Size = new Size(177, 32);
            txt_1.TabIndex = 9;
            // 
            // txt_2
            // 
            txt_2.BackColor = SystemColors.Control;
            txt_2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_2.Location = new Point(571, 332);
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(177, 32);
            txt_2.TabIndex = 11;
            // 
            // lbl_5
            // 
            lbl_5.AutoSize = true;
            lbl_5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_5.Location = new Point(425, 467);
            lbl_5.Name = "lbl_5";
            lbl_5.Size = new Size(88, 23);
            lbl_5.TabIndex = 10;
            lbl_5.Text = "Address";
            // 
            // txt_3
            // 
            txt_3.BackColor = SystemColors.Control;
            txt_3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_3.Location = new Point(571, 375);
            txt_3.Name = "txt_3";
            txt_3.Size = new Size(177, 32);
            txt_3.TabIndex = 13;
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_4.Location = new Point(425, 423);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(114, 23);
            lbl_4.TabIndex = 12;
            lbl_4.Text = "Nationality";
            // 
            // txt_4
            // 
            txt_4.BackColor = SystemColors.Control;
            txt_4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_4.Location = new Point(571, 419);
            txt_4.Name = "txt_4";
            txt_4.Size = new Size(177, 32);
            txt_4.TabIndex = 15;
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_2.Location = new Point(425, 335);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(62, 23);
            lbl_2.TabIndex = 14;
            lbl_2.Text = "CNIC";
            // 
            // txt_5
            // 
            txt_5.BackColor = SystemColors.Control;
            txt_5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_5.Location = new Point(571, 462);
            txt_5.Name = "txt_5";
            txt_5.Size = new Size(177, 32);
            txt_5.TabIndex = 17;
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_3.Location = new Point(426, 378);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(85, 23);
            lbl_3.TabIndex = 16;
            lbl_3.Text = "Gender";
            // 
            // txt_6
            // 
            txt_6.BackColor = SystemColors.Control;
            txt_6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_6.Location = new Point(571, 505);
            txt_6.Name = "txt_6";
            txt_6.Size = new Size(177, 32);
            txt_6.TabIndex = 19;
            // 
            // lbl_6
            // 
            lbl_6.AutoSize = true;
            lbl_6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_6.Location = new Point(425, 507);
            lbl_6.Name = "lbl_6";
            lbl_6.Size = new Size(111, 23);
            lbl_6.TabIndex = 18;
            lbl_6.Text = "Phone No.";
            // 
            // txt_7
            // 
            txt_7.BackColor = SystemColors.Control;
            txt_7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_7.Location = new Point(571, 550);
            txt_7.Name = "txt_7";
            txt_7.Size = new Size(177, 32);
            txt_7.TabIndex = 21;
            // 
            // lbl_7
            // 
            lbl_7.AutoSize = true;
            lbl_7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_7.Location = new Point(423, 554);
            lbl_7.Name = "lbl_7";
            lbl_7.Size = new Size(92, 23);
            lbl_7.TabIndex = 20;
            lbl_7.Text = "Passport";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(443, 239);
            label12.Name = "label12";
            label12.Size = new Size(295, 27);
            label12.TabIndex = 24;
            label12.Text = "REQUESTED iNFORMATION";
            // 
            // AirLineServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(label12);
            Controls.Add(txt_7);
            Controls.Add(lbl_7);
            Controls.Add(txt_6);
            Controls.Add(lbl_6);
            Controls.Add(txt_5);
            Controls.Add(lbl_3);
            Controls.Add(txt_4);
            Controls.Add(lbl_2);
            Controls.Add(txt_3);
            Controls.Add(lbl_4);
            Controls.Add(txt_2);
            Controls.Add(lbl_5);
            Controls.Add(txt_1);
            Controls.Add(lbl_1);
            Controls.Add(panel2);
            Controls.Add(cmb_choice);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AirLineServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AirLineServices";
            Load += AirLineServices_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txt_id;
        private Panel panel1;
        private ComboBox cmb_choice;
        private Panel panel2;
        private Label label3;
        private Label lbl_1;
        private TextBox txt_1;
        private TextBox txt_2;
        private Label lbl_5;
        private TextBox txt_3;
        private Label lbl_4;
        private TextBox txt_4;
        private Label lbl_2;
        private TextBox txt_5;
        private Label lbl_3;
        private TextBox txt_6;
        private Label lbl_6;
        private TextBox txt_7;
        private Label lbl_7;
        private Label label12;
    }
}