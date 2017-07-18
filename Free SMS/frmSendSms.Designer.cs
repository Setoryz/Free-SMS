namespace Free_SMS
{
    partial class frmSendSms
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
            this.rectHeader = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblCloseLoginWindow = new System.Windows.Forms.Label();
            this.lblCopyrightInfo = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.pnlSendButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSendButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectHeader
            // 
            this.rectHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.rectHeader.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectHeader.BorderColor = System.Drawing.Color.White;
            this.rectHeader.Location = new System.Drawing.Point(-1, -1);
            this.rectHeader.Name = "rectHeader";
            this.rectHeader.Size = new System.Drawing.Size(496, 81);
            // 
            // rectFooter
            // 
            this.rectFooter.BackColor = System.Drawing.Color.Gray;
            this.rectFooter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectFooter.BorderColor = System.Drawing.Color.White;
            this.rectFooter.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectFooter.Location = new System.Drawing.Point(-1, 551);
            this.rectFooter.Name = "rectFooter";
            this.rectFooter.Size = new System.Drawing.Size(496, 57);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1,
            this.rectFooter,
            this.rectHeader});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 607);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblVersionInfo.Font = new System.Drawing.Font("Source Sans Pro", 9F);
            this.lblVersionInfo.ForeColor = System.Drawing.Color.White;
            this.lblVersionInfo.Location = new System.Drawing.Point(133, 54);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(62, 15);
            this.lblVersionInfo.TabIndex = 12;
            this.lblVersionInfo.Text = "Version 1.0";
            this.lblVersionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblLogo.Font = new System.Drawing.Font("Source Sans Pro", 32F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 13);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(194, 54);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "Free Sms";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCloseLoginWindow
            // 
            this.lblCloseLoginWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseLoginWindow.AutoSize = true;
            this.lblCloseLoginWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblCloseLoginWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseLoginWindow.Font = new System.Drawing.Font("Ephesus", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseLoginWindow.ForeColor = System.Drawing.Color.White;
            this.lblCloseLoginWindow.Location = new System.Drawing.Point(477, 2);
            this.lblCloseLoginWindow.Name = "lblCloseLoginWindow";
            this.lblCloseLoginWindow.Size = new System.Drawing.Size(16, 14);
            this.lblCloseLoginWindow.TabIndex = 10;
            this.lblCloseLoginWindow.Text = "X";
            this.lblCloseLoginWindow.Click += new System.EventHandler(this.lblCloseLoginWindow_Click);
            this.lblCloseLoginWindow.MouseEnter += new System.EventHandler(this.lblCloseLoginWindow_MouseEnter);
            this.lblCloseLoginWindow.MouseLeave += new System.EventHandler(this.lblCloseLoginWindow_MouseLeave);
            // 
            // lblCopyrightInfo
            // 
            this.lblCopyrightInfo.AutoSize = true;
            this.lblCopyrightInfo.BackColor = System.Drawing.Color.Gray;
            this.lblCopyrightInfo.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblCopyrightInfo.ForeColor = System.Drawing.Color.White;
            this.lblCopyrightInfo.Location = new System.Drawing.Point(371, 588);
            this.lblCopyrightInfo.Name = "lblCopyrightInfo";
            this.lblCopyrightInfo.Size = new System.Drawing.Size(124, 18);
            this.lblCopyrightInfo.TabIndex = 13;
            this.lblCopyrightInfo.Text = "Setoryz Inc.. © 2017";
            this.lblCopyrightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape1.Location = new System.Drawing.Point(18, 156);
            this.rectangleShape1.Name = "rectHeader";
            this.rectangleShape1.Size = new System.Drawing.Size(451, 39);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape2.Location = new System.Drawing.Point(18, 207);
            this.rectangleShape2.Name = "rectHeader";
            this.rectangleShape2.Size = new System.Drawing.Size(451, 286);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.White;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.Color.White;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape3.Location = new System.Drawing.Point(18, 100);
            this.rectangleShape3.Name = "rectHeader";
            this.rectangleShape3.Size = new System.Drawing.Size(84, 39);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.White;
            this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4.BorderColor = System.Drawing.Color.White;
            this.rectangleShape4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape4.Location = new System.Drawing.Point(170, 100);
            this.rectangleShape4.Name = "rectHeader";
            this.rectangleShape4.Size = new System.Drawing.Size(299, 39);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.Color.White;
            this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape5.BorderColor = System.Drawing.Color.White;
            this.rectangleShape5.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape5.Location = new System.Drawing.Point(337, 505);
            this.rectangleShape5.Name = "rectHeader";
            this.rectangleShape5.Size = new System.Drawing.Size(130, 39);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.BackColor = System.Drawing.Color.White;
            this.txtCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountryCode.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.txtCountryCode.Location = new System.Drawing.Point(24, 107);
            this.txtCountryCode.MaxLength = 4;
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(73, 27);
            this.txtCountryCode.TabIndex = 14;
            this.txtCountryCode.Text = "+234";
            this.txtCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRecipient
            // 
            this.txtRecipient.BackColor = System.Drawing.Color.White;
            this.txtRecipient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipient.Font = new System.Drawing.Font("Brillant", 15.75F);
            this.txtRecipient.ForeColor = System.Drawing.Color.Gray;
            this.txtRecipient.Location = new System.Drawing.Point(182, 109);
            this.txtRecipient.MaxLength = 11;
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(281, 23);
            this.txtRecipient.TabIndex = 14;
            this.txtRecipient.Text = "recipient\'s phone number";
            this.txtRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecipient.Enter += new System.EventHandler(this.txtRecipient_Enter);
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.Color.White;
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSender.Font = new System.Drawing.Font("Brillant", 15.75F);
            this.txtSender.ForeColor = System.Drawing.Color.Gray;
            this.txtSender.Location = new System.Drawing.Point(24, 165);
            this.txtSender.MaxLength = 30;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(439, 23);
            this.txtSender.TabIndex = 14;
            this.txtSender.Text = "sender\'s phone number/name";
            this.txtSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSender.Enter += new System.EventHandler(this.txtSender_Enter);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Brillant", 13F);
            this.txtMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtMessage.Location = new System.Drawing.Point(21, 207);
            this.txtMessage.MaxLength = 140;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(447, 287);
            this.txtMessage.TabIndex = 14;
            this.txtMessage.Text = "message...";
            // 
            // pnlSendButton
            // 
            this.pnlSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.pnlSendButton.Controls.Add(this.label1);
            this.pnlSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSendButton.Location = new System.Drawing.Point(337, 505);
            this.pnlSendButton.Name = "pnlSendButton";
            this.pnlSendButton.Size = new System.Drawing.Size(131, 40);
            this.pnlSendButton.TabIndex = 15;
            this.pnlSendButton.Click += new System.EventHandler(this.pnlSendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Send";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.pnlSendButton_Click);
            // 
            // frmSendSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(494, 607);
            this.Controls.Add(this.pnlSendButton);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.lblCopyrightInfo);
            this.Controls.Add(this.lblVersionInfo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblCloseLoginWindow);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSendSms";
            this.Text = "frmSendSms";
            this.pnlSendButton.ResumeLayout(false);
            this.pnlSendButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectHeader;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectFooter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblVersionInfo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblCloseLoginWindow;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblCopyrightInfo;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel pnlSendButton;
        private System.Windows.Forms.Label label1;
    }
}