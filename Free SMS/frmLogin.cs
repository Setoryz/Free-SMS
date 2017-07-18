using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Free_SMS
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();

        }


        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void lblCloseLoginWindow_MouseEnter(object sender, EventArgs e)
        {
            this.lblCloseLoginWindow.ForeColor = Color.Red;
        }


        private void lblCloseLoginWindow_MouseLeave(object sender, EventArgs e)
        {
            this.lblCloseLoginWindow.ForeColor = Color.Gray;
        }

        private void lblCloseLoginWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pnlLoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Seyitan\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count (*) From Login where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lblCloseLoginWindow_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
