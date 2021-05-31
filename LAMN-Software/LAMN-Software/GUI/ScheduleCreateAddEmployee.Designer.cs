
namespace LAMN_Software
{
    partial class ScheduleCreateAddEmployee
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
            this.lbxScheduleCreatePlanned = new System.Windows.Forms.ListBox();
            this.lbxScheduleCreateAvailable = new System.Windows.Forms.ListBox();
            this.btnScheduleCreateRemove = new System.Windows.Forms.Button();
            this.btnScheduleCreateAdd = new System.Windows.Forms.Button();
            this.btnScheduleCreateDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShiftInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxScheduleCreatePlanned
            // 
            this.lbxScheduleCreatePlanned.FormattingEnabled = true;
            this.lbxScheduleCreatePlanned.Location = new System.Drawing.Point(12, 103);
            this.lbxScheduleCreatePlanned.Name = "lbxScheduleCreatePlanned";
            this.lbxScheduleCreatePlanned.Size = new System.Drawing.Size(357, 407);
            this.lbxScheduleCreatePlanned.TabIndex = 0;
            // 
            // lbxScheduleCreateAvailable
            // 
            this.lbxScheduleCreateAvailable.FormattingEnabled = true;
            this.lbxScheduleCreateAvailable.Location = new System.Drawing.Point(375, 103);
            this.lbxScheduleCreateAvailable.Name = "lbxScheduleCreateAvailable";
            this.lbxScheduleCreateAvailable.Size = new System.Drawing.Size(384, 407);
            this.lbxScheduleCreateAvailable.TabIndex = 1;
            // 
            // btnScheduleCreateRemove
            // 
            this.btnScheduleCreateRemove.Location = new System.Drawing.Point(12, 525);
            this.btnScheduleCreateRemove.Name = "btnScheduleCreateRemove";
            this.btnScheduleCreateRemove.Size = new System.Drawing.Size(357, 23);
            this.btnScheduleCreateRemove.TabIndex = 2;
            this.btnScheduleCreateRemove.Text = "Remove selected employee from shift";
            this.btnScheduleCreateRemove.UseVisualStyleBackColor = true;
            this.btnScheduleCreateRemove.Click += new System.EventHandler(this.btnScheduleCreateRemove_Click);
            // 
            // btnScheduleCreateAdd
            // 
            this.btnScheduleCreateAdd.Location = new System.Drawing.Point(375, 525);
            this.btnScheduleCreateAdd.Name = "btnScheduleCreateAdd";
            this.btnScheduleCreateAdd.Size = new System.Drawing.Size(384, 23);
            this.btnScheduleCreateAdd.TabIndex = 3;
            this.btnScheduleCreateAdd.Text = "Add selected employee to shift";
            this.btnScheduleCreateAdd.UseVisualStyleBackColor = true;
            this.btnScheduleCreateAdd.Click += new System.EventHandler(this.btnScheduleCreateAdd_Click);
            // 
            // btnScheduleCreateDone
            // 
            this.btnScheduleCreateDone.Location = new System.Drawing.Point(12, 554);
            this.btnScheduleCreateDone.Name = "btnScheduleCreateDone";
            this.btnScheduleCreateDone.Size = new System.Drawing.Size(357, 23);
            this.btnScheduleCreateDone.TabIndex = 4;
            this.btnScheduleCreateDone.Text = "Go back to schedule page";
            this.btnScheduleCreateDone.UseVisualStyleBackColor = true;
            this.btnScheduleCreateDone.Click += new System.EventHandler(this.btnScheduleCreateDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employees currently assigned to shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employees available for shift";
            // 
            // lblShiftInformation
            // 
            this.lblShiftInformation.AutoSize = true;
            this.lblShiftInformation.Location = new System.Drawing.Point(12, 13);
            this.lblShiftInformation.Name = "lblShiftInformation";
            this.lblShiftInformation.Size = new System.Drawing.Size(48, 13);
            this.lblShiftInformation.TabIndex = 7;
            this.lblShiftInformation.Text = "Shift info";
            // 
            // ScheduleCreateAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 646);
            this.Controls.Add(this.lblShiftInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScheduleCreateDone);
            this.Controls.Add(this.btnScheduleCreateAdd);
            this.Controls.Add(this.btnScheduleCreateRemove);
            this.Controls.Add(this.lbxScheduleCreateAvailable);
            this.Controls.Add(this.lbxScheduleCreatePlanned);
            this.Name = "ScheduleCreateAddEmployee";
            this.Text = "ScheduleCreateAddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxScheduleCreatePlanned;
        private System.Windows.Forms.ListBox lbxScheduleCreateAvailable;
        private System.Windows.Forms.Button btnScheduleCreateRemove;
        private System.Windows.Forms.Button btnScheduleCreateAdd;
        private System.Windows.Forms.Button btnScheduleCreateDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShiftInformation;
    }
}