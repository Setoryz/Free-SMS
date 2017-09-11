using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Free_SMS
{
    public partial class frmSendSms : Form
    {
        public frmSendSms()
        {
            InitializeComponent();
        }

        private void lblCloseLoginWindow_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblCloseLoginWindow_MouseEnter(object sender, EventArgs e)
        {
            lblCloseLoginWindow.ForeColor = Color.Red;
        }

        private void lblCloseLoginWindow_MouseLeave(object sender, EventArgs e)
        {
            lblCloseLoginWindow.ForeColor = Color.White;
        }

        private void txtRecipient_Enter(object sender, EventArgs e)
        {
            if (txtRecipient.Text == "recipient's phone number")
                txtRecipient.Text = "";
        }

        private void txtSender_Enter(object sender, EventArgs e)
        {
            if (txtSender.Text == "sender's phone number/name")
                txtSender.Text = "";
        }

        private void pnlSendButton_Click(object sender, EventArgs e)
        {
            //To Do
            message = txtMessage.Text;
            sender = txtSender.Text;
            string countryCode = txtCountryCode.Text;
            string recipientNumber = txtRecipient.Text;
            number = countryCode + recipientNumber.Substring(1);
            if (recipientNumber.Length != 11)
            {
                txtRecipient.ForeColor = Color.Red;
                MessageBox.Show("The recipient Phone number you entered is either invalid or not supported, ReCheck the number and try again", "Invalid Number", MessageBoxButtons.RetryCancel);
            }
            else if (message.Length == 0)
            {
                txtMessage.ForeColor = Color.Red;
            }
            else
            {
                if (txtRecipient.ForeColor == Color.Red)
                    txtRecipient.ForeColor = Color.Gray;
                if (txtMessage.ForeColor == Color.Red)
                    txtMessage.ForeColor = Color.Gray;
                if (!(txtSender.Text.Length >= 1))
                    sender = "Setoryz";
                try
                {
                    MessageBox.Show(sendSMS());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Sending Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        //Message Parameters
        string apiKey = "";
        string message, number;
        string sender = "GTBank";
        public string sendSMS()
        {
            string encodedMessage = HttpUtility.UrlEncode(message);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("http://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"username" , ""},
                {"password" , ""},
                {"numbers" , number},
                {"message" , message},
                {"sender" , sender}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }
    }
}
