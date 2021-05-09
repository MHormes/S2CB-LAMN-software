﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlTabCover = new System.Windows.Forms.Panel();
            this.gpnlStatsType = new LAMN_Software.GradientPanel();
            this.cbxStatsType = new System.Windows.Forms.ComboBox();
            this.gpnlStatistics = new LAMN_Software.GradientPanel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMediaBazaar = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.gpnlSchedules = new LAMN_Software.GradientPanel();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.gpnlStock = new LAMN_Software.GradientPanel();
            this.btnStock = new System.Windows.Forms.Button();
            this.gpnlEmployees = new LAMN_Software.GradientPanel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tcNavigator = new System.Windows.Forms.TabControl();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.btnStockAdjustColumnWidth = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSellProduct = new System.Windows.Forms.Button();
            this.btnStockStats = new System.Windows.Forms.Button();
            this.dgvAllStock = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tpSchedulesEmp = new System.Windows.Forms.TabPage();
            this.chkShowFTE = new System.Windows.Forms.CheckBox();
            this.btnScheduleEmpSearch = new System.Windows.Forms.Button();
            this.tbxScheduleEmpSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblScheduleCurrentWeek = new System.Windows.Forms.Label();
            this.btnScheduleEmpSaveCurrentWeek = new System.Windows.Forms.Button();
            this.nudScheduleEmpWeek = new System.Windows.Forms.NumericUpDown();
            this.btnSchedulesEmpShowWeek = new System.Windows.Forms.Button();
            this.dgvSchedulesEmp = new System.Windows.Forms.DataGridView();
            this.schedulesEmpFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesEmpMonday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpTuesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpWednesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpThursday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpFriday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpSaturday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpSunday = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.schedulesEmpFTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSchedulesCreate = new System.Windows.Forms.TabPage();
            this.btnScheduleCreateMinimumPeople = new System.Windows.Forms.Button();
            this.btnSchedulesCreateLoadTemplate = new System.Windows.Forms.Button();
            this.btnSchedulesCreateSaveTempalte = new System.Windows.Forms.Button();
            this.btnSchedulesCreateSaveCurrent = new System.Windows.Forms.Button();
            this.nudSchedulesCreateWeek = new System.Windows.Forms.NumericUpDown();
            this.btnSchedulesCreateShowWeek = new System.Windows.Forms.Button();
            this.tpScheduleMin = new System.Windows.Forms.TabPage();
            this.btnSchedulesSaveMinPeople = new System.Windows.Forms.Button();
            this.dgvScheduleMinP = new System.Windows.Forms.DataGridView();
            this.ScheduleMinShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleMinSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpScheduleChoise = new System.Windows.Forms.TabPage();
            this.gpnlViewSchedules = new LAMN_Software.GradientPanel();
            this.lblViewSchedules = new System.Windows.Forms.Label();
            this.pbxViewSchedules = new System.Windows.Forms.PictureBox();
            this.gpnlCreateSchedules = new LAMN_Software.GradientPanel();
            this.lblCreateSchedules = new System.Windows.Forms.Label();
            this.pbxAddSchedules = new System.Windows.Forms.PictureBox();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.btnInfoChangeRequest = new System.Windows.Forms.Button();
            this.btnEmpStats = new System.Windows.Forms.Button();
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
            this.dgvStartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tpStatsStock = new System.Windows.Forms.TabPage();
            this.btnStockStatsRandomize = new System.Windows.Forms.Button();
            this.btnDeselectStatsStock3 = new System.Windows.Forms.Button();
            this.btnDeselectStatsStock2 = new System.Windows.Forms.Button();
            this.btnDeselectStatsStock1 = new System.Windows.Forms.Button();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxStats3 = new System.Windows.Forms.ComboBox();
            this.cbxStats2 = new System.Windows.Forms.ComboBox();
            this.cbxStats1 = new System.Windows.Forms.ComboBox();
            this.tpStockAdd = new System.Windows.Forms.TabPage();
            this.lblStockAdd_Details = new System.Windows.Forms.Label();
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
            this.tbxEmployeeAdd_Nationality = new System.Windows.Forms.TextBox();
            this.tbxEmployeeAdd_Degree = new System.Windows.Forms.TextBox();
            this.cbxEmployeeAdd_Gender = new System.Windows.Forms.ComboBox();
            this.lblNationionality = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.cbxEmployeeAdd_ContractType = new System.Windows.Forms.ComboBox();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.dtpEmployeeAdd_EndingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeAdd_StartingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
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
            this.tpStatsEmployee = new System.Windows.Forms.TabPage();
            this.chartEmployeesPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpNewOrder = new System.Windows.Forms.TabPage();
            this.btnNewOrderBack = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.tbNewOrderEAN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNewOrderID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbNewOrderWarehouse = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbNewOrderStore = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbNewOrderName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tpSellProduct = new System.Windows.Forms.TabPage();
            this.btnSellConfirm = new System.Windows.Forms.Button();
            this.btnSellProdBack = new System.Windows.Forms.Button();
            this.tbSellEAN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSellID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSellQuantity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSellName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpRequestChangeInfo = new System.Windows.Forms.TabPage();
            this.lblChangeInfo = new System.Windows.Forms.Label();
            this.lbChangeInfo = new System.Windows.Forms.ListBox();
            this.gbOldInfo = new System.Windows.Forms.GroupBox();
            this.lblOldInfo_ICErelation = new System.Windows.Forms.Label();
            this.lblOldInfo_ICEnumber = new System.Windows.Forms.Label();
            this.lblOldInfo_PhoneNumber = new System.Windows.Forms.Label();
            this.lblOldInfo_SecondName = new System.Windows.Forms.Label();
            this.lblOldInfo_FirstName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gbNewInfo = new System.Windows.Forms.GroupBox();
            this.btnDeclineInfoChanges = new System.Windows.Forms.Button();
            this.btnApproveInfoChanges = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblNewInfo_ICErelation = new System.Windows.Forms.Label();
            this.lblNewInfo_ICEnumber = new System.Windows.Forms.Label();
            this.lblNewInfo_PhoneNumber = new System.Windows.Forms.Label();
            this.lblNewInfo_SecondName = new System.Windows.Forms.Label();
            this.lblNewInfo_FirstName = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlTabCover.SuspendLayout();
            this.gpnlStatsType.SuspendLayout();
            this.gpnlStatistics.SuspendLayout();
            this.gpnlSchedules.SuspendLayout();
            this.gpnlStock.SuspendLayout();
            this.gpnlEmployees.SuspendLayout();
            this.tcNavigator.SuspendLayout();
            this.tpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).BeginInit();
            this.tpSchedulesEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScheduleEmpWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulesEmp)).BeginInit();
            this.tpSchedulesCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSchedulesCreateWeek)).BeginInit();
            this.tpScheduleMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleMinP)).BeginInit();
            this.tpScheduleChoise.SuspendLayout();
            this.gpnlViewSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewSchedules)).BeginInit();
            this.gpnlCreateSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSchedules)).BeginInit();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tpStatsStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.tpStockAdd.SuspendLayout();
            this.tpEmployeeAdd.SuspendLayout();
            this.tpStatsEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesPosition)).BeginInit();
            this.tpNewOrder.SuspendLayout();
            this.tpSellProduct.SuspendLayout();
            this.tpRequestChangeInfo.SuspendLayout();
            this.gbOldInfo.SuspendLayout();
            this.gbNewInfo.SuspendLayout();
            this.pnlBar.SuspendLayout();
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
            this.pnlTabCover.Size = new System.Drawing.Size(3067, 174);
            this.pnlTabCover.TabIndex = 11;
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
            this.cbxStatsType.Items.AddRange(new object[] {
            "Stock",
            "Employees"});
            this.cbxStatsType.Location = new System.Drawing.Point(0, 67);
            this.cbxStatsType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStatsType.Name = "cbxStatsType";
            this.cbxStatsType.Size = new System.Drawing.Size(308, 61);
            this.cbxStatsType.TabIndex = 0;
            this.cbxStatsType.Text = "Stock";
            this.cbxStatsType.Visible = false;
            this.cbxStatsType.SelectedIndexChanged += new System.EventHandler(this.cbxStatsType_SelectedIndexChanged);
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
            // tcNavigator
            // 
            this.tcNavigator.Controls.Add(this.tpStock);
            this.tcNavigator.Controls.Add(this.tpSchedulesEmp);
            this.tcNavigator.Controls.Add(this.tpSchedulesCreate);
            this.tcNavigator.Controls.Add(this.tpScheduleMin);
            this.tcNavigator.Controls.Add(this.tpScheduleChoise);
            this.tcNavigator.Controls.Add(this.tpEmployees);
            this.tcNavigator.Controls.Add(this.tpStatsStock);
            this.tcNavigator.Controls.Add(this.tpStockAdd);
            this.tcNavigator.Controls.Add(this.tpEmployeeAdd);
            this.tcNavigator.Controls.Add(this.tpStatsEmployee);
            this.tcNavigator.Controls.Add(this.tpNewOrder);
            this.tcNavigator.Controls.Add(this.tpSellProduct);
            this.tcNavigator.Controls.Add(this.tpRequestChangeInfo);
            this.tcNavigator.Location = new System.Drawing.Point(32, 248);
            this.tcNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcNavigator.Name = "tcNavigator";
            this.tcNavigator.SelectedIndex = 0;
            this.tcNavigator.Size = new System.Drawing.Size(3016, 1388);
            this.tcNavigator.TabIndex = 9;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.btnStockAdjustColumnWidth);
            this.tpStock.Controls.Add(this.btnOrder);
            this.tpStock.Controls.Add(this.btnSellProduct);
            this.tpStock.Controls.Add(this.btnStockStats);
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
            // btnStockAdjustColumnWidth
            // 
            this.btnStockAdjustColumnWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockAdjustColumnWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdjustColumnWidth.Location = new System.Drawing.Point(5112, 134);
            this.btnStockAdjustColumnWidth.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStockAdjustColumnWidth.Name = "btnStockAdjustColumnWidth";
            this.btnStockAdjustColumnWidth.Size = new System.Drawing.Size(856, 122);
            this.btnStockAdjustColumnWidth.TabIndex = 26;
            this.btnStockAdjustColumnWidth.Text = "Reset column width";
            this.btnStockAdjustColumnWidth.UseVisualStyleBackColor = true;
            this.btnStockAdjustColumnWidth.Click += new System.EventHandler(this.btnStockAdjustColumnWidth_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F);
            this.btnOrder.Location = new System.Drawing.Point(1952, 1252);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(275, 83);
            this.btnOrder.TabIndex = 25;
            this.btnOrder.Text = "New order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSellProduct.Location = new System.Drawing.Point(1675, 1252);
            this.btnSellProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(275, 83);
            this.btnSellProduct.TabIndex = 24;
            this.btnSellProduct.Text = "Sell product";
            this.btnSellProduct.UseVisualStyleBackColor = true;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // btnStockStats
            // 
            this.btnStockStats.Font = new System.Drawing.Font("Arial", 12F);
            this.btnStockStats.Location = new System.Drawing.Point(2229, 1254);
            this.btnStockStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStockStats.Name = "btnStockStats";
            this.btnStockStats.Size = new System.Drawing.Size(275, 83);
            this.btnStockStats.TabIndex = 23;
            this.btnStockStats.Text = "📊 Statistics";
            this.btnStockStats.UseVisualStyleBackColor = true;
            this.btnStockStats.Click += new System.EventHandler(this.btnStockStats_Click);
            // 
            // dgvAllStock
            // 
            this.dgvAllStock.AllowUserToAddRows = false;
            this.dgvAllStock.AllowUserToDeleteRows = false;
            this.dgvAllStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EAN,
            this.ProductName,
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
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 12;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
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
            this.CostPrice.HeaderText = "Cost price (€)";
            this.CostPrice.MinimumWidth = 12;
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Width = 250;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Sell price (€)";
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
            this.btnStock_ReActivateProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.btnStock_ReActivateProduct.Location = new System.Drawing.Point(1027, 1252);
            this.btnStock_ReActivateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock_ReActivateProduct.Name = "btnStock_ReActivateProduct";
            this.btnStock_ReActivateProduct.Size = new System.Drawing.Size(645, 83);
            this.btnStock_ReActivateProduct.TabIndex = 14;
            this.btnStock_ReActivateProduct.Text = "Reactivate selected product";
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
            this.tbxSearchStock.Location = new System.Drawing.Point(2507, 1257);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(364, 65);
            this.tbxSearchStock.TabIndex = 11;
            this.tbxSearchStock.TabStop = false;
            this.tbxSearchStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearchStock_KeyPress);
            // 
            // btnDeActivateStock
            // 
            this.btnDeActivateStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeActivateStock.Location = new System.Drawing.Point(1027, 1252);
            this.btnDeActivateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeActivateStock.Name = "btnDeActivateStock";
            this.btnDeActivateStock.Size = new System.Drawing.Size(645, 83);
            this.btnDeActivateStock.TabIndex = 10;
            this.btnDeActivateStock.Text = "🗑️ Deactivate selected product";
            this.btnDeActivateStock.UseVisualStyleBackColor = true;
            this.btnDeActivateStock.Click += new System.EventHandler(this.btnDeActivateStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditStock.Location = new System.Drawing.Point(456, 1252);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(565, 83);
            this.btnEditStock.TabIndex = 10;
            this.btnEditStock.Text = "✎ Edit selected product";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchStock.Location = new System.Drawing.Point(2888, 1252);
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
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddStock.Location = new System.Drawing.Point(13, 1254);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(437, 83);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "+ Add new product";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tpSchedulesEmp
            // 
            this.tpSchedulesEmp.Controls.Add(this.chkShowFTE);
            this.tpSchedulesEmp.Controls.Add(this.btnScheduleEmpSearch);
            this.tpSchedulesEmp.Controls.Add(this.tbxScheduleEmpSearch);
            this.tpSchedulesEmp.Controls.Add(this.label18);
            this.tpSchedulesEmp.Controls.Add(this.lblScheduleCurrentWeek);
            this.tpSchedulesEmp.Controls.Add(this.btnScheduleEmpSaveCurrentWeek);
            this.tpSchedulesEmp.Controls.Add(this.nudScheduleEmpWeek);
            this.tpSchedulesEmp.Controls.Add(this.btnSchedulesEmpShowWeek);
            this.tpSchedulesEmp.Controls.Add(this.dgvSchedulesEmp);
            this.tpSchedulesEmp.Location = new System.Drawing.Point(10, 42);
            this.tpSchedulesEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedulesEmp.Name = "tpSchedulesEmp";
            this.tpSchedulesEmp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedulesEmp.Size = new System.Drawing.Size(2996, 1336);
            this.tpSchedulesEmp.TabIndex = 1;
            this.tpSchedulesEmp.Text = "SchedulesEmp";
            this.tpSchedulesEmp.UseVisualStyleBackColor = true;
            // 
            // chkShowFTE
            // 
            this.chkShowFTE.AutoSize = true;
            this.chkShowFTE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowFTE.Location = new System.Drawing.Point(5416, 12);
            this.chkShowFTE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkShowFTE.Name = "chkShowFTE";
            this.chkShowFTE.Size = new System.Drawing.Size(243, 49);
            this.chkShowFTE.TabIndex = 24;
            this.chkShowFTE.Text = "Show FTE";
            this.chkShowFTE.UseVisualStyleBackColor = true;
            this.chkShowFTE.CheckedChanged += new System.EventHandler(this.chkShowFTE_CheckedChanged);
            // 
            // btnScheduleEmpSearch
            // 
            this.btnScheduleEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleEmpSearch.Location = new System.Drawing.Point(2640, 1161);
            this.btnScheduleEmpSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnScheduleEmpSearch.Name = "btnScheduleEmpSearch";
            this.btnScheduleEmpSearch.Size = new System.Drawing.Size(328, 143);
            this.btnScheduleEmpSearch.TabIndex = 23;
            this.btnScheduleEmpSearch.Text = "Search for an employee";
            this.btnScheduleEmpSearch.UseVisualStyleBackColor = true;
            this.btnScheduleEmpSearch.Click += new System.EventHandler(this.btnScheduleEmpSearch_Click);
            // 
            // tbxScheduleEmpSearch
            // 
            this.tbxScheduleEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxScheduleEmpSearch.Location = new System.Drawing.Point(2197, 1214);
            this.tbxScheduleEmpSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbxScheduleEmpSearch.Multiline = true;
            this.tbxScheduleEmpSearch.Name = "tbxScheduleEmpSearch";
            this.tbxScheduleEmpSearch.Size = new System.Drawing.Size(420, 87);
            this.tbxScheduleEmpSearch.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(2189, 1164);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(386, 39);
            this.label18.TabIndex = 21;
            this.label18.Text = "Search for an employee:";
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
            // btnScheduleEmpSaveCurrentWeek
            // 
            this.btnScheduleEmpSaveCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleEmpSaveCurrentWeek.Location = new System.Drawing.Point(352, 1157);
            this.btnScheduleEmpSaveCurrentWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnScheduleEmpSaveCurrentWeek.Name = "btnScheduleEmpSaveCurrentWeek";
            this.btnScheduleEmpSaveCurrentWeek.Size = new System.Drawing.Size(317, 167);
            this.btnScheduleEmpSaveCurrentWeek.TabIndex = 16;
            this.btnScheduleEmpSaveCurrentWeek.Text = "Save current week";
            this.btnScheduleEmpSaveCurrentWeek.UseVisualStyleBackColor = true;
            this.btnScheduleEmpSaveCurrentWeek.Click += new System.EventHandler(this.btnScheduleEmpSaveCurrentWeek_Click);
            // 
            // nudScheduleEmpWeek
            // 
            this.nudScheduleEmpWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudScheduleEmpWeek.Location = new System.Drawing.Point(16, 1159);
            this.nudScheduleEmpWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nudScheduleEmpWeek.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nudScheduleEmpWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScheduleEmpWeek.Name = "nudScheduleEmpWeek";
            this.nudScheduleEmpWeek.Size = new System.Drawing.Size(320, 45);
            this.nudScheduleEmpWeek.TabIndex = 15;
            this.nudScheduleEmpWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSchedulesEmpShowWeek
            // 
            this.btnSchedulesEmpShowWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesEmpShowWeek.Location = new System.Drawing.Point(11, 1214);
            this.btnSchedulesEmpShowWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesEmpShowWeek.Name = "btnSchedulesEmpShowWeek";
            this.btnSchedulesEmpShowWeek.Size = new System.Drawing.Size(325, 110);
            this.btnSchedulesEmpShowWeek.TabIndex = 14;
            this.btnSchedulesEmpShowWeek.Text = "Show schedules for chosen week";
            this.btnSchedulesEmpShowWeek.UseVisualStyleBackColor = true;
            this.btnSchedulesEmpShowWeek.Click += new System.EventHandler(this.btnSchedulesEmpShowWeek_Click);
            // 
            // dgvSchedulesEmp
            // 
            this.dgvSchedulesEmp.AllowUserToAddRows = false;
            this.dgvSchedulesEmp.AllowUserToDeleteRows = false;
            this.dgvSchedulesEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedulesEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedulesEmpFirstName,
            this.schedulesEmpMonday,
            this.schedulesEmpTuesday,
            this.schedulesEmpWednesday,
            this.schedulesEmpThursday,
            this.schedulesEmpFriday,
            this.schedulesEmpSaturday,
            this.schedulesEmpSunday,
            this.schedulesEmpFTE});
            this.dgvSchedulesEmp.Location = new System.Drawing.Point(0, 62);
            this.dgvSchedulesEmp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvSchedulesEmp.Name = "dgvSchedulesEmp";
            this.dgvSchedulesEmp.RowHeadersWidth = 51;
            this.dgvSchedulesEmp.RowTemplate.Height = 30;
            this.dgvSchedulesEmp.Size = new System.Drawing.Size(2968, 1071);
            this.dgvSchedulesEmp.TabIndex = 13;
            // 
            // schedulesEmpFirstName
            // 
            this.schedulesEmpFirstName.HeaderText = "First Name";
            this.schedulesEmpFirstName.MinimumWidth = 6;
            this.schedulesEmpFirstName.Name = "schedulesEmpFirstName";
            this.schedulesEmpFirstName.ReadOnly = true;
            this.schedulesEmpFirstName.Width = 125;
            // 
            // schedulesEmpMonday
            // 
            this.schedulesEmpMonday.HeaderText = "Monday";
            this.schedulesEmpMonday.Items.AddRange(new object[] {
            "M",
            "A",
            "E"});
            this.schedulesEmpMonday.MinimumWidth = 6;
            this.schedulesEmpMonday.Name = "schedulesEmpMonday";
            this.schedulesEmpMonday.Width = 125;
            // 
            // schedulesEmpTuesday
            // 
            this.schedulesEmpTuesday.HeaderText = "Tuesday";
            this.schedulesEmpTuesday.MinimumWidth = 6;
            this.schedulesEmpTuesday.Name = "schedulesEmpTuesday";
            this.schedulesEmpTuesday.Width = 125;
            // 
            // schedulesEmpWednesday
            // 
            this.schedulesEmpWednesday.HeaderText = "Wednesday";
            this.schedulesEmpWednesday.MinimumWidth = 6;
            this.schedulesEmpWednesday.Name = "schedulesEmpWednesday";
            this.schedulesEmpWednesday.Width = 125;
            // 
            // schedulesEmpThursday
            // 
            this.schedulesEmpThursday.HeaderText = "Thursday";
            this.schedulesEmpThursday.MinimumWidth = 6;
            this.schedulesEmpThursday.Name = "schedulesEmpThursday";
            this.schedulesEmpThursday.Width = 125;
            // 
            // schedulesEmpFriday
            // 
            this.schedulesEmpFriday.HeaderText = "Friday";
            this.schedulesEmpFriday.MinimumWidth = 6;
            this.schedulesEmpFriday.Name = "schedulesEmpFriday";
            this.schedulesEmpFriday.Width = 125;
            // 
            // schedulesEmpSaturday
            // 
            this.schedulesEmpSaturday.HeaderText = "Saturday";
            this.schedulesEmpSaturday.MinimumWidth = 6;
            this.schedulesEmpSaturday.Name = "schedulesEmpSaturday";
            this.schedulesEmpSaturday.Width = 125;
            // 
            // schedulesEmpSunday
            // 
            this.schedulesEmpSunday.HeaderText = "Sunday";
            this.schedulesEmpSunday.MinimumWidth = 6;
            this.schedulesEmpSunday.Name = "schedulesEmpSunday";
            this.schedulesEmpSunday.Width = 125;
            // 
            // schedulesEmpFTE
            // 
            this.schedulesEmpFTE.HeaderText = "FTE";
            this.schedulesEmpFTE.MinimumWidth = 10;
            this.schedulesEmpFTE.Name = "schedulesEmpFTE";
            this.schedulesEmpFTE.ReadOnly = true;
            this.schedulesEmpFTE.Width = 200;
            // 
            // tpSchedulesCreate
            // 
            this.tpSchedulesCreate.Controls.Add(this.btnScheduleCreateMinimumPeople);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateLoadTemplate);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateSaveTempalte);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateSaveCurrent);
            this.tpSchedulesCreate.Controls.Add(this.nudSchedulesCreateWeek);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateShowWeek);
            this.tpSchedulesCreate.Location = new System.Drawing.Point(10, 42);
            this.tpSchedulesCreate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpSchedulesCreate.Name = "tpSchedulesCreate";
            this.tpSchedulesCreate.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpSchedulesCreate.Size = new System.Drawing.Size(2996, 1336);
            this.tpSchedulesCreate.TabIndex = 11;
            this.tpSchedulesCreate.Text = "SchedulesCreate";
            this.tpSchedulesCreate.UseVisualStyleBackColor = true;
            // 
            // btnScheduleCreateMinimumPeople
            // 
            this.btnScheduleCreateMinimumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnScheduleCreateMinimumPeople.Location = new System.Drawing.Point(1925, 1168);
            this.btnScheduleCreateMinimumPeople.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnScheduleCreateMinimumPeople.Name = "btnScheduleCreateMinimumPeople";
            this.btnScheduleCreateMinimumPeople.Size = new System.Drawing.Size(376, 148);
            this.btnScheduleCreateMinimumPeople.TabIndex = 23;
            this.btnScheduleCreateMinimumPeople.Text = "Update mimimum people per shift";
            this.btnScheduleCreateMinimumPeople.UseVisualStyleBackColor = true;
            this.btnScheduleCreateMinimumPeople.Click += new System.EventHandler(this.btnScheduleCreateMinimumPeople_Click);
            // 
            // btnSchedulesCreateLoadTemplate
            // 
            this.btnSchedulesCreateLoadTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnSchedulesCreateLoadTemplate.Location = new System.Drawing.Point(2317, 1171);
            this.btnSchedulesCreateLoadTemplate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesCreateLoadTemplate.Name = "btnSchedulesCreateLoadTemplate";
            this.btnSchedulesCreateLoadTemplate.Size = new System.Drawing.Size(325, 143);
            this.btnSchedulesCreateLoadTemplate.TabIndex = 22;
            this.btnSchedulesCreateLoadTemplate.Text = "Load template for current week";
            this.btnSchedulesCreateLoadTemplate.UseVisualStyleBackColor = true;
            this.btnSchedulesCreateLoadTemplate.Click += new System.EventHandler(this.btnSchedulesCreateLoadTemplate_Click);
            // 
            // btnSchedulesCreateSaveTempalte
            // 
            this.btnSchedulesCreateSaveTempalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnSchedulesCreateSaveTempalte.Location = new System.Drawing.Point(2659, 1168);
            this.btnSchedulesCreateSaveTempalte.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesCreateSaveTempalte.Name = "btnSchedulesCreateSaveTempalte";
            this.btnSchedulesCreateSaveTempalte.Size = new System.Drawing.Size(325, 148);
            this.btnSchedulesCreateSaveTempalte.TabIndex = 21;
            this.btnSchedulesCreateSaveTempalte.Text = "Save current week as template";
            this.btnSchedulesCreateSaveTempalte.UseVisualStyleBackColor = true;
            this.btnSchedulesCreateSaveTempalte.Click += new System.EventHandler(this.btnSchedulesCreateSaveTempalte_Click);
            // 
            // btnSchedulesCreateSaveCurrent
            // 
            this.btnSchedulesCreateSaveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnSchedulesCreateSaveCurrent.Location = new System.Drawing.Point(363, 1161);
            this.btnSchedulesCreateSaveCurrent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesCreateSaveCurrent.Name = "btnSchedulesCreateSaveCurrent";
            this.btnSchedulesCreateSaveCurrent.Size = new System.Drawing.Size(317, 167);
            this.btnSchedulesCreateSaveCurrent.TabIndex = 19;
            this.btnSchedulesCreateSaveCurrent.Text = "Save current week";
            this.btnSchedulesCreateSaveCurrent.UseVisualStyleBackColor = true;
            // 
            // nudSchedulesCreateWeek
            // 
            this.nudSchedulesCreateWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudSchedulesCreateWeek.Location = new System.Drawing.Point(27, 1164);
            this.nudSchedulesCreateWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nudSchedulesCreateWeek.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nudSchedulesCreateWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSchedulesCreateWeek.Name = "nudSchedulesCreateWeek";
            this.nudSchedulesCreateWeek.Size = new System.Drawing.Size(320, 45);
            this.nudSchedulesCreateWeek.TabIndex = 18;
            this.nudSchedulesCreateWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSchedulesCreateShowWeek
            // 
            this.btnSchedulesCreateShowWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnSchedulesCreateShowWeek.Location = new System.Drawing.Point(21, 1219);
            this.btnSchedulesCreateShowWeek.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesCreateShowWeek.Name = "btnSchedulesCreateShowWeek";
            this.btnSchedulesCreateShowWeek.Size = new System.Drawing.Size(325, 110);
            this.btnSchedulesCreateShowWeek.TabIndex = 17;
            this.btnSchedulesCreateShowWeek.Text = "Show schedules for chosen week";
            this.btnSchedulesCreateShowWeek.UseVisualStyleBackColor = true;
            // 
            // tpScheduleMin
            // 
            this.tpScheduleMin.Controls.Add(this.btnSchedulesSaveMinPeople);
            this.tpScheduleMin.Controls.Add(this.dgvScheduleMinP);
            this.tpScheduleMin.Location = new System.Drawing.Point(10, 42);
            this.tpScheduleMin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpScheduleMin.Name = "tpScheduleMin";
            this.tpScheduleMin.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpScheduleMin.Size = new System.Drawing.Size(2996, 1336);
            this.tpScheduleMin.TabIndex = 9;
            this.tpScheduleMin.Text = "SchedulesMin";
            this.tpScheduleMin.UseVisualStyleBackColor = true;
            // 
            // btnSchedulesSaveMinPeople
            // 
            this.btnSchedulesSaveMinPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesSaveMinPeople.Location = new System.Drawing.Point(2613, 1099);
            this.btnSchedulesSaveMinPeople.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSchedulesSaveMinPeople.Name = "btnSchedulesSaveMinPeople";
            this.btnSchedulesSaveMinPeople.Size = new System.Drawing.Size(365, 222);
            this.btnSchedulesSaveMinPeople.TabIndex = 15;
            this.btnSchedulesSaveMinPeople.Text = "Save minimum amount of people";
            this.btnSchedulesSaveMinPeople.UseVisualStyleBackColor = true;
            this.btnSchedulesSaveMinPeople.Click += new System.EventHandler(this.btnSchedulesSaveMinPeople_Click);
            // 
            // dgvScheduleMinP
            // 
            this.dgvScheduleMinP.AllowUserToAddRows = false;
            this.dgvScheduleMinP.AllowUserToDeleteRows = false;
            this.dgvScheduleMinP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduleMinP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleMinShift,
            this.ScheduleMinMonday,
            this.ScheduleMinTuesday,
            this.ScheduleMinWednesday,
            this.ScheduleMinThursday,
            this.ScheduleMinFriday,
            this.ScheduleMinSaturday,
            this.ScheduleMinSunday});
            this.dgvScheduleMinP.Location = new System.Drawing.Point(16, 14);
            this.dgvScheduleMinP.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvScheduleMinP.Name = "dgvScheduleMinP";
            this.dgvScheduleMinP.RowHeadersWidth = 51;
            this.dgvScheduleMinP.RowTemplate.Height = 30;
            this.dgvScheduleMinP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScheduleMinP.Size = new System.Drawing.Size(2968, 1071);
            this.dgvScheduleMinP.TabIndex = 14;
            // 
            // ScheduleMinShift
            // 
            this.ScheduleMinShift.HeaderText = "Shift";
            this.ScheduleMinShift.MinimumWidth = 6;
            this.ScheduleMinShift.Name = "ScheduleMinShift";
            this.ScheduleMinShift.Width = 125;
            // 
            // ScheduleMinMonday
            // 
            this.ScheduleMinMonday.HeaderText = "Monday";
            this.ScheduleMinMonday.MinimumWidth = 6;
            this.ScheduleMinMonday.Name = "ScheduleMinMonday";
            this.ScheduleMinMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinMonday.Width = 125;
            // 
            // ScheduleMinTuesday
            // 
            this.ScheduleMinTuesday.HeaderText = "Tuesday";
            this.ScheduleMinTuesday.MinimumWidth = 6;
            this.ScheduleMinTuesday.Name = "ScheduleMinTuesday";
            this.ScheduleMinTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinTuesday.Width = 125;
            // 
            // ScheduleMinWednesday
            // 
            this.ScheduleMinWednesday.HeaderText = "Wednesday";
            this.ScheduleMinWednesday.MinimumWidth = 6;
            this.ScheduleMinWednesday.Name = "ScheduleMinWednesday";
            this.ScheduleMinWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinWednesday.Width = 125;
            // 
            // ScheduleMinThursday
            // 
            this.ScheduleMinThursday.HeaderText = "Thursday";
            this.ScheduleMinThursday.MinimumWidth = 6;
            this.ScheduleMinThursday.Name = "ScheduleMinThursday";
            this.ScheduleMinThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinThursday.Width = 125;
            // 
            // ScheduleMinFriday
            // 
            this.ScheduleMinFriday.HeaderText = "Friday";
            this.ScheduleMinFriday.MinimumWidth = 6;
            this.ScheduleMinFriday.Name = "ScheduleMinFriday";
            this.ScheduleMinFriday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinFriday.Width = 125;
            // 
            // ScheduleMinSaturday
            // 
            this.ScheduleMinSaturday.HeaderText = "Saturday";
            this.ScheduleMinSaturday.MinimumWidth = 6;
            this.ScheduleMinSaturday.Name = "ScheduleMinSaturday";
            this.ScheduleMinSaturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinSaturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinSaturday.Width = 125;
            // 
            // ScheduleMinSunday
            // 
            this.ScheduleMinSunday.HeaderText = "Sunday";
            this.ScheduleMinSunday.MinimumWidth = 6;
            this.ScheduleMinSunday.Name = "ScheduleMinSunday";
            this.ScheduleMinSunday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleMinSunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ScheduleMinSunday.Width = 125;
            // 
            // tpScheduleChoise
            // 
            this.tpScheduleChoise.Controls.Add(this.gpnlViewSchedules);
            this.tpScheduleChoise.Controls.Add(this.gpnlCreateSchedules);
            this.tpScheduleChoise.Location = new System.Drawing.Point(10, 42);
            this.tpScheduleChoise.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpScheduleChoise.Name = "tpScheduleChoise";
            this.tpScheduleChoise.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tpScheduleChoise.Size = new System.Drawing.Size(2996, 1336);
            this.tpScheduleChoise.TabIndex = 10;
            this.tpScheduleChoise.Text = "ScheduleChoise";
            this.tpScheduleChoise.UseVisualStyleBackColor = true;
            // 
            // gpnlViewSchedules
            // 
            this.gpnlViewSchedules.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlViewSchedules.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlViewSchedules.Controls.Add(this.lblViewSchedules);
            this.gpnlViewSchedules.Controls.Add(this.pbxViewSchedules);
            this.gpnlViewSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpnlViewSchedules.Location = new System.Drawing.Point(1547, 291);
            this.gpnlViewSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlViewSchedules.Name = "gpnlViewSchedules";
            this.gpnlViewSchedules.Size = new System.Drawing.Size(1029, 718);
            this.gpnlViewSchedules.TabIndex = 14;
            this.gpnlViewSchedules.Click += new System.EventHandler(this.gpnlViewSchedules_Click);
            this.gpnlViewSchedules.MouseEnter += new System.EventHandler(this.gpnlViewSchedules_MouseEnter);
            this.gpnlViewSchedules.MouseLeave += new System.EventHandler(this.gpnlViewSchedules_MouseLeave);
            // 
            // lblViewSchedules
            // 
            this.lblViewSchedules.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSchedules.ForeColor = System.Drawing.Color.White;
            this.lblViewSchedules.Location = new System.Drawing.Point(216, 494);
            this.lblViewSchedules.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblViewSchedules.Name = "lblViewSchedules";
            this.lblViewSchedules.Size = new System.Drawing.Size(616, 145);
            this.lblViewSchedules.TabIndex = 0;
            this.lblViewSchedules.Text = "View schedule for an employee";
            this.lblViewSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewSchedules.Click += new System.EventHandler(this.lblViewSchedules_Click);
            // 
            // pbxViewSchedules
            // 
            this.pbxViewSchedules.Enabled = false;
            this.pbxViewSchedules.Image = global::LAMN_Software.Properties.Resources.AllSchedules;
            this.pbxViewSchedules.Location = new System.Drawing.Point(203, 67);
            this.pbxViewSchedules.Margin = new System.Windows.Forms.Padding(5);
            this.pbxViewSchedules.Name = "pbxViewSchedules";
            this.pbxViewSchedules.Size = new System.Drawing.Size(635, 389);
            this.pbxViewSchedules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxViewSchedules.TabIndex = 17;
            this.pbxViewSchedules.TabStop = false;
            // 
            // gpnlCreateSchedules
            // 
            this.gpnlCreateSchedules.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlCreateSchedules.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlCreateSchedules.Controls.Add(this.lblCreateSchedules);
            this.gpnlCreateSchedules.Controls.Add(this.pbxAddSchedules);
            this.gpnlCreateSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpnlCreateSchedules.Location = new System.Drawing.Point(373, 289);
            this.gpnlCreateSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpnlCreateSchedules.Name = "gpnlCreateSchedules";
            this.gpnlCreateSchedules.Size = new System.Drawing.Size(1029, 720);
            this.gpnlCreateSchedules.TabIndex = 13;
            this.gpnlCreateSchedules.Click += new System.EventHandler(this.gpnlCreateSchedules_Click);
            this.gpnlCreateSchedules.MouseEnter += new System.EventHandler(this.gpnlCreateSchedules_MouseEnter);
            this.gpnlCreateSchedules.MouseLeave += new System.EventHandler(this.gpnlCreateSchedules_MouseLeave);
            // 
            // lblCreateSchedules
            // 
            this.lblCreateSchedules.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSchedules.ForeColor = System.Drawing.Color.White;
            this.lblCreateSchedules.Location = new System.Drawing.Point(235, 522);
            this.lblCreateSchedules.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCreateSchedules.Name = "lblCreateSchedules";
            this.lblCreateSchedules.Size = new System.Drawing.Size(573, 91);
            this.lblCreateSchedules.TabIndex = 0;
            this.lblCreateSchedules.Text = "Add schedules";
            this.lblCreateSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateSchedules.Click += new System.EventHandler(this.lblCreateSchedules_Click);
            // 
            // pbxAddSchedules
            // 
            this.pbxAddSchedules.Enabled = false;
            this.pbxAddSchedules.Image = global::LAMN_Software.Properties.Resources.AddSchedule;
            this.pbxAddSchedules.Location = new System.Drawing.Point(192, 67);
            this.pbxAddSchedules.Margin = new System.Windows.Forms.Padding(5);
            this.pbxAddSchedules.Name = "pbxAddSchedules";
            this.pbxAddSchedules.Size = new System.Drawing.Size(635, 389);
            this.pbxAddSchedules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAddSchedules.TabIndex = 16;
            this.pbxAddSchedules.TabStop = false;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Controls.Add(this.label16);
            this.tpEmployees.Controls.Add(this.btnInfoChangeRequest);
            this.tpEmployees.Controls.Add(this.btnEmpStats);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(2361, 1244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 36);
            this.label16.TabIndex = 24;
            this.label16.Text = "1";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfoChangeRequest
            // 
            this.btnInfoChangeRequest.Font = new System.Drawing.Font("Arial", 12F);
            this.btnInfoChangeRequest.Location = new System.Drawing.Point(1886, 1241);
            this.btnInfoChangeRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoChangeRequest.Name = "btnInfoChangeRequest";
            this.btnInfoChangeRequest.Size = new System.Drawing.Size(496, 83);
            this.btnInfoChangeRequest.TabIndex = 23;
            this.btnInfoChangeRequest.Text = "✉️ Info change requests";
            this.btnInfoChangeRequest.UseVisualStyleBackColor = true;
            this.btnInfoChangeRequest.Click += new System.EventHandler(this.btnInfoChangeRequest_Click_1);
            // 
            // btnEmpStats
            // 
            this.btnEmpStats.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEmpStats.Location = new System.Drawing.Point(1591, 1241);
            this.btnEmpStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpStats.Name = "btnEmpStats";
            this.btnEmpStats.Size = new System.Drawing.Size(278, 83);
            this.btnEmpStats.TabIndex = 22;
            this.btnEmpStats.Text = "📊 Statistics";
            this.btnEmpStats.UseVisualStyleBackColor = true;
            this.btnEmpStats.Click += new System.EventHandler(this.btnEmpStats_Click);
            // 
            // cbxActiveInactiveEmployees
            // 
            this.cbxActiveInactiveEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActiveInactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxActiveInactiveEmployees.FormattingEnabled = true;
            this.cbxActiveInactiveEmployees.Items.AddRange(new object[] {
            "Active",
            "Terminated"});
            this.cbxActiveInactiveEmployees.Location = new System.Drawing.Point(987, 19);
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
            this.lblActiveInactiveEmployees.Location = new System.Drawing.Point(8, 21);
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
            this.dgvQuittingReason,
            this.dgvStartingDate,
            this.dgvEndingDate,
            this.dgvContractType,
            this.dgvGender,
            this.dgvDegree,
            this.dgvNationality});
            this.dgvEmployees.Location = new System.Drawing.Point(5, 114);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
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
            // dgvStartingDate
            // 
            this.dgvStartingDate.HeaderText = "Starting Date";
            this.dgvStartingDate.MinimumWidth = 12;
            this.dgvStartingDate.Name = "dgvStartingDate";
            this.dgvStartingDate.ReadOnly = true;
            this.dgvStartingDate.Width = 250;
            // 
            // dgvEndingDate
            // 
            this.dgvEndingDate.HeaderText = "Ending Date";
            this.dgvEndingDate.MinimumWidth = 12;
            this.dgvEndingDate.Name = "dgvEndingDate";
            this.dgvEndingDate.ReadOnly = true;
            this.dgvEndingDate.Width = 250;
            // 
            // dgvContractType
            // 
            this.dgvContractType.HeaderText = "Contract Type";
            this.dgvContractType.MinimumWidth = 12;
            this.dgvContractType.Name = "dgvContractType";
            this.dgvContractType.ReadOnly = true;
            this.dgvContractType.Width = 250;
            // 
            // dgvGender
            // 
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.MinimumWidth = 12;
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.ReadOnly = true;
            this.dgvGender.Width = 250;
            // 
            // dgvDegree
            // 
            this.dgvDegree.HeaderText = "Degree";
            this.dgvDegree.MinimumWidth = 12;
            this.dgvDegree.Name = "dgvDegree";
            this.dgvDegree.ReadOnly = true;
            this.dgvDegree.Width = 250;
            // 
            // dgvNationality
            // 
            this.dgvNationality.HeaderText = "Nationality";
            this.dgvNationality.MinimumWidth = 12;
            this.dgvNationality.Name = "dgvNationality";
            this.dgvNationality.ReadOnly = true;
            this.dgvNationality.Width = 250;
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchEmployee.Location = new System.Drawing.Point(2404, 1247);
            this.tbxSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(474, 65);
            this.tbxSearchEmployee.TabIndex = 17;
            this.tbxSearchEmployee.TabStop = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(1020, 1242);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(551, 83);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "🗑️ End contract of selected";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditEmployee.Location = new System.Drawing.Point(471, 1242);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(533, 83);
            this.btnEditEmployee.TabIndex = 14;
            this.btnEditEmployee.Text = "✎ Edit selected employee";
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
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddEmployee.Location = new System.Drawing.Point(5, 1242);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(447, 83);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = "+ Add new employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tpStatsStock
            // 
            this.tpStatsStock.Controls.Add(this.btnStockStatsRandomize);
            this.tpStatsStock.Controls.Add(this.btnDeselectStatsStock3);
            this.tpStatsStock.Controls.Add(this.btnDeselectStatsStock2);
            this.tpStatsStock.Controls.Add(this.btnDeselectStatsStock1);
            this.tpStatsStock.Controls.Add(this.chartStock);
            this.tpStatsStock.Controls.Add(this.cbxStats3);
            this.tpStatsStock.Controls.Add(this.cbxStats2);
            this.tpStatsStock.Controls.Add(this.cbxStats1);
            this.tpStatsStock.Location = new System.Drawing.Point(10, 42);
            this.tpStatsStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStatsStock.Name = "tpStatsStock";
            this.tpStatsStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStatsStock.Size = new System.Drawing.Size(2996, 1336);
            this.tpStatsStock.TabIndex = 3;
            this.tpStatsStock.Text = "StatsStock";
            this.tpStatsStock.UseVisualStyleBackColor = true;
            // 
            // btnStockStatsRandomize
            // 
            this.btnStockStatsRandomize.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockStatsRandomize.Location = new System.Drawing.Point(733, 761);
            this.btnStockStatsRandomize.Margin = new System.Windows.Forms.Padding(5);
            this.btnStockStatsRandomize.Name = "btnStockStatsRandomize";
            this.btnStockStatsRandomize.Size = new System.Drawing.Size(176, 136);
            this.btnStockStatsRandomize.TabIndex = 6;
            this.btnStockStatsRandomize.Text = "🎲";
            this.btnStockStatsRandomize.UseVisualStyleBackColor = true;
            this.btnStockStatsRandomize.Visible = false;
            this.btnStockStatsRandomize.Click += new System.EventHandler(this.btnStockStatsRandomize_Click);
            // 
            // btnDeselectStatsStock3
            // 
            this.btnDeselectStatsStock3.BackColor = System.Drawing.Color.Transparent;
            this.btnDeselectStatsStock3.FlatAppearance.BorderSize = 0;
            this.btnDeselectStatsStock3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectStatsStock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectStatsStock3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeselectStatsStock3.Location = new System.Drawing.Point(35, 334);
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
            this.btnDeselectStatsStock2.Location = new System.Drawing.Point(35, 243);
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
            this.btnDeselectStatsStock1.Location = new System.Drawing.Point(35, 153);
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
            chartArea5.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartStock.Legends.Add(legend5);
            this.chartStock.Location = new System.Drawing.Point(752, 88);
            this.chartStock.Margin = new System.Windows.Forms.Padding(5);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Store Stock Total";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Warehouse Stock Total";
            series8.YValuesPerPoint = 6;
            this.chartStock.Series.Add(series7);
            this.chartStock.Series.Add(series8);
            this.chartStock.Size = new System.Drawing.Size(3099, 935);
            this.chartStock.TabIndex = 3;
            this.chartStock.Text = "Stock Chart";
            this.chartStock.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // cbxStats3
            // 
            this.cbxStats3.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats3.FormattingEnabled = true;
            this.cbxStats3.Location = new System.Drawing.Point(83, 334);
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
            this.cbxStats2.Location = new System.Drawing.Point(83, 243);
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
            this.cbxStats1.Location = new System.Drawing.Point(83, 153);
            this.cbxStats1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStats1.Name = "cbxStats1";
            this.cbxStats1.Size = new System.Drawing.Size(252, 65);
            this.cbxStats1.TabIndex = 1;
            this.cbxStats1.Text = "Stock 1";
            this.cbxStats1.SelectedValueChanged += new System.EventHandler(this.cbxStats1_SelectedValueChanged);
            // 
            // tpStockAdd
            // 
            this.tpStockAdd.Controls.Add(this.lblStockAdd_Details);
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
            // lblStockAdd_Details
            // 
            this.lblStockAdd_Details.AutoSize = true;
            this.lblStockAdd_Details.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Details.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Details.Location = new System.Drawing.Point(533, 568);
            this.lblStockAdd_Details.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStockAdd_Details.Name = "lblStockAdd_Details";
            this.lblStockAdd_Details.Size = new System.Drawing.Size(118, 39);
            this.lblStockAdd_Details.TabIndex = 22;
            this.lblStockAdd_Details.Text = "Details";
            // 
            // tbxStockAdd_EANCode
            // 
            this.tbxStockAdd_EANCode.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_EANCode.Location = new System.Drawing.Point(1541, 777);
            this.tbxStockAdd_EANCode.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_EANCode.Name = "tbxStockAdd_EANCode";
            this.tbxStockAdd_EANCode.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_EANCode.TabIndex = 1;
            // 
            // lblStockAddEAN
            // 
            this.lblStockAddEAN.AutoSize = true;
            this.lblStockAddEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAddEAN.Location = new System.Drawing.Point(483, 782);
            this.lblStockAddEAN.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
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
            this.tbxStockAdd_TotalSold.Location = new System.Drawing.Point(4163, 1734);
            this.tbxStockAdd_TotalSold.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_TotalSold.Name = "tbxStockAdd_TotalSold";
            this.tbxStockAdd_TotalSold.Size = new System.Drawing.Size(961, 61);
            this.tbxStockAdd_TotalSold.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.Location = new System.Drawing.Point(2973, 1750);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 53);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.Location = new System.Drawing.Point(477, 656);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 53);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID";
            // 
            // tbxStockAdd_ID
            // 
            this.tbxStockAdd_ID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ID.Location = new System.Drawing.Point(1541, 649);
            this.tbxStockAdd_ID.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_ID.Name = "tbxStockAdd_ID";
            this.tbxStockAdd_ID.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_ID.TabIndex = 13;
            // 
            // tbxStockAdd_Sell
            // 
            this.tbxStockAdd_Sell.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Sell.Location = new System.Drawing.Point(4163, 782);
            this.tbxStockAdd_Sell.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_Sell.Name = "tbxStockAdd_Sell";
            this.tbxStockAdd_Sell.Size = new System.Drawing.Size(991, 61);
            this.tbxStockAdd_Sell.TabIndex = 8;
            // 
            // tbxStockAdd_AddInfo
            // 
            this.tbxStockAdd_AddInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_AddInfo.Location = new System.Drawing.Point(2995, 1400);
            this.tbxStockAdd_AddInfo.Margin = new System.Windows.Forms.Padding(5);
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
            this.label1.Location = new System.Drawing.Point(2979, 1037);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label4.Location = new System.Drawing.Point(2979, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(2973, 796);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 53);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price (€)";
            // 
            // tbxStockAdd_MinimumStock
            // 
            this.tbxStockAdd_MinimumStock.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_MinimumStock.Location = new System.Drawing.Point(4163, 1140);
            this.tbxStockAdd_MinimumStock.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_MinimumStock.Name = "tbxStockAdd_MinimumStock";
            this.tbxStockAdd_MinimumStock.Size = new System.Drawing.Size(991, 61);
            this.tbxStockAdd_MinimumStock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(2973, 1295);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 53);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(2973, 1154);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 53);
            this.label7.TabIndex = 6;
            this.label7.Text = "Minimum Stock Required";
            // 
            // tbxStockAdd_Cost
            // 
            this.tbxStockAdd_Cost.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Cost.Location = new System.Drawing.Point(4163, 653);
            this.tbxStockAdd_Cost.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_Cost.Name = "tbxStockAdd_Cost";
            this.tbxStockAdd_Cost.Size = new System.Drawing.Size(991, 61);
            this.tbxStockAdd_Cost.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(2973, 668);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 53);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cost Price (€)";
            // 
            // tbxStockAdd_WarehouseLocation
            // 
            this.tbxStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseLocation.Location = new System.Drawing.Point(1541, 1350);
            this.tbxStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_WarehouseLocation.Name = "tbxStockAdd_WarehouseLocation";
            this.tbxStockAdd_WarehouseLocation.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_WarehouseLocation.TabIndex = 4;
            // 
            // tbxStockAdd_StoreLocation
            // 
            this.tbxStockAdd_StoreLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreLocation.Location = new System.Drawing.Point(1541, 1831);
            this.tbxStockAdd_StoreLocation.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_StoreLocation.Name = "tbxStockAdd_StoreLocation";
            this.tbxStockAdd_StoreLocation.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_StoreLocation.TabIndex = 6;
            // 
            // lblStockAdd_Store
            // 
            this.lblStockAdd_Store.AutoSize = true;
            this.lblStockAdd_Store.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Store.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Store.Location = new System.Drawing.Point(483, 1622);
            this.lblStockAdd_Store.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lblStockAdd_Warehouse.Location = new System.Drawing.Point(483, 1140);
            this.lblStockAdd_Warehouse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStockAdd_Warehouse.Name = "lblStockAdd_Warehouse";
            this.lblStockAdd_Warehouse.Size = new System.Drawing.Size(188, 39);
            this.lblStockAdd_Warehouse.TabIndex = 0;
            this.lblStockAdd_Warehouse.Text = "Warehouse";
            // 
            // lblStockAdd_WarehouseLocation
            // 
            this.lblStockAdd_WarehouseLocation.AutoSize = true;
            this.lblStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseLocation.Location = new System.Drawing.Point(477, 1362);
            this.lblStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStockAdd_WarehouseLocation.Name = "lblStockAdd_WarehouseLocation";
            this.lblStockAdd_WarehouseLocation.Size = new System.Drawing.Size(466, 53);
            this.lblStockAdd_WarehouseLocation.TabIndex = 0;
            this.lblStockAdd_WarehouseLocation.Text = "Warehouse Location ";
            // 
            // tbxStockAdd_StoreQuantity
            // 
            this.tbxStockAdd_StoreQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreQuantity.Location = new System.Drawing.Point(1541, 1703);
            this.tbxStockAdd_StoreQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_StoreQuantity.Name = "tbxStockAdd_StoreQuantity";
            this.tbxStockAdd_StoreQuantity.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_StoreQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(477, 1843);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store Location ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(477, 1715);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Quantity";
            // 
            // tbxStockAdd_WarehouseQuantity
            // 
            this.tbxStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(1541, 1226);
            this.tbxStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_WarehouseQuantity.Name = "tbxStockAdd_WarehouseQuantity";
            this.tbxStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_WarehouseQuantity.TabIndex = 3;
            // 
            // lblStockAdd_WarehouseQuantity
            // 
            this.lblStockAdd_WarehouseQuantity.AutoSize = true;
            this.lblStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(477, 1233);
            this.lblStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStockAdd_WarehouseQuantity.Name = "lblStockAdd_WarehouseQuantity";
            this.lblStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(450, 53);
            this.lblStockAdd_WarehouseQuantity.TabIndex = 0;
            this.lblStockAdd_WarehouseQuantity.Text = "Warehouse Quantity";
            // 
            // tbxStockAdd_ProductName
            // 
            this.tbxStockAdd_ProductName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ProductName.Location = new System.Drawing.Point(1541, 899);
            this.tbxStockAdd_ProductName.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStockAdd_ProductName.Name = "tbxStockAdd_ProductName";
            this.tbxStockAdd_ProductName.Size = new System.Drawing.Size(1145, 61);
            this.tbxStockAdd_ProductName.TabIndex = 2;
            // 
            // lblProductAdd_StockName
            // 
            this.lblProductAdd_StockName.AutoSize = true;
            this.lblProductAdd_StockName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblProductAdd_StockName.Location = new System.Drawing.Point(477, 916);
            this.lblProductAdd_StockName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductAdd_StockName.Name = "lblProductAdd_StockName";
            this.lblProductAdd_StockName.Size = new System.Drawing.Size(314, 53);
            this.lblProductAdd_StockName.TabIndex = 0;
            this.lblProductAdd_StockName.Text = "Product name";
            // 
            // tpEmployeeAdd
            // 
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_Nationality);
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_Degree);
            this.tpEmployeeAdd.Controls.Add(this.cbxEmployeeAdd_Gender);
            this.tpEmployeeAdd.Controls.Add(this.lblNationionality);
            this.tpEmployeeAdd.Controls.Add(this.lblDegree);
            this.tpEmployeeAdd.Controls.Add(this.lblGender);
            this.tpEmployeeAdd.Controls.Add(this.lblContractType);
            this.tpEmployeeAdd.Controls.Add(this.cbxEmployeeAdd_ContractType);
            this.tpEmployeeAdd.Controls.Add(this.lblEndingDate);
            this.tpEmployeeAdd.Controls.Add(this.dtpEmployeeAdd_EndingDate);
            this.tpEmployeeAdd.Controls.Add(this.dtpEmployeeAdd_StartingDate);
            this.tpEmployeeAdd.Controls.Add(this.lblStartDate);
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
            // tbxEmployeeAdd_Nationality
            // 
            this.tbxEmployeeAdd_Nationality.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_Nationality.Location = new System.Drawing.Point(619, 1135);
            this.tbxEmployeeAdd_Nationality.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_Nationality.Name = "tbxEmployeeAdd_Nationality";
            this.tbxEmployeeAdd_Nationality.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_Nationality.TabIndex = 66;
            // 
            // tbxEmployeeAdd_Degree
            // 
            this.tbxEmployeeAdd_Degree.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_Degree.Location = new System.Drawing.Point(619, 1066);
            this.tbxEmployeeAdd_Degree.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_Degree.Name = "tbxEmployeeAdd_Degree";
            this.tbxEmployeeAdd_Degree.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_Degree.TabIndex = 65;
            // 
            // cbxEmployeeAdd_Gender
            // 
            this.cbxEmployeeAdd_Gender.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_Gender.FormattingEnabled = true;
            this.cbxEmployeeAdd_Gender.ItemHeight = 53;
            this.cbxEmployeeAdd_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxEmployeeAdd_Gender.Location = new System.Drawing.Point(619, 994);
            this.cbxEmployeeAdd_Gender.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEmployeeAdd_Gender.Name = "cbxEmployeeAdd_Gender";
            this.cbxEmployeeAdd_Gender.Size = new System.Drawing.Size(620, 61);
            this.cbxEmployeeAdd_Gender.TabIndex = 64;
            // 
            // lblNationionality
            // 
            this.lblNationionality.AutoSize = true;
            this.lblNationionality.Font = new System.Drawing.Font("Arial", 14F);
            this.lblNationionality.Location = new System.Drawing.Point(5, 1152);
            this.lblNationionality.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNationionality.Name = "lblNationionality";
            this.lblNationionality.Size = new System.Drawing.Size(240, 53);
            this.lblNationionality.TabIndex = 63;
            this.lblNationionality.Text = "Nationality";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDegree.Location = new System.Drawing.Point(11, 1073);
            this.lblDegree.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(177, 53);
            this.lblDegree.TabIndex = 62;
            this.lblDegree.Text = "Degree";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 14F);
            this.lblGender.Location = new System.Drawing.Point(11, 994);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(180, 53);
            this.lblGender.TabIndex = 61;
            this.lblGender.Text = "Gender";
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContractType.Location = new System.Drawing.Point(5, 930);
            this.lblContractType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(313, 53);
            this.lblContractType.TabIndex = 60;
            this.lblContractType.Text = "Contract Type";
            // 
            // cbxEmployeeAdd_ContractType
            // 
            this.cbxEmployeeAdd_ContractType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_ContractType.FormattingEnabled = true;
            this.cbxEmployeeAdd_ContractType.ItemHeight = 53;
            this.cbxEmployeeAdd_ContractType.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cbxEmployeeAdd_ContractType.Location = new System.Drawing.Point(619, 923);
            this.cbxEmployeeAdd_ContractType.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEmployeeAdd_ContractType.Name = "cbxEmployeeAdd_ContractType";
            this.cbxEmployeeAdd_ContractType.Size = new System.Drawing.Size(620, 61);
            this.cbxEmployeeAdd_ContractType.TabIndex = 59;
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEndingDate.Location = new System.Drawing.Point(5, 868);
            this.lblEndingDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(280, 53);
            this.lblEndingDate.TabIndex = 58;
            this.lblEndingDate.Text = "Ending Date";
            // 
            // dtpEmployeeAdd_EndingDate
            // 
            this.dtpEmployeeAdd_EndingDate.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_EndingDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_EndingDate.Location = new System.Drawing.Point(619, 868);
            this.dtpEmployeeAdd_EndingDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEmployeeAdd_EndingDate.Name = "dtpEmployeeAdd_EndingDate";
            this.dtpEmployeeAdd_EndingDate.Size = new System.Drawing.Size(620, 46);
            this.dtpEmployeeAdd_EndingDate.TabIndex = 57;
            this.dtpEmployeeAdd_EndingDate.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // dtpEmployeeAdd_StartingDate
            // 
            this.dtpEmployeeAdd_StartingDate.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_StartingDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_StartingDate.Location = new System.Drawing.Point(619, 813);
            this.dtpEmployeeAdd_StartingDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEmployeeAdd_StartingDate.Name = "dtpEmployeeAdd_StartingDate";
            this.dtpEmployeeAdd_StartingDate.Size = new System.Drawing.Size(620, 46);
            this.dtpEmployeeAdd_StartingDate.TabIndex = 56;
            this.dtpEmployeeAdd_StartingDate.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStartDate.Location = new System.Drawing.Point(-3, 816);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(296, 53);
            this.lblStartDate.TabIndex = 55;
            this.lblStartDate.Text = "Starting Date";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSalary.Location = new System.Drawing.Point(-8, 744);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(343, 53);
            this.lblSalary.TabIndex = 54;
            this.lblSalary.Text = "Salary per hour";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxSalary.Location = new System.Drawing.Point(619, 744);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(620, 61);
            this.tbxSalary.TabIndex = 53;
            // 
            // btnEmployeeAdd_ConfirmEdit
            // 
            this.btnEmployeeAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployeeAdd_ConfirmEdit.Location = new System.Drawing.Point(2563, 1245);
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
            this.lblEmployeeAdd_Details.Location = new System.Drawing.Point(13, 398);
            this.lblEmployeeAdd_Details.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.cbxEmployeeAdd_Position.Items.AddRange(new object[] {
            "MANAGER",
            "HR",
            "SALES",
            "DEPOT",
            "SECURITY"});
            this.cbxEmployeeAdd_Position.Location = new System.Drawing.Point(619, 672);
            this.cbxEmployeeAdd_Position.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEmployeeAdd_Position.Name = "cbxEmployeeAdd_Position";
            this.cbxEmployeeAdd_Position.Size = new System.Drawing.Size(620, 61);
            this.cbxEmployeeAdd_Position.TabIndex = 45;
            // 
            // cbxEmployeeAdd_ICERelationship
            // 
            this.cbxEmployeeAdd_ICERelationship.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_ICERelationship.FormattingEnabled = true;
            this.cbxEmployeeAdd_ICERelationship.Items.AddRange(new object[] {
            "PARTNER",
            "FATHER",
            "MOTHER",
            "BROTHER",
            "SISTER",
            "UNCLE",
            "AUNT",
            "COUSIN",
            "FRIEND",
            "OTHER"});
            this.cbxEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(1899, 455);
            this.cbxEmployeeAdd_ICERelationship.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEmployeeAdd_ICERelationship.Name = "cbxEmployeeAdd_ICERelationship";
            this.cbxEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(513, 61);
            this.cbxEmployeeAdd_ICERelationship.TabIndex = 47;
            // 
            // dtpEmployeeAdd_DateOfBirth
            // 
            this.dtpEmployeeAdd_DateOfBirth.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(619, 546);
            this.dtpEmployeeAdd_DateOfBirth.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEmployeeAdd_DateOfBirth.Name = "dtpEmployeeAdd_DateOfBirth";
            this.dtpEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(620, 46);
            this.dtpEmployeeAdd_DateOfBirth.TabIndex = 43;
            this.dtpEmployeeAdd_DateOfBirth.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // btnBackToEmpPage
            // 
            this.btnBackToEmpPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToEmpPage.Location = new System.Drawing.Point(-645, 713);
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
            this.btnEmployeeAdd_Confirm.Location = new System.Drawing.Point(2136, 1245);
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
            this.lblEmployeeAdd_FirstName.Location = new System.Drawing.Point(8, 198);
            this.lblEmployeeAdd_FirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_FirstName.Name = "lblEmployeeAdd_FirstName";
            this.lblEmployeeAdd_FirstName.Size = new System.Drawing.Size(244, 53);
            this.lblEmployeeAdd_FirstName.TabIndex = 41;
            this.lblEmployeeAdd_FirstName.Text = "First name";
            // 
            // tbxEmployeeAdd_FirstName
            // 
            this.tbxEmployeeAdd_FirstName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_FirstName.Location = new System.Drawing.Point(619, 196);
            this.tbxEmployeeAdd_FirstName.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_FirstName.Name = "tbxEmployeeAdd_FirstName";
            this.tbxEmployeeAdd_FirstName.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_FirstName.TabIndex = 40;
            // 
            // tbxEmployeeAdd_AdditonalInfo
            // 
            this.tbxEmployeeAdd_AdditonalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_AdditonalInfo.Location = new System.Drawing.Point(1925, 816);
            this.tbxEmployeeAdd_AdditonalInfo.Margin = new System.Windows.Forms.Padding(5);
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
            this.lblEmployeeAdd_ICE.Location = new System.Drawing.Point(1909, 176);
            this.lblEmployeeAdd_ICE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_ICE.Name = "lblEmployeeAdd_ICE";
            this.lblEmployeeAdd_ICE.Size = new System.Drawing.Size(346, 39);
            this.lblEmployeeAdd_ICE.TabIndex = 31;
            this.lblEmployeeAdd_ICE.Text = "In Case of Emergency";
            // 
            // lblEmployeeAdd_ICERelationship
            // 
            this.lblEmployeeAdd_ICERelationship.AutoSize = true;
            this.lblEmployeeAdd_ICERelationship.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(1899, 398);
            this.lblEmployeeAdd_ICERelationship.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_ICERelationship.Name = "lblEmployeeAdd_ICERelationship";
            this.lblEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(370, 53);
            this.lblEmployeeAdd_ICERelationship.TabIndex = 32;
            this.lblEmployeeAdd_ICERelationship.Text = "ICE Relationship";
            // 
            // lblEmployeeAdd_AdditionalInfo
            // 
            this.lblEmployeeAdd_AdditionalInfo.AutoSize = true;
            this.lblEmployeeAdd_AdditionalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_AdditionalInfo.Location = new System.Drawing.Point(1904, 708);
            this.lblEmployeeAdd_AdditionalInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_AdditionalInfo.Name = "lblEmployeeAdd_AdditionalInfo";
            this.lblEmployeeAdd_AdditionalInfo.Size = new System.Drawing.Size(472, 53);
            this.lblEmployeeAdd_AdditionalInfo.TabIndex = 34;
            this.lblEmployeeAdd_AdditionalInfo.Text = "Additional Information";
            // 
            // tbxEmployeeAdd_ICENumber
            // 
            this.tbxEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_ICENumber.Location = new System.Drawing.Point(1909, 320);
            this.tbxEmployeeAdd_ICENumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_ICENumber.Name = "tbxEmployeeAdd_ICENumber";
            this.tbxEmployeeAdd_ICENumber.Size = new System.Drawing.Size(513, 61);
            this.tbxEmployeeAdd_ICENumber.TabIndex = 46;
            // 
            // lblEmployeeAdd_ICENumber
            // 
            this.lblEmployeeAdd_ICENumber.AutoSize = true;
            this.lblEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICENumber.Location = new System.Drawing.Point(1899, 269);
            this.lblEmployeeAdd_ICENumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lblEmployeeAdd_Name.Location = new System.Drawing.Point(13, 105);
            this.lblEmployeeAdd_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_Name.Name = "lblEmployeeAdd_Name";
            this.lblEmployeeAdd_Name.Size = new System.Drawing.Size(105, 39);
            this.lblEmployeeAdd_Name.TabIndex = 26;
            this.lblEmployeeAdd_Name.Text = "Name";
            // 
            // lblEmployeeAdd_DateOfBirth
            // 
            this.lblEmployeeAdd_DateOfBirth.AutoSize = true;
            this.lblEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(-3, 548);
            this.lblEmployeeAdd_DateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_DateOfBirth.Name = "lblEmployeeAdd_DateOfBirth";
            this.lblEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(278, 53);
            this.lblEmployeeAdd_DateOfBirth.TabIndex = 25;
            this.lblEmployeeAdd_DateOfBirth.Text = "Date of birth";
            // 
            // tbxEmployeeAdd_PhoneNumber
            // 
            this.tbxEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(619, 603);
            this.tbxEmployeeAdd_PhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_PhoneNumber.Name = "tbxEmployeeAdd_PhoneNumber";
            this.tbxEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_PhoneNumber.TabIndex = 44;
            // 
            // lblEmployeeAdd_Position
            // 
            this.lblEmployeeAdd_Position.AutoSize = true;
            this.lblEmployeeAdd_Position.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_Position.Location = new System.Drawing.Point(-3, 682);
            this.lblEmployeeAdd_Position.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_Position.Name = "lblEmployeeAdd_Position";
            this.lblEmployeeAdd_Position.Size = new System.Drawing.Size(189, 53);
            this.lblEmployeeAdd_Position.TabIndex = 24;
            this.lblEmployeeAdd_Position.Text = "Position";
            // 
            // lblEmployeeAdd_PhoneNumber
            // 
            this.lblEmployeeAdd_PhoneNumber.AutoSize = true;
            this.lblEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(-8, 613);
            this.lblEmployeeAdd_PhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_PhoneNumber.Name = "lblEmployeeAdd_PhoneNumber";
            this.lblEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(329, 53);
            this.lblEmployeeAdd_PhoneNumber.TabIndex = 23;
            this.lblEmployeeAdd_PhoneNumber.Text = "Phone number";
            // 
            // tbxEmployeeAdd_BSN
            // 
            this.tbxEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_BSN.Location = new System.Drawing.Point(619, 477);
            this.tbxEmployeeAdd_BSN.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_BSN.Name = "tbxEmployeeAdd_BSN";
            this.tbxEmployeeAdd_BSN.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_BSN.TabIndex = 42;
            // 
            // lblEmployeeAdd_BSN
            // 
            this.lblEmployeeAdd_BSN.AutoSize = true;
            this.lblEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_BSN.Location = new System.Drawing.Point(8, 484);
            this.lblEmployeeAdd_BSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_BSN.Name = "lblEmployeeAdd_BSN";
            this.lblEmployeeAdd_BSN.Size = new System.Drawing.Size(119, 53);
            this.lblEmployeeAdd_BSN.TabIndex = 22;
            this.lblEmployeeAdd_BSN.Text = "BSN";
            // 
            // tbxEmployeeAdd_SecondName
            // 
            this.tbxEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_SecondName.Location = new System.Drawing.Point(619, 324);
            this.tbxEmployeeAdd_SecondName.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmployeeAdd_SecondName.Name = "tbxEmployeeAdd_SecondName";
            this.tbxEmployeeAdd_SecondName.Size = new System.Drawing.Size(620, 61);
            this.tbxEmployeeAdd_SecondName.TabIndex = 41;
            // 
            // lblEmployeeAdd_SecondName
            // 
            this.lblEmployeeAdd_SecondName.AutoSize = true;
            this.lblEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_SecondName.Location = new System.Drawing.Point(8, 327);
            this.lblEmployeeAdd_SecondName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployeeAdd_SecondName.Name = "lblEmployeeAdd_SecondName";
            this.lblEmployeeAdd_SecondName.Size = new System.Drawing.Size(311, 53);
            this.lblEmployeeAdd_SecondName.TabIndex = 21;
            this.lblEmployeeAdd_SecondName.Text = "Second name";
            // 
            // tpStatsEmployee
            // 
            this.tpStatsEmployee.Controls.Add(this.chartEmployeesPosition);
            this.tpStatsEmployee.Location = new System.Drawing.Point(10, 42);
            this.tpStatsEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.tpStatsEmployee.Name = "tpStatsEmployee";
            this.tpStatsEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.tpStatsEmployee.Size = new System.Drawing.Size(2996, 1336);
            this.tpStatsEmployee.TabIndex = 6;
            this.tpStatsEmployee.Text = "StatsEmp";
            this.tpStatsEmployee.UseVisualStyleBackColor = true;
            // 
            // chartEmployeesPosition
            // 
            chartArea6.Name = "ChartArea1";
            this.chartEmployeesPosition.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartEmployeesPosition.Legends.Add(legend6);
            this.chartEmployeesPosition.Location = new System.Drawing.Point(11, 0);
            this.chartEmployeesPosition.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.chartEmployeesPosition.Name = "chartEmployeesPosition";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.Legend = "Legend1";
            series9.Name = "Positions";
            this.chartEmployeesPosition.Series.Add(series9);
            this.chartEmployeesPosition.Size = new System.Drawing.Size(2603, 1808);
            this.chartEmployeesPosition.TabIndex = 0;
            this.chartEmployeesPosition.Text = "chart1";
            // 
            // tpNewOrder
            // 
            this.tpNewOrder.Controls.Add(this.btnNewOrderBack);
            this.tpNewOrder.Controls.Add(this.btnAddNewOrder);
            this.tpNewOrder.Controls.Add(this.tbNewOrderEAN);
            this.tpNewOrder.Controls.Add(this.label11);
            this.tpNewOrder.Controls.Add(this.label13);
            this.tpNewOrder.Controls.Add(this.tbNewOrderID);
            this.tpNewOrder.Controls.Add(this.label19);
            this.tpNewOrder.Controls.Add(this.label20);
            this.tpNewOrder.Controls.Add(this.tbNewOrderWarehouse);
            this.tpNewOrder.Controls.Add(this.label23);
            this.tpNewOrder.Controls.Add(this.tbNewOrderStore);
            this.tpNewOrder.Controls.Add(this.label24);
            this.tpNewOrder.Controls.Add(this.tbNewOrderName);
            this.tpNewOrder.Controls.Add(this.label25);
            this.tpNewOrder.Location = new System.Drawing.Point(10, 42);
            this.tpNewOrder.Margin = new System.Windows.Forms.Padding(5);
            this.tpNewOrder.Name = "tpNewOrder";
            this.tpNewOrder.Padding = new System.Windows.Forms.Padding(5);
            this.tpNewOrder.Size = new System.Drawing.Size(2996, 1336);
            this.tpNewOrder.TabIndex = 7;
            this.tpNewOrder.Text = "NewOrder";
            this.tpNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewOrderBack
            // 
            this.btnNewOrderBack.Font = new System.Drawing.Font("Arial", 13F);
            this.btnNewOrderBack.Location = new System.Drawing.Point(5, 1247);
            this.btnNewOrderBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewOrderBack.Name = "btnNewOrderBack";
            this.btnNewOrderBack.Size = new System.Drawing.Size(421, 83);
            this.btnNewOrderBack.TabIndex = 50;
            this.btnNewOrderBack.Text = "<- Back to Stock";
            this.btnNewOrderBack.UseVisualStyleBackColor = true;
            this.btnNewOrderBack.Click += new System.EventHandler(this.btnNewOrderBack_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddNewOrder.Location = new System.Drawing.Point(2579, 1247);
            this.btnAddNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(411, 83);
            this.btnAddNewOrder.TabIndex = 49;
            this.btnAddNewOrder.Text = "✎ Add (Confirm)";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // tbNewOrderEAN
            // 
            this.tbNewOrderEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderEAN.Location = new System.Drawing.Point(1560, 253);
            this.tbNewOrderEAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewOrderEAN.Name = "tbNewOrderEAN";
            this.tbNewOrderEAN.Size = new System.Drawing.Size(471, 61);
            this.tbNewOrderEAN.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(1077, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 53);
            this.label11.TabIndex = 48;
            this.label11.Text = "EAN Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(1072, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 53);
            this.label13.TabIndex = 46;
            this.label13.Text = "Product ID";
            // 
            // tbNewOrderID
            // 
            this.tbNewOrderID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderID.Location = new System.Drawing.Point(1560, 186);
            this.tbNewOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewOrderID.Name = "tbNewOrderID";
            this.tbNewOrderID.Size = new System.Drawing.Size(471, 61);
            this.tbNewOrderID.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(1016, 668);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 39);
            this.label19.TabIndex = 28;
            this.label19.Text = "Store";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(1016, 529);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 39);
            this.label20.TabIndex = 27;
            this.label20.Text = "Warehouse";
            // 
            // tbNewOrderWarehouse
            // 
            this.tbNewOrderWarehouse.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderWarehouse.Location = new System.Drawing.Point(1643, 696);
            this.tbNewOrderWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewOrderWarehouse.Name = "tbNewOrderWarehouse";
            this.tbNewOrderWarehouse.Size = new System.Drawing.Size(471, 61);
            this.tbNewOrderWarehouse.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 14F);
            this.label23.Location = new System.Drawing.Point(1016, 711);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(454, 53);
            this.label23.TabIndex = 24;
            this.label23.Text = "Store quantity to add";
            // 
            // tbNewOrderStore
            // 
            this.tbNewOrderStore.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderStore.Location = new System.Drawing.Point(1643, 570);
            this.tbNewOrderStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewOrderStore.Name = "tbNewOrderStore";
            this.tbNewOrderStore.Size = new System.Drawing.Size(471, 61);
            this.tbNewOrderStore.TabIndex = 32;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 14F);
            this.label24.Location = new System.Drawing.Point(1016, 575);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(582, 53);
            this.label24.TabIndex = 23;
            this.label24.Text = "Warehouse quantity to add";
            // 
            // tbNewOrderName
            // 
            this.tbNewOrderName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderName.Location = new System.Drawing.Point(1560, 315);
            this.tbNewOrderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewOrderName.Name = "tbNewOrderName";
            this.tbNewOrderName.Size = new System.Drawing.Size(471, 61);
            this.tbNewOrderName.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 14F);
            this.label25.Location = new System.Drawing.Point(1072, 322);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(314, 53);
            this.label25.TabIndex = 22;
            this.label25.Text = "Product name";
            // 
            // tpSellProduct
            // 
            this.tpSellProduct.Controls.Add(this.btnSellConfirm);
            this.tpSellProduct.Controls.Add(this.btnSellProdBack);
            this.tpSellProduct.Controls.Add(this.tbSellEAN);
            this.tpSellProduct.Controls.Add(this.label12);
            this.tpSellProduct.Controls.Add(this.label14);
            this.tpSellProduct.Controls.Add(this.tbSellID);
            this.tpSellProduct.Controls.Add(this.label15);
            this.tpSellProduct.Controls.Add(this.tbSellQuantity);
            this.tpSellProduct.Controls.Add(this.label17);
            this.tpSellProduct.Controls.Add(this.tbSellName);
            this.tpSellProduct.Controls.Add(this.label21);
            this.tpSellProduct.Location = new System.Drawing.Point(10, 42);
            this.tpSellProduct.Margin = new System.Windows.Forms.Padding(5);
            this.tpSellProduct.Name = "tpSellProduct";
            this.tpSellProduct.Padding = new System.Windows.Forms.Padding(5);
            this.tpSellProduct.Size = new System.Drawing.Size(2996, 1336);
            this.tpSellProduct.TabIndex = 8;
            this.tpSellProduct.Text = "SellProduct";
            this.tpSellProduct.UseVisualStyleBackColor = true;
            // 
            // btnSellConfirm
            // 
            this.btnSellConfirm.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSellConfirm.Location = new System.Drawing.Point(2579, 1247);
            this.btnSellConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellConfirm.Name = "btnSellConfirm";
            this.btnSellConfirm.Size = new System.Drawing.Size(411, 83);
            this.btnSellConfirm.TabIndex = 62;
            this.btnSellConfirm.Text = "✎ Sell (Confirm)";
            this.btnSellConfirm.UseVisualStyleBackColor = true;
            this.btnSellConfirm.Click += new System.EventHandler(this.btnSellConfirm_Click);
            // 
            // btnSellProdBack
            // 
            this.btnSellProdBack.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSellProdBack.Location = new System.Drawing.Point(5, 1247);
            this.btnSellProdBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellProdBack.Name = "btnSellProdBack";
            this.btnSellProdBack.Size = new System.Drawing.Size(421, 83);
            this.btnSellProdBack.TabIndex = 61;
            this.btnSellProdBack.Text = "<- Back to Stock";
            this.btnSellProdBack.UseVisualStyleBackColor = true;
            this.btnSellProdBack.Click += new System.EventHandler(this.btnSellProdBack_Click);
            // 
            // tbSellEAN
            // 
            this.tbSellEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellEAN.Location = new System.Drawing.Point(1560, 253);
            this.tbSellEAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSellEAN.Name = "tbSellEAN";
            this.tbSellEAN.Size = new System.Drawing.Size(471, 61);
            this.tbSellEAN.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(1077, 253);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 53);
            this.label12.TabIndex = 60;
            this.label12.Text = "EAN Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F);
            this.label14.Location = new System.Drawing.Point(1072, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 53);
            this.label14.TabIndex = 59;
            this.label14.Text = "Product ID";
            // 
            // tbSellID
            // 
            this.tbSellID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellID.Location = new System.Drawing.Point(1560, 186);
            this.tbSellID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSellID.Name = "tbSellID";
            this.tbSellID.Size = new System.Drawing.Size(471, 61);
            this.tbSellID.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(1072, 563);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 39);
            this.label15.TabIndex = 53;
            this.label15.Text = "Store";
            // 
            // tbSellQuantity
            // 
            this.tbSellQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellQuantity.Location = new System.Drawing.Point(1560, 594);
            this.tbSellQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSellQuantity.Name = "tbSellQuantity";
            this.tbSellQuantity.Size = new System.Drawing.Size(471, 61);
            this.tbSellQuantity.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14F);
            this.label17.Location = new System.Drawing.Point(1072, 606);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(332, 53);
            this.label17.TabIndex = 51;
            this.label17.Text = "Quantity to sell";
            // 
            // tbSellName
            // 
            this.tbSellName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellName.Location = new System.Drawing.Point(1560, 315);
            this.tbSellName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSellName.Name = "tbSellName";
            this.tbSellName.Size = new System.Drawing.Size(471, 61);
            this.tbSellName.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14F);
            this.label21.Location = new System.Drawing.Point(1072, 322);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(314, 53);
            this.label21.TabIndex = 49;
            this.label21.Text = "Product name";
            // 
            // tpRequestChangeInfo
            // 
            this.tpRequestChangeInfo.Controls.Add(this.lblChangeInfo);
            this.tpRequestChangeInfo.Controls.Add(this.lbChangeInfo);
            this.tpRequestChangeInfo.Controls.Add(this.gbOldInfo);
            this.tpRequestChangeInfo.Controls.Add(this.gbNewInfo);
            this.tpRequestChangeInfo.Controls.Add(this.label22);
            this.tpRequestChangeInfo.Location = new System.Drawing.Point(10, 42);
            this.tpRequestChangeInfo.Name = "tpRequestChangeInfo";
            this.tpRequestChangeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRequestChangeInfo.Size = new System.Drawing.Size(2996, 1336);
            this.tpRequestChangeInfo.TabIndex = 12;
            this.tpRequestChangeInfo.Text = "RequestChangeInfo";
            this.tpRequestChangeInfo.UseVisualStyleBackColor = true;
            // 
            // lblChangeInfo
            // 
            this.lblChangeInfo.AutoSize = true;
            this.lblChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeInfo.Location = new System.Drawing.Point(83, 53);
            this.lblChangeInfo.Name = "lblChangeInfo";
            this.lblChangeInfo.Size = new System.Drawing.Size(341, 44);
            this.lblChangeInfo.TabIndex = 5;
            this.lblChangeInfo.Text = "Choose employee";
            // 
            // lbChangeInfo
            // 
            this.lbChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeInfo.FormattingEnabled = true;
            this.lbChangeInfo.ItemHeight = 42;
            this.lbChangeInfo.Location = new System.Drawing.Point(82, 118);
            this.lbChangeInfo.Name = "lbChangeInfo";
            this.lbChangeInfo.Size = new System.Drawing.Size(1660, 1138);
            this.lbChangeInfo.TabIndex = 4;
            // 
            // gbOldInfo
            // 
            this.gbOldInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbOldInfo.Controls.Add(this.label42);
            this.gbOldInfo.Controls.Add(this.label41);
            this.gbOldInfo.Controls.Add(this.label40);
            this.gbOldInfo.Controls.Add(this.label39);
            this.gbOldInfo.Controls.Add(this.label38);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_ICErelation);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_ICEnumber);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_PhoneNumber);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_SecondName);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_FirstName);
            this.gbOldInfo.Controls.Add(this.label26);
            this.gbOldInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOldInfo.Location = new System.Drawing.Point(1828, 118);
            this.gbOldInfo.Name = "gbOldInfo";
            this.gbOldInfo.Size = new System.Drawing.Size(1016, 511);
            this.gbOldInfo.TabIndex = 2;
            this.gbOldInfo.TabStop = false;
            this.gbOldInfo.Text = "Old info";
            // 
            // lblOldInfo_ICErelation
            // 
            this.lblOldInfo_ICErelation.AutoSize = true;
            this.lblOldInfo_ICErelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_ICErelation.Location = new System.Drawing.Point(41, 381);
            this.lblOldInfo_ICErelation.Name = "lblOldInfo_ICErelation";
            this.lblOldInfo_ICErelation.Size = new System.Drawing.Size(218, 39);
            this.lblOldInfo_ICErelation.TabIndex = 5;
            this.lblOldInfo_ICErelation.Text = "ICE relation:";
            // 
            // lblOldInfo_ICEnumber
            // 
            this.lblOldInfo_ICEnumber.AutoSize = true;
            this.lblOldInfo_ICEnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_ICEnumber.Location = new System.Drawing.Point(41, 309);
            this.lblOldInfo_ICEnumber.Name = "lblOldInfo_ICEnumber";
            this.lblOldInfo_ICEnumber.Size = new System.Drawing.Size(219, 39);
            this.lblOldInfo_ICEnumber.TabIndex = 4;
            this.lblOldInfo_ICEnumber.Text = "ICE number:";
            // 
            // lblOldInfo_PhoneNumber
            // 
            this.lblOldInfo_PhoneNumber.AutoSize = true;
            this.lblOldInfo_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_PhoneNumber.Location = new System.Drawing.Point(41, 238);
            this.lblOldInfo_PhoneNumber.Name = "lblOldInfo_PhoneNumber";
            this.lblOldInfo_PhoneNumber.Size = new System.Drawing.Size(268, 39);
            this.lblOldInfo_PhoneNumber.TabIndex = 4;
            this.lblOldInfo_PhoneNumber.Text = "Phone Number:";
            // 
            // lblOldInfo_SecondName
            // 
            this.lblOldInfo_SecondName.AutoSize = true;
            this.lblOldInfo_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_SecondName.Location = new System.Drawing.Point(41, 170);
            this.lblOldInfo_SecondName.Name = "lblOldInfo_SecondName";
            this.lblOldInfo_SecondName.Size = new System.Drawing.Size(248, 39);
            this.lblOldInfo_SecondName.TabIndex = 4;
            this.lblOldInfo_SecondName.Text = "Second name:";
            // 
            // lblOldInfo_FirstName
            // 
            this.lblOldInfo_FirstName.AutoSize = true;
            this.lblOldInfo_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_FirstName.Location = new System.Drawing.Point(41, 106);
            this.lblOldInfo_FirstName.Name = "lblOldInfo_FirstName";
            this.lblOldInfo_FirstName.Size = new System.Drawing.Size(207, 39);
            this.lblOldInfo_FirstName.TabIndex = 2;
            this.lblOldInfo_FirstName.Text = "First name: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 44);
            this.label26.TabIndex = 0;
            // 
            // gbNewInfo
            // 
            this.gbNewInfo.Controls.Add(this.label33);
            this.gbNewInfo.Controls.Add(this.label34);
            this.gbNewInfo.Controls.Add(this.label35);
            this.gbNewInfo.Controls.Add(this.label36);
            this.gbNewInfo.Controls.Add(this.label37);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_ICErelation);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_ICEnumber);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_PhoneNumber);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_SecondName);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_FirstName);
            this.gbNewInfo.Controls.Add(this.btnDeclineInfoChanges);
            this.gbNewInfo.Controls.Add(this.btnApproveInfoChanges);
            this.gbNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewInfo.Location = new System.Drawing.Point(1828, 673);
            this.gbNewInfo.Name = "gbNewInfo";
            this.gbNewInfo.Size = new System.Drawing.Size(1016, 599);
            this.gbNewInfo.TabIndex = 3;
            this.gbNewInfo.TabStop = false;
            this.gbNewInfo.Text = "New info";
            // 
            // btnDeclineInfoChanges
            // 
            this.btnDeclineInfoChanges.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeclineInfoChanges.Location = new System.Drawing.Point(538, 474);
            this.btnDeclineInfoChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeclineInfoChanges.Name = "btnDeclineInfoChanges";
            this.btnDeclineInfoChanges.Size = new System.Drawing.Size(426, 83);
            this.btnDeclineInfoChanges.TabIndex = 16;
            this.btnDeclineInfoChanges.Text = "❌ Decline changes";
            this.btnDeclineInfoChanges.UseVisualStyleBackColor = true;
            // 
            // btnApproveInfoChanges
            // 
            this.btnApproveInfoChanges.Font = new System.Drawing.Font("Arial", 12F);
            this.btnApproveInfoChanges.Location = new System.Drawing.Point(48, 474);
            this.btnApproveInfoChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApproveInfoChanges.Name = "btnApproveInfoChanges";
            this.btnApproveInfoChanges.Size = new System.Drawing.Size(426, 83);
            this.btnApproveInfoChanges.TabIndex = 15;
            this.btnApproveInfoChanges.Text = "✔️ Approve changes";
            this.btnApproveInfoChanges.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(85, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 36);
            this.label22.TabIndex = 0;
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
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(389, 106);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(187, 39);
            this.label38.TabIndex = 6;
            this.label38.Text = "First name";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(389, 170);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(238, 39);
            this.label39.TabIndex = 7;
            this.label39.Text = "Second name";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(389, 238);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(258, 39);
            this.label40.TabIndex = 8;
            this.label40.Text = "Phone Number";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(389, 309);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(209, 39);
            this.label41.TabIndex = 9;
            this.label41.Text = "ICE number";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(389, 381);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(208, 39);
            this.label42.TabIndex = 10;
            this.label42.Text = "ICE relation";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(389, 370);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(208, 39);
            this.label33.TabIndex = 26;
            this.label33.Text = "ICE relation";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(389, 298);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(209, 39);
            this.label34.TabIndex = 25;
            this.label34.Text = "ICE number";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(389, 227);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(258, 39);
            this.label35.TabIndex = 24;
            this.label35.Text = "Phone Number";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(389, 159);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(238, 39);
            this.label36.TabIndex = 23;
            this.label36.Text = "Second name";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(389, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(187, 39);
            this.label37.TabIndex = 22;
            this.label37.Text = "First name";
            // 
            // lblNewInfo_ICErelation
            // 
            this.lblNewInfo_ICErelation.AutoSize = true;
            this.lblNewInfo_ICErelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_ICErelation.Location = new System.Drawing.Point(41, 370);
            this.lblNewInfo_ICErelation.Name = "lblNewInfo_ICErelation";
            this.lblNewInfo_ICErelation.Size = new System.Drawing.Size(218, 39);
            this.lblNewInfo_ICErelation.TabIndex = 21;
            this.lblNewInfo_ICErelation.Text = "ICE relation:";
            // 
            // lblNewInfo_ICEnumber
            // 
            this.lblNewInfo_ICEnumber.AutoSize = true;
            this.lblNewInfo_ICEnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_ICEnumber.Location = new System.Drawing.Point(41, 298);
            this.lblNewInfo_ICEnumber.Name = "lblNewInfo_ICEnumber";
            this.lblNewInfo_ICEnumber.Size = new System.Drawing.Size(219, 39);
            this.lblNewInfo_ICEnumber.TabIndex = 18;
            this.lblNewInfo_ICEnumber.Text = "ICE number:";
            // 
            // lblNewInfo_PhoneNumber
            // 
            this.lblNewInfo_PhoneNumber.AutoSize = true;
            this.lblNewInfo_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_PhoneNumber.Location = new System.Drawing.Point(41, 227);
            this.lblNewInfo_PhoneNumber.Name = "lblNewInfo_PhoneNumber";
            this.lblNewInfo_PhoneNumber.Size = new System.Drawing.Size(268, 39);
            this.lblNewInfo_PhoneNumber.TabIndex = 19;
            this.lblNewInfo_PhoneNumber.Text = "Phone Number:";
            // 
            // lblNewInfo_SecondName
            // 
            this.lblNewInfo_SecondName.AutoSize = true;
            this.lblNewInfo_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_SecondName.Location = new System.Drawing.Point(41, 159);
            this.lblNewInfo_SecondName.Name = "lblNewInfo_SecondName";
            this.lblNewInfo_SecondName.Size = new System.Drawing.Size(248, 39);
            this.lblNewInfo_SecondName.TabIndex = 20;
            this.lblNewInfo_SecondName.Text = "Second name:";
            // 
            // lblNewInfo_FirstName
            // 
            this.lblNewInfo_FirstName.AutoSize = true;
            this.lblNewInfo_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_FirstName.Location = new System.Drawing.Point(41, 95);
            this.lblNewInfo_FirstName.Name = "lblNewInfo_FirstName";
            this.lblNewInfo_FirstName.Size = new System.Drawing.Size(207, 39);
            this.lblNewInfo_FirstName.TabIndex = 17;
            this.lblNewInfo_FirstName.Text = "First name: ";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3077, 1645);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(3077, 1645);
            this.MinimumSize = new System.Drawing.Size(3077, 1645);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlTabCover.ResumeLayout(false);
            this.gpnlStatsType.ResumeLayout(false);
            this.gpnlStatistics.ResumeLayout(false);
            this.gpnlSchedules.ResumeLayout(false);
            this.gpnlStock.ResumeLayout(false);
            this.gpnlEmployees.ResumeLayout(false);
            this.tcNavigator.ResumeLayout(false);
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).EndInit();
            this.tpSchedulesEmp.ResumeLayout(false);
            this.tpSchedulesEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScheduleEmpWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulesEmp)).EndInit();
            this.tpSchedulesCreate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSchedulesCreateWeek)).EndInit();
            this.tpScheduleMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleMinP)).EndInit();
            this.tpScheduleChoise.ResumeLayout(false);
            this.gpnlViewSchedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewSchedules)).EndInit();
            this.gpnlCreateSchedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSchedules)).EndInit();
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tpStatsStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.tpStockAdd.ResumeLayout(false);
            this.tpStockAdd.PerformLayout();
            this.tpEmployeeAdd.ResumeLayout(false);
            this.tpEmployeeAdd.PerformLayout();
            this.tpStatsEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesPosition)).EndInit();
            this.tpNewOrder.ResumeLayout(false);
            this.tpNewOrder.PerformLayout();
            this.tpSellProduct.ResumeLayout(false);
            this.tpSellProduct.PerformLayout();
            this.tpRequestChangeInfo.ResumeLayout(false);
            this.tpRequestChangeInfo.PerformLayout();
            this.gbOldInfo.ResumeLayout(false);
            this.gbOldInfo.PerformLayout();
            this.gbNewInfo.ResumeLayout(false);
            this.gbNewInfo.PerformLayout();
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
        private System.Windows.Forms.TabPage tpSchedulesEmp;
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
        private System.Windows.Forms.DataGridView dgvSchedulesEmp;
        private System.Windows.Forms.Button btnSchedulesEmpShowWeek;
        private System.Windows.Forms.NumericUpDown nudScheduleEmpWeek;
        private System.Windows.Forms.Button btnScheduleEmpSaveCurrentWeek;
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
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ComboBox cbxActiveInactiveEmployees;
        private System.Windows.Forms.Label lblActiveInactiveEmployees;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationS;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityWH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationWH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSold;
        private System.Windows.Forms.TabPage tpStatsEmployee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeesPosition;
        private System.Windows.Forms.Button btnEmpStats;
        private System.Windows.Forms.Button btnStockStats;
        private System.Windows.Forms.Button btnStockStatsRandomize;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSellProduct;
        private System.Windows.Forms.TabPage tpNewOrder;
        private System.Windows.Forms.TabPage tpSellProduct;
        private System.Windows.Forms.TextBox tbNewOrderEAN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNewOrderID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbNewOrderWarehouse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbNewOrderStore;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbNewOrderName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnNewOrderBack;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.TabPage tpScheduleMin;
        private System.Windows.Forms.DataGridView dgvScheduleMinP;
        private System.Windows.Forms.Button btnSchedulesSaveMinPeople;
        private System.Windows.Forms.TextBox tbSellEAN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSellID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSellQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSellName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSellProdBack;
        private System.Windows.Forms.Button btnSellConfirm;
        private System.Windows.Forms.TabPage tpScheduleChoise;
        private GradientPanel gpnlViewSchedules;
        private GradientPanel gpnlCreateSchedules;
        private System.Windows.Forms.TabPage tpSchedulesCreate;
        private System.Windows.Forms.Button btnScheduleEmpSearch;
        private System.Windows.Forms.TextBox tbxScheduleEmpSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSchedulesCreateSaveCurrent;
        private System.Windows.Forms.NumericUpDown nudSchedulesCreateWeek;
        private System.Windows.Forms.Button btnSchedulesCreateShowWeek;
        private System.Windows.Forms.Button btnScheduleCreateMinimumPeople;
        private System.Windows.Forms.Button btnSchedulesCreateLoadTemplate;
        private System.Windows.Forms.Button btnSchedulesCreateSaveTempalte;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedulesEmpFirstName;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpMonday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpTuesday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpWednesday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpThursday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpFriday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpSaturday;
        private System.Windows.Forms.DataGridViewComboBoxColumn schedulesEmpSunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedulesEmpFTE;
        private System.Windows.Forms.PictureBox pbxAddSchedules;
        private System.Windows.Forms.PictureBox pbxViewSchedules;
        private System.Windows.Forms.Label lblCreateSchedules;
        private System.Windows.Forms.Label lblViewSchedules;
        private System.Windows.Forms.Label lblStockAdd_Details;
        private System.Windows.Forms.Button btnStockAdjustColumnWidth;
        private System.Windows.Forms.CheckBox chkShowFTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleMinSunday;
        private System.Windows.Forms.ComboBox cbxEmployeeAdd_ContractType;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeAdd_EndingDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeAdd_StartingDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_Nationality;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_Degree;
        private System.Windows.Forms.ComboBox cbxEmployeeAdd_Gender;
        private System.Windows.Forms.Label lblNationionality;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblGender;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEndingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNationality;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInfoChangeRequest;
        private System.Windows.Forms.TabPage tpRequestChangeInfo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox gbNewInfo;
        private System.Windows.Forms.GroupBox gbOldInfo;
        private System.Windows.Forms.Label lblOldInfo_ICErelation;
        private System.Windows.Forms.Label lblOldInfo_ICEnumber;
        private System.Windows.Forms.Label lblOldInfo_PhoneNumber;
        private System.Windows.Forms.Label lblOldInfo_SecondName;
        private System.Windows.Forms.Label lblOldInfo_FirstName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnDeclineInfoChanges;
        private System.Windows.Forms.Button btnApproveInfoChanges;
        private System.Windows.Forms.ListBox lbChangeInfo;
        private System.Windows.Forms.Label lblChangeInfo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblNewInfo_ICErelation;
        private System.Windows.Forms.Label lblNewInfo_ICEnumber;
        private System.Windows.Forms.Label lblNewInfo_PhoneNumber;
        private System.Windows.Forms.Label lblNewInfo_SecondName;
        private System.Windows.Forms.Label lblNewInfo_FirstName;
    }
}