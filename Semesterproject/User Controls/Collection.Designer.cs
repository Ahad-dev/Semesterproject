namespace Semesterproject.User_Controls
{
    partial class Collection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txt_content = new Guna.UI2.WinForms.Guna2TextBox();
            txt_date = new TextBox();
            btn_update = new Button();
            btn_reset = new Button();
            btn_back = new Button();
            btn_delete = new Button();
            lbl_date = new Label();
            txt_type = new TextBox();
            txt_Id = new TextBox();
            lbl_type = new Label();
            lbl_reportId = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_content
            // 
            txt_content.BorderColor = Color.Black;
            txt_content.CustomizableEdges = customizableEdges1;
            txt_content.DefaultText = "";
            txt_content.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_content.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_content.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_content.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_content.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_content.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_content.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_content.Location = new Point(169, 85);
            txt_content.Margin = new Padding(4, 4, 4, 4);
            txt_content.Name = "txt_content";
            txt_content.PasswordChar = '\0';
            txt_content.PlaceholderText = "";
            txt_content.SelectedText = "";
            txt_content.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_content.Size = new Size(588, 63);
            txt_content.TabIndex = 118;
            // 
            // txt_date
            // 
            txt_date.Font = new Font("Century Gothic", 12F);
            txt_date.Location = new Point(317, 166);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(187, 32);
            txt_date.TabIndex = 117;
            txt_date.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(70, 33, 26);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.Snow;
            btn_update.Location = new Point(127, 229);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 42);
            btn_update.TabIndex = 116;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.FromArgb(70, 33, 26);
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = Color.Snow;
            btn_reset.Location = new Point(422, 229);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(119, 40);
            btn_reset.TabIndex = 115;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(70, 33, 26);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Snow;
            btn_back.Location = new Point(564, 229);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(119, 42);
            btn_back.TabIndex = 114;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(70, 33, 26);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.Snow;
            btn_delete.Location = new Point(274, 229);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 42);
            btn_delete.TabIndex = 113;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_date.Location = new Point(174, 169);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(130, 23);
            lbl_date.TabIndex = 112;
            lbl_date.Text = "Report Date";
            // 
            // txt_type
            // 
            txt_type.Font = new Font("Century Gothic", 12F);
            txt_type.Location = new Point(570, 29);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(187, 32);
            txt_type.TabIndex = 111;
            txt_type.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Id
            // 
            txt_Id.Font = new Font("Century Gothic", 12F);
            txt_Id.Location = new Point(169, 29);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(187, 32);
            txt_Id.TabIndex = 110;
            txt_Id.TextAlign = HorizontalAlignment.Center;
            txt_Id.Leave += txt_Id_Leave;
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_type.Location = new Point(422, 32);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(127, 23);
            lbl_type.TabIndex = 109;
            lbl_type.Text = "Report Type";
            // 
            // lbl_reportId
            // 
            lbl_reportId.AutoSize = true;
            lbl_reportId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_reportId.ForeColor = SystemColors.ActiveCaptionText;
            lbl_reportId.Location = new Point(34, 31);
            lbl_reportId.Name = "lbl_reportId";
            lbl_reportId.Size = new Size(101, 23);
            lbl_reportId.TabIndex = 108;
            lbl_reportId.Text = "Report ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 85);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 107;
            label3.Text = "Content";
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 211, 178);
            Controls.Add(txt_content);
            Controls.Add(txt_date);
            Controls.Add(btn_update);
            Controls.Add(btn_reset);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(lbl_date);
            Controls.Add(txt_type);
            Controls.Add(txt_Id);
            Controls.Add(lbl_type);
            Controls.Add(lbl_reportId);
            Controls.Add(label3);
            Name = "Collection";
            Size = new Size(792, 296);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_content;
        private TextBox txt_date;
        private Button btn_update;
        private Button btn_reset;
        private Button btn_back;
        private Button btn_delete;
        private Label lbl_date;
        private TextBox txt_type;
        private TextBox txt_Id;
        private Label lbl_type;
        private Label lbl_reportId;
        private Label label3;
    }
}
