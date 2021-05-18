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
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_accountPassword = new System.Windows.Forms.TextBox();
            this.label_loginTitle = new System.Windows.Forms.Label();
            this.textBox_accountName = new System.Windows.Forms.TextBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevAccess = new System.Windows.Forms.Button();
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
            this.button_login.ForeColor = System.Drawing.Color.Indigo;
            this.button_login.Location = new System.Drawing.Point(261, 398);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 35);
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
            this.textBox_accountPassword.Location = new System.Drawing.Point(189, 312);
            this.textBox_accountPassword.Name = "textBox_accountPassword";
            this.textBox_accountPassword.Size = new System.Drawing.Size(280, 42);
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
            this.label_loginTitle.Location = new System.Drawing.Point(192, 180);
            this.label_loginTitle.Name = "label_loginTitle";
            this.label_loginTitle.Size = new System.Drawing.Size(295, 34);
            this.label_loginTitle.TabIndex = 0;
            this.label_loginTitle.Text = "Media Bazaar";
            // 
            // textBox_accountName
            // 
            this.textBox_accountName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountName.ForeColor = System.Drawing.Color.Gray;
            this.textBox_accountName.Location = new System.Drawing.Point(189, 252);
            this.textBox_accountName.Margin = new System.Windows.Forms.Padding(29, 28, 29, 28);
            this.textBox_accountName.Name = "textBox_accountName";
            this.textBox_accountName.Size = new System.Drawing.Size(280, 42);
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
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnDevAccess);
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
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBackground.MaximumSize = new System.Drawing.Size(641, 537);
            this.pnlBackground.MinimumSize = new System.Drawing.Size(641, 537);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(641, 537);
            this.pnlBackground.TabIndex = 8;
            this.pnlBackground.Click += new System.EventHandler(this.pnlBackground_Click);
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(133, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "© 2021 LAMN Software. All Rights Reserved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDevAccess
            // 
            this.btnDevAccess.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDevAccess.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnDevAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevAccess.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevAccess.ForeColor = System.Drawing.Color.White;
            this.btnDevAccess.Location = new System.Drawing.Point(389, 399);
            this.btnDevAccess.Name = "btnDevAccess";
            this.btnDevAccess.Size = new System.Drawing.Size(67, 34);
            this.btnDevAccess.TabIndex = 10;
            this.btnDevAccess.TabStop = false;
            this.btnDevAccess.Text = "DEV";
            this.btnDevAccess.UseVisualStyleBackColor = false;
            this.btnDevAccess.Click += new System.EventHandler(this.btnDevAccess_Click);
            // 
            // textBox_defocus
            // 
            this.textBox_defocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_defocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defocus.Location = new System.Drawing.Point(0, 0);
            this.textBox_defocus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_defocus.Name = "textBox_defocus";
            this.textBox_defocus.Size = new System.Drawing.Size(2, 9);
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
            this.pnlBar.Location = new System.Drawing.Point(-1, -1);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(638, 39);
            this.pnlBar.TabIndex = 8;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(3, 1);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(594, 38);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(599, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(36, 35);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblMB
            // 
            this.lblMB.BackColor = System.Drawing.Color.Transparent;
            this.lblMB.Font = new System.Drawing.Font("Arial Black", 75F, System.Drawing.FontStyle.Bold);
            this.lblMB.ForeColor = System.Drawing.Color.White;
            this.lblMB.Location = new System.Drawing.Point(171, 58);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(328, 141);
            this.lblMB.TabIndex = 9;
            this.lblMB.Text = "MB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 536);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(640, 536);
            this.MinimumSize = new System.Drawing.Size(640, 536);
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
        private System.Windows.Forms.Button btnDevAccess;
        private System.Windows.Forms.Label label1;
    }
}

