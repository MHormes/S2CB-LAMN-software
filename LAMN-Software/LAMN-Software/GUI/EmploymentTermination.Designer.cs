namespace LAMN_Software
{
    partial class EmploymentTermination
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
            this.btnCancel_termination = new System.Windows.Forms.Button();
            this.btnConfirmTermination = new System.Windows.Forms.Button();
            this.tbxTerminationReason = new System.Windows.Forms.TextBox();
            this.lblTerminationReason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel_termination
            // 
            this.btnCancel_termination.Font = new System.Drawing.Font("Arial", 13F);
            this.btnCancel_termination.Location = new System.Drawing.Point(223, 618);
            this.btnCancel_termination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_termination.Name = "btnCancel_termination";
            this.btnCancel_termination.Size = new System.Drawing.Size(309, 83);
            this.btnCancel_termination.TabIndex = 17;
            this.btnCancel_termination.Text = "Cancel";
            this.btnCancel_termination.UseVisualStyleBackColor = true;
            this.btnCancel_termination.Click += new System.EventHandler(this.btnCancel_termination_Click);
            // 
            // btnConfirmTermination
            // 
            this.btnConfirmTermination.Font = new System.Drawing.Font("Arial", 13F);
            this.btnConfirmTermination.Location = new System.Drawing.Point(646, 618);
            this.btnConfirmTermination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmTermination.Name = "btnConfirmTermination";
            this.btnConfirmTermination.Size = new System.Drawing.Size(309, 83);
            this.btnConfirmTermination.TabIndex = 18;
            this.btnConfirmTermination.Text = "Confirm";
            this.btnConfirmTermination.UseVisualStyleBackColor = true;
            this.btnConfirmTermination.Click += new System.EventHandler(this.btnConfirmTermination_Click);
            // 
            // tbxTerminationReason
            // 
            this.tbxTerminationReason.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxTerminationReason.Location = new System.Drawing.Point(152, 335);
            this.tbxTerminationReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTerminationReason.Multiline = true;
            this.tbxTerminationReason.Name = "tbxTerminationReason";
            this.tbxTerminationReason.Size = new System.Drawing.Size(896, 77);
            this.tbxTerminationReason.TabIndex = 49;
            // 
            // lblTerminationReason
            // 
            this.lblTerminationReason.AutoSize = true;
            this.lblTerminationReason.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminationReason.Location = new System.Drawing.Point(402, 269);
            this.lblTerminationReason.Name = "lblTerminationReason";
            this.lblTerminationReason.Size = new System.Drawing.Size(392, 43);
            this.lblTerminationReason.TabIndex = 50;
            this.lblTerminationReason.Text = "Reason of termination";
            // 
            // EmploymentTermination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 795);
            this.Controls.Add(this.lblTerminationReason);
            this.Controls.Add(this.tbxTerminationReason);
            this.Controls.Add(this.btnConfirmTermination);
            this.Controls.Add(this.btnCancel_termination);
            this.Name = "EmploymentTermination";
            this.Text = "EmploymentTermination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel_termination;
        private System.Windows.Forms.Button btnConfirmTermination;
        private System.Windows.Forms.TextBox tbxTerminationReason;
        private System.Windows.Forms.Label lblTerminationReason;
    }
}