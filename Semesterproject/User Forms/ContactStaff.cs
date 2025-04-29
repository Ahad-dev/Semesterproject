using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterproject.User_Forms
{
    public partial class ContactStaff : Form
    {
        public ContactStaff()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email.Text); // Your Gmail
            mail.To.Add("ahmadraza.aslm234@gmail.com");                // Receiver's Email
            mail.Subject = title.Text;
            mail.Body = message.Text;

            // Step 2: Setup SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;

            // Step 3: Use your Gmail + App Password
            smtpClient.Credentials = new NetworkCredential("sktfscm21557034@gmail.com", "uxfp ydrk mmqc ygje");

            // Step 4: Send it!
            smtpClient.Send(mail);
            MessageBox.Show("You'll get response soon!!");
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
