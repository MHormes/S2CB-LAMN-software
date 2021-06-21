namespace LAMN_Software.GUI
{
    partial class DeclineChangeOfInfo
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
            this.lblDeclineReason = new System.Windows.Forms.Label();
            this.tbxDeclineReason = new System.Windows.Forms.TextBox();
            this.btnConfirmDecline = new System.Windows.Forms.Button();
            this.btnCancel_decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeclineReason
            // 
            this.lblDeclineReason.AutoSize = true;
            this.lblDeclineReason.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclineReason.Location = new System.Drawing.Point(401, 112);
            this.lblDeclineReason.Name = "lblDeclineReason";
            this.lblDeclineReason.Size = new System.Drawing.Size(803, 108);
            this.lblDeclineReason.TabIndex = 54;
            this.lblDeclineReason.Text = "Reason of decline";
            // 
            // tbxDeclineReason
            // 
            this.tbxDeclineReason.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxDeclineReason.Location = new System.Drawing.Point(152, 195);
            this.tbxDeclineReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDeclineReason.Multiline = true;
            this.tbxDeclineReason.Name = "tbxDeclineReason";
            this.tbxDeclineReason.Size = new System.Drawing.Size(896, 292);
            this.tbxDeclineReason.TabIndex = 53;
            // 
            // btnConfirmDecline
            // 
            this.btnConfirmDecline.Font = new System.Drawing.Font("Arial", 13F);
            this.btnConfirmDecline.Location = new System.Drawing.Point(646, 557);
            this.btnConfirmDecline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmDecline.Name = "btnConfirmDecline";
            this.btnConfirmDecline.Size = new System.Drawing.Size(309, 83);
            this.btnConfirmDecline.TabIndex = 52;
            this.btnConfirmDecline.Text = "Confirm";
            this.btnConfirmDecline.UseVisualStyleBackColor = true;
            this.btnConfirmDecline.Click += new System.EventHandler(this.btnConfirmDecline_Click);
            // 
            // btnCancel_decline
            // 
            this.btnCancel_decline.Font = new System.Drawing.Font("Arial", 13F);
            this.btnCancel_decline.Location = new System.Drawing.Point(223, 557);
            this.btnCancel_decline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_decline.Name = "btnCancel_decline";
            this.btnCancel_decline.Size = new System.Drawing.Size(309, 83);
            this.btnCancel_decline.TabIndex = 51;
            this.btnCancel_decline.Text = "Cancel";
            this.btnCancel_decline.UseVisualStyleBackColor = true;
            this.btnCancel_decline.Click += new System.EventHandler(this.btnCancel_decline_Click);
            // 
            // DeclineChangeOfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 799);
            this.Controls.Add(this.tbxDeclineReason);
            this.Controls.Add(this.lblDeclineReason);
            this.Controls.Add(this.btnConfirmDecline);
            this.Controls.Add(this.btnCancel_decline);
            this.Name = "DeclineChangeOfInfo";
            this.Text = "DeclineChangeOfInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeclineReason;
        private System.Windows.Forms.TextBox tbxDeclineReason;
        private System.Windows.Forms.Button btnConfirmDecline;
        private System.Windows.Forms.Button btnCancel_decline;
    }
}