namespace Semesterproject
{
    partial class Reports
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lbl_exit = new Label();
            panel2 = new Panel();
            lbl_header = new Label();
            label1 = new Label();
            btn_view = new Guna.UI2.WinForms.Guna2Button();
            btn_generate = new Guna.UI2.WinForms.Guna2Button();
            txt_date = new TextBox();
            txt_reportID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            cmb_type = new ComboBox();
            txt_content = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 71, 58);
            panel1.Controls.Add(lbl_exit);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 24);
            panel1.TabIndex = 0;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.BackColor = Color.White;
            lbl_exit.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_exit.ForeColor = SystemColors.ActiveCaptionText;
            lbl_exit.Location = new Point(773, -1);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(28, 27);
            lbl_exit.TabIndex = 71;
            lbl_exit.Text = "X";
            lbl_exit.Click += lbl_exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 71, 58);
            panel2.Location = new Point(0, 607);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 20);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_header
            // 
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Underline);
            lbl_header.ForeColor = Color.FromArgb(49, 71, 58);
            lbl_header.Location = new Point(142, 53);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(544, 40);
            lbl_header.TabIndex = 2;
            lbl_header.Text = "Report Management SubSystem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.FromArgb(49, 71, 58);
            label1.Location = new Point(253, 93);
            label1.Name = "label1";
            label1.Size = new Size(307, 40);
            label1.TabIndex = 3;
            label1.Text = "Generate Reports";
            label1.Click += label1_Click;
            // 
            // btn_view
            // 
            btn_view.CustomizableEdges = customizableEdges1;
            btn_view.DisabledState.BorderColor = Color.DarkGray;
            btn_view.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_view.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_view.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_view.FillColor = Color.FromArgb(49, 71, 58);
            btn_view.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_view.ForeColor = Color.White;
            btn_view.Location = new Point(216, 487);
            btn_view.Name = "btn_view";
            btn_view.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_view.Size = new Size(189, 54);
            btn_view.TabIndex = 4;
            btn_view.Text = "View Report";
            btn_view.Click += guna2Button1_Click;
            // 
            // btn_generate
            // 
            btn_generate.CustomizableEdges = customizableEdges3;
            btn_generate.DisabledState.BorderColor = Color.DarkGray;
            btn_generate.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_generate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_generate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_generate.FillColor = Color.FromArgb(49, 71, 58);
            btn_generate.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_generate.ForeColor = Color.White;
            btn_generate.Location = new Point(415, 487);
            btn_generate.Name = "btn_generate";
            btn_generate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_generate.Size = new Size(189, 54);
            btn_generate.TabIndex = 5;
            btn_generate.Text = "Generate Report";
            btn_generate.Click += btn_generate_Click;
            // 
            // txt_date
            // 
            txt_date.Font = new Font("Century Gothic", 13.8F);
            txt_date.Location = new Point(368, 387);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(230, 36);
            txt_date.TabIndex = 66;
            txt_date.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_reportID
            // 
            txt_reportID.Font = new Font("Century Gothic", 13.8F);
            txt_reportID.Location = new Point(367, 231);
            txt_reportID.Name = "txt_reportID";
            txt_reportID.Size = new Size(230, 36);
            txt_reportID.TabIndex = 64;
            txt_reportID.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(219, 392);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 63;
            label6.Text = "Curr. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(219, 339);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 62;
            label5.Text = "Content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(218, 234);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 61;
            label4.Text = "Report ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 287);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 60;
            label3.Text = "Report Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.report;
            pictureBox1.Location = new Point(623, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // cmb_type
            // 
            cmb_type.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_type.FormattingEnabled = true;
            cmb_type.Items.AddRange(new object[] { "FlightsReport", "PassengersReports", "TicketsReports", "CancellationReports" });
            cmb_type.Location = new Point(367, 285);
            cmb_type.Name = "cmb_type";
            cmb_type.Size = new Size(230, 35);
            cmb_type.TabIndex = 69;
            // 
            // txt_content
            // 
            txt_content.BackColor = SystemColors.Window;
            txt_content.BorderColor = Color.Black;
            txt_content.CustomizableEdges = customizableEdges5;
            txt_content.DefaultText = "";
            txt_content.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_content.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_content.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_content.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_content.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_content.Font = new Font("Segoe UI", 9F);
            txt_content.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_content.Location = new Point(367, 336);
            txt_content.Margin = new Padding(3, 4, 3, 4);
            txt_content.Name = "txt_content";
            txt_content.PasswordChar = '\0';
            txt_content.PlaceholderText = "";
            txt_content.SelectedText = "";
            txt_content.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_content.Size = new Size(230, 36);
            txt_content.TabIndex = 70;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 246, 246);
            ClientSize = new Size(800, 627);
            Controls.Add(txt_content);
            Controls.Add(cmb_type);
            Controls.Add(pictureBox1);
            Controls.Add(txt_date);
            Controls.Add(txt_reportID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_generate);
            Controls.Add(btn_view);
            Controls.Add(label1);
            Controls.Add(lbl_header);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbl_header;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_view;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private TextBox txt_date;
        private TextBox txt_reportID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox cmb_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_content;
        private Label lbl_exit;
    }
}