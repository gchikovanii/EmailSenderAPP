using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace EmailSenderApp
{
    public partial class Email : Form
    {
        string emailAddress;
        string password;
        string recipientEmail;
        string senderName;
        string filePath;
        public Email()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            emailAddress = emailTb.Text;
            password = passwordTb.Text;
            recipientEmail = recipientEmailTb.Text;
            senderName = senderNameTb.Text;
            MimeMessage message = new MimeMessage();
            //add sender
            message.From.Add(new MailboxAddress(senderName, emailAddress));
            //add reciver
            message.To.Add(MailboxAddress.Parse($"{recipientEmail}"));
            message.Subject = subjectTb.Text;
            message.Body = new TextPart("plain")
            {
                Text = bodyRTB.Text
            };
            var builder = new BodyBuilder();
            builder.Attachments.Add(filePath);
            message.Body = builder.ToMessageBody();
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(emailAddress, password);
                client.Send(message);

                MessageBox.Show("Message Sent Succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Upload your file:",
                Filter = "All files (*.*)|*.*",
                DefaultExt = "*.xml"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                attachmentTb.Text = filePath;
            }
        }
    }
}
