namespace LAMN_Software
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_accountPassword = new System.Windows.Forms.TextBox();
            this.label_loginTitle = new System.Windows.Forms.Label();
            this.textBox_accountName = new System.Windows.Forms.TextBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblTV = new System.Windows.Forms.Label();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_login.Location = new System.Drawing.Point(498, 750);
            this.button_login.Margin = new System.Windows.Forms.Padding(5);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(215, 63);
            this.button_login.TabIndex = 0;
            this.button_login.TabStop = false;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_accountPassword
            // 
            this.textBox_accountPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBox_accountPassword.Location = new System.Drawing.Point(358, 575);
            this.textBox_accountPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_accountPassword.Name = "textBox_accountPassword";
            this.textBox_accountPassword.Size = new System.Drawing.Size(487, 70);
            this.textBox_accountPassword.TabIndex = 0;
            this.textBox_accountPassword.TabStop = false;
            this.textBox_accountPassword.Text = "Password";
            this.textBox_accountPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_accountPassword.Enter += new System.EventHandler(this.textBox_accountPassword_Enter);
            this.textBox_accountPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_accountPassword_KeyPress);
            this.textBox_accountPassword.Leave += new System.EventHandler(this.textBox_accountPassword_Leave);
            // 
            // label_loginTitle
            // 
            this.label_loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_loginTitle.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginTitle.ForeColor = System.Drawing.Color.White;
            this.label_loginTitle.Location = new System.Drawing.Point(356, 302);
            this.label_loginTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_loginTitle.Name = "label_loginTitle";
            this.label_loginTitle.Size = new System.Drawing.Size(432, 75);
            this.label_loginTitle.TabIndex = 0;
            this.label_loginTitle.Text = "Media Bazaar";
            // 
            // textBox_accountName
            // 
            this.textBox_accountName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountName.ForeColor = System.Drawing.Color.Gray;
            this.textBox_accountName.Location = new System.Drawing.Point(358, 465);
            this.textBox_accountName.Margin = new System.Windows.Forms.Padding(50);
            this.textBox_accountName.Name = "textBox_accountName";
            this.textBox_accountName.Size = new System.Drawing.Size(487, 70);
            this.textBox_accountName.TabIndex = 0;
            this.textBox_accountName.TabStop = false;
            this.textBox_accountName.Text = "Account name";
            this.textBox_accountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_accountName.Enter += new System.EventHandler(this.textBox_accountName_Enter);
            this.textBox_accountName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_accountName_KeyPress);
            this.textBox_accountName.Leave += new System.EventHandler(this.textBox_accountName_Leave);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Gray;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.lblTV);
            this.pnlBackground.Controls.Add(this.label_loginTitle);
            this.pnlBackground.Controls.Add(this.textBox_defocus);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.Controls.Add(this.button_login);
            this.pnlBackground.Controls.Add(this.textBox_accountPassword);
            this.pnlBackground.Controls.Add(this.textBox_accountName);
            this.pnlBackground.Controls.Add(this.lblMB);
            this.pnlBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1120, 968);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Click += new System.EventHandler(this.pnlBackground_Click);
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // lblTV
            // 
            this.lblTV.BackColor = System.Drawing.Color.Transparent;
            this.lblTV.Font = new System.Drawing.Font("Arial Black", 55F, System.Drawing.FontStyle.Bold);
            this.lblTV.ForeColor = System.Drawing.Color.White;
            this.lblTV.Image = ((System.Drawing.Image)(resources.GetObject("lblTV.Image")));
            this.lblTV.Location = new System.Drawing.Point(644, 169);
            this.lblTV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(144, 133);
            this.lblTV.TabIndex = 10;
            // 
            // textBox_defocus
            // 
            this.textBox_defocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_defocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defocus.Location = new System.Drawing.Point(0, 0);
            this.textBox_defocus.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_defocus.Name = "textBox_defocus";
            this.textBox_defocus.Size = new System.Drawing.Size(0, 11);
            this.textBox_defocus.TabIndex = 0;
            this.textBox_defocus.TabStop = false;
            this.textBox_defocus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_defocus_KeyDown);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlBar.Controls.Add(this.pnlDragBar);
            this.pnlBar.Controls.Add(this.lblClose);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBar.Location = new System.Drawing.Point(-2, -2);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1116, 71);
            this.pnlBar.TabIndex = 8;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(6, 1);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(1040, 69);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1049, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(63, 63);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMB
            // 
            this.lblMB.BackColor = System.Drawing.Color.Transparent;
            this.lblMB.Font = new System.Drawing.Font("Arial Black", 55F, System.Drawing.FontStyle.Bold);
            this.lblMB.ForeColor = System.Drawing.Color.White;
            this.lblMB.Location = new System.Drawing.Point(319, 121);
            this.lblMB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(394, 208);
            this.lblMB.TabIndex = 9;
            this.lblMB.Text = "MB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 958);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_accountPassword;
        private System.Windows.Forms.Label label_loginTitle;
        private System.Windows.Forms.TextBox textBox_accountName;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox textBox_defocus;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlDragBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblTV;
    }
}

