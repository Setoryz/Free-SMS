using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Free_SMS
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void lblCloseLoginWindow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void lblCloseLoginWindow_MouseEnter(object sender, EventArgs e)
        {
            lblCloseLoginWindow.ForeColor = Color.Red;
        }

        private void lblCloseLoginWindow_MouseLeave(object sender, EventArgs e)
        {
            lblCloseLoginWindow.ForeColor = Color.White;
        }

        private void pnlSendSms_MouseEnter(object sender, EventArgs e)
        {
            pnlSendSms.BackColor = Color.FromArgb(224, 224, 224);
            lblSendSms.ForeColor = Color.FromArgb(13, 71, 161);
        }

        private void pnlSendSms_MouseLeave(object sender, EventArgs e)
        {
            lblSendSms.ForeColor = Color.White;
            pnlSendSms.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void pnlSendSms_Click(object sender, EventArgs e)
        {
            frmSendSms sendSmsForm = new frmSendSms();
            sendSmsForm.Show();
        }
    }
}
