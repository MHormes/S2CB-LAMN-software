
namespace LAMN_Software
{
    partial class ProductForm
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.tcNavigator = new System.Windows.Forms.TabControl();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.tpSchedules = new System.Windows.Forms.TabPage();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.tpStatistics = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.tcNavigator.SuspendLayout();
            this.tpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Gray;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.btnStatistics);
            this.pnlBackground.Controls.Add(this.btnEmployees);
            this.pnlBackground.Controls.Add(this.btnSchedules);
            this.pnlBackground.Controls.Add(this.btnStock);
            this.pnlBackground.Controls.Add(this.tcNavigator);
            this.pnlBackground.Controls.Add(this.textBox_defocus);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1705, 996);
            this.pnlBackground.TabIndex = 9;
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
            this.pnlBar.Size = new System.Drawing.Size(1706, 71);
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
            this.pnlDragBar.Size = new System.Drawing.Size(1628, 69);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1643, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(63, 63);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // tcNavigator
            // 
            this.tcNavigator.Controls.Add(this.tpStock);
            this.tcNavigator.Controls.Add(this.tpSchedules);
            this.tcNavigator.Controls.Add(this.tpEmployees);
            this.tcNavigator.Controls.Add(this.tpStatistics);
            this.tcNavigator.Location = new System.Drawing.Point(11, 182);
            this.tcNavigator.Name = "tcNavigator";
            this.tcNavigator.SelectedIndex = 0;
            this.tcNavigator.Size = new System.Drawing.Size(1680, 802);
            this.tcNavigator.TabIndex = 9;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.tbxSearchStock);
            this.tpStock.Controls.Add(this.listBox1);
            this.tpStock.Controls.Add(this.btnDeleteStock);
            this.tpStock.Controls.Add(this.btnEditStock);
            this.tpStock.Controls.Add(this.btnSearchStock);
            this.tpStock.Controls.Add(this.btnAddStock);
            this.tpStock.Location = new System.Drawing.Point(10, 40);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpStock.Size = new System.Drawing.Size(1660, 752);
            this.tpStock.TabIndex = 0;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // tpSchedules
            // 
            this.tpSchedules.Location = new System.Drawing.Point(10, 40);
            this.tpSchedules.Name = "tpSchedules";
            this.tpSchedules.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedules.Size = new System.Drawing.Size(1660, 752);
            this.tpSchedules.TabIndex = 1;
            this.tpSchedules.Text = "Schedules";
            this.tpSchedules.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStock.Location = new System.Drawing.Point(355, 78);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(263, 125);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnSchedules
            // 
            this.btnSchedules.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSchedules.Location = new System.Drawing.Point(624, 78);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(263, 125);
            this.btnSchedules.TabIndex = 10;
            this.btnSchedules.Text = "Schedules";
            this.btnSchedules.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployees.Location = new System.Drawing.Point(893, 78);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(263, 125);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStatistics.Location = new System.Drawing.Point(1162, 78);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(263, 125);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Location = new System.Drawing.Point(10, 40);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1660, 752);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // tpStatistics
            // 
            this.tpStatistics.Location = new System.Drawing.Point(10, 40);
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatistics.Size = new System.Drawing.Size(1660, 752);
            this.tpStatistics.TabIndex = 3;
            this.tpStatistics.Text = "Statistics";
            this.tpStatistics.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(110, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1403, 466);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddStock.Location = new System.Drawing.Point(110, 577);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(204, 77);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "+ Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEditStock.Location = new System.Drawing.Point(320, 577);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(307, 77);
            this.btnEditStock.TabIndex = 10;
            this.btnEditStock.Text = "✎ Edit selected";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnDeleteStock.Location = new System.Drawing.Point(633, 577);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(397, 77);
            this.btnDeleteStock.TabIndex = 10;
            this.btnDeleteStock.Text = "🗑️ Delete selected";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchStock.Location = new System.Drawing.Point(1047, 585);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(368, 59);
            this.tbxSearchStock.TabIndex = 11;
            this.tbxSearchStock.TabStop = false;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchStock.Location = new System.Drawing.Point(1429, 577);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(84, 77);
            this.btnSearchStock.TabIndex = 10;
            this.btnSearchStock.Text = "🔍";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 997);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.tcNavigator.ResumeLayout(false);
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox textBox_defocus;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlDragBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TabControl tcNavigator;
        private System.Windows.Forms.TabPage tpStock;
        private System.Windows.Forms.TabPage tpSchedules;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpStatistics;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnAddStock;
    }
}