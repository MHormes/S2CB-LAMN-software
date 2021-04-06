
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlTabCover = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMediaBazaar = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.tcNavigator = new System.Windows.Forms.TabControl();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.dgvAllStock = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityWH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationWH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStock_ReActivateProduct = new System.Windows.Forms.Button();
            this.cbxStockCurrentlyShowing = new System.Windows.Forms.ComboBox();
            this.lblStockCurrentlyShowing = new System.Windows.Forms.Label();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnDeActivateStock = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tpSchedules = new System.Windows.Forms.TabPage();
            this.button_loadTemplate = new System.Windows.Forms.Button();
            this.button_saveAsTemplate = new System.Windows.Forms.Button();
            this.lblScheduleCurrentWeek = new System.Windows.Forms.Label();
            this.btnScheduleSaveCurrentWeek = new System.Windows.Forms.Button();
            this.nudScheduleWeek = new System.Windows.Forms.NumericUpDown();
            this.btnSchedulesShowWeek = new System.Windows.Forms.Button();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.schedulesFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesMonday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesTuesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesWednesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesThursday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesFriday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesSaturday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesSunday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.cbxActiveInactiveEmployees = new System.Windows.Forms.ComboBox();
            this.lblActiveInactiveEmployees = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvEmployeeObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalaryPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIceRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuittingReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tpStatsStock = new System.Windows.Forms.TabPage();
            this.btnDeselectStatsStock3 = new System.Windows.Forms.Button();
            this.btnDeselectStatsStock2 = new System.Windows.Forms.Button();
            this.btnDeselectStatsStock1 = new System.Windows.Forms.Button();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxStats3 = new System.Windows.Forms.ComboBox();
            this.cbxStats2 = new System.Windows.Forms.ComboBox();
            this.cbxStats1 = new System.Windows.Forms.ComboBox();
            this.tpStockAdd = new System.Windows.Forms.TabPage();
            this.tbxStockAdd_EANCode = new System.Windows.Forms.TextBox();
            this.lblStockAddEAN = new System.Windows.Forms.Label();
            this.btnBackToStockPage = new System.Windows.Forms.Button();
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
            this.tpEmployeeAdd = new System.Windows.Forms.TabPage();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.btnEmployeeAdd_ConfirmEdit = new System.Windows.Forms.Button();
            this.lblEmployeeAdd_Details = new System.Windows.Forms.Label();
            this.cbxEmployeeAdd_Position = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeAdd_ICERelationship = new System.Windows.Forms.ComboBox();
            this.dtpEmployeeAdd_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnBackToEmpPage = new System.Windows.Forms.Button();
            this.btnEmployeeAdd_Confirm = new System.Windows.Forms.Button();
            this.lblEmployeeAdd_FirstName = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_FirstName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeAdd_AdditonalInfo = new System.Windows.Forms.TextBox();
            this.lblEmployeeAdd_ICE = new System.Windows.Forms.Label();
            this.lblEmployeeAdd_ICERelationship = new System.Windows.Forms.Label();
            this.lblEmployeeAdd_AdditionalInfo = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_ICENumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeAdd_ICENumber = new System.Windows.Forms.Label();
            this.lblEmployeeAdd_Name = new System.Windows.Forms.Label();
            this.lblEmployeeAdd_DateOfBirth = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeAdd_Position = new System.Windows.Forms.Label();
            this.lblEmployeeAdd_PhoneNumber = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_BSN = new System.Windows.Forms.TextBox();
            this.lblEmployeeAdd_BSN = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_SecondName = new System.Windows.Forms.TextBox();
            this.lblEmployeeAdd_SecondName = new System.Windows.Forms.Label();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.gpnlStatsType = new LAMN_Software.GradientPanel();
            this.cbxStatsType = new System.Windows.Forms.ComboBox();
            this.gpnlStatistics = new LAMN_Software.GradientPanel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.gpnlSchedules = new LAMN_Software.GradientPanel();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.gpnlStock = new LAMN_Software.GradientPanel();
            this.btnStock = new System.Windows.Forms.Button();
            this.gpnlEmployees = new LAMN_Software.GradientPanel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlTabCover.SuspendLayout();
            this.tcNavigator.SuspendLayout();
            this.tpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).BeginInit();
            this.tpSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScheduleWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tpStatsStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.tpStockAdd.SuspendLayout();
            this.tpEmployeeAdd.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.gpnlStatsType.SuspendLayout();
            this.gpnlStatistics.SuspendLayout();
            this.gpnlSchedules.SuspendLayout();
            this.gpnlStock.SuspendLayout();
            this.gpnlEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Gray;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.pnlTabCover);
            this.pnlBackground.Controls.Add(this.tcNavigator);
            this.pnlBackground.Controls.Add(this.textBox_defocus);
            this.pnlBackground.Controls.Add(this.pnlBar);
            this.pnlBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(5);
            this.pnlBackground.MaximumSize = new System.Drawing.Size(3074, 1643);
            this.pnlBackground.MinimumSize = new System.Drawing.Size(3074, 1643);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(3074, 1643);
            this.pnlBackground.TabIndex = 9;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // pnlTabCover
            // 
            this.pnlTabCover.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabCover.Controls.Add(this.gpnlStatsType);
            this.pnlTabCover.Controls.Add(this.gpnlStatistics);
            this.pnlTabCover.Controls.Add(this.btnLogout);
            this.pnlTabCover.Controls.Add(this.lblMediaBazaar);
            this.pnlTabCover.Controls.Add(this.lblMB);
            this.pnlTabCover.Controls.Add(this.gpnlSchedules);
            this.pnlTabCover.Controls.Add(this.gpnlStock);
            this.pnlTabCover.Controls.Add(this.gpnlEmployees);
            this.pnlTabCover.Location = new System.Drawing.Point(3, 69);
            this.pnlTabCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTabCover.Name = "pnlTabCover";
            this.pnlTabCover.Size = new System.Drawing.Size(3067, 169);
            this.pnlTabCover.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(2768, 21);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 93);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMediaBazaar
            // 
            this.lblMediaBazaar.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaBazaar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.lblMediaBazaar.ForeColor = System.Drawing.Color.White;
            this.lblMediaBazaar.Location = new System.Drawing.Point(69, 112);
            this.lblMediaBazaar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMediaBazaar.Name = "lblMediaBazaar";
            this.lblMediaBazaar.Size = new System.Drawing.Size(269, 45);
            this.lblMediaBazaar.TabIndex = 14;
            this.lblMediaBazaar.Text = "Media Bazaar";
            // 
            // lblMB
            // 
            this.lblMB.BackColor = System.Drawing.Color.Transparent;
            this.lblMB.Font = new System.Drawing.Font("Arial Black", 35F);
            this.lblMB.ForeColor = System.Drawing.Color.White;
            this.lblMB.Location = new System.Drawing.Point(53, 2);
            this.lblMB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(312, 114);
            this.lblMB.TabIndex = 11;
            this.lblMB.Text = "MB";
            // 
            // tcNavigator
            // 
            this.tcNavigator.Controls.Add(this.tpStock);
            this.tcNavigator.Controls.Add(this.tpSchedules);
            this.tcNavigator.Controls.Add(this.tpEmployees);
            this.tcNavigator.Controls.Add(this.tpStatsStock);
            this.tcNavigator.Controls.Add(this.tpStockAdd);
            this.tcNavigator.Controls.Add(this.tpEmployeeAdd);
            this.tcNavigator.Location = new System.Drawing.Point(32, 248);
            this.tcNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcNavigator.Name = "tcNavigator";
            this.tcNavigator.SelectedIndex = 0;
            this.tcNavigator.Size = new System.Drawing.Size(3016, 1388);
            this.tcNavigator.TabIndex = 9;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.dgvAllStock);
            this.tpStock.Controls.Add(this.btnStock_ReActivateProduct);
            this.tpStock.Controls.Add(this.cbxStockCurrentlyShowing);
            this.tpStock.Controls.Add(this.lblStockCurrentlyShowing);
            this.tpStock.Controls.Add(this.tbxSearchStock);
            this.tpStock.Controls.Add(this.btnDeActivateStock);
            this.tpStock.Controls.Add(this.btnEditStock);
            this.tpStock.Controls.Add(this.btnSearchStock);
            this.tpStock.Controls.Add(this.btnAddStock);
            this.tpStock.Location = new System.Drawing.Point(10, 42);
            this.tpStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStock.Size = new System.Drawing.Size(2996, 1336);
            this.tpStock.TabIndex = 0;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // dgvAllStock
            // 
            this.dgvAllStock.AllowUserToAddRows = false;
            this.dgvAllStock.AllowUserToDeleteRows = false;
            this.dgvAllStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EAN,
            this.Name,
            this.QuantityS,
            this.LocationS,
            this.QuantityWH,
            this.LocationWH,
            this.CostPrice,
            this.SellPrice,
            this.MinimumStock,
            this.TotalSold});
            this.dgvAllStock.Location = new System.Drawing.Point(13, 74);
            this.dgvAllStock.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvAllStock.Name = "dgvAllStock";
            this.dgvAllStock.ReadOnly = true;
            this.dgvAllStock.RowHeadersWidth = 102;
            this.dgvAllStock.Size = new System.Drawing.Size(2971, 1159);
            this.dgvAllStock.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 250;
            // 
            // EAN
            // 
            this.EAN.HeaderText = "EAN";
            this.EAN.MinimumWidth = 12;
            this.EAN.Name = "EAN";
            this.EAN.ReadOnly = true;
            this.EAN.Width = 250;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 12;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 250;
            // 
            // QuantityS
            // 
            this.QuantityS.HeaderText = "Quantity in Store";
            this.QuantityS.MinimumWidth = 12;
            this.QuantityS.Name = "QuantityS";
            this.QuantityS.ReadOnly = true;
            this.QuantityS.Width = 250;
            // 
            // LocationS
            // 
            this.LocationS.HeaderText = "Location in Store";
            this.LocationS.MinimumWidth = 12;
            this.LocationS.Name = "LocationS";
            this.LocationS.ReadOnly = true;
            this.LocationS.Width = 250;
            // 
            // QuantityWH
            // 
            this.QuantityWH.HeaderText = "Quantity in the warehouse";
            this.QuantityWH.MinimumWidth = 12;
            this.QuantityWH.Name = "QuantityWH";
            this.QuantityWH.ReadOnly = true;
            this.QuantityWH.Width = 250;
            // 
            // LocationWH
            // 
            this.LocationWH.HeaderText = "Location in the warehouse";
            this.LocationWH.MinimumWidth = 12;
            this.LocationWH.Name = "LocationWH";
            this.LocationWH.ReadOnly = true;
            this.LocationWH.Width = 250;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost price";
            this.CostPrice.MinimumWidth = 12;
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Width = 250;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Sell price";
            this.SellPrice.MinimumWidth = 12;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            this.SellPrice.Width = 250;
            // 
            // MinimumStock
            // 
            this.MinimumStock.HeaderText = "Minimum stock required";
            this.MinimumStock.MinimumWidth = 12;
            this.MinimumStock.Name = "MinimumStock";
            this.MinimumStock.ReadOnly = true;
            this.MinimumStock.Width = 250;
            // 
            // TotalSold
            // 
            this.TotalSold.HeaderText = "Total amount sold";
            this.TotalSold.MinimumWidth = 12;
            this.TotalSold.Name = "TotalSold";
            this.TotalSold.ReadOnly = true;
            this.TotalSold.Width = 250;
            // 
            // btnStock_ReActivateProduct
            // 
            this.btnStock_ReActivateProduct.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStock_ReActivateProduct.Location = new System.Drawing.Point(1176, 1250);
            this.btnStock_ReActivateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock_ReActivateProduct.Name = "btnStock_ReActivateProduct";
            this.btnStock_ReActivateProduct.Size = new System.Drawing.Size(808, 83);
            this.btnStock_ReActivateProduct.TabIndex = 14;
            this.btnStock_ReActivateProduct.Text = "Reactivate the selected product";
            this.btnStock_ReActivateProduct.UseVisualStyleBackColor = true;
            this.btnStock_ReActivateProduct.Click += new System.EventHandler(this.btnStock_ReActivateProduct_Click);
            // 
            // cbxStockCurrentlyShowing
            // 
            this.cbxStockCurrentlyShowing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStockCurrentlyShowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxStockCurrentlyShowing.FormattingEnabled = true;
            this.cbxStockCurrentlyShowing.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbxStockCurrentlyShowing.Location = new System.Drawing.Point(813, 10);
            this.cbxStockCurrentlyShowing.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbxStockCurrentlyShowing.Name = "cbxStockCurrentlyShowing";
            this.cbxStockCurrentlyShowing.Size = new System.Drawing.Size(316, 59);
            this.cbxStockCurrentlyShowing.TabIndex = 13;
            this.cbxStockCurrentlyShowing.SelectedIndexChanged += new System.EventHandler(this.cbxStockCurrentlyShowing_SelectedIndexChanged);
            // 
            // lblStockCurrentlyShowing
            // 
            this.lblStockCurrentlyShowing.AutoSize = true;
            this.lblStockCurrentlyShowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStockCurrentlyShowing.Location = new System.Drawing.Point(11, 12);
            this.lblStockCurrentlyShowing.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStockCurrentlyShowing.Name = "lblStockCurrentlyShowing";
            this.lblStockCurrentlyShowing.Size = new System.Drawing.Size(717, 52);
            this.lblStockCurrentlyShowing.TabIndex = 12;
            this.lblStockCurrentlyShowing.Text = "Curerntly showing all items that are:";
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchStock.Location = new System.Drawing.Point(2453, 1250);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(420, 65);
            this.tbxSearchStock.TabIndex = 11;
            this.tbxSearchStock.TabStop = false;
            this.tbxSearchStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearchStock_KeyPress);
            // 
            // btnDeActivateStock
            // 
            this.btnDeActivateStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnDeActivateStock.Location = new System.Drawing.Point(1176, 1250);
            this.btnDeActivateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeActivateStock.Name = "btnDeActivateStock";
            this.btnDeActivateStock.Size = new System.Drawing.Size(808, 83);
            this.btnDeActivateStock.TabIndex = 10;
            this.btnDeActivateStock.Text = "🗑️ Deactivate the selected product";
            this.btnDeActivateStock.UseVisualStyleBackColor = true;
            this.btnDeActivateStock.Click += new System.EventHandler(this.btnDeActivateStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEditStock.Location = new System.Drawing.Point(533, 1250);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(637, 83);
            this.btnEditStock.TabIndex = 10;
            this.btnEditStock.Text = "✎ Edit the selected product";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchStock.Location = new System.Drawing.Point(2888, 1242);
            this.btnSearchStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(96, 83);
            this.btnSearchStock.TabIndex = 10;
            this.btnSearchStock.Text = "🔍";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddStock.Location = new System.Drawing.Point(16, 1247);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(512, 83);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "+ Add a new product";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tpSchedules
            // 
            this.tpSchedules.Controls.Add(this.button_loadTemplate);
            this.tpSchedules.Controls.Add(this.button_saveAsTemplate);
            this.tpSchedules.Controls.Add(this.lblScheduleCurrentWeek);
            this.tpSchedules.Controls.Add(this.btnScheduleSaveCurrentWeek);
            this.tpSchedules.Controls.Add(this.nudScheduleWeek);
            this.tpSchedules.Controls.Add(this.btnSchedulesShowWeek);
            this.tpSchedules.Controls.Add(this.dgvSchedules);
            this.tpSchedules.Location = new System.Drawing.Point(10, 42);
            this.tpSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedules.Name = "tpSchedules";
            this.tpSchedules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedules.Size = new System.Drawing.Size(2996, 1336);
            this.tpSchedules.TabIndex = 1;
            this.tpSchedules.Text = "Schedules";
            this.tpSchedules.UseVisualStyleBackColor = true;
            // 
            // button_loadTemplate
            // 
            this.button_loadTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_loadTemplate.Location = new System.Drawing.Point(1715, 1173);
            this.button_loadTemplate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_loadTemplate.Name = "button_loadTemplate";
            this.button_loadTemplate.Size = new System.Drawing.Size(325, 148);
            this.button_loadTemplate.TabIndex = 19;
            this.button_loadTemplate.Text = "Load template for current week";
            this.button_loadTemplate.UseVisualStyleBackColor = true;
            this.button_loadTemplate.Click += new System.EventHandler(this.button_loadTemplate_Click);
            // 
            // button_saveAsTemplate
            // 
            this.button_saveAsTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_saveAsTemplate.Location = new System.Drawing.Point(2293, 1178);
            this.button_saveAsTemplate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_saveAsTemplate.Name = "button_saveAsTemplate";
            this.button_saveAsTemplate.Size = new System.Drawing.Size(325, 148);
            this.button_saveAsTemplate.TabIndex = 18;
            this.button_saveAsTemplate.Text = "Save current week as template";
            this.button_saveAsTemplate.UseVisualStyleBackColor = true;
            this.button_saveAsTemplate.Click += new System.EventHandler(this.button_saveAsTemplate_Click);
            // 
            // lblScheduleCurrentWeek
            // 
            this.lblScheduleCurrentWeek.AutoSize = true;
            this.lblScheduleCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblScheduleCurrentWeek.Location = new System.Drawing.Point(13, 12);
            this.lblScheduleCurrentWeek.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblScheduleCurrentWeek.Name = "lblScheduleCurrentWeek";
            this.lblScheduleCurrentWeek.Size = new System.Drawing.Size(454, 46);
            this.lblScheduleCurrentWeek.TabIndex = 17;
            this.lblScheduleCurrentWeek.Text = "Currently showing week:";
            // 
            // btnScheduleSaveCurrentWeek
            // 
            this.btnScheduleSaveCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleSaveCurrentWeek.Location = new System.Drawing.Point(2659, 1178);
            this.btnScheduleSaveCurrentWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnScheduleSaveCurrentWeek.Name = "btnScheduleSaveCurrentWeek";
            this.btnScheduleSaveCurrentWeek.Size = new System.Drawing.Size(325, 148);
            this.btnScheduleSaveCurrentWeek.TabIndex = 16;
            this.btnScheduleSaveCurrentWeek.Text = "Save current week";
            this.btnScheduleSaveCurrentWeek.UseVisualStyleBackColor = true;
            this.btnScheduleSaveCurrentWeek.Click += new System.EventHandler(this.btnScheduleSaveCurrentWeek_Click);
            // 
            // nudScheduleWeek
            // 
            this.nudScheduleWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudScheduleWeek.Location = new System.Drawing.Point(11, 1271);
            this.nudScheduleWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nudScheduleWeek.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nudScheduleWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScheduleWeek.Name = "nudScheduleWeek";
            this.nudScheduleWeek.Size = new System.Drawing.Size(320, 45);
            this.nudScheduleWeek.TabIndex = 15;
            this.nudScheduleWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSchedulesShowWeek
            // 
            this.btnSchedulesShowWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesShowWeek.Location = new System.Drawing.Point(11, 1147);
            this.btnSchedulesShowWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesShowWeek.Name = "btnSchedulesShowWeek";
            this.btnSchedulesShowWeek.Size = new System.Drawing.Size(325, 110);
            this.btnSchedulesShowWeek.TabIndex = 14;
            this.btnSchedulesShowWeek.Text = "Show schedules for chosen week";
            this.btnSchedulesShowWeek.UseVisualStyleBackColor = true;
            this.btnSchedulesShowWeek.Click += new System.EventHandler(this.btnSchedulesShowWeek_Click);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedulesFirstName,
            this.schedulesMonday,
            this.schedulesTuesday,
            this.schedulesWednesday,
            this.schedulesThursday,
            this.schedulesFriday,
            this.schedulesSaturday,
            this.schedulesSunday});
            this.dgvSchedules.Location = new System.Drawing.Point(0, 62);
            this.dgvSchedules.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSchedules.Size = new System.Drawing.Size(2819, 1071);
            this.dgvSchedules.TabIndex = 13;
            // 
            // schedulesFirstName
            // 
            this.schedulesFirstName.HeaderText = "First Name";
            this.schedulesFirstName.MinimumWidth = 6;
            this.schedulesFirstName.Name = "schedulesFirstName";
            this.schedulesFirstName.ReadOnly = true;
            this.schedulesFirstName.Width = 125;
            // 
            // schedulesMonday
            // 
            this.schedulesMonday.HeaderText = "Monday";
            this.schedulesMonday.Items.AddRange(new object[] {
            "M",
            "A",
            "E"});
            this.schedulesMonday.MinimumWidth = 6;
            this.schedulesMonday.Name = "schedulesMonday";
            this.schedulesMonday.Width = 125;
            // 
            // schedulesTuesday
            // 
            this.schedulesTuesday.HeaderText = "Tuesday";
            this.schedulesTuesday.MinimumWidth = 6;
            this.schedulesTuesday.Name = "schedulesTuesday";
            this.schedulesTuesday.Width = 125;
            // 
            // schedulesWednesday
            // 
            this.schedulesWednesday.HeaderText = "Wednesday";
            this.schedulesWednesday.MinimumWidth = 6;
            this.schedulesWednesday.Name = "schedulesWednesday";
            this.schedulesWednesday.Width = 125;
            // 
            // schedulesThursday
            // 
            this.schedulesThursday.HeaderText = "Thursday";
            this.schedulesThursday.MinimumWidth = 6;
            this.schedulesThursday.Name = "schedulesThursday";
            this.schedulesThursday.Width = 125;
            // 
            // schedulesFriday
            // 
            this.schedulesFriday.HeaderText = "Friday";
            this.schedulesFriday.MinimumWidth = 6;
            this.schedulesFriday.Name = "schedulesFriday";
            this.schedulesFriday.Width = 125;
            // 
            // schedulesSaturday
            // 
            this.schedulesSaturday.HeaderText = "Saturday";
            this.schedulesSaturday.MinimumWidth = 6;
            this.schedulesSaturday.Name = "schedulesSaturday";
            this.schedulesSaturday.Width = 125;
            // 
            // schedulesSunday
            // 
            this.schedulesSunday.HeaderText = "Sunday";
            this.schedulesSunday.MinimumWidth = 6;
            this.schedulesSunday.Name = "schedulesSunday";
            this.schedulesSunday.Width = 125;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Controls.Add(this.cbxActiveInactiveEmployees);
            this.tpEmployees.Controls.Add(this.lblActiveInactiveEmployees);
            this.tpEmployees.Controls.Add(this.dgvEmployees);
            this.tpEmployees.Controls.Add(this.tbxSearchEmployee);
            this.tpEmployees.Controls.Add(this.btnDeleteEmployee);
            this.tpEmployees.Controls.Add(this.btnEditEmployee);
            this.tpEmployees.Controls.Add(this.btnSearchEmployee);
            this.tpEmployees.Controls.Add(this.btnAddEmployee);
            this.tpEmployees.Location = new System.Drawing.Point(10, 42);
            this.tpEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployees.Size = new System.Drawing.Size(2996, 1336);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // cbxActiveInactiveEmployees
            // 
            this.cbxActiveInactiveEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActiveInactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxActiveInactiveEmployees.FormattingEnabled = true;
            this.cbxActiveInactiveEmployees.Items.AddRange(new object[] {
            "Active",
            "Terminated"});
            this.cbxActiveInactiveEmployees.Location = new System.Drawing.Point(985, 9);
            this.cbxActiveInactiveEmployees.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbxActiveInactiveEmployees.Name = "cbxActiveInactiveEmployees";
            this.cbxActiveInactiveEmployees.Size = new System.Drawing.Size(316, 59);
            this.cbxActiveInactiveEmployees.TabIndex = 21;
            this.cbxActiveInactiveEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxActiveInactiveEmployees_SelectedIndexChanged);
            // 
            // lblActiveInactiveEmployees
            // 
            this.lblActiveInactiveEmployees.AutoSize = true;
            this.lblActiveInactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblActiveInactiveEmployees.Location = new System.Drawing.Point(8, 12);
            this.lblActiveInactiveEmployees.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblActiveInactiveEmployees.Name = "lblActiveInactiveEmployees";
            this.lblActiveInactiveEmployees.Size = new System.Drawing.Size(823, 52);
            this.lblActiveInactiveEmployees.TabIndex = 20;
            this.lblActiveInactiveEmployees.Text = "Currently showing all employees that are:";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEmployeeObj,
            this.dgvFirstName,
            this.dgvSecondName,
            this.dgvPosition,
            this.dgvSalaryPerHour,
            this.dgvBsn,
            this.dgvDateOfBirth,
            this.dgvPhoneNumber,
            this.dgvEmail,
            this.dgvIceNumber,
            this.dgvIceRelation,
            this.dgvQuittingReason});
            this.dgvEmployees.Location = new System.Drawing.Point(8, 105);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 102;
            this.dgvEmployees.Size = new System.Drawing.Size(2971, 1116);
            this.dgvEmployees.TabIndex = 19;
            // 
            // dgvEmployeeObj
            // 
            this.dgvEmployeeObj.HeaderText = "Employee Object";
            this.dgvEmployeeObj.MinimumWidth = 12;
            this.dgvEmployeeObj.Name = "dgvEmployeeObj";
            this.dgvEmployeeObj.ReadOnly = true;
            this.dgvEmployeeObj.Visible = false;
            this.dgvEmployeeObj.Width = 250;
            // 
            // dgvFirstName
            // 
            this.dgvFirstName.HeaderText = "First name";
            this.dgvFirstName.MinimumWidth = 12;
            this.dgvFirstName.Name = "dgvFirstName";
            this.dgvFirstName.ReadOnly = true;
            this.dgvFirstName.Width = 250;
            // 
            // dgvSecondName
            // 
            this.dgvSecondName.HeaderText = "Second name";
            this.dgvSecondName.MinimumWidth = 12;
            this.dgvSecondName.Name = "dgvSecondName";
            this.dgvSecondName.ReadOnly = true;
            this.dgvSecondName.Width = 250;
            // 
            // dgvPosition
            // 
            this.dgvPosition.HeaderText = "Position";
            this.dgvPosition.MinimumWidth = 12;
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.Width = 250;
            // 
            // dgvSalaryPerHour
            // 
            this.dgvSalaryPerHour.HeaderText = "Salary per hour ";
            this.dgvSalaryPerHour.MinimumWidth = 12;
            this.dgvSalaryPerHour.Name = "dgvSalaryPerHour";
            this.dgvSalaryPerHour.ReadOnly = true;
            this.dgvSalaryPerHour.Width = 250;
            // 
            // dgvBsn
            // 
            this.dgvBsn.HeaderText = "BSN";
            this.dgvBsn.MinimumWidth = 12;
            this.dgvBsn.Name = "dgvBsn";
            this.dgvBsn.ReadOnly = true;
            this.dgvBsn.Width = 250;
            // 
            // dgvDateOfBirth
            // 
            this.dgvDateOfBirth.HeaderText = "Date of birth";
            this.dgvDateOfBirth.MinimumWidth = 12;
            this.dgvDateOfBirth.Name = "dgvDateOfBirth";
            this.dgvDateOfBirth.ReadOnly = true;
            this.dgvDateOfBirth.Width = 250;
            // 
            // dgvPhoneNumber
            // 
            this.dgvPhoneNumber.HeaderText = "Phone number";
            this.dgvPhoneNumber.MinimumWidth = 12;
            this.dgvPhoneNumber.Name = "dgvPhoneNumber";
            this.dgvPhoneNumber.ReadOnly = true;
            this.dgvPhoneNumber.Width = 250;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 12;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.Width = 250;
            // 
            // dgvIceNumber
            // 
            this.dgvIceNumber.HeaderText = "ICE number";
            this.dgvIceNumber.MinimumWidth = 12;
            this.dgvIceNumber.Name = "dgvIceNumber";
            this.dgvIceNumber.ReadOnly = true;
            this.dgvIceNumber.Width = 250;
            // 
            // dgvIceRelation
            // 
            this.dgvIceRelation.HeaderText = "ICE relation";
            this.dgvIceRelation.MinimumWidth = 12;
            this.dgvIceRelation.Name = "dgvIceRelation";
            this.dgvIceRelation.ReadOnly = true;
            this.dgvIceRelation.Width = 250;
            // 
            // dgvQuittingReason
            // 
            this.dgvQuittingReason.HeaderText = "Quitting reason";
            this.dgvQuittingReason.MinimumWidth = 12;
            this.dgvQuittingReason.Name = "dgvQuittingReason";
            this.dgvQuittingReason.ReadOnly = true;
            this.dgvQuittingReason.Width = 250;
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchEmployee.Location = new System.Drawing.Point(2459, 1247);
            this.tbxSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(420, 65);
            this.tbxSearchEmployee.TabIndex = 17;
            this.tbxSearchEmployee.TabStop = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Arial", 13F);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(603, 1247);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(475, 83);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "🗑️ Terminate selected";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEditEmployee.Location = new System.Drawing.Point(245, 1247);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(352, 83);
            this.btnEditEmployee.TabIndex = 14;
            this.btnEditEmployee.Text = "✎ Edit selected";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchEmployee.Location = new System.Drawing.Point(2893, 1242);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(96, 83);
            this.btnSearchEmployee.TabIndex = 15;
            this.btnSearchEmployee.Text = "🔍";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddEmployee.Location = new System.Drawing.Point(5, 1247);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(232, 83);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = "+ Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tpStatsStock
            // 
            this.tpStatistics.Controls.Add(this.btnDeselectStatsStock3);
            this.tpStatistics.Controls.Add(this.btnDeselectStatsStock2);
            this.tpStatistics.Controls.Add(this.btnDeselectStatsStock1);
            this.tpStatistics.Controls.Add(this.chartStock);
            this.tpStatistics.Controls.Add(this.cbxStats3);
            this.tpStatistics.Controls.Add(this.cbxStats2);
            this.tpStatistics.Controls.Add(this.cbxStats1);
            this.tpStatistics.Location = new System.Drawing.Point(10, 42);
            this.tpStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStatistics.Size = new System.Drawing.Size(2996, 1336);
            this.tpStatistics.TabIndex = 3;
            this.tpStatistics.Text = "Statistics";
            this.tpStatistics.UseVisualStyleBackColor = true;
            // 
            // btnDeselectStatsStock3
            // 
            this.btnDeselectStatsStock3.BackColor = System.Drawing.Color.Transparent;
            this.btnDeselectStatsStock3.FlatAppearance.BorderSize = 0;
            this.btnDeselectStatsStock3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectStatsStock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectStatsStock3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeselectStatsStock3.Location = new System.Drawing.Point(64, 489);
            this.btnDeselectStatsStock3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeselectStatsStock3.Name = "btnDeselectStatsStock3";
            this.btnDeselectStatsStock3.Size = new System.Drawing.Size(45, 62);
            this.btnDeselectStatsStock3.TabIndex = 5;
            this.btnDeselectStatsStock3.Text = "✖";
            this.btnDeselectStatsStock3.UseVisualStyleBackColor = false;
            this.btnDeselectStatsStock3.Visible = false;
            this.btnDeselectStatsStock3.Click += new System.EventHandler(this.btnDeselectStatsStock3_Click);
            // 
            // btnDeselectStatsStock2
            // 
            this.btnDeselectStatsStock2.BackColor = System.Drawing.Color.Transparent;
            this.btnDeselectStatsStock2.FlatAppearance.BorderSize = 0;
            this.btnDeselectStatsStock2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectStatsStock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectStatsStock2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeselectStatsStock2.Location = new System.Drawing.Point(64, 398);
            this.btnDeselectStatsStock2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeselectStatsStock2.Name = "btnDeselectStatsStock2";
            this.btnDeselectStatsStock2.Size = new System.Drawing.Size(45, 62);
            this.btnDeselectStatsStock2.TabIndex = 5;
            this.btnDeselectStatsStock2.Text = "✖";
            this.btnDeselectStatsStock2.UseVisualStyleBackColor = false;
            this.btnDeselectStatsStock2.Visible = false;
            this.btnDeselectStatsStock2.Click += new System.EventHandler(this.btnDeselectStatsStock2_Click);
            // 
            // btnDeselectStatsStock1
            // 
            this.btnDeselectStatsStock1.BackColor = System.Drawing.Color.Transparent;
            this.btnDeselectStatsStock1.FlatAppearance.BorderSize = 0;
            this.btnDeselectStatsStock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectStatsStock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectStatsStock1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeselectStatsStock1.Location = new System.Drawing.Point(64, 308);
            this.btnDeselectStatsStock1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeselectStatsStock1.Name = "btnDeselectStatsStock1";
            this.btnDeselectStatsStock1.Size = new System.Drawing.Size(45, 62);
            this.btnDeselectStatsStock1.TabIndex = 5;
            this.btnDeselectStatsStock1.Text = "✖";
            this.btnDeselectStatsStock1.UseVisualStyleBackColor = false;
            this.btnDeselectStatsStock1.Visible = false;
            this.btnDeselectStatsStock1.Click += new System.EventHandler(this.btnDeselectStatsStock1_Click);
            // 
            // chartStock
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(405, 200);
            this.chartStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Store Stock Total";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Warehouse Stock Total";
            series2.YValuesPerPoint = 6;
            this.chartStock.Series.Add(series1);
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(1549, 486);
            this.chartStock.TabIndex = 3;
            this.chartStock.Text = "Stock Chart";
            // 
            // cbxStats3
            // 
            this.cbxStats3.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats3.FormattingEnabled = true;
            this.cbxStats3.Location = new System.Drawing.Point(112, 489);
            this.cbxStats3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStats3.Name = "cbxStats3";
            this.cbxStats3.Size = new System.Drawing.Size(252, 65);
            this.cbxStats3.TabIndex = 1;
            this.cbxStats3.Text = "Stock 3";
            this.cbxStats3.SelectedIndexChanged += new System.EventHandler(this.cbxStats3_SelectedIndexChanged);
            // 
            // cbxStats2
            // 
            this.cbxStats2.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats2.FormattingEnabled = true;
            this.cbxStats2.Location = new System.Drawing.Point(112, 398);
            this.cbxStats2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStats2.Name = "cbxStats2";
            this.cbxStats2.Size = new System.Drawing.Size(252, 65);
            this.cbxStats2.TabIndex = 1;
            this.cbxStats2.Text = "Stock 2";
            this.cbxStats2.SelectedIndexChanged += new System.EventHandler(this.cbxStats2_SelectedIndexChanged);
            // 
            // cbxStats1
            // 
            this.cbxStats1.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats1.FormattingEnabled = true;
            this.cbxStats1.Location = new System.Drawing.Point(112, 308);
            this.cbxStats1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStats1.Name = "cbxStats1";
            this.cbxStats1.Size = new System.Drawing.Size(252, 65);
            this.cbxStats1.TabIndex = 1;
            this.cbxStats1.Text = "Stock 1";
            this.cbxStats1.SelectedValueChanged += new System.EventHandler(this.cbxStats1_SelectedValueChanged);
            // 
            // tpStockAdd
            // 
            this.tpStockAdd.Controls.Add(this.tbxStockAdd_EANCode);
            this.tpStockAdd.Controls.Add(this.lblStockAddEAN);
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
            this.tpStockAdd.Location = new System.Drawing.Point(10, 42);
            this.tpStockAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStockAdd.Name = "tpStockAdd";
            this.tpStockAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStockAdd.Size = new System.Drawing.Size(2996, 1336);
            this.tpStockAdd.TabIndex = 4;
            this.tpStockAdd.Text = "StockAdd";
            this.tpStockAdd.UseVisualStyleBackColor = true;
            // 
            // tbxStockAdd_EANCode
            // 
            this.tbxStockAdd_EANCode.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_EANCode.Location = new System.Drawing.Point(584, 110);
            this.tbxStockAdd_EANCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_EANCode.Name = "tbxStockAdd_EANCode";
            this.tbxStockAdd_EANCode.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_EANCode.TabIndex = 1;
            // 
            // lblStockAddEAN
            // 
            this.lblStockAddEAN.AutoSize = true;
            this.lblStockAddEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAddEAN.Location = new System.Drawing.Point(101, 110);
            this.lblStockAddEAN.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStockAddEAN.Name = "lblStockAddEAN";
            this.lblStockAddEAN.Size = new System.Drawing.Size(244, 53);
            this.lblStockAddEAN.TabIndex = 21;
            this.lblStockAddEAN.Text = "EAN Code";
            // 
            // btnBackToStockPage
            // 
            this.btnBackToStockPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToStockPage.Location = new System.Drawing.Point(5, 1247);
            this.btnBackToStockPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToStockPage.Name = "btnBackToStockPage";
            this.btnBackToStockPage.Size = new System.Drawing.Size(421, 83);
            this.btnBackToStockPage.TabIndex = 20;
            this.btnBackToStockPage.Text = "<- Back to Stock";
            this.btnBackToStockPage.UseVisualStyleBackColor = true;
            this.btnBackToStockPage.Click += new System.EventHandler(this.btnBackToStockPage_click);
            // 
            // btnStockAdd_ConfirmEdit
            // 
            this.btnStockAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmEdit.Location = new System.Drawing.Point(2579, 1247);
            this.btnStockAdd_ConfirmEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStockAdd_ConfirmEdit.Name = "btnStockAdd_ConfirmEdit";
            this.btnStockAdd_ConfirmEdit.Size = new System.Drawing.Size(411, 83);
            this.btnStockAdd_ConfirmEdit.TabIndex = 19;
            this.btnStockAdd_ConfirmEdit.Text = "✎ Edit (Confirm)";
            this.btnStockAdd_ConfirmEdit.UseVisualStyleBackColor = true;
            this.btnStockAdd_ConfirmEdit.Click += new System.EventHandler(this.btnStockAdd_ConfirmEdit_Click);
            // 
            // btnStockAdd_ConfirmAdd
            // 
            this.btnStockAdd_ConfirmAdd.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmAdd.Location = new System.Drawing.Point(2579, 1252);
            this.btnStockAdd_ConfirmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStockAdd_ConfirmAdd.Name = "btnStockAdd_ConfirmAdd";
            this.btnStockAdd_ConfirmAdd.Size = new System.Drawing.Size(421, 83);
            this.btnStockAdd_ConfirmAdd.TabIndex = 18;
            this.btnStockAdd_ConfirmAdd.Text = "+ Add (Confirm)";
            this.btnStockAdd_ConfirmAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd_ConfirmAdd.Click += new System.EventHandler(this.btnStockAdd_ConfirmAdd_Click);
            // 
            // tbxStockAdd_TotalSold
            // 
            this.tbxStockAdd_TotalSold.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_TotalSold.Location = new System.Drawing.Point(1965, 565);
            this.tbxStockAdd_TotalSold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_TotalSold.Name = "tbxStockAdd_TotalSold";
            this.tbxStockAdd_TotalSold.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_TotalSold.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.Location = new System.Drawing.Point(1603, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 53);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.Location = new System.Drawing.Point(99, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 53);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID";
            // 
            // tbxStockAdd_ID
            // 
            this.tbxStockAdd_ID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ID.Location = new System.Drawing.Point(584, 43);
            this.tbxStockAdd_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_ID.Name = "tbxStockAdd_ID";
            this.tbxStockAdd_ID.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_ID.TabIndex = 13;
            // 
            // tbxStockAdd_Sell
            // 
            this.tbxStockAdd_Sell.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Sell.Location = new System.Drawing.Point(1965, 119);
            this.tbxStockAdd_Sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_Sell.Name = "tbxStockAdd_Sell";
            this.tbxStockAdd_Sell.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_Sell.TabIndex = 8;
            // 
            // tbxStockAdd_AddInfo
            // 
            this.tbxStockAdd_AddInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_AddInfo.Location = new System.Drawing.Point(1613, 391);
            this.tbxStockAdd_AddInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_AddInfo.Multiline = true;
            this.tbxStockAdd_AddInfo.Name = "tbxStockAdd_AddInfo";
            this.tbxStockAdd_AddInfo.Size = new System.Drawing.Size(1081, 140);
            this.tbxStockAdd_AddInfo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(1605, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(1605, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(1603, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 53);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price";
            // 
            // tbxStockAdd_MinimumStock
            // 
            this.tbxStockAdd_MinimumStock.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_MinimumStock.Location = new System.Drawing.Point(2197, 255);
            this.tbxStockAdd_MinimumStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_MinimumStock.Name = "tbxStockAdd_MinimumStock";
            this.tbxStockAdd_MinimumStock.Size = new System.Drawing.Size(553, 61);
            this.tbxStockAdd_MinimumStock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(1603, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 53);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(1603, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 53);
            this.label7.TabIndex = 6;
            this.label7.Text = "Minimum Stock Required";
            // 
            // tbxStockAdd_Cost
            // 
            this.tbxStockAdd_Cost.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Cost.Location = new System.Drawing.Point(1965, 52);
            this.tbxStockAdd_Cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_Cost.Name = "tbxStockAdd_Cost";
            this.tbxStockAdd_Cost.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_Cost.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(1603, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 53);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cost Price";
            // 
            // tbxStockAdd_WarehouseLocation
            // 
            this.tbxStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseLocation.Location = new System.Drawing.Point(587, 746);
            this.tbxStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_WarehouseLocation.Name = "tbxStockAdd_WarehouseLocation";
            this.tbxStockAdd_WarehouseLocation.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_WarehouseLocation.TabIndex = 4;
            // 
            // tbxStockAdd_StoreLocation
            // 
            this.tbxStockAdd_StoreLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreLocation.Location = new System.Drawing.Point(587, 997);
            this.tbxStockAdd_StoreLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_StoreLocation.Name = "tbxStockAdd_StoreLocation";
            this.tbxStockAdd_StoreLocation.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_StoreLocation.TabIndex = 6;
            // 
            // lblStockAdd_Store
            // 
            this.lblStockAdd_Store.AutoSize = true;
            this.lblStockAdd_Store.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Store.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Store.Location = new System.Drawing.Point(104, 887);
            this.lblStockAdd_Store.Name = "lblStockAdd_Store";
            this.lblStockAdd_Store.Size = new System.Drawing.Size(96, 39);
            this.lblStockAdd_Store.TabIndex = 0;
            this.lblStockAdd_Store.Text = "Store";
            // 
            // lblStockAdd_Warehouse
            // 
            this.lblStockAdd_Warehouse.AutoSize = true;
            this.lblStockAdd_Warehouse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Warehouse.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Warehouse.Location = new System.Drawing.Point(104, 637);
            this.lblStockAdd_Warehouse.Name = "lblStockAdd_Warehouse";
            this.lblStockAdd_Warehouse.Size = new System.Drawing.Size(188, 39);
            this.lblStockAdd_Warehouse.TabIndex = 0;
            this.lblStockAdd_Warehouse.Text = "Warehouse";
            // 
            // lblStockAdd_WarehouseLocation
            // 
            this.lblStockAdd_WarehouseLocation.AutoSize = true;
            this.lblStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseLocation.Location = new System.Drawing.Point(101, 751);
            this.lblStockAdd_WarehouseLocation.Name = "lblStockAdd_WarehouseLocation";
            this.lblStockAdd_WarehouseLocation.Size = new System.Drawing.Size(466, 53);
            this.lblStockAdd_WarehouseLocation.TabIndex = 0;
            this.lblStockAdd_WarehouseLocation.Text = "Warehouse Location ";
            // 
            // tbxStockAdd_StoreQuantity
            // 
            this.tbxStockAdd_StoreQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreQuantity.Location = new System.Drawing.Point(587, 930);
            this.tbxStockAdd_StoreQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_StoreQuantity.Name = "tbxStockAdd_StoreQuantity";
            this.tbxStockAdd_StoreQuantity.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_StoreQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(101, 1002);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store Location ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(101, 935);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Quantity";
            // 
            // tbxStockAdd_WarehouseQuantity
            // 
            this.tbxStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(587, 682);
            this.tbxStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_WarehouseQuantity.Name = "tbxStockAdd_WarehouseQuantity";
            this.tbxStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_WarehouseQuantity.TabIndex = 3;
            // 
            // lblStockAdd_WarehouseQuantity
            // 
            this.lblStockAdd_WarehouseQuantity.AutoSize = true;
            this.lblStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(101, 684);
            this.lblStockAdd_WarehouseQuantity.Name = "lblStockAdd_WarehouseQuantity";
            this.lblStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(450, 53);
            this.lblStockAdd_WarehouseQuantity.TabIndex = 0;
            this.lblStockAdd_WarehouseQuantity.Text = "Warehouse Quantity";
            // 
            // tbxStockAdd_ProductName
            // 
            this.tbxStockAdd_ProductName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ProductName.Location = new System.Drawing.Point(584, 172);
            this.tbxStockAdd_ProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStockAdd_ProductName.Name = "tbxStockAdd_ProductName";
            this.tbxStockAdd_ProductName.Size = new System.Drawing.Size(471, 61);
            this.tbxStockAdd_ProductName.TabIndex = 2;
            // 
            // lblProductAdd_StockName
            // 
            this.lblProductAdd_StockName.AutoSize = true;
            this.lblProductAdd_StockName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblProductAdd_StockName.Location = new System.Drawing.Point(99, 179);
            this.lblProductAdd_StockName.Name = "lblProductAdd_StockName";
            this.lblProductAdd_StockName.Size = new System.Drawing.Size(314, 53);
            this.lblProductAdd_StockName.TabIndex = 0;
            this.lblProductAdd_StockName.Text = "Product name";
            // 
            // tpEmployeeAdd
            // 
            this.tpEmployeeAdd.Controls.Add(this.lblSalary);
            this.tpEmployeeAdd.Controls.Add(this.tbxSalary);
            this.tpEmployeeAdd.Controls.Add(this.btnEmployeeAdd_ConfirmEdit);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_Details);
            this.tpEmployeeAdd.Controls.Add(this.cbxEmployeeAdd_Position);
            this.tpEmployeeAdd.Controls.Add(this.cbxEmployeeAdd_ICERelationship);
            this.tpEmployeeAdd.Controls.Add(this.dtpEmployeeAdd_DateOfBirth);
            this.tpEmployeeAdd.Controls.Add(this.btnBackToEmpPage);
            this.tpEmployeeAdd.Controls.Add(this.btnEmployeeAdd_Confirm);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_FirstName);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_FirstName);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_AdditonalInfo);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_ICE);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_ICERelationship);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_AdditionalInfo);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_ICENumber);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_ICENumber);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_Name);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_DateOfBirth);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_PhoneNumber);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_Position);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_PhoneNumber);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_BSN);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_BSN);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_SecondName);
            this.tpEmployeeAdd.Controls.Add(this.lblEmployeeAdd_SecondName);
            this.tpEmployeeAdd.Location = new System.Drawing.Point(10, 42);
            this.tpEmployeeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployeeAdd.Name = "tpEmployeeAdd";
            this.tpEmployeeAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmployeeAdd.Size = new System.Drawing.Size(2996, 1336);
            this.tpEmployeeAdd.TabIndex = 5;
            this.tpEmployeeAdd.Text = "EmployeeAdd";
            this.tpEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSalary.Location = new System.Drawing.Point(99, 585);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(343, 53);
            this.lblSalary.TabIndex = 54;
            this.lblSalary.Text = "Salary per hour";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxSalary.Location = new System.Drawing.Point(584, 585);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(620, 61);
            this.tbxSalary.TabIndex = 53;
            // 
            // btnEmployeeAdd_ConfirmEdit
            // 
            this.btnEmployeeAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployeeAdd_ConfirmEdit.Location = new System.Drawing.Point(2571, 1247);
            this.btnEmployeeAdd_ConfirmEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeAdd_ConfirmEdit.Name = "btnEmployeeAdd_ConfirmEdit";
            this.btnEmployeeAdd_ConfirmEdit.Size = new System.Drawing.Size(421, 83);
            this.btnEmployeeAdd_ConfirmEdit.TabIndex = 49;
            this.btnEmployeeAdd_ConfirmEdit.Text = "✎ Edit (Confirm)";
            this.btnEmployeeAdd_ConfirmEdit.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd_ConfirmEdit.Click += new System.EventHandler(this.btnEmployeeAdd_ConfirmEdit_Click);
            // 
            // lblEmployeeAdd_Details
            // 
            this.lblEmployeeAdd_Details.AutoSize = true;
            this.lblEmployeeAdd_Details.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdd_Details.ForeColor = System.Drawing.Color.Silver;
            this.lblEmployeeAdd_Details.Location = new System.Drawing.Point(101, 286);
            this.lblEmployeeAdd_Details.Name = "lblEmployeeAdd_Details";
            this.lblEmployeeAdd_Details.Size = new System.Drawing.Size(118, 39);
            this.lblEmployeeAdd_Details.TabIndex = 46;
            this.lblEmployeeAdd_Details.Text = "Details";
            // 
            // cbxEmployeeAdd_Position
            // 
            this.cbxEmployeeAdd_Position.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_Position.FormattingEnabled = true;
            this.cbxEmployeeAdd_Position.ItemHeight = 53;
            this.cbxEmployeeAdd_Position.Location = new System.Drawing.Point(584, 520);
            this.cbxEmployeeAdd_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEmployeeAdd_Position.Name = "cbxEmployeeAdd_Position";
            this.cbxEmployeeAdd_Position.Size = new System.Drawing.Size(620, 61);
            this.cbxEmployeeAdd_Position.TabIndex = 45;
            // 
            // cbxEmployeeAdd_ICERelationship
            // 
            this.cbxEmployeeAdd_ICERelationship.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_ICERelationship.FormattingEnabled = true;
            this.cbxEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(2352, 196);
            this.cbxEmployeeAdd_ICERelationship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEmployeeAdd_ICERelationship.Name = "cbxEmployeeAdd_ICERelationship";
            this.cbxEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(513, 61);
            this.cbxEmployeeAdd_ICERelationship.TabIndex = 47;
            // 
            // dtpEmployeeAdd_DateOfBirth
            // 
            this.dtpEmployeeAdd_DateOfBirth.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(584, 398);
            this.dtpEmployeeAdd_DateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEmployeeAdd_DateOfBirth.Name = "dtpEmployeeAdd_DateOfBirth";
            this.dtpEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(620, 46);
            this.dtpEmployeeAdd_DateOfBirth.TabIndex = 43;
            this.dtpEmployeeAdd_DateOfBirth.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // btnBackToEmpPage
            // 
            this.btnBackToEmpPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToEmpPage.Location = new System.Drawing.Point(3, 1247);
            this.btnBackToEmpPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToEmpPage.Name = "btnBackToEmpPage";
            this.btnBackToEmpPage.Size = new System.Drawing.Size(421, 83);
            this.btnBackToEmpPage.TabIndex = 50;
            this.btnBackToEmpPage.Text = "<- Back to Stock";
            this.btnBackToEmpPage.UseVisualStyleBackColor = true;
            this.btnBackToEmpPage.Click += new System.EventHandler(this.btnBackToEmpPage_Click);
            // 
            // btnEmployeeAdd_Confirm
            // 
            this.btnEmployeeAdd_Confirm.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployeeAdd_Confirm.Location = new System.Drawing.Point(2568, 1247);
            this.btnEmployeeAdd_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeAdd_Confirm.Name = "btnEmployeeAdd_Confirm";
            this.btnEmployeeAdd_Confirm.Size = new System.Drawing.Size(421, 83);
            this.btnEmployeeAdd_Confirm.TabIndex = 49;
            this.btnEmployeeAdd_Confirm.Text = "+ Add (Confirm)";
            this.btnEmployeeAdd_Confirm.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd_Confirm.Click += new System.EventHandler(this.btnEmployeeAdd_Confirm_Click);
            // 
            // lblEmployeeAdd_FirstName
            // 
            this.lblEmployeeAdd_FirstName.AutoSize = true;
            this.lblEmployeeAdd_FirstName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_FirstName.Location = new System.Drawing.Point(99, 131);
            this.lblEmployeeAdd_FirstName.Name = "lblEmployeeAdd_FirstName";
            this.lblEmployeeAdd_FirstName.Size = new System.Drawing.Size(244, 53);
            this.lblEmployeeAdd_FirstName.TabIndex = 41;
            this.lblEmployeeAdd_FirstName.Text = "First name";
            // 
            // tbxEmployeeAdd_FirstName
            // 
            this.tbxEmployeeAdd_FirstName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_FirstName.Location = new System.Drawing.Point(584, 131);
            this.tbxEmployeeAdd_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_FirstName.Name = "tbxEmployeeAdd_FirstName";
            this.tbxEmployeeAdd_FirstName.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_FirstName.TabIndex = 40;
            // 
            // tbxEmployeeAdd_AdditonalInfo
            // 
            this.tbxEmployeeAdd_AdditonalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_AdditonalInfo.Location = new System.Drawing.Point(1880, 415);
            this.tbxEmployeeAdd_AdditonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_AdditonalInfo.Multiline = true;
            this.tbxEmployeeAdd_AdditonalInfo.Name = "tbxEmployeeAdd_AdditonalInfo";
            this.tbxEmployeeAdd_AdditonalInfo.Size = new System.Drawing.Size(985, 183);
            this.tbxEmployeeAdd_AdditonalInfo.TabIndex = 48;
            // 
            // lblEmployeeAdd_ICE
            // 
            this.lblEmployeeAdd_ICE.AutoSize = true;
            this.lblEmployeeAdd_ICE.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdd_ICE.ForeColor = System.Drawing.Color.Silver;
            this.lblEmployeeAdd_ICE.Location = new System.Drawing.Point(1872, 83);
            this.lblEmployeeAdd_ICE.Name = "lblEmployeeAdd_ICE";
            this.lblEmployeeAdd_ICE.Size = new System.Drawing.Size(346, 39);
            this.lblEmployeeAdd_ICE.TabIndex = 31;
            this.lblEmployeeAdd_ICE.Text = "In Case of Emergency";
            // 
            // lblEmployeeAdd_ICERelationship
            // 
            this.lblEmployeeAdd_ICERelationship.AutoSize = true;
            this.lblEmployeeAdd_ICERelationship.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(1867, 198);
            this.lblEmployeeAdd_ICERelationship.Name = "lblEmployeeAdd_ICERelationship";
            this.lblEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(370, 53);
            this.lblEmployeeAdd_ICERelationship.TabIndex = 32;
            this.lblEmployeeAdd_ICERelationship.Text = "ICE Relationship";
            // 
            // lblEmployeeAdd_AdditionalInfo
            // 
            this.lblEmployeeAdd_AdditionalInfo.AutoSize = true;
            this.lblEmployeeAdd_AdditionalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_AdditionalInfo.Location = new System.Drawing.Point(1869, 360);
            this.lblEmployeeAdd_AdditionalInfo.Name = "lblEmployeeAdd_AdditionalInfo";
            this.lblEmployeeAdd_AdditionalInfo.Size = new System.Drawing.Size(472, 53);
            this.lblEmployeeAdd_AdditionalInfo.TabIndex = 34;
            this.lblEmployeeAdd_AdditionalInfo.Text = "Additional Information";
            // 
            // tbxEmployeeAdd_ICENumber
            // 
            this.tbxEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_ICENumber.Location = new System.Drawing.Point(2352, 131);
            this.tbxEmployeeAdd_ICENumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_ICENumber.Name = "tbxEmployeeAdd_ICENumber";
            this.tbxEmployeeAdd_ICENumber.Size = new System.Drawing.Size(513, 61);
            this.tbxEmployeeAdd_ICENumber.TabIndex = 46;
            // 
            // lblEmployeeAdd_ICENumber
            // 
            this.lblEmployeeAdd_ICENumber.AutoSize = true;
            this.lblEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICENumber.Location = new System.Drawing.Point(1867, 131);
            this.lblEmployeeAdd_ICENumber.Name = "lblEmployeeAdd_ICENumber";
            this.lblEmployeeAdd_ICENumber.Size = new System.Drawing.Size(271, 53);
            this.lblEmployeeAdd_ICENumber.TabIndex = 37;
            this.lblEmployeeAdd_ICENumber.Text = "ICE number";
            // 
            // lblEmployeeAdd_Name
            // 
            this.lblEmployeeAdd_Name.AutoSize = true;
            this.lblEmployeeAdd_Name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdd_Name.ForeColor = System.Drawing.Color.Silver;
            this.lblEmployeeAdd_Name.Location = new System.Drawing.Point(101, 83);
            this.lblEmployeeAdd_Name.Name = "lblEmployeeAdd_Name";
            this.lblEmployeeAdd_Name.Size = new System.Drawing.Size(105, 39);
            this.lblEmployeeAdd_Name.TabIndex = 26;
            this.lblEmployeeAdd_Name.Text = "Name";
            // 
            // lblEmployeeAdd_DateOfBirth
            // 
            this.lblEmployeeAdd_DateOfBirth.AutoSize = true;
            this.lblEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(99, 398);
            this.lblEmployeeAdd_DateOfBirth.Name = "lblEmployeeAdd_DateOfBirth";
            this.lblEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(278, 53);
            this.lblEmployeeAdd_DateOfBirth.TabIndex = 25;
            this.lblEmployeeAdd_DateOfBirth.Text = "Date of birth";
            // 
            // tbxEmployeeAdd_PhoneNumber
            // 
            this.tbxEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(584, 453);
            this.tbxEmployeeAdd_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_PhoneNumber.Name = "tbxEmployeeAdd_PhoneNumber";
            this.tbxEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_PhoneNumber.TabIndex = 44;
            // 
            // lblEmployeeAdd_Position
            // 
            this.lblEmployeeAdd_Position.AutoSize = true;
            this.lblEmployeeAdd_Position.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_Position.Location = new System.Drawing.Point(99, 525);
            this.lblEmployeeAdd_Position.Name = "lblEmployeeAdd_Position";
            this.lblEmployeeAdd_Position.Size = new System.Drawing.Size(189, 53);
            this.lblEmployeeAdd_Position.TabIndex = 24;
            this.lblEmployeeAdd_Position.Text = "Position";
            // 
            // lblEmployeeAdd_PhoneNumber
            // 
            this.lblEmployeeAdd_PhoneNumber.AutoSize = true;
            this.lblEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(99, 458);
            this.lblEmployeeAdd_PhoneNumber.Name = "lblEmployeeAdd_PhoneNumber";
            this.lblEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(329, 53);
            this.lblEmployeeAdd_PhoneNumber.TabIndex = 23;
            this.lblEmployeeAdd_PhoneNumber.Text = "Phone number";
            // 
            // tbxEmployeeAdd_BSN
            // 
            this.tbxEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_BSN.Location = new System.Drawing.Point(584, 329);
            this.tbxEmployeeAdd_BSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_BSN.Name = "tbxEmployeeAdd_BSN";
            this.tbxEmployeeAdd_BSN.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_BSN.TabIndex = 42;
            // 
            // lblEmployeeAdd_BSN
            // 
            this.lblEmployeeAdd_BSN.AutoSize = true;
            this.lblEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_BSN.Location = new System.Drawing.Point(99, 331);
            this.lblEmployeeAdd_BSN.Name = "lblEmployeeAdd_BSN";
            this.lblEmployeeAdd_BSN.Size = new System.Drawing.Size(119, 53);
            this.lblEmployeeAdd_BSN.TabIndex = 22;
            this.lblEmployeeAdd_BSN.Text = "BSN";
            // 
            // tbxEmployeeAdd_SecondName
            // 
            this.tbxEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_SecondName.Location = new System.Drawing.Point(584, 198);
            this.tbxEmployeeAdd_SecondName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeAdd_SecondName.Name = "tbxEmployeeAdd_SecondName";
            this.tbxEmployeeAdd_SecondName.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_SecondName.TabIndex = 41;
            // 
            // lblEmployeeAdd_SecondName
            // 
            this.lblEmployeeAdd_SecondName.AutoSize = true;
            this.lblEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_SecondName.Location = new System.Drawing.Point(99, 198);
            this.lblEmployeeAdd_SecondName.Name = "lblEmployeeAdd_SecondName";
            this.lblEmployeeAdd_SecondName.Size = new System.Drawing.Size(311, 53);
            this.lblEmployeeAdd_SecondName.TabIndex = 21;
            this.lblEmployeeAdd_SecondName.Text = "Second name";
            // 
            // textBox_defocus
            // 
            this.textBox_defocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_defocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defocus.Location = new System.Drawing.Point(0, 0);
            this.textBox_defocus.Margin = new System.Windows.Forms.Padding(5);
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
            this.pnlBar.Location = new System.Drawing.Point(-3, -2);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(5);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(3077, 76);
            this.pnlBar.TabIndex = 8;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlDragBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDragBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDragBar.Location = new System.Drawing.Point(8, 0);
            this.pnlDragBar.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(2992, 74);
            this.pnlDragBar.TabIndex = 9;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            this.pnlDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(3000, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(72, 67);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // gpnlStatsType
            // 
            this.gpnlStatsType.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlStatsType.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlStatsType.Controls.Add(this.cbxStatsType);
            this.gpnlStatsType.Location = new System.Drawing.Point(1867, 0);
            this.gpnlStatsType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlStatsType.Name = "gpnlStatsType";
            this.gpnlStatsType.Size = new System.Drawing.Size(371, 207);
            this.gpnlStatsType.TabIndex = 14;
            this.gpnlStatsType.Visible = false;
            // 
            // cbxStatsType
            // 
            this.cbxStatsType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxStatsType.FormattingEnabled = true;
            this.cbxStatsType.Location = new System.Drawing.Point(0, 67);
            this.cbxStatsType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStatsType.Name = "cbxStatsType";
            this.cbxStatsType.Size = new System.Drawing.Size(308, 61);
            this.cbxStatsType.TabIndex = 0;
            this.cbxStatsType.Visible = false;
            // 
            // gpnlStatistics
            // 
            this.gpnlStatistics.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlStatistics.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlStatistics.Controls.Add(this.btnStatistics);
            this.gpnlStatistics.Location = new System.Drawing.Point(1448, -2);
            this.gpnlStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlStatistics.Name = "gpnlStatistics";
            this.gpnlStatistics.Size = new System.Drawing.Size(419, 207);
            this.gpnlStatistics.TabIndex = 13;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(-3, 24);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(419, 150);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // gpnlSchedules
            // 
            this.gpnlSchedules.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlSchedules.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlSchedules.Controls.Add(this.btnSchedules);
            this.gpnlSchedules.Location = new System.Drawing.Point(624, -2);
            this.gpnlSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlSchedules.Name = "gpnlSchedules";
            this.gpnlSchedules.Size = new System.Drawing.Size(397, 207);
            this.gpnlSchedules.TabIndex = 12;
            // 
            // btnSchedules
            // 
            this.btnSchedules.BackColor = System.Drawing.Color.Transparent;
            this.btnSchedules.FlatAppearance.BorderSize = 0;
            this.btnSchedules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnSchedules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedules.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedules.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.Location = new System.Drawing.Point(3, 24);
            this.btnSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(392, 150);
            this.btnSchedules.TabIndex = 10;
            this.btnSchedules.Text = "Schedules";
            this.btnSchedules.UseVisualStyleBackColor = false;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // gpnlStock
            // 
            this.gpnlStock.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlStock.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlStock.Controls.Add(this.btnStock);
            this.gpnlStock.Location = new System.Drawing.Point(376, 0);
            this.gpnlStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlStock.Name = "gpnlStock";
            this.gpnlStock.Size = new System.Drawing.Size(245, 207);
            this.gpnlStock.TabIndex = 11;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(3, 24);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(243, 150);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // gpnlEmployees
            // 
            this.gpnlEmployees.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlEmployees.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlEmployees.Controls.Add(this.btnEmployees);
            this.gpnlEmployees.Location = new System.Drawing.Point(1027, 0);
            this.gpnlEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlEmployees.Name = "gpnlEmployees";
            this.gpnlEmployees.Size = new System.Drawing.Size(419, 207);
            this.gpnlEmployees.TabIndex = 12;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(14)))), ((int)(((byte)(97)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(-3, 24);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(419, 150);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3075, 1643);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(3075, 1643);
            this.MinimumSize = new System.Drawing.Size(1533, 823);
            this.Text = "ProductForm";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlTabCover.ResumeLayout(false);
            this.tcNavigator.ResumeLayout(false);
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).EndInit();
            this.tpSchedules.ResumeLayout(false);
            this.tpSchedules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScheduleWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tpStatsStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.tpStockAdd.ResumeLayout(false);
            this.tpStockAdd.PerformLayout();
            this.tpEmployeeAdd.ResumeLayout(false);
            this.tpEmployeeAdd.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.gpnlStatsType.ResumeLayout(false);
            this.gpnlStatistics.ResumeLayout(false);
            this.gpnlSchedules.ResumeLayout(false);
            this.gpnlStock.ResumeLayout(false);
            this.gpnlEmployees.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpStatsStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.Button btnDeActivateStock;
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
        private System.Windows.Forms.TextBox tbxSearchEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TabPage tpEmployeeAdd;
        private System.Windows.Forms.DateTimePicker dtpEmployeeAdd_DateOfBirth;
        private System.Windows.Forms.Button btnBackToEmpPage;
        private System.Windows.Forms.Label lblEmployeeAdd_FirstName;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_FirstName;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_AdditonalInfo;
        private System.Windows.Forms.Label lblEmployeeAdd_ICE;
        private System.Windows.Forms.Label lblEmployeeAdd_ICERelationship;
        private System.Windows.Forms.Label lblEmployeeAdd_AdditionalInfo;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_ICENumber;
        private System.Windows.Forms.Label lblEmployeeAdd_ICENumber;
        private System.Windows.Forms.Label lblEmployeeAdd_Name;
        private System.Windows.Forms.Label lblEmployeeAdd_DateOfBirth;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_PhoneNumber;
        private System.Windows.Forms.Label lblEmployeeAdd_Position;
        private System.Windows.Forms.Label lblEmployeeAdd_PhoneNumber;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_BSN;
        private System.Windows.Forms.Label lblEmployeeAdd_BSN;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_SecondName;
        private System.Windows.Forms.Label lblEmployeeAdd_SecondName;
        private System.Windows.Forms.ComboBox cbxEmployeeAdd_ICERelationship;
        private System.Windows.Forms.Label lblEmployeeAdd_Details;
        private System.Windows.Forms.ComboBox cbxEmployeeAdd_Position;
        private System.Windows.Forms.Button btnEmployeeAdd_Confirm;
        private System.Windows.Forms.Panel pnlTabCover;
        private System.Windows.Forms.Button btnStock;
        private GradientPanel gpnlStock;
        private GradientPanel gpnlSchedules;
        private GradientPanel gpnlEmployees;
        private System.Windows.Forms.Button btnEmployeeAdd_ConfirmEdit;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblMediaBazaar;
        private System.Windows.Forms.ComboBox cbxStats3;
        private System.Windows.Forms.ComboBox cbxStats2;
        private System.Windows.Forms.ComboBox cbxStats1;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Button btnSchedulesShowWeek;
        private System.Windows.Forms.NumericUpDown nudScheduleWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedulesFirstName;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesMonday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesTuesday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesWednesday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesThursday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesFriday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesSaturday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesSunday;
        private System.Windows.Forms.Button btnScheduleSaveCurrentWeek;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblScheduleCurrentWeek;
        private GradientPanel gpnlStatistics;
        private System.Windows.Forms.Button btnStatistics;
        private GradientPanel gpnlStatsType;
        private System.Windows.Forms.ComboBox cbxStatsType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.Button btnDeselectStatsStock1;
        private System.Windows.Forms.Button btnDeselectStatsStock3;
        private System.Windows.Forms.Button btnDeselectStatsStock2;
        private System.Windows.Forms.ComboBox cbxStockCurrentlyShowing;
        private System.Windows.Forms.Label lblStockCurrentlyShowing;
        private System.Windows.Forms.TextBox tbxStockAdd_EANCode;
        private System.Windows.Forms.Label lblStockAddEAN;
        private System.Windows.Forms.Button btnStock_ReActivateProduct;
        private System.Windows.Forms.DataGridView dgvAllStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationS;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityWH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationWH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSold;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button button_loadTemplate;
        private System.Windows.Forms.Button button_saveAsTemplate;
        private System.Windows.Forms.ComboBox cbxActiveInactiveEmployees;
        private System.Windows.Forms.Label lblActiveInactiveEmployees;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalaryPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIceRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuittingReason;
    }
}