namespace Free_SMS
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectLoginButton = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectPassword = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectUsername = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pnlLoginButton = new System.Windows.Forms.Panel();
            this.lblLoginButton = new System.Windows.Forms.Label();
            this.lblCloseLoginWindow = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlLoginButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectLoginButton,
            this.rectPassword,
            this.rectUsername});
            this.shapeContainer1.Size = new System.Drawing.Size(341, 400);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // rectLoginButton
            // 
            this.rectLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.rectLoginButton.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectLoginButton.BorderColor = System.Drawing.Color.White;
            this.rectLoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectLoginButton.FillColor = System.Drawing.Color.Transparent;
            this.rectLoginButton.Location = new System.Drawing.Point(45, 274);
            this.rectLoginButton.Name = "rectLoginButton";
            this.rectLoginButton.Size = new System.Drawing.Size(245, 46);
            // 
            // rectPassword
            // 
            this.rectPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rectPassword.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectPassword.BorderColor = System.Drawing.Color.White;
            this.rectPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectPassword.FillColor = System.Drawing.Color.Transparent;
            this.rectPassword.Location = new System.Drawing.Point(45, 205);
            this.rectPassword.Name = "rectPassword";
            this.rectPassword.Size = new System.Drawing.Size(245, 46);
            // 
            // rectUsername
            // 
            this.rectUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rectUsername.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectUsername.BorderColor = System.Drawing.Color.White;
            this.rectUsername.FillColor = System.Drawing.Color.Transparent;
            this.rectUsername.Location = new System.Drawing.Point(45, 139);
            this.rectUsername.Name = "rectUsername";
            this.rectUsername.Size = new System.Drawing.Size(245, 46);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(70, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(70, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.linkLabel1.Location = new System.Drawing.Point(130, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 14);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create an Account";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.linkLabel2.Location = new System.Drawing.Point(131, 366);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 14);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "forgot password?";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLoginButton
            // 
            this.pnlLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.pnlLoginButton.Controls.Add(this.lblLoginButton);
            this.pnlLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLoginButton.Location = new System.Drawing.Point(56, 279);
            this.pnlLoginButton.Name = "pnlLoginButton";
            this.pnlLoginButton.Size = new System.Drawing.Size(225, 37);
            this.pnlLoginButton.TabIndex = 3;
            this.pnlLoginButton.Click += new System.EventHandler(this.pnlLoginButton_Click);
            // 
            // lblLoginButton
            // 
            this.lblLoginButton.AutoSize = true;
            this.lblLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginButton.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginButton.ForeColor = System.Drawing.Color.White;
            this.lblLoginButton.Location = new System.Drawing.Point(85, 5);
            this.lblLoginButton.Name = "lblLoginButton";
            this.lblLoginButton.Size = new System.Drawing.Size(64, 26);
            this.lblLoginButton.TabIndex = 0;
            this.lblLoginButton.Text = "Login";
            // 
            // lblCloseLoginWindow
            // 
            this.lblCloseLoginWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseLoginWindow.AutoSize = true;
            this.lblCloseLoginWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseLoginWindow.Font = new System.Drawing.Font("Ephesus", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseLoginWindow.ForeColor = System.Drawing.Color.Gray;
            this.lblCloseLoginWindow.Location = new System.Drawing.Point(325, 1);
            this.lblCloseLoginWindow.Name = "lblCloseLoginWindow";
            this.lblCloseLoginWindow.Size = new System.Drawing.Size(16, 14);
            this.lblCloseLoginWindow.TabIndex = 6;
            this.lblCloseLoginWindow.Text = "X";
            this.lblCloseLoginWindow.Click += new System.EventHandler(this.lblCloseLoginWindow_Click_1);
            this.lblCloseLoginWindow.MouseEnter += new System.EventHandler(this.lblCloseLoginWindow_MouseEnter);
            this.lblCloseLoginWindow.MouseLeave += new System.EventHandler(this.lblCloseLoginWindow_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(160, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "make password visible";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 400);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblCloseLoginWindow);
            this.Controls.Add(this.pnlLoginButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginButton.ResumeLayout(false);
            this.pnlLoginButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectUsername;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectLoginButton;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel pnlLoginButton;
        private System.Windows.Forms.Label lblLoginButton;
        private System.Windows.Forms.Label lblCloseLoginWindow;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}