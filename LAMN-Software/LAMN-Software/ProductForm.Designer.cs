
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
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.tcNavigator = new System.Windows.Forms.TabControl();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.lbxAllStock = new System.Windows.Forms.ListBox();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tpSchedules = new System.Windows.Forms.TabPage();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.tpStatistics = new System.Windows.Forms.TabPage();
            this.tpStockAdd = new System.Windows.Forms.TabPage();
            this.btnStockAdd_ConfirmEdit = new System.Windows.Forms.Button();
            this.btnStockAdd_ConfirmAdd = new System.Windows.Forms.Button();
            this.tbxStockAdd_TotalSold = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxStockAdd_ID = new System.Windows.Forms.TextBox();
            this.tbxStockAdd_Sell = new System.Windows.Forms.TextBox();
            this.tbxStockAdd_AddInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStockAdd_MinimumStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxStockAdd_Cost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxStockAdd_WarehouseLocation = new System.Windows.Forms.TextBox();
            this.tbxStockAdd_StoreLocation = new System.Windows.Forms.TextBox();
            this.lblStockAdd_Store = new System.Windows.Forms.Label();
            this.lblStockAdd_Warehouse = new System.Windows.Forms.Label();
            this.lblStockAdd_WarehouseLocation = new System.Windows.Forms.Label();
            this.tbxStockAdd_StoreQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStockAdd_WarehouseQuantity = new System.Windows.Forms.TextBox();
            this.lblStockAdd_WarehouseQuantity = new System.Windows.Forms.Label();
            this.tbxStockAdd_ProductName = new System.Windows.Forms.TextBox();
            this.lblProductAdd_StockName = new System.Windows.Forms.Label();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnBackToStockPage = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.tcNavigator.SuspendLayout();
            this.tpStock.SuspendLayout();
            this.tpStockAdd.SuspendLayout();
            this.pnlBar.SuspendLayout();
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
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(732, 448);
            this.pnlBackground.TabIndex = 9;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStatistics.Location = new System.Drawing.Point(545, 34);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(113, 56);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployees.Location = new System.Drawing.Point(430, 34);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(113, 56);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSchedules.Location = new System.Drawing.Point(315, 34);
            this.btnSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(113, 56);
            this.btnSchedules.TabIndex = 10;
            this.btnSchedules.Text = "Schedules";
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStock.Location = new System.Drawing.Point(199, 34);
            this.btnStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(113, 56);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // tcNavigator
            // 
            this.tcNavigator.Controls.Add(this.tpStock);
            this.tcNavigator.Controls.Add(this.tpSchedules);
            this.tcNavigator.Controls.Add(this.tpEmployees);
            this.tcNavigator.Controls.Add(this.tpStatistics);
            this.tcNavigator.Controls.Add(this.tpStockAdd);
            this.tcNavigator.Location = new System.Drawing.Point(2, 85);
            this.tcNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.tcNavigator.Name = "tcNavigator";
            this.tcNavigator.SelectedIndex = 0;
            this.tcNavigator.Size = new System.Drawing.Size(720, 360);
            this.tcNavigator.TabIndex = 9;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.tbxSearchStock);
            this.tpStock.Controls.Add(this.lbxAllStock);
            this.tpStock.Controls.Add(this.btnDeleteStock);
            this.tpStock.Controls.Add(this.btnEditStock);
            this.tpStock.Controls.Add(this.btnSearchStock);
            this.tpStock.Controls.Add(this.btnAddStock);
            this.tpStock.Location = new System.Drawing.Point(4, 18);
            this.tpStock.Margin = new System.Windows.Forms.Padding(1);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(1);
            this.tpStock.Size = new System.Drawing.Size(712, 338);
            this.tpStock.TabIndex = 0;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchStock.Location = new System.Drawing.Point(449, 262);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(1);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(160, 30);
            this.tbxSearchStock.TabIndex = 11;
            this.tbxSearchStock.TabStop = false;
            // 
            // lbxAllStock
            // 
            this.lbxAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbxAllStock.FormattingEnabled = true;
            this.lbxAllStock.ItemHeight = 20;
            this.lbxAllStock.Location = new System.Drawing.Point(47, 44);
            this.lbxAllStock.Margin = new System.Windows.Forms.Padding(1);
            this.lbxAllStock.Name = "lbxAllStock";
            this.lbxAllStock.Size = new System.Drawing.Size(604, 204);
            this.lbxAllStock.TabIndex = 0;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnDeleteStock.Location = new System.Drawing.Point(271, 259);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(170, 35);
            this.btnDeleteStock.TabIndex = 10;
            this.btnDeleteStock.Text = "🗑️ Delete selected";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEditStock.Location = new System.Drawing.Point(137, 259);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(132, 35);
            this.btnEditStock.TabIndex = 10;
            this.btnEditStock.Text = "✎ Edit selected";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchStock.Location = new System.Drawing.Point(612, 259);
            this.btnSearchStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(36, 35);
            this.btnSearchStock.TabIndex = 10;
            this.btnSearchStock.Text = "🔍";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddStock.Location = new System.Drawing.Point(47, 259);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(87, 35);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "+ Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tpSchedules
            // 
            this.tpSchedules.Location = new System.Drawing.Point(4, 18);
            this.tpSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.tpSchedules.Name = "tpSchedules";
            this.tpSchedules.Padding = new System.Windows.Forms.Padding(1);
            this.tpSchedules.Size = new System.Drawing.Size(712, 338);
            this.tpSchedules.TabIndex = 1;
            this.tpSchedules.Text = "Schedules";
            this.tpSchedules.UseVisualStyleBackColor = true;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Location = new System.Drawing.Point(4, 18);
            this.tpEmployees.Margin = new System.Windows.Forms.Padding(1);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(1);
            this.tpEmployees.Size = new System.Drawing.Size(712, 338);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // tpStatistics
            // 
            this.tpStatistics.Location = new System.Drawing.Point(4, 18);
            this.tpStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.Padding = new System.Windows.Forms.Padding(1);
            this.tpStatistics.Size = new System.Drawing.Size(712, 338);
            this.tpStatistics.TabIndex = 3;
            this.tpStatistics.Text = "Statistics";
            this.tpStatistics.UseVisualStyleBackColor = true;
            // 
            // tpStockAdd
            // 
            this.tpStockAdd.Controls.Add(this.btnBackToStockPage);
            this.tpStockAdd.Controls.Add(this.btnStockAdd_ConfirmEdit);
            this.tpStockAdd.Controls.Add(this.btnStockAdd_ConfirmAdd);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_TotalSold);
            this.tpStockAdd.Controls.Add(this.label10);
            this.tpStockAdd.Controls.Add(this.label9);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_ID);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_Sell);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_AddInfo);
            this.tpStockAdd.Controls.Add(this.label1);
            this.tpStockAdd.Controls.Add(this.label4);
            this.tpStockAdd.Controls.Add(this.label5);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_MinimumStock);
            this.tpStockAdd.Controls.Add(this.label6);
            this.tpStockAdd.Controls.Add(this.label7);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_Cost);
            this.tpStockAdd.Controls.Add(this.label8);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_WarehouseLocation);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_StoreLocation);
            this.tpStockAdd.Controls.Add(this.lblStockAdd_Store);
            this.tpStockAdd.Controls.Add(this.lblStockAdd_Warehouse);
            this.tpStockAdd.Controls.Add(this.lblStockAdd_WarehouseLocation);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_StoreQuantity);
            this.tpStockAdd.Controls.Add(this.label3);
            this.tpStockAdd.Controls.Add(this.label2);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_WarehouseQuantity);
            this.tpStockAdd.Controls.Add(this.lblStockAdd_WarehouseQuantity);
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_ProductName);
            this.tpStockAdd.Controls.Add(this.lblProductAdd_StockName);
            this.tpStockAdd.Location = new System.Drawing.Point(4, 18);
            this.tpStockAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tpStockAdd.Name = "tpStockAdd";
            this.tpStockAdd.Padding = new System.Windows.Forms.Padding(1);
            this.tpStockAdd.Size = new System.Drawing.Size(712, 338);
            this.tpStockAdd.TabIndex = 4;
            this.tpStockAdd.Text = "StockAdd";
            this.tpStockAdd.UseVisualStyleBackColor = true;
            // 
            // btnStockAdd_ConfirmEdit
            // 
            this.btnStockAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmEdit.Location = new System.Drawing.Point(536, 287);
            this.btnStockAdd_ConfirmEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btnStockAdd_ConfirmEdit.Name = "btnStockAdd_ConfirmEdit";
            this.btnStockAdd_ConfirmEdit.Size = new System.Drawing.Size(158, 35);
            this.btnStockAdd_ConfirmEdit.TabIndex = 19;
            this.btnStockAdd_ConfirmEdit.Text = "✎ Edit (Confirm)";
            this.btnStockAdd_ConfirmEdit.UseVisualStyleBackColor = true;
            this.btnStockAdd_ConfirmEdit.Click += new System.EventHandler(this.btnStockAdd_ConfirmEdit_Click);
            // 
            // btnStockAdd_ConfirmAdd
            // 
            this.btnStockAdd_ConfirmAdd.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmAdd.Location = new System.Drawing.Point(536, 287);
            this.btnStockAdd_ConfirmAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnStockAdd_ConfirmAdd.Name = "btnStockAdd_ConfirmAdd";
            this.btnStockAdd_ConfirmAdd.Size = new System.Drawing.Size(158, 35);
            this.btnStockAdd_ConfirmAdd.TabIndex = 18;
            this.btnStockAdd_ConfirmAdd.Text = "+ Add (Confirm)";
            this.btnStockAdd_ConfirmAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd_ConfirmAdd.Click += new System.EventHandler(this.btnStockAdd_ConfirmAdd_Click);
            // 
            // tbxStockAdd_TotalSold
            // 
            this.tbxStockAdd_TotalSold.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_TotalSold.Location = new System.Drawing.Point(536, 241);
            this.tbxStockAdd_TotalSold.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_TotalSold.Name = "tbxStockAdd_TotalSold";
            this.tbxStockAdd_TotalSold.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_TotalSold.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.Location = new System.Drawing.Point(354, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.Location = new System.Drawing.Point(37, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID";
            // 
            // tbxStockAdd_ID
            // 
            this.tbxStockAdd_ID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ID.Location = new System.Drawing.Point(219, 18);
            this.tbxStockAdd_ID.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_ID.Name = "tbxStockAdd_ID";
            this.tbxStockAdd_ID.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_ID.TabIndex = 13;
            // 
            // tbxStockAdd_Sell
            // 
            this.tbxStockAdd_Sell.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Sell.Location = new System.Drawing.Point(536, 51);
            this.tbxStockAdd_Sell.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_Sell.Name = "tbxStockAdd_Sell";
            this.tbxStockAdd_Sell.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_Sell.TabIndex = 7;
            // 
            // tbxStockAdd_AddInfo
            // 
            this.tbxStockAdd_AddInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_AddInfo.Location = new System.Drawing.Point(358, 167);
            this.tbxStockAdd_AddInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_AddInfo.Multiline = true;
            this.tbxStockAdd_AddInfo.Name = "tbxStockAdd_AddInfo";
            this.tbxStockAdd_AddInfo.Size = new System.Drawing.Size(281, 70);
            this.tbxStockAdd_AddInfo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(364, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(364, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(354, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price";
            // 
            // tbxStockAdd_MinimumStock
            // 
            this.tbxStockAdd_MinimumStock.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_MinimumStock.Location = new System.Drawing.Point(536, 109);
            this.tbxStockAdd_MinimumStock.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_MinimumStock.Name = "tbxStockAdd_MinimumStock";
            this.tbxStockAdd_MinimumStock.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_MinimumStock.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(354, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(354, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Minimum Stock Required";
            // 
            // tbxStockAdd_Cost
            // 
            this.tbxStockAdd_Cost.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Cost.Location = new System.Drawing.Point(536, 24);
            this.tbxStockAdd_Cost.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_Cost.Name = "tbxStockAdd_Cost";
            this.tbxStockAdd_Cost.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_Cost.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(354, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cost Price";
            // 
            // tbxStockAdd_WarehouseLocation
            // 
            this.tbxStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseLocation.Location = new System.Drawing.Point(219, 131);
            this.tbxStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_WarehouseLocation.Name = "tbxStockAdd_WarehouseLocation";
            this.tbxStockAdd_WarehouseLocation.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_WarehouseLocation.TabIndex = 3;
            // 
            // tbxStockAdd_StoreLocation
            // 
            this.tbxStockAdd_StoreLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreLocation.Location = new System.Drawing.Point(219, 236);
            this.tbxStockAdd_StoreLocation.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_StoreLocation.Name = "tbxStockAdd_StoreLocation";
            this.tbxStockAdd_StoreLocation.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_StoreLocation.TabIndex = 5;
            // 
            // lblStockAdd_Store
            // 
            this.lblStockAdd_Store.AutoSize = true;
            this.lblStockAdd_Store.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Store.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Store.Location = new System.Drawing.Point(47, 185);
            this.lblStockAdd_Store.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStockAdd_Store.Name = "lblStockAdd_Store";
            this.lblStockAdd_Store.Size = new System.Drawing.Size(42, 16);
            this.lblStockAdd_Store.TabIndex = 0;
            this.lblStockAdd_Store.Text = "Store";
            // 
            // lblStockAdd_Warehouse
            // 
            this.lblStockAdd_Warehouse.AutoSize = true;
            this.lblStockAdd_Warehouse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Warehouse.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Warehouse.Location = new System.Drawing.Point(47, 85);
            this.lblStockAdd_Warehouse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStockAdd_Warehouse.Name = "lblStockAdd_Warehouse";
            this.lblStockAdd_Warehouse.Size = new System.Drawing.Size(80, 16);
            this.lblStockAdd_Warehouse.TabIndex = 0;
            this.lblStockAdd_Warehouse.Text = "Warehouse";
            // 
            // lblStockAdd_WarehouseLocation
            // 
            this.lblStockAdd_WarehouseLocation.AutoSize = true;
            this.lblStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseLocation.Location = new System.Drawing.Point(37, 133);
            this.lblStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStockAdd_WarehouseLocation.Name = "lblStockAdd_WarehouseLocation";
            this.lblStockAdd_WarehouseLocation.Size = new System.Drawing.Size(189, 22);
            this.lblStockAdd_WarehouseLocation.TabIndex = 0;
            this.lblStockAdd_WarehouseLocation.Text = "Warehouse Location ";
            // 
            // tbxStockAdd_StoreQuantity
            // 
            this.tbxStockAdd_StoreQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreQuantity.Location = new System.Drawing.Point(219, 208);
            this.tbxStockAdd_StoreQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_StoreQuantity.Name = "tbxStockAdd_StoreQuantity";
            this.tbxStockAdd_StoreQuantity.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_StoreQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store Location ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(37, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Quantity";
            // 
            // tbxStockAdd_WarehouseQuantity
            // 
            this.tbxStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(219, 104);
            this.tbxStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_WarehouseQuantity.Name = "tbxStockAdd_WarehouseQuantity";
            this.tbxStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_WarehouseQuantity.TabIndex = 2;
            // 
            // lblStockAdd_WarehouseQuantity
            // 
            this.lblStockAdd_WarehouseQuantity.AutoSize = true;
            this.lblStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(37, 105);
            this.lblStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStockAdd_WarehouseQuantity.Name = "lblStockAdd_WarehouseQuantity";
            this.lblStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(180, 22);
            this.lblStockAdd_WarehouseQuantity.TabIndex = 0;
            this.lblStockAdd_WarehouseQuantity.Text = "Warehouse Quantity";
            // 
            // tbxStockAdd_ProductName
            // 
            this.tbxStockAdd_ProductName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ProductName.Location = new System.Drawing.Point(219, 46);
            this.tbxStockAdd_ProductName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStockAdd_ProductName.Name = "tbxStockAdd_ProductName";
            this.tbxStockAdd_ProductName.Size = new System.Drawing.Size(103, 29);
            this.tbxStockAdd_ProductName.TabIndex = 1;
            // 
            // lblProductAdd_StockName
            // 
            this.lblProductAdd_StockName.AutoSize = true;
            this.lblProductAdd_StockName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblProductAdd_StockName.Location = new System.Drawing.Point(37, 46);
            this.lblProductAdd_StockName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductAdd_StockName.Name = "lblProductAdd_StockName";
            this.lblProductAdd_StockName.Size = new System.Drawing.Size(128, 22);
            this.lblProductAdd_StockName.TabIndex = 0;
            this.lblProductAdd_StockName.Text = "Product name";
            // 
            // textBox_defocus
            // 
            this.textBox_defocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_defocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defocus.Location = new System.Drawing.Point(0, 0);
            this.textBox_defocus.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_defocus.Name = "textBox_defocus";
            this.textBox_defocus.Size = new System.Drawing.Size(2, 9);
            this.textBox_defocus.TabIndex = 0;
            this.textBox_defocus.TabStop = false;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlBar.Controls.Add(this.pnlDragBar);
            this.pnlBar.Controls.Add(this.lblClose);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBar.Location = new System.Drawing.Point(-1, -1);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(731, 32);
            this.pnlBar.TabIndex = 8;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(3, 0);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(698, 31);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(704, 1);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnBackToStockPage
            // 
            this.btnBackToStockPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToStockPage.Location = new System.Drawing.Point(17, 287);
            this.btnBackToStockPage.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackToStockPage.Name = "btnBackToStockPage";
            this.btnBackToStockPage.Size = new System.Drawing.Size(158, 35);
            this.btnBackToStockPage.TabIndex = 20;
            this.btnBackToStockPage.Text = "<- Back to Stock";
            this.btnBackToStockPage.UseVisualStyleBackColor = true;
            this.btnBackToStockPage.Click += new System.EventHandler(this.btnBackToStockPage_click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.tcNavigator.ResumeLayout(false);
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
            this.tpStockAdd.ResumeLayout(false);
            this.tpStockAdd.PerformLayout();
            this.pnlBar.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbxAllStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TabPage tpStockAdd;
        private System.Windows.Forms.TextBox tbxStockAdd_ProductName;
        private System.Windows.Forms.Label lblProductAdd_StockName;
        private System.Windows.Forms.TextBox tbxStockAdd_WarehouseQuantity;
        private System.Windows.Forms.Label lblStockAdd_WarehouseQuantity;
        private System.Windows.Forms.TextBox tbxStockAdd_WarehouseLocation;
        private System.Windows.Forms.TextBox tbxStockAdd_StoreLocation;
        private System.Windows.Forms.Label lblStockAdd_Store;
        private System.Windows.Forms.Label lblStockAdd_Warehouse;
        private System.Windows.Forms.Label lblStockAdd_WarehouseLocation;
        private System.Windows.Forms.TextBox tbxStockAdd_StoreQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStockAdd_Sell;
        private System.Windows.Forms.TextBox tbxStockAdd_AddInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStockAdd_MinimumStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxStockAdd_Cost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxStockAdd_ID;
        private System.Windows.Forms.TextBox tbxStockAdd_TotalSold;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStockAdd_ConfirmAdd;
        private System.Windows.Forms.Button btnStockAdd_ConfirmEdit;
        private System.Windows.Forms.Button btnBackToStockPage;
    }
}