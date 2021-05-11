
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblScheduleCurrentWeekEmp = new System.Windows.Forms.Label();
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
            this.lblScheduleCurrentWeekCreate = new System.Windows.Forms.Label();
            this.dgvSchedulesCreate = new System.Windows.Forms.DataGridView();
            this.SchedulesCreateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedulesCreateMorning = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SchedulesCreateAfternoon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SchedulesCreateEvening = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SchedulesCreateMinMorning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedulesCreateMinAfternoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedulesCreateMinEvening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScheduleCreateMinimumPeople = new System.Windows.Forms.Button();
            this.btnSchedulesCreateLoadTemplate = new System.Windows.Forms.Button();
            this.btnSchedulesCreateSaveTempalte = new System.Windows.Forms.Button();
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
            this.lblOldInfo_iceRelation_input = new System.Windows.Forms.Label();
            this.lblOldInfo_iceNumber_input = new System.Windows.Forms.Label();
            this.lblOldInfo_PhoneNumber_input = new System.Windows.Forms.Label();
            this.lblOldInfo_SecondName_input = new System.Windows.Forms.Label();
            this.lblOldInfo_FirstName_input = new System.Windows.Forms.Label();
            this.lblOldInfo_ICErelation = new System.Windows.Forms.Label();
            this.lblOldInfo_ICEnumber = new System.Windows.Forms.Label();
            this.lblOldInfo_PhoneNumber = new System.Windows.Forms.Label();
            this.lblOldInfo_SecondName = new System.Windows.Forms.Label();
            this.lblOldInfo_FirstName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gbNewInfo = new System.Windows.Forms.GroupBox();
            this.lblNewInfo_iceRelation_input = new System.Windows.Forms.Label();
            this.lblNewInfo_iceNumber_input = new System.Windows.Forms.Label();
            this.lblNewInfo_PhoneNumber_input = new System.Windows.Forms.Label();
            this.lblNewInfo_SecondName_input = new System.Windows.Forms.Label();
            this.lblNewInfo_FirstName_input = new System.Windows.Forms.Label();
            this.lblNewInfo_ICErelation = new System.Windows.Forms.Label();
            this.lblNewInfo_ICEnumber = new System.Windows.Forms.Label();
            this.lblNewInfo_PhoneNumber = new System.Windows.Forms.Label();
            this.lblNewInfo_SecondName = new System.Windows.Forms.Label();
            this.lblNewInfo_FirstName = new System.Windows.Forms.Label();
            this.btnDeclineInfoChanges = new System.Windows.Forms.Button();
            this.btnApproveInfoChanges = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_defocus = new System.Windows.Forms.TextBox();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
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
            this.dvgContractHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContractHours = new System.Windows.Forms.Label();
            this.tbxEmployeeAdd_ContractHours = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulesCreate)).BeginInit();
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
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackground.MaximumSize = new System.Drawing.Size(1154, 690);
            this.pnlBackground.MinimumSize = new System.Drawing.Size(1154, 690);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1154, 690);
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
            this.pnlTabCover.Location = new System.Drawing.Point(1, 29);
            this.pnlTabCover.Margin = new System.Windows.Forms.Padding(1);
            this.pnlTabCover.Name = "pnlTabCover";
            this.pnlTabCover.Size = new System.Drawing.Size(1150, 73);
            this.pnlTabCover.TabIndex = 11;
            // 
            // gpnlStatsType
            // 
            this.gpnlStatsType.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlStatsType.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlStatsType.Controls.Add(this.cbxStatsType);
            this.gpnlStatsType.Location = new System.Drawing.Point(700, 0);
            this.gpnlStatsType.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlStatsType.Name = "gpnlStatsType";
            this.gpnlStatsType.Size = new System.Drawing.Size(139, 87);
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
            this.cbxStatsType.Location = new System.Drawing.Point(0, 28);
            this.cbxStatsType.Margin = new System.Windows.Forms.Padding(1);
            this.cbxStatsType.Name = "cbxStatsType";
            this.cbxStatsType.Size = new System.Drawing.Size(118, 30);
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
            this.gpnlStatistics.Location = new System.Drawing.Point(543, -1);
            this.gpnlStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlStatistics.Name = "gpnlStatistics";
            this.gpnlStatistics.Size = new System.Drawing.Size(157, 87);
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
            this.btnStatistics.Location = new System.Drawing.Point(-1, 10);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(1);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(157, 63);
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
            this.btnLogout.Location = new System.Drawing.Point(1038, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 39);
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
            this.lblMediaBazaar.Location = new System.Drawing.Point(26, 47);
            this.lblMediaBazaar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMediaBazaar.Name = "lblMediaBazaar";
            this.lblMediaBazaar.Size = new System.Drawing.Size(101, 19);
            this.lblMediaBazaar.TabIndex = 14;
            this.lblMediaBazaar.Text = "Media Bazaar";
            // 
            // lblMB
            // 
            this.lblMB.BackColor = System.Drawing.Color.Transparent;
            this.lblMB.Font = new System.Drawing.Font("Arial Black", 35F);
            this.lblMB.ForeColor = System.Drawing.Color.White;
            this.lblMB.Location = new System.Drawing.Point(20, 1);
            this.lblMB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(117, 48);
            this.lblMB.TabIndex = 11;
            this.lblMB.Text = "MB";
            // 
            // gpnlSchedules
            // 
            this.gpnlSchedules.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(50)))), ((int)(((byte)(168)))));
            this.gpnlSchedules.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(34)))), ((int)(((byte)(117)))));
            this.gpnlSchedules.Controls.Add(this.btnSchedules);
            this.gpnlSchedules.Location = new System.Drawing.Point(234, -1);
            this.gpnlSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlSchedules.Name = "gpnlSchedules";
            this.gpnlSchedules.Size = new System.Drawing.Size(149, 87);
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
            this.btnSchedules.Location = new System.Drawing.Point(1, 10);
            this.btnSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(147, 63);
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
            this.gpnlStock.Location = new System.Drawing.Point(141, 0);
            this.gpnlStock.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlStock.Name = "gpnlStock";
            this.gpnlStock.Size = new System.Drawing.Size(92, 87);
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
            this.btnStock.Location = new System.Drawing.Point(1, 10);
            this.btnStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(91, 63);
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
            this.gpnlEmployees.Location = new System.Drawing.Point(385, 0);
            this.gpnlEmployees.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlEmployees.Name = "gpnlEmployees";
            this.gpnlEmployees.Size = new System.Drawing.Size(157, 87);
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
            this.btnEmployees.Location = new System.Drawing.Point(-1, 10);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(157, 63);
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
            this.tcNavigator.Location = new System.Drawing.Point(12, 104);
            this.tcNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.tcNavigator.Name = "tcNavigator";
            this.tcNavigator.SelectedIndex = 0;
            this.tcNavigator.Size = new System.Drawing.Size(1131, 582);
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
            this.tpStock.Location = new System.Drawing.Point(4, 18);
            this.tpStock.Margin = new System.Windows.Forms.Padding(1);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(1);
            this.tpStock.Size = new System.Drawing.Size(1123, 560);
            this.tpStock.TabIndex = 0;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // btnStockAdjustColumnWidth
            // 
            this.btnStockAdjustColumnWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockAdjustColumnWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdjustColumnWidth.Location = new System.Drawing.Point(1913, 36);
            this.btnStockAdjustColumnWidth.Name = "btnStockAdjustColumnWidth";
            this.btnStockAdjustColumnWidth.Size = new System.Drawing.Size(321, 51);
            this.btnStockAdjustColumnWidth.TabIndex = 26;
            this.btnStockAdjustColumnWidth.Text = "Reset column width";
            this.btnStockAdjustColumnWidth.UseVisualStyleBackColor = true;
            this.btnStockAdjustColumnWidth.Click += new System.EventHandler(this.btnStockAdjustColumnWidth_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F);
            this.btnOrder.Location = new System.Drawing.Point(732, 525);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(103, 35);
            this.btnOrder.TabIndex = 25;
            this.btnOrder.Text = "New order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSellProduct.Location = new System.Drawing.Point(628, 525);
            this.btnSellProduct.Margin = new System.Windows.Forms.Padding(1);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(103, 35);
            this.btnSellProduct.TabIndex = 24;
            this.btnSellProduct.Text = "Sell product";
            this.btnSellProduct.UseVisualStyleBackColor = true;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // btnStockStats
            // 
            this.btnStockStats.Font = new System.Drawing.Font("Arial", 12F);
            this.btnStockStats.Location = new System.Drawing.Point(836, 526);
            this.btnStockStats.Margin = new System.Windows.Forms.Padding(1);
            this.btnStockStats.Name = "btnStockStats";
            this.btnStockStats.Size = new System.Drawing.Size(103, 35);
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
            this.dgvAllStock.Location = new System.Drawing.Point(5, 31);
            this.dgvAllStock.Name = "dgvAllStock";
            this.dgvAllStock.ReadOnly = true;
            this.dgvAllStock.RowHeadersWidth = 102;
            this.dgvAllStock.Size = new System.Drawing.Size(1114, 486);
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
            this.btnStock_ReActivateProduct.Location = new System.Drawing.Point(385, 525);
            this.btnStock_ReActivateProduct.Margin = new System.Windows.Forms.Padding(1);
            this.btnStock_ReActivateProduct.Name = "btnStock_ReActivateProduct";
            this.btnStock_ReActivateProduct.Size = new System.Drawing.Size(242, 35);
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
            this.cbxStockCurrentlyShowing.Location = new System.Drawing.Point(305, 4);
            this.cbxStockCurrentlyShowing.Name = "cbxStockCurrentlyShowing";
            this.cbxStockCurrentlyShowing.Size = new System.Drawing.Size(121, 28);
            this.cbxStockCurrentlyShowing.TabIndex = 13;
            this.cbxStockCurrentlyShowing.SelectedIndexChanged += new System.EventHandler(this.cbxStockCurrentlyShowing_SelectedIndexChanged);
            // 
            // lblStockCurrentlyShowing
            // 
            this.lblStockCurrentlyShowing.AutoSize = true;
            this.lblStockCurrentlyShowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStockCurrentlyShowing.Location = new System.Drawing.Point(4, 5);
            this.lblStockCurrentlyShowing.Name = "lblStockCurrentlyShowing";
            this.lblStockCurrentlyShowing.Size = new System.Drawing.Size(295, 22);
            this.lblStockCurrentlyShowing.TabIndex = 12;
            this.lblStockCurrentlyShowing.Text = "Curerntly showing all items that are:";
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchStock.Location = new System.Drawing.Point(940, 527);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(1);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(139, 30);
            this.tbxSearchStock.TabIndex = 11;
            this.tbxSearchStock.TabStop = false;
            this.tbxSearchStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearchStock_KeyPress);
            // 
            // btnDeActivateStock
            // 
            this.btnDeActivateStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeActivateStock.Location = new System.Drawing.Point(385, 525);
            this.btnDeActivateStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeActivateStock.Name = "btnDeActivateStock";
            this.btnDeActivateStock.Size = new System.Drawing.Size(242, 35);
            this.btnDeActivateStock.TabIndex = 10;
            this.btnDeActivateStock.Text = "🗑️ Deactivate selected product";
            this.btnDeActivateStock.UseVisualStyleBackColor = true;
            this.btnDeActivateStock.Click += new System.EventHandler(this.btnDeActivateStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditStock.Location = new System.Drawing.Point(171, 525);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(212, 35);
            this.btnEditStock.TabIndex = 10;
            this.btnEditStock.Text = "✎ Edit selected product";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchStock.Location = new System.Drawing.Point(1083, 525);
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
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddStock.Location = new System.Drawing.Point(5, 526);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(164, 35);
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
            this.tpSchedulesEmp.Controls.Add(this.lblScheduleCurrentWeekEmp);
            this.tpSchedulesEmp.Controls.Add(this.btnScheduleEmpSaveCurrentWeek);
            this.tpSchedulesEmp.Controls.Add(this.nudScheduleEmpWeek);
            this.tpSchedulesEmp.Controls.Add(this.btnSchedulesEmpShowWeek);
            this.tpSchedulesEmp.Controls.Add(this.dgvSchedulesEmp);
            this.tpSchedulesEmp.Location = new System.Drawing.Point(4, 18);
            this.tpSchedulesEmp.Margin = new System.Windows.Forms.Padding(1);
            this.tpSchedulesEmp.Name = "tpSchedulesEmp";
            this.tpSchedulesEmp.Padding = new System.Windows.Forms.Padding(1);
            this.tpSchedulesEmp.Size = new System.Drawing.Size(1123, 560);
            this.tpSchedulesEmp.TabIndex = 1;
            this.tpSchedulesEmp.Text = "SchedulesEmp";
            this.tpSchedulesEmp.UseVisualStyleBackColor = true;
            // 
            // chkShowFTE
            // 
            this.chkShowFTE.AutoSize = true;
            this.chkShowFTE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowFTE.Location = new System.Drawing.Point(1020, 3);
            this.chkShowFTE.Name = "chkShowFTE";
            this.chkShowFTE.Size = new System.Drawing.Size(100, 22);
            this.chkShowFTE.TabIndex = 24;
            this.chkShowFTE.Text = "Show FTE";
            this.chkShowFTE.UseVisualStyleBackColor = true;
            this.chkShowFTE.CheckedChanged += new System.EventHandler(this.chkShowFTE_CheckedChanged);
            // 
            // btnScheduleEmpSearch
            // 
            this.btnScheduleEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleEmpSearch.Location = new System.Drawing.Point(990, 487);
            this.btnScheduleEmpSearch.Name = "btnScheduleEmpSearch";
            this.btnScheduleEmpSearch.Size = new System.Drawing.Size(123, 60);
            this.btnScheduleEmpSearch.TabIndex = 23;
            this.btnScheduleEmpSearch.Text = "Search for an employee";
            this.btnScheduleEmpSearch.UseVisualStyleBackColor = true;
            this.btnScheduleEmpSearch.Click += new System.EventHandler(this.btnScheduleEmpSearch_Click);
            // 
            // tbxScheduleEmpSearch
            // 
            this.tbxScheduleEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxScheduleEmpSearch.Location = new System.Drawing.Point(824, 509);
            this.tbxScheduleEmpSearch.Multiline = true;
            this.tbxScheduleEmpSearch.Name = "tbxScheduleEmpSearch";
            this.tbxScheduleEmpSearch.Size = new System.Drawing.Size(160, 39);
            this.tbxScheduleEmpSearch.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(821, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Search for an employee:";
            // 
            // lblScheduleCurrentWeekEmp
            // 
            this.lblScheduleCurrentWeekEmp.AutoSize = true;
            this.lblScheduleCurrentWeekEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblScheduleCurrentWeekEmp.Location = new System.Drawing.Point(5, 5);
            this.lblScheduleCurrentWeekEmp.Name = "lblScheduleCurrentWeekEmp";
            this.lblScheduleCurrentWeekEmp.Size = new System.Drawing.Size(179, 20);
            this.lblScheduleCurrentWeekEmp.TabIndex = 17;
            this.lblScheduleCurrentWeekEmp.Text = "Currently showing week:";
            // 
            // btnScheduleEmpSaveCurrentWeek
            // 
            this.btnScheduleEmpSaveCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleEmpSaveCurrentWeek.Location = new System.Drawing.Point(132, 485);
            this.btnScheduleEmpSaveCurrentWeek.Name = "btnScheduleEmpSaveCurrentWeek";
            this.btnScheduleEmpSaveCurrentWeek.Size = new System.Drawing.Size(119, 70);
            this.btnScheduleEmpSaveCurrentWeek.TabIndex = 16;
            this.btnScheduleEmpSaveCurrentWeek.Text = "Save current week";
            this.btnScheduleEmpSaveCurrentWeek.UseVisualStyleBackColor = true;
            this.btnScheduleEmpSaveCurrentWeek.Click += new System.EventHandler(this.btnScheduleEmpSaveCurrentWeek_Click);
            // 
            // nudScheduleEmpWeek
            // 
            this.nudScheduleEmpWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudScheduleEmpWeek.Location = new System.Drawing.Point(6, 486);
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
            this.nudScheduleEmpWeek.Size = new System.Drawing.Size(120, 23);
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
            this.btnSchedulesEmpShowWeek.Location = new System.Drawing.Point(4, 509);
            this.btnSchedulesEmpShowWeek.Name = "btnSchedulesEmpShowWeek";
            this.btnSchedulesEmpShowWeek.Size = new System.Drawing.Size(122, 46);
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
            this.dgvSchedulesEmp.Location = new System.Drawing.Point(0, 26);
            this.dgvSchedulesEmp.Name = "dgvSchedulesEmp";
            this.dgvSchedulesEmp.RowHeadersWidth = 51;
            this.dgvSchedulesEmp.RowTemplate.Height = 30;
            this.dgvSchedulesEmp.Size = new System.Drawing.Size(1113, 449);
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
            this.tpSchedulesCreate.Controls.Add(this.lblScheduleCurrentWeekCreate);
            this.tpSchedulesCreate.Controls.Add(this.dgvSchedulesCreate);
            this.tpSchedulesCreate.Controls.Add(this.btnScheduleCreateMinimumPeople);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateLoadTemplate);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateSaveTempalte);
            this.tpSchedulesCreate.Controls.Add(this.nudSchedulesCreateWeek);
            this.tpSchedulesCreate.Controls.Add(this.btnSchedulesCreateShowWeek);
            this.tpSchedulesCreate.Location = new System.Drawing.Point(4, 18);
            this.tpSchedulesCreate.Name = "tpSchedulesCreate";
            this.tpSchedulesCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedulesCreate.Size = new System.Drawing.Size(1123, 560);
            this.tpSchedulesCreate.TabIndex = 11;
            this.tpSchedulesCreate.Text = "SchedulesCreate";
            this.tpSchedulesCreate.UseVisualStyleBackColor = true;
            // 
            // lblScheduleCurrentWeekCreate
            // 
            this.lblScheduleCurrentWeekCreate.AutoSize = true;
            this.lblScheduleCurrentWeekCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblScheduleCurrentWeekCreate.Location = new System.Drawing.Point(6, 3);
            this.lblScheduleCurrentWeekCreate.Name = "lblScheduleCurrentWeekCreate";
            this.lblScheduleCurrentWeekCreate.Size = new System.Drawing.Size(179, 20);
            this.lblScheduleCurrentWeekCreate.TabIndex = 25;
            this.lblScheduleCurrentWeekCreate.Text = "Currently showing week:";
            // 
            // dgvSchedulesCreate
            // 
            this.dgvSchedulesCreate.AllowUserToAddRows = false;
            this.dgvSchedulesCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedulesCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchedulesCreateDay,
            this.SchedulesCreateMorning,
            this.SchedulesCreateAfternoon,
            this.SchedulesCreateEvening,
            this.SchedulesCreateMinMorning,
            this.SchedulesCreateMinAfternoon,
            this.SchedulesCreateMinEvening});
            this.dgvSchedulesCreate.Location = new System.Drawing.Point(7, 26);
            this.dgvSchedulesCreate.Name = "dgvSchedulesCreate";
            this.dgvSchedulesCreate.Size = new System.Drawing.Size(1110, 455);
            this.dgvSchedulesCreate.TabIndex = 24;
            this.dgvSchedulesCreate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedulesCreate_CellContentClick);
            // 
            // SchedulesCreateDay
            // 
            this.SchedulesCreateDay.HeaderText = "Day";
            this.SchedulesCreateDay.Name = "SchedulesCreateDay";
            this.SchedulesCreateDay.ReadOnly = true;
            // 
            // SchedulesCreateMorning
            // 
            this.SchedulesCreateMorning.HeaderText = "Morning";
            this.SchedulesCreateMorning.Name = "SchedulesCreateMorning";
            // 
            // SchedulesCreateAfternoon
            // 
            this.SchedulesCreateAfternoon.HeaderText = "Afternoon";
            this.SchedulesCreateAfternoon.Name = "SchedulesCreateAfternoon";
            // 
            // SchedulesCreateEvening
            // 
            this.SchedulesCreateEvening.HeaderText = "Evening";
            this.SchedulesCreateEvening.Name = "SchedulesCreateEvening";
            // 
            // SchedulesCreateMinMorning
            // 
            this.SchedulesCreateMinMorning.HeaderText = "Min. Morning";
            this.SchedulesCreateMinMorning.Name = "SchedulesCreateMinMorning";
            this.SchedulesCreateMinMorning.ReadOnly = true;
            // 
            // SchedulesCreateMinAfternoon
            // 
            this.SchedulesCreateMinAfternoon.HeaderText = "Min. Afternoon";
            this.SchedulesCreateMinAfternoon.Name = "SchedulesCreateMinAfternoon";
            this.SchedulesCreateMinAfternoon.ReadOnly = true;
            // 
            // SchedulesCreateMinEvening
            // 
            this.SchedulesCreateMinEvening.HeaderText = "Min. Evening";
            this.SchedulesCreateMinEvening.Name = "SchedulesCreateMinEvening";
            this.SchedulesCreateMinEvening.ReadOnly = true;
            // 
            // btnScheduleCreateMinimumPeople
            // 
            this.btnScheduleCreateMinimumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScheduleCreateMinimumPeople.Location = new System.Drawing.Point(722, 490);
            this.btnScheduleCreateMinimumPeople.Name = "btnScheduleCreateMinimumPeople";
            this.btnScheduleCreateMinimumPeople.Size = new System.Drawing.Size(141, 62);
            this.btnScheduleCreateMinimumPeople.TabIndex = 23;
            this.btnScheduleCreateMinimumPeople.Text = "Update mimimum people per shift";
            this.btnScheduleCreateMinimumPeople.UseVisualStyleBackColor = true;
            this.btnScheduleCreateMinimumPeople.Click += new System.EventHandler(this.btnScheduleCreateMinimumPeople_Click);
            // 
            // btnSchedulesCreateLoadTemplate
            // 
            this.btnSchedulesCreateLoadTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesCreateLoadTemplate.Location = new System.Drawing.Point(869, 491);
            this.btnSchedulesCreateLoadTemplate.Name = "btnSchedulesCreateLoadTemplate";
            this.btnSchedulesCreateLoadTemplate.Size = new System.Drawing.Size(122, 60);
            this.btnSchedulesCreateLoadTemplate.TabIndex = 22;
            this.btnSchedulesCreateLoadTemplate.Text = "Load template for current week";
            this.btnSchedulesCreateLoadTemplate.UseVisualStyleBackColor = true;
            this.btnSchedulesCreateLoadTemplate.Click += new System.EventHandler(this.btnSchedulesCreateLoadTemplate_Click);
            // 
            // btnSchedulesCreateSaveTempalte
            // 
            this.btnSchedulesCreateSaveTempalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesCreateSaveTempalte.Location = new System.Drawing.Point(997, 490);
            this.btnSchedulesCreateSaveTempalte.Name = "btnSchedulesCreateSaveTempalte";
            this.btnSchedulesCreateSaveTempalte.Size = new System.Drawing.Size(122, 62);
            this.btnSchedulesCreateSaveTempalte.TabIndex = 21;
            this.btnSchedulesCreateSaveTempalte.Text = "Save current week as template";
            this.btnSchedulesCreateSaveTempalte.UseVisualStyleBackColor = true;
            this.btnSchedulesCreateSaveTempalte.Click += new System.EventHandler(this.btnSchedulesCreateSaveTempalte_Click);
            // 
            // nudSchedulesCreateWeek
            // 
            this.nudSchedulesCreateWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudSchedulesCreateWeek.Location = new System.Drawing.Point(10, 488);
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
            this.nudSchedulesCreateWeek.Size = new System.Drawing.Size(120, 23);
            this.nudSchedulesCreateWeek.TabIndex = 18;
            this.nudSchedulesCreateWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSchedulesCreateShowWeek
            // 
            this.btnSchedulesCreateShowWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesCreateShowWeek.Location = new System.Drawing.Point(8, 511);
            this.btnSchedulesCreateShowWeek.Name = "btnSchedulesCreateShowWeek";
            this.btnSchedulesCreateShowWeek.Size = new System.Drawing.Size(122, 46);
            this.btnSchedulesCreateShowWeek.TabIndex = 17;
            this.btnSchedulesCreateShowWeek.Text = "Show schedules for chosen week";
            this.btnSchedulesCreateShowWeek.UseVisualStyleBackColor = true;
            this.btnSchedulesCreateShowWeek.Click += new System.EventHandler(this.btnSchedulesCreateShowWeek_Click);
            // 
            // tpScheduleMin
            // 
            this.tpScheduleMin.Controls.Add(this.btnSchedulesSaveMinPeople);
            this.tpScheduleMin.Controls.Add(this.dgvScheduleMinP);
            this.tpScheduleMin.Location = new System.Drawing.Point(4, 18);
            this.tpScheduleMin.Name = "tpScheduleMin";
            this.tpScheduleMin.Padding = new System.Windows.Forms.Padding(3);
            this.tpScheduleMin.Size = new System.Drawing.Size(1123, 560);
            this.tpScheduleMin.TabIndex = 9;
            this.tpScheduleMin.Text = "SchedulesMin";
            this.tpScheduleMin.UseVisualStyleBackColor = true;
            // 
            // btnSchedulesSaveMinPeople
            // 
            this.btnSchedulesSaveMinPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSchedulesSaveMinPeople.Location = new System.Drawing.Point(980, 461);
            this.btnSchedulesSaveMinPeople.Name = "btnSchedulesSaveMinPeople";
            this.btnSchedulesSaveMinPeople.Size = new System.Drawing.Size(137, 93);
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
            this.dgvScheduleMinP.Location = new System.Drawing.Point(6, 6);
            this.dgvScheduleMinP.Name = "dgvScheduleMinP";
            this.dgvScheduleMinP.RowHeadersWidth = 51;
            this.dgvScheduleMinP.RowTemplate.Height = 30;
            this.dgvScheduleMinP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScheduleMinP.Size = new System.Drawing.Size(1113, 449);
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
            this.tpScheduleChoise.Location = new System.Drawing.Point(4, 18);
            this.tpScheduleChoise.Name = "tpScheduleChoise";
            this.tpScheduleChoise.Padding = new System.Windows.Forms.Padding(3);
            this.tpScheduleChoise.Size = new System.Drawing.Size(1123, 560);
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
            this.gpnlViewSchedules.Location = new System.Drawing.Point(580, 122);
            this.gpnlViewSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlViewSchedules.Name = "gpnlViewSchedules";
            this.gpnlViewSchedules.Size = new System.Drawing.Size(386, 301);
            this.gpnlViewSchedules.TabIndex = 14;
            this.gpnlViewSchedules.Click += new System.EventHandler(this.gpnlViewSchedules_Click);
            this.gpnlViewSchedules.MouseEnter += new System.EventHandler(this.gpnlViewSchedules_MouseEnter);
            this.gpnlViewSchedules.MouseLeave += new System.EventHandler(this.gpnlViewSchedules_MouseLeave);
            // 
            // lblViewSchedules
            // 
            this.lblViewSchedules.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSchedules.ForeColor = System.Drawing.Color.White;
            this.lblViewSchedules.Location = new System.Drawing.Point(81, 207);
            this.lblViewSchedules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewSchedules.Name = "lblViewSchedules";
            this.lblViewSchedules.Size = new System.Drawing.Size(231, 61);
            this.lblViewSchedules.TabIndex = 0;
            this.lblViewSchedules.Text = "View schedule for an employee";
            this.lblViewSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewSchedules.Click += new System.EventHandler(this.lblViewSchedules_Click);
            // 
            // pbxViewSchedules
            // 
            this.pbxViewSchedules.Enabled = false;
            this.pbxViewSchedules.Image = global::LAMN_Software.Properties.Resources.AllSchedules;
            this.pbxViewSchedules.Location = new System.Drawing.Point(76, 28);
            this.pbxViewSchedules.Margin = new System.Windows.Forms.Padding(2);
            this.pbxViewSchedules.Name = "pbxViewSchedules";
            this.pbxViewSchedules.Size = new System.Drawing.Size(238, 163);
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
            this.gpnlCreateSchedules.Location = new System.Drawing.Point(140, 121);
            this.gpnlCreateSchedules.Margin = new System.Windows.Forms.Padding(1);
            this.gpnlCreateSchedules.Name = "gpnlCreateSchedules";
            this.gpnlCreateSchedules.Size = new System.Drawing.Size(386, 302);
            this.gpnlCreateSchedules.TabIndex = 13;
            this.gpnlCreateSchedules.Click += new System.EventHandler(this.gpnlCreateSchedules_Click);
            this.gpnlCreateSchedules.MouseEnter += new System.EventHandler(this.gpnlCreateSchedules_MouseEnter);
            this.gpnlCreateSchedules.MouseLeave += new System.EventHandler(this.gpnlCreateSchedules_MouseLeave);
            // 
            // lblCreateSchedules
            // 
            this.lblCreateSchedules.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSchedules.ForeColor = System.Drawing.Color.White;
            this.lblCreateSchedules.Location = new System.Drawing.Point(88, 219);
            this.lblCreateSchedules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateSchedules.Name = "lblCreateSchedules";
            this.lblCreateSchedules.Size = new System.Drawing.Size(215, 38);
            this.lblCreateSchedules.TabIndex = 0;
            this.lblCreateSchedules.Text = "Add schedules";
            this.lblCreateSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateSchedules.Click += new System.EventHandler(this.lblCreateSchedules_Click);
            // 
            // pbxAddSchedules
            // 
            this.pbxAddSchedules.Enabled = false;
            this.pbxAddSchedules.Image = global::LAMN_Software.Properties.Resources.AddSchedule;
            this.pbxAddSchedules.Location = new System.Drawing.Point(72, 28);
            this.pbxAddSchedules.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAddSchedules.Name = "pbxAddSchedules";
            this.pbxAddSchedules.Size = new System.Drawing.Size(238, 163);
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
            this.tpEmployees.Location = new System.Drawing.Point(4, 18);
            this.tpEmployees.Margin = new System.Windows.Forms.Padding(1);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(1);
            this.tpEmployees.Size = new System.Drawing.Size(1123, 560);
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
            this.label16.Location = new System.Drawing.Point(885, 522);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "1";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfoChangeRequest
            // 
            this.btnInfoChangeRequest.Font = new System.Drawing.Font("Arial", 12F);
            this.btnInfoChangeRequest.Location = new System.Drawing.Point(707, 520);
            this.btnInfoChangeRequest.Margin = new System.Windows.Forms.Padding(1);
            this.btnInfoChangeRequest.Name = "btnInfoChangeRequest";
            this.btnInfoChangeRequest.Size = new System.Drawing.Size(186, 35);
            this.btnInfoChangeRequest.TabIndex = 23;
            this.btnInfoChangeRequest.Text = "✉️ Info change requests";
            this.btnInfoChangeRequest.UseVisualStyleBackColor = true;
            this.btnInfoChangeRequest.Click += new System.EventHandler(this.btnInfoChangeRequest_Click_1);
            // 
            // btnEmpStats
            // 
            this.btnEmpStats.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEmpStats.Location = new System.Drawing.Point(597, 520);
            this.btnEmpStats.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmpStats.Name = "btnEmpStats";
            this.btnEmpStats.Size = new System.Drawing.Size(104, 35);
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
            this.cbxActiveInactiveEmployees.Location = new System.Drawing.Point(370, 8);
            this.cbxActiveInactiveEmployees.Name = "cbxActiveInactiveEmployees";
            this.cbxActiveInactiveEmployees.Size = new System.Drawing.Size(121, 28);
            this.cbxActiveInactiveEmployees.TabIndex = 21;
            this.cbxActiveInactiveEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxActiveInactiveEmployees_SelectedIndexChanged);
            // 
            // lblActiveInactiveEmployees
            // 
            this.lblActiveInactiveEmployees.AutoSize = true;
            this.lblActiveInactiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblActiveInactiveEmployees.Location = new System.Drawing.Point(3, 9);
            this.lblActiveInactiveEmployees.Name = "lblActiveInactiveEmployees";
            this.lblActiveInactiveEmployees.Size = new System.Drawing.Size(339, 22);
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
            this.dgvNationality,
            this.dvgContractHours});
            this.dgvEmployees.Location = new System.Drawing.Point(2, 48);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 102;
            this.dgvEmployees.Size = new System.Drawing.Size(1114, 468);
            this.dgvEmployees.TabIndex = 19;
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Font = new System.Drawing.Font("Arial", 15F);
            this.tbxSearchEmployee.Location = new System.Drawing.Point(902, 523);
            this.tbxSearchEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(180, 30);
            this.tbxSearchEmployee.TabIndex = 17;
            this.tbxSearchEmployee.TabStop = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(382, 521);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(207, 35);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "🗑️ End contract of selected";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditEmployee.Location = new System.Drawing.Point(177, 521);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(200, 35);
            this.btnEditEmployee.TabIndex = 14;
            this.btnEditEmployee.Text = "✎ Edit selected employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearchEmployee.Location = new System.Drawing.Point(1085, 521);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(36, 35);
            this.btnSearchEmployee.TabIndex = 15;
            this.btnSearchEmployee.Text = "🔍";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddEmployee.Location = new System.Drawing.Point(2, 521);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(168, 35);
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
            this.tpStatsStock.Location = new System.Drawing.Point(4, 18);
            this.tpStatsStock.Margin = new System.Windows.Forms.Padding(1);
            this.tpStatsStock.Name = "tpStatsStock";
            this.tpStatsStock.Padding = new System.Windows.Forms.Padding(1);
            this.tpStatsStock.Size = new System.Drawing.Size(1123, 560);
            this.tpStatsStock.TabIndex = 3;
            this.tpStatsStock.Text = "StatsStock";
            this.tpStatsStock.UseVisualStyleBackColor = true;
            // 
            // btnStockStatsRandomize
            // 
            this.btnStockStatsRandomize.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockStatsRandomize.Location = new System.Drawing.Point(275, 319);
            this.btnStockStatsRandomize.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockStatsRandomize.Name = "btnStockStatsRandomize";
            this.btnStockStatsRandomize.Size = new System.Drawing.Size(66, 57);
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
            this.btnDeselectStatsStock3.Location = new System.Drawing.Point(13, 140);
            this.btnDeselectStatsStock3.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeselectStatsStock3.Name = "btnDeselectStatsStock3";
            this.btnDeselectStatsStock3.Size = new System.Drawing.Size(17, 26);
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
            this.btnDeselectStatsStock2.Location = new System.Drawing.Point(13, 102);
            this.btnDeselectStatsStock2.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeselectStatsStock2.Name = "btnDeselectStatsStock2";
            this.btnDeselectStatsStock2.Size = new System.Drawing.Size(17, 26);
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
            this.btnDeselectStatsStock1.Location = new System.Drawing.Point(13, 64);
            this.btnDeselectStatsStock1.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeselectStatsStock1.Name = "btnDeselectStatsStock1";
            this.btnDeselectStatsStock1.Size = new System.Drawing.Size(17, 26);
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
            this.chartStock.Location = new System.Drawing.Point(282, 37);
            this.chartStock.Margin = new System.Windows.Forms.Padding(2);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Store Stock Total";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Warehouse Stock Total";
            series2.YValuesPerPoint = 6;
            this.chartStock.Series.Add(series1);
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(1162, 392);
            this.chartStock.TabIndex = 3;
            this.chartStock.Text = "Stock Chart";
            this.chartStock.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // cbxStats3
            // 
            this.cbxStats3.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats3.FormattingEnabled = true;
            this.cbxStats3.Location = new System.Drawing.Point(31, 140);
            this.cbxStats3.Margin = new System.Windows.Forms.Padding(1);
            this.cbxStats3.Name = "cbxStats3";
            this.cbxStats3.Size = new System.Drawing.Size(97, 31);
            this.cbxStats3.TabIndex = 1;
            this.cbxStats3.Text = "Stock 3";
            this.cbxStats3.SelectedIndexChanged += new System.EventHandler(this.cbxStats3_SelectedIndexChanged);
            // 
            // cbxStats2
            // 
            this.cbxStats2.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats2.FormattingEnabled = true;
            this.cbxStats2.Location = new System.Drawing.Point(31, 102);
            this.cbxStats2.Margin = new System.Windows.Forms.Padding(1);
            this.cbxStats2.Name = "cbxStats2";
            this.cbxStats2.Size = new System.Drawing.Size(97, 31);
            this.cbxStats2.TabIndex = 1;
            this.cbxStats2.Text = "Stock 2";
            this.cbxStats2.SelectedIndexChanged += new System.EventHandler(this.cbxStats2_SelectedIndexChanged);
            // 
            // cbxStats1
            // 
            this.cbxStats1.Font = new System.Drawing.Font("Arial", 15F);
            this.cbxStats1.FormattingEnabled = true;
            this.cbxStats1.Location = new System.Drawing.Point(31, 64);
            this.cbxStats1.Margin = new System.Windows.Forms.Padding(1);
            this.cbxStats1.Name = "cbxStats1";
            this.cbxStats1.Size = new System.Drawing.Size(97, 31);
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
            this.tpStockAdd.Location = new System.Drawing.Point(4, 18);
            this.tpStockAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tpStockAdd.Name = "tpStockAdd";
            this.tpStockAdd.Padding = new System.Windows.Forms.Padding(1);
            this.tpStockAdd.Size = new System.Drawing.Size(1123, 560);
            this.tpStockAdd.TabIndex = 4;
            this.tpStockAdd.Text = "StockAdd";
            this.tpStockAdd.UseVisualStyleBackColor = true;
            // 
            // lblStockAdd_Details
            // 
            this.lblStockAdd_Details.AutoSize = true;
            this.lblStockAdd_Details.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Details.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Details.Location = new System.Drawing.Point(200, 238);
            this.lblStockAdd_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockAdd_Details.Name = "lblStockAdd_Details";
            this.lblStockAdd_Details.Size = new System.Drawing.Size(51, 16);
            this.lblStockAdd_Details.TabIndex = 22;
            this.lblStockAdd_Details.Text = "Details";
            // 
            // tbxStockAdd_EANCode
            // 
            this.tbxStockAdd_EANCode.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_EANCode.Location = new System.Drawing.Point(578, 326);
            this.tbxStockAdd_EANCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_EANCode.Name = "tbxStockAdd_EANCode";
            this.tbxStockAdd_EANCode.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_EANCode.TabIndex = 1;
            // 
            // lblStockAddEAN
            // 
            this.lblStockAddEAN.AutoSize = true;
            this.lblStockAddEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAddEAN.Location = new System.Drawing.Point(181, 328);
            this.lblStockAddEAN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStockAddEAN.Name = "lblStockAddEAN";
            this.lblStockAddEAN.Size = new System.Drawing.Size(101, 22);
            this.lblStockAddEAN.TabIndex = 21;
            this.lblStockAddEAN.Text = "EAN Code";
            // 
            // btnBackToStockPage
            // 
            this.btnBackToStockPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToStockPage.Location = new System.Drawing.Point(2, 523);
            this.btnBackToStockPage.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackToStockPage.Name = "btnBackToStockPage";
            this.btnBackToStockPage.Size = new System.Drawing.Size(158, 35);
            this.btnBackToStockPage.TabIndex = 20;
            this.btnBackToStockPage.Text = "<- Back to Stock";
            this.btnBackToStockPage.UseVisualStyleBackColor = true;
            this.btnBackToStockPage.Click += new System.EventHandler(this.btnBackToStockPage_click);
            // 
            // btnStockAdd_ConfirmEdit
            // 
            this.btnStockAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmEdit.Location = new System.Drawing.Point(967, 523);
            this.btnStockAdd_ConfirmEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btnStockAdd_ConfirmEdit.Name = "btnStockAdd_ConfirmEdit";
            this.btnStockAdd_ConfirmEdit.Size = new System.Drawing.Size(154, 35);
            this.btnStockAdd_ConfirmEdit.TabIndex = 19;
            this.btnStockAdd_ConfirmEdit.Text = "✎ Edit (Confirm)";
            this.btnStockAdd_ConfirmEdit.UseVisualStyleBackColor = true;
            this.btnStockAdd_ConfirmEdit.Click += new System.EventHandler(this.btnStockAdd_ConfirmEdit_Click);
            // 
            // btnStockAdd_ConfirmAdd
            // 
            this.btnStockAdd_ConfirmAdd.Font = new System.Drawing.Font("Arial", 13F);
            this.btnStockAdd_ConfirmAdd.Location = new System.Drawing.Point(967, 525);
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
            this.tbxStockAdd_TotalSold.Location = new System.Drawing.Point(1561, 727);
            this.tbxStockAdd_TotalSold.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_TotalSold.Name = "tbxStockAdd_TotalSold";
            this.tbxStockAdd_TotalSold.Size = new System.Drawing.Size(363, 29);
            this.tbxStockAdd_TotalSold.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.Location = new System.Drawing.Point(1115, 734);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.Location = new System.Drawing.Point(179, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID";
            // 
            // tbxStockAdd_ID
            // 
            this.tbxStockAdd_ID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ID.Location = new System.Drawing.Point(578, 272);
            this.tbxStockAdd_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_ID.Name = "tbxStockAdd_ID";
            this.tbxStockAdd_ID.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_ID.TabIndex = 13;
            // 
            // tbxStockAdd_Sell
            // 
            this.tbxStockAdd_Sell.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Sell.Location = new System.Drawing.Point(1561, 328);
            this.tbxStockAdd_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_Sell.Name = "tbxStockAdd_Sell";
            this.tbxStockAdd_Sell.Size = new System.Drawing.Size(374, 29);
            this.tbxStockAdd_Sell.TabIndex = 8;
            // 
            // tbxStockAdd_AddInfo
            // 
            this.tbxStockAdd_AddInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_AddInfo.Location = new System.Drawing.Point(1123, 587);
            this.tbxStockAdd_AddInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_AddInfo.Multiline = true;
            this.tbxStockAdd_AddInfo.Name = "tbxStockAdd_AddInfo";
            this.tbxStockAdd_AddInfo.Size = new System.Drawing.Size(408, 61);
            this.tbxStockAdd_AddInfo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(1117, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label4.Location = new System.Drawing.Point(1117, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(1115, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price (€)";
            // 
            // tbxStockAdd_MinimumStock
            // 
            this.tbxStockAdd_MinimumStock.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_MinimumStock.Location = new System.Drawing.Point(1561, 478);
            this.tbxStockAdd_MinimumStock.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_MinimumStock.Name = "tbxStockAdd_MinimumStock";
            this.tbxStockAdd_MinimumStock.Size = new System.Drawing.Size(374, 29);
            this.tbxStockAdd_MinimumStock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(1115, 543);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(1115, 484);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Minimum Stock Required";
            // 
            // tbxStockAdd_Cost
            // 
            this.tbxStockAdd_Cost.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_Cost.Location = new System.Drawing.Point(1561, 274);
            this.tbxStockAdd_Cost.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_Cost.Name = "tbxStockAdd_Cost";
            this.tbxStockAdd_Cost.Size = new System.Drawing.Size(374, 29);
            this.tbxStockAdd_Cost.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(1115, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cost Price (€)";
            // 
            // tbxStockAdd_WarehouseLocation
            // 
            this.tbxStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseLocation.Location = new System.Drawing.Point(578, 566);
            this.tbxStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_WarehouseLocation.Name = "tbxStockAdd_WarehouseLocation";
            this.tbxStockAdd_WarehouseLocation.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_WarehouseLocation.TabIndex = 4;
            // 
            // tbxStockAdd_StoreLocation
            // 
            this.tbxStockAdd_StoreLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreLocation.Location = new System.Drawing.Point(578, 768);
            this.tbxStockAdd_StoreLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_StoreLocation.Name = "tbxStockAdd_StoreLocation";
            this.tbxStockAdd_StoreLocation.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_StoreLocation.TabIndex = 6;
            // 
            // lblStockAdd_Store
            // 
            this.lblStockAdd_Store.AutoSize = true;
            this.lblStockAdd_Store.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd_Store.ForeColor = System.Drawing.Color.Silver;
            this.lblStockAdd_Store.Location = new System.Drawing.Point(181, 680);
            this.lblStockAdd_Store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblStockAdd_Warehouse.Location = new System.Drawing.Point(181, 478);
            this.lblStockAdd_Warehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockAdd_Warehouse.Name = "lblStockAdd_Warehouse";
            this.lblStockAdd_Warehouse.Size = new System.Drawing.Size(80, 16);
            this.lblStockAdd_Warehouse.TabIndex = 0;
            this.lblStockAdd_Warehouse.Text = "Warehouse";
            // 
            // lblStockAdd_WarehouseLocation
            // 
            this.lblStockAdd_WarehouseLocation.AutoSize = true;
            this.lblStockAdd_WarehouseLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseLocation.Location = new System.Drawing.Point(179, 571);
            this.lblStockAdd_WarehouseLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockAdd_WarehouseLocation.Name = "lblStockAdd_WarehouseLocation";
            this.lblStockAdd_WarehouseLocation.Size = new System.Drawing.Size(189, 22);
            this.lblStockAdd_WarehouseLocation.TabIndex = 0;
            this.lblStockAdd_WarehouseLocation.Text = "Warehouse Location ";
            // 
            // tbxStockAdd_StoreQuantity
            // 
            this.tbxStockAdd_StoreQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_StoreQuantity.Location = new System.Drawing.Point(578, 714);
            this.tbxStockAdd_StoreQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_StoreQuantity.Name = "tbxStockAdd_StoreQuantity";
            this.tbxStockAdd_StoreQuantity.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_StoreQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(179, 773);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store Location ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(179, 719);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Quantity";
            // 
            // tbxStockAdd_WarehouseQuantity
            // 
            this.tbxStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(578, 514);
            this.tbxStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_WarehouseQuantity.Name = "tbxStockAdd_WarehouseQuantity";
            this.tbxStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_WarehouseQuantity.TabIndex = 3;
            // 
            // lblStockAdd_WarehouseQuantity
            // 
            this.lblStockAdd_WarehouseQuantity.AutoSize = true;
            this.lblStockAdd_WarehouseQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStockAdd_WarehouseQuantity.Location = new System.Drawing.Point(179, 517);
            this.lblStockAdd_WarehouseQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockAdd_WarehouseQuantity.Name = "lblStockAdd_WarehouseQuantity";
            this.lblStockAdd_WarehouseQuantity.Size = new System.Drawing.Size(180, 22);
            this.lblStockAdd_WarehouseQuantity.TabIndex = 0;
            this.lblStockAdd_WarehouseQuantity.Text = "Warehouse Quantity";
            // 
            // tbxStockAdd_ProductName
            // 
            this.tbxStockAdd_ProductName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxStockAdd_ProductName.Location = new System.Drawing.Point(578, 377);
            this.tbxStockAdd_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStockAdd_ProductName.Name = "tbxStockAdd_ProductName";
            this.tbxStockAdd_ProductName.Size = new System.Drawing.Size(432, 29);
            this.tbxStockAdd_ProductName.TabIndex = 2;
            // 
            // lblProductAdd_StockName
            // 
            this.lblProductAdd_StockName.AutoSize = true;
            this.lblProductAdd_StockName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblProductAdd_StockName.Location = new System.Drawing.Point(179, 384);
            this.lblProductAdd_StockName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductAdd_StockName.Name = "lblProductAdd_StockName";
            this.lblProductAdd_StockName.Size = new System.Drawing.Size(128, 22);
            this.lblProductAdd_StockName.TabIndex = 0;
            this.lblProductAdd_StockName.Text = "Product name";
            // 
            // tpEmployeeAdd
            // 
            this.tpEmployeeAdd.Controls.Add(this.tbxEmployeeAdd_ContractHours);
            this.tpEmployeeAdd.Controls.Add(this.lblContractHours);
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
            this.tpEmployeeAdd.Location = new System.Drawing.Point(4, 18);
            this.tpEmployeeAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tpEmployeeAdd.Name = "tpEmployeeAdd";
            this.tpEmployeeAdd.Padding = new System.Windows.Forms.Padding(1);
            this.tpEmployeeAdd.Size = new System.Drawing.Size(1123, 560);
            this.tpEmployeeAdd.TabIndex = 5;
            this.tpEmployeeAdd.Text = "EmployeeAdd";
            this.tpEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // tbxEmployeeAdd_Nationality
            // 
            this.tbxEmployeeAdd_Nationality.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_Nationality.Location = new System.Drawing.Point(232, 476);
            this.tbxEmployeeAdd_Nationality.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_Nationality.Name = "tbxEmployeeAdd_Nationality";
            this.tbxEmployeeAdd_Nationality.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_Nationality.TabIndex = 66;
            // 
            // tbxEmployeeAdd_Degree
            // 
            this.tbxEmployeeAdd_Degree.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_Degree.Location = new System.Drawing.Point(232, 447);
            this.tbxEmployeeAdd_Degree.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_Degree.Name = "tbxEmployeeAdd_Degree";
            this.tbxEmployeeAdd_Degree.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_Degree.TabIndex = 65;
            // 
            // cbxEmployeeAdd_Gender
            // 
            this.cbxEmployeeAdd_Gender.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_Gender.FormattingEnabled = true;
            this.cbxEmployeeAdd_Gender.ItemHeight = 22;
            this.cbxEmployeeAdd_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxEmployeeAdd_Gender.Location = new System.Drawing.Point(232, 417);
            this.cbxEmployeeAdd_Gender.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmployeeAdd_Gender.Name = "cbxEmployeeAdd_Gender";
            this.cbxEmployeeAdd_Gender.Size = new System.Drawing.Size(235, 30);
            this.cbxEmployeeAdd_Gender.TabIndex = 64;
            // 
            // lblNationionality
            // 
            this.lblNationionality.AutoSize = true;
            this.lblNationionality.Font = new System.Drawing.Font("Arial", 14F);
            this.lblNationionality.Location = new System.Drawing.Point(2, 483);
            this.lblNationionality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNationionality.Name = "lblNationionality";
            this.lblNationionality.Size = new System.Drawing.Size(95, 22);
            this.lblNationionality.TabIndex = 63;
            this.lblNationionality.Text = "Nationality";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDegree.Location = new System.Drawing.Point(4, 450);
            this.lblDegree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(74, 22);
            this.lblDegree.TabIndex = 62;
            this.lblDegree.Text = "Degree";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 14F);
            this.lblGender.Location = new System.Drawing.Point(4, 417);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 22);
            this.lblGender.TabIndex = 61;
            this.lblGender.Text = "Gender";
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContractType.Location = new System.Drawing.Point(2, 390);
            this.lblContractType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(128, 22);
            this.lblContractType.TabIndex = 60;
            this.lblContractType.Text = "Contract Type";
            // 
            // cbxEmployeeAdd_ContractType
            // 
            this.cbxEmployeeAdd_ContractType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_ContractType.FormattingEnabled = true;
            this.cbxEmployeeAdd_ContractType.ItemHeight = 22;
            this.cbxEmployeeAdd_ContractType.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cbxEmployeeAdd_ContractType.Location = new System.Drawing.Point(232, 387);
            this.cbxEmployeeAdd_ContractType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmployeeAdd_ContractType.Name = "cbxEmployeeAdd_ContractType";
            this.cbxEmployeeAdd_ContractType.Size = new System.Drawing.Size(235, 30);
            this.cbxEmployeeAdd_ContractType.TabIndex = 59;
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEndingDate.Location = new System.Drawing.Point(2, 364);
            this.lblEndingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(114, 22);
            this.lblEndingDate.TabIndex = 58;
            this.lblEndingDate.Text = "Ending Date";
            // 
            // dtpEmployeeAdd_EndingDate
            // 
            this.dtpEmployeeAdd_EndingDate.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_EndingDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_EndingDate.Location = new System.Drawing.Point(232, 364);
            this.dtpEmployeeAdd_EndingDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEmployeeAdd_EndingDate.Name = "dtpEmployeeAdd_EndingDate";
            this.dtpEmployeeAdd_EndingDate.Size = new System.Drawing.Size(235, 23);
            this.dtpEmployeeAdd_EndingDate.TabIndex = 57;
            this.dtpEmployeeAdd_EndingDate.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // dtpEmployeeAdd_StartingDate
            // 
            this.dtpEmployeeAdd_StartingDate.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_StartingDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_StartingDate.Location = new System.Drawing.Point(232, 341);
            this.dtpEmployeeAdd_StartingDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEmployeeAdd_StartingDate.Name = "dtpEmployeeAdd_StartingDate";
            this.dtpEmployeeAdd_StartingDate.Size = new System.Drawing.Size(235, 23);
            this.dtpEmployeeAdd_StartingDate.TabIndex = 56;
            this.dtpEmployeeAdd_StartingDate.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 14F);
            this.lblStartDate.Location = new System.Drawing.Point(-1, 342);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(119, 22);
            this.lblStartDate.TabIndex = 55;
            this.lblStartDate.Text = "Starting Date";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSalary.Location = new System.Drawing.Point(-3, 312);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(137, 22);
            this.lblSalary.TabIndex = 54;
            this.lblSalary.Text = "Salary per hour";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxSalary.Location = new System.Drawing.Point(232, 312);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(235, 29);
            this.tbxSalary.TabIndex = 53;
            // 
            // btnEmployeeAdd_ConfirmEdit
            // 
            this.btnEmployeeAdd_ConfirmEdit.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployeeAdd_ConfirmEdit.Location = new System.Drawing.Point(961, 522);
            this.btnEmployeeAdd_ConfirmEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployeeAdd_ConfirmEdit.Name = "btnEmployeeAdd_ConfirmEdit";
            this.btnEmployeeAdd_ConfirmEdit.Size = new System.Drawing.Size(158, 35);
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
            this.lblEmployeeAdd_Details.Location = new System.Drawing.Point(5, 167);
            this.lblEmployeeAdd_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_Details.Name = "lblEmployeeAdd_Details";
            this.lblEmployeeAdd_Details.Size = new System.Drawing.Size(51, 16);
            this.lblEmployeeAdd_Details.TabIndex = 46;
            this.lblEmployeeAdd_Details.Text = "Details";
            // 
            // cbxEmployeeAdd_Position
            // 
            this.cbxEmployeeAdd_Position.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxEmployeeAdd_Position.FormattingEnabled = true;
            this.cbxEmployeeAdd_Position.ItemHeight = 22;
            this.cbxEmployeeAdd_Position.Items.AddRange(new object[] {
            "MANAGER",
            "HR",
            "SALES",
            "DEPOT",
            "SECURITY"});
            this.cbxEmployeeAdd_Position.Location = new System.Drawing.Point(232, 282);
            this.cbxEmployeeAdd_Position.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmployeeAdd_Position.Name = "cbxEmployeeAdd_Position";
            this.cbxEmployeeAdd_Position.Size = new System.Drawing.Size(235, 30);
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
            this.cbxEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(712, 191);
            this.cbxEmployeeAdd_ICERelationship.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmployeeAdd_ICERelationship.Name = "cbxEmployeeAdd_ICERelationship";
            this.cbxEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(195, 30);
            this.cbxEmployeeAdd_ICERelationship.TabIndex = 47;
            // 
            // dtpEmployeeAdd_DateOfBirth
            // 
            this.dtpEmployeeAdd_DateOfBirth.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(232, 229);
            this.dtpEmployeeAdd_DateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEmployeeAdd_DateOfBirth.Name = "dtpEmployeeAdd_DateOfBirth";
            this.dtpEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(235, 23);
            this.dtpEmployeeAdd_DateOfBirth.TabIndex = 43;
            this.dtpEmployeeAdd_DateOfBirth.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // btnBackToEmpPage
            // 
            this.btnBackToEmpPage.Font = new System.Drawing.Font("Arial", 13F);
            this.btnBackToEmpPage.Location = new System.Drawing.Point(-242, 299);
            this.btnBackToEmpPage.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackToEmpPage.Name = "btnBackToEmpPage";
            this.btnBackToEmpPage.Size = new System.Drawing.Size(158, 35);
            this.btnBackToEmpPage.TabIndex = 50;
            this.btnBackToEmpPage.Text = "<- Back to Stock";
            this.btnBackToEmpPage.UseVisualStyleBackColor = true;
            this.btnBackToEmpPage.Click += new System.EventHandler(this.btnBackToEmpPage_Click);
            // 
            // btnEmployeeAdd_Confirm
            // 
            this.btnEmployeeAdd_Confirm.Font = new System.Drawing.Font("Arial", 13F);
            this.btnEmployeeAdd_Confirm.Location = new System.Drawing.Point(801, 522);
            this.btnEmployeeAdd_Confirm.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployeeAdd_Confirm.Name = "btnEmployeeAdd_Confirm";
            this.btnEmployeeAdd_Confirm.Size = new System.Drawing.Size(158, 35);
            this.btnEmployeeAdd_Confirm.TabIndex = 49;
            this.btnEmployeeAdd_Confirm.Text = "+ Add (Confirm)";
            this.btnEmployeeAdd_Confirm.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd_Confirm.Click += new System.EventHandler(this.btnEmployeeAdd_Confirm_Click);
            // 
            // lblEmployeeAdd_FirstName
            // 
            this.lblEmployeeAdd_FirstName.AutoSize = true;
            this.lblEmployeeAdd_FirstName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_FirstName.Location = new System.Drawing.Point(3, 83);
            this.lblEmployeeAdd_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_FirstName.Name = "lblEmployeeAdd_FirstName";
            this.lblEmployeeAdd_FirstName.Size = new System.Drawing.Size(99, 22);
            this.lblEmployeeAdd_FirstName.TabIndex = 41;
            this.lblEmployeeAdd_FirstName.Text = "First name";
            // 
            // tbxEmployeeAdd_FirstName
            // 
            this.tbxEmployeeAdd_FirstName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_FirstName.Location = new System.Drawing.Point(232, 82);
            this.tbxEmployeeAdd_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_FirstName.Name = "tbxEmployeeAdd_FirstName";
            this.tbxEmployeeAdd_FirstName.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_FirstName.TabIndex = 40;
            // 
            // tbxEmployeeAdd_AdditonalInfo
            // 
            this.tbxEmployeeAdd_AdditonalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_AdditonalInfo.Location = new System.Drawing.Point(722, 342);
            this.tbxEmployeeAdd_AdditonalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_AdditonalInfo.Multiline = true;
            this.tbxEmployeeAdd_AdditonalInfo.Name = "tbxEmployeeAdd_AdditonalInfo";
            this.tbxEmployeeAdd_AdditonalInfo.Size = new System.Drawing.Size(372, 79);
            this.tbxEmployeeAdd_AdditonalInfo.TabIndex = 48;
            // 
            // lblEmployeeAdd_ICE
            // 
            this.lblEmployeeAdd_ICE.AutoSize = true;
            this.lblEmployeeAdd_ICE.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdd_ICE.ForeColor = System.Drawing.Color.Silver;
            this.lblEmployeeAdd_ICE.Location = new System.Drawing.Point(716, 74);
            this.lblEmployeeAdd_ICE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_ICE.Name = "lblEmployeeAdd_ICE";
            this.lblEmployeeAdd_ICE.Size = new System.Drawing.Size(147, 16);
            this.lblEmployeeAdd_ICE.TabIndex = 31;
            this.lblEmployeeAdd_ICE.Text = "In Case of Emergency";
            // 
            // lblEmployeeAdd_ICERelationship
            // 
            this.lblEmployeeAdd_ICERelationship.AutoSize = true;
            this.lblEmployeeAdd_ICERelationship.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICERelationship.Location = new System.Drawing.Point(712, 167);
            this.lblEmployeeAdd_ICERelationship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_ICERelationship.Name = "lblEmployeeAdd_ICERelationship";
            this.lblEmployeeAdd_ICERelationship.Size = new System.Drawing.Size(152, 22);
            this.lblEmployeeAdd_ICERelationship.TabIndex = 32;
            this.lblEmployeeAdd_ICERelationship.Text = "ICE Relationship";
            // 
            // lblEmployeeAdd_AdditionalInfo
            // 
            this.lblEmployeeAdd_AdditionalInfo.AutoSize = true;
            this.lblEmployeeAdd_AdditionalInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_AdditionalInfo.Location = new System.Drawing.Point(714, 297);
            this.lblEmployeeAdd_AdditionalInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_AdditionalInfo.Name = "lblEmployeeAdd_AdditionalInfo";
            this.lblEmployeeAdd_AdditionalInfo.Size = new System.Drawing.Size(193, 22);
            this.lblEmployeeAdd_AdditionalInfo.TabIndex = 34;
            this.lblEmployeeAdd_AdditionalInfo.Text = "Additional Information";
            // 
            // tbxEmployeeAdd_ICENumber
            // 
            this.tbxEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_ICENumber.Location = new System.Drawing.Point(716, 134);
            this.tbxEmployeeAdd_ICENumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_ICENumber.Name = "tbxEmployeeAdd_ICENumber";
            this.tbxEmployeeAdd_ICENumber.Size = new System.Drawing.Size(195, 29);
            this.tbxEmployeeAdd_ICENumber.TabIndex = 46;
            // 
            // lblEmployeeAdd_ICENumber
            // 
            this.lblEmployeeAdd_ICENumber.AutoSize = true;
            this.lblEmployeeAdd_ICENumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_ICENumber.Location = new System.Drawing.Point(712, 113);
            this.lblEmployeeAdd_ICENumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_ICENumber.Name = "lblEmployeeAdd_ICENumber";
            this.lblEmployeeAdd_ICENumber.Size = new System.Drawing.Size(112, 22);
            this.lblEmployeeAdd_ICENumber.TabIndex = 37;
            this.lblEmployeeAdd_ICENumber.Text = "ICE number";
            // 
            // lblEmployeeAdd_Name
            // 
            this.lblEmployeeAdd_Name.AutoSize = true;
            this.lblEmployeeAdd_Name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdd_Name.ForeColor = System.Drawing.Color.Silver;
            this.lblEmployeeAdd_Name.Location = new System.Drawing.Point(5, 44);
            this.lblEmployeeAdd_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_Name.Name = "lblEmployeeAdd_Name";
            this.lblEmployeeAdd_Name.Size = new System.Drawing.Size(44, 16);
            this.lblEmployeeAdd_Name.TabIndex = 26;
            this.lblEmployeeAdd_Name.Text = "Name";
            // 
            // lblEmployeeAdd_DateOfBirth
            // 
            this.lblEmployeeAdd_DateOfBirth.AutoSize = true;
            this.lblEmployeeAdd_DateOfBirth.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_DateOfBirth.Location = new System.Drawing.Point(-1, 230);
            this.lblEmployeeAdd_DateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_DateOfBirth.Name = "lblEmployeeAdd_DateOfBirth";
            this.lblEmployeeAdd_DateOfBirth.Size = new System.Drawing.Size(113, 22);
            this.lblEmployeeAdd_DateOfBirth.TabIndex = 25;
            this.lblEmployeeAdd_DateOfBirth.Text = "Date of birth";
            // 
            // tbxEmployeeAdd_PhoneNumber
            // 
            this.tbxEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(232, 253);
            this.tbxEmployeeAdd_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_PhoneNumber.Name = "tbxEmployeeAdd_PhoneNumber";
            this.tbxEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_PhoneNumber.TabIndex = 44;
            // 
            // lblEmployeeAdd_Position
            // 
            this.lblEmployeeAdd_Position.AutoSize = true;
            this.lblEmployeeAdd_Position.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_Position.Location = new System.Drawing.Point(-1, 286);
            this.lblEmployeeAdd_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_Position.Name = "lblEmployeeAdd_Position";
            this.lblEmployeeAdd_Position.Size = new System.Drawing.Size(78, 22);
            this.lblEmployeeAdd_Position.TabIndex = 24;
            this.lblEmployeeAdd_Position.Text = "Position";
            // 
            // lblEmployeeAdd_PhoneNumber
            // 
            this.lblEmployeeAdd_PhoneNumber.AutoSize = true;
            this.lblEmployeeAdd_PhoneNumber.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_PhoneNumber.Location = new System.Drawing.Point(-3, 257);
            this.lblEmployeeAdd_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_PhoneNumber.Name = "lblEmployeeAdd_PhoneNumber";
            this.lblEmployeeAdd_PhoneNumber.Size = new System.Drawing.Size(134, 22);
            this.lblEmployeeAdd_PhoneNumber.TabIndex = 23;
            this.lblEmployeeAdd_PhoneNumber.Text = "Phone number";
            // 
            // tbxEmployeeAdd_BSN
            // 
            this.tbxEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_BSN.Location = new System.Drawing.Point(232, 200);
            this.tbxEmployeeAdd_BSN.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_BSN.Name = "tbxEmployeeAdd_BSN";
            this.tbxEmployeeAdd_BSN.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_BSN.TabIndex = 42;
            // 
            // lblEmployeeAdd_BSN
            // 
            this.lblEmployeeAdd_BSN.AutoSize = true;
            this.lblEmployeeAdd_BSN.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_BSN.Location = new System.Drawing.Point(3, 203);
            this.lblEmployeeAdd_BSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_BSN.Name = "lblEmployeeAdd_BSN";
            this.lblEmployeeAdd_BSN.Size = new System.Drawing.Size(49, 22);
            this.lblEmployeeAdd_BSN.TabIndex = 22;
            this.lblEmployeeAdd_BSN.Text = "BSN";
            // 
            // tbxEmployeeAdd_SecondName
            // 
            this.tbxEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_SecondName.Location = new System.Drawing.Point(232, 136);
            this.tbxEmployeeAdd_SecondName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_SecondName.Name = "tbxEmployeeAdd_SecondName";
            this.tbxEmployeeAdd_SecondName.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_SecondName.TabIndex = 41;
            // 
            // lblEmployeeAdd_SecondName
            // 
            this.lblEmployeeAdd_SecondName.AutoSize = true;
            this.lblEmployeeAdd_SecondName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeAdd_SecondName.Location = new System.Drawing.Point(3, 137);
            this.lblEmployeeAdd_SecondName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeAdd_SecondName.Name = "lblEmployeeAdd_SecondName";
            this.lblEmployeeAdd_SecondName.Size = new System.Drawing.Size(128, 22);
            this.lblEmployeeAdd_SecondName.TabIndex = 21;
            this.lblEmployeeAdd_SecondName.Text = "Second name";
            // 
            // tpStatsEmployee
            // 
            this.tpStatsEmployee.Controls.Add(this.chartEmployeesPosition);
            this.tpStatsEmployee.Location = new System.Drawing.Point(4, 18);
            this.tpStatsEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tpStatsEmployee.Name = "tpStatsEmployee";
            this.tpStatsEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.tpStatsEmployee.Size = new System.Drawing.Size(1123, 560);
            this.tpStatsEmployee.TabIndex = 6;
            this.tpStatsEmployee.Text = "StatsEmp";
            this.tpStatsEmployee.UseVisualStyleBackColor = true;
            // 
            // chartEmployeesPosition
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEmployeesPosition.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEmployeesPosition.Legends.Add(legend2);
            this.chartEmployeesPosition.Location = new System.Drawing.Point(4, 0);
            this.chartEmployeesPosition.Margin = new System.Windows.Forms.Padding(4);
            this.chartEmployeesPosition.Name = "chartEmployeesPosition";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Positions";
            this.chartEmployeesPosition.Series.Add(series3);
            this.chartEmployeesPosition.Size = new System.Drawing.Size(976, 758);
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
            this.tpNewOrder.Location = new System.Drawing.Point(4, 18);
            this.tpNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tpNewOrder.Name = "tpNewOrder";
            this.tpNewOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tpNewOrder.Size = new System.Drawing.Size(1123, 560);
            this.tpNewOrder.TabIndex = 7;
            this.tpNewOrder.Text = "NewOrder";
            this.tpNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewOrderBack
            // 
            this.btnNewOrderBack.Font = new System.Drawing.Font("Arial", 13F);
            this.btnNewOrderBack.Location = new System.Drawing.Point(2, 523);
            this.btnNewOrderBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewOrderBack.Name = "btnNewOrderBack";
            this.btnNewOrderBack.Size = new System.Drawing.Size(158, 35);
            this.btnNewOrderBack.TabIndex = 50;
            this.btnNewOrderBack.Text = "<- Back to Stock";
            this.btnNewOrderBack.UseVisualStyleBackColor = true;
            this.btnNewOrderBack.Click += new System.EventHandler(this.btnNewOrderBack_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Font = new System.Drawing.Font("Arial", 13F);
            this.btnAddNewOrder.Location = new System.Drawing.Point(967, 523);
            this.btnAddNewOrder.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(154, 35);
            this.btnAddNewOrder.TabIndex = 49;
            this.btnAddNewOrder.Text = "✎ Add (Confirm)";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // tbNewOrderEAN
            // 
            this.tbNewOrderEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderEAN.Location = new System.Drawing.Point(585, 106);
            this.tbNewOrderEAN.Margin = new System.Windows.Forms.Padding(1);
            this.tbNewOrderEAN.Name = "tbNewOrderEAN";
            this.tbNewOrderEAN.Size = new System.Drawing.Size(179, 29);
            this.tbNewOrderEAN.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(404, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 48;
            this.label11.Text = "EAN Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(402, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 22);
            this.label13.TabIndex = 46;
            this.label13.Text = "Product ID";
            // 
            // tbNewOrderID
            // 
            this.tbNewOrderID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderID.Location = new System.Drawing.Point(585, 78);
            this.tbNewOrderID.Margin = new System.Windows.Forms.Padding(1);
            this.tbNewOrderID.Name = "tbNewOrderID";
            this.tbNewOrderID.Size = new System.Drawing.Size(179, 29);
            this.tbNewOrderID.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(381, 280);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "Store";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(381, 222);
            this.label20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Warehouse";
            // 
            // tbNewOrderWarehouse
            // 
            this.tbNewOrderWarehouse.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderWarehouse.Location = new System.Drawing.Point(616, 292);
            this.tbNewOrderWarehouse.Margin = new System.Windows.Forms.Padding(1);
            this.tbNewOrderWarehouse.Name = "tbNewOrderWarehouse";
            this.tbNewOrderWarehouse.Size = new System.Drawing.Size(179, 29);
            this.tbNewOrderWarehouse.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 14F);
            this.label23.Location = new System.Drawing.Point(381, 298);
            this.label23.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(183, 22);
            this.label23.TabIndex = 24;
            this.label23.Text = "Store quantity to add";
            // 
            // tbNewOrderStore
            // 
            this.tbNewOrderStore.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderStore.Location = new System.Drawing.Point(616, 239);
            this.tbNewOrderStore.Margin = new System.Windows.Forms.Padding(1);
            this.tbNewOrderStore.Name = "tbNewOrderStore";
            this.tbNewOrderStore.Size = new System.Drawing.Size(179, 29);
            this.tbNewOrderStore.TabIndex = 32;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 14F);
            this.label24.Location = new System.Drawing.Point(381, 241);
            this.label24.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(234, 22);
            this.label24.TabIndex = 23;
            this.label24.Text = "Warehouse quantity to add";
            // 
            // tbNewOrderName
            // 
            this.tbNewOrderName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbNewOrderName.Location = new System.Drawing.Point(585, 132);
            this.tbNewOrderName.Margin = new System.Windows.Forms.Padding(1);
            this.tbNewOrderName.Name = "tbNewOrderName";
            this.tbNewOrderName.Size = new System.Drawing.Size(179, 29);
            this.tbNewOrderName.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 14F);
            this.label25.Location = new System.Drawing.Point(402, 135);
            this.label25.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(128, 22);
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
            this.tpSellProduct.Location = new System.Drawing.Point(4, 18);
            this.tpSellProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tpSellProduct.Name = "tpSellProduct";
            this.tpSellProduct.Padding = new System.Windows.Forms.Padding(2);
            this.tpSellProduct.Size = new System.Drawing.Size(1123, 560);
            this.tpSellProduct.TabIndex = 8;
            this.tpSellProduct.Text = "SellProduct";
            this.tpSellProduct.UseVisualStyleBackColor = true;
            // 
            // btnSellConfirm
            // 
            this.btnSellConfirm.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSellConfirm.Location = new System.Drawing.Point(967, 523);
            this.btnSellConfirm.Margin = new System.Windows.Forms.Padding(1);
            this.btnSellConfirm.Name = "btnSellConfirm";
            this.btnSellConfirm.Size = new System.Drawing.Size(154, 35);
            this.btnSellConfirm.TabIndex = 62;
            this.btnSellConfirm.Text = "✎ Sell (Confirm)";
            this.btnSellConfirm.UseVisualStyleBackColor = true;
            this.btnSellConfirm.Click += new System.EventHandler(this.btnSellConfirm_Click);
            // 
            // btnSellProdBack
            // 
            this.btnSellProdBack.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSellProdBack.Location = new System.Drawing.Point(2, 523);
            this.btnSellProdBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnSellProdBack.Name = "btnSellProdBack";
            this.btnSellProdBack.Size = new System.Drawing.Size(158, 35);
            this.btnSellProdBack.TabIndex = 61;
            this.btnSellProdBack.Text = "<- Back to Stock";
            this.btnSellProdBack.UseVisualStyleBackColor = true;
            this.btnSellProdBack.Click += new System.EventHandler(this.btnSellProdBack_Click);
            // 
            // tbSellEAN
            // 
            this.tbSellEAN.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellEAN.Location = new System.Drawing.Point(585, 106);
            this.tbSellEAN.Margin = new System.Windows.Forms.Padding(1);
            this.tbSellEAN.Name = "tbSellEAN";
            this.tbSellEAN.Size = new System.Drawing.Size(179, 29);
            this.tbSellEAN.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(404, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 22);
            this.label12.TabIndex = 60;
            this.label12.Text = "EAN Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F);
            this.label14.Location = new System.Drawing.Point(402, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 22);
            this.label14.TabIndex = 59;
            this.label14.Text = "Product ID";
            // 
            // tbSellID
            // 
            this.tbSellID.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellID.Location = new System.Drawing.Point(585, 78);
            this.tbSellID.Margin = new System.Windows.Forms.Padding(1);
            this.tbSellID.Name = "tbSellID";
            this.tbSellID.Size = new System.Drawing.Size(179, 29);
            this.tbSellID.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(402, 236);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "Store";
            // 
            // tbSellQuantity
            // 
            this.tbSellQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellQuantity.Location = new System.Drawing.Point(585, 249);
            this.tbSellQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.tbSellQuantity.Name = "tbSellQuantity";
            this.tbSellQuantity.Size = new System.Drawing.Size(179, 29);
            this.tbSellQuantity.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14F);
            this.label17.Location = new System.Drawing.Point(402, 254);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 22);
            this.label17.TabIndex = 51;
            this.label17.Text = "Quantity to sell";
            // 
            // tbSellName
            // 
            this.tbSellName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSellName.Location = new System.Drawing.Point(585, 132);
            this.tbSellName.Margin = new System.Windows.Forms.Padding(1);
            this.tbSellName.Name = "tbSellName";
            this.tbSellName.Size = new System.Drawing.Size(179, 29);
            this.tbSellName.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14F);
            this.label21.Location = new System.Drawing.Point(402, 135);
            this.label21.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 22);
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
            this.tpRequestChangeInfo.Location = new System.Drawing.Point(4, 18);
            this.tpRequestChangeInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tpRequestChangeInfo.Name = "tpRequestChangeInfo";
            this.tpRequestChangeInfo.Padding = new System.Windows.Forms.Padding(1);
            this.tpRequestChangeInfo.Size = new System.Drawing.Size(1123, 560);
            this.tpRequestChangeInfo.TabIndex = 12;
            this.tpRequestChangeInfo.Text = "RequestChangeInfo";
            this.tpRequestChangeInfo.UseVisualStyleBackColor = true;
            // 
            // lblChangeInfo
            // 
            this.lblChangeInfo.AutoSize = true;
            this.lblChangeInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeInfo.Location = new System.Drawing.Point(31, 26);
            this.lblChangeInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblChangeInfo.Name = "lblChangeInfo";
            this.lblChangeInfo.Size = new System.Drawing.Size(147, 19);
            this.lblChangeInfo.TabIndex = 5;
            this.lblChangeInfo.Text = "Choose employee";
            // 
            // lbChangeInfo
            // 
            this.lbChangeInfo.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeInfo.FormattingEnabled = true;
            this.lbChangeInfo.ItemHeight = 17;
            this.lbChangeInfo.Location = new System.Drawing.Point(34, 56);
            this.lbChangeInfo.Margin = new System.Windows.Forms.Padding(1);
            this.lbChangeInfo.Name = "lbChangeInfo";
            this.lbChangeInfo.Size = new System.Drawing.Size(622, 480);
            this.lbChangeInfo.TabIndex = 4;
            this.lbChangeInfo.SelectedIndexChanged += new System.EventHandler(this.lbChangeInfo_SelectedIndexChanged);
            // 
            // gbOldInfo
            // 
            this.gbOldInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbOldInfo.Controls.Add(this.lblOldInfo_iceRelation_input);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_iceNumber_input);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_PhoneNumber_input);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_SecondName_input);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_FirstName_input);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_ICErelation);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_ICEnumber);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_PhoneNumber);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_SecondName);
            this.gbOldInfo.Controls.Add(this.lblOldInfo_FirstName);
            this.gbOldInfo.Controls.Add(this.label26);
            this.gbOldInfo.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOldInfo.Location = new System.Drawing.Point(686, 49);
            this.gbOldInfo.Margin = new System.Windows.Forms.Padding(1);
            this.gbOldInfo.Name = "gbOldInfo";
            this.gbOldInfo.Padding = new System.Windows.Forms.Padding(1);
            this.gbOldInfo.Size = new System.Drawing.Size(381, 214);
            this.gbOldInfo.TabIndex = 2;
            this.gbOldInfo.TabStop = false;
            this.gbOldInfo.Text = "Old info";
            // 
            // lblOldInfo_iceRelation_input
            // 
            this.lblOldInfo_iceRelation_input.AutoSize = true;
            this.lblOldInfo_iceRelation_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_iceRelation_input.Location = new System.Drawing.Point(146, 160);
            this.lblOldInfo_iceRelation_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_iceRelation_input.Name = "lblOldInfo_iceRelation_input";
            this.lblOldInfo_iceRelation_input.Size = new System.Drawing.Size(0, 16);
            this.lblOldInfo_iceRelation_input.TabIndex = 10;
            // 
            // lblOldInfo_iceNumber_input
            // 
            this.lblOldInfo_iceNumber_input.AutoSize = true;
            this.lblOldInfo_iceNumber_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_iceNumber_input.Location = new System.Drawing.Point(146, 130);
            this.lblOldInfo_iceNumber_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_iceNumber_input.Name = "lblOldInfo_iceNumber_input";
            this.lblOldInfo_iceNumber_input.Size = new System.Drawing.Size(0, 16);
            this.lblOldInfo_iceNumber_input.TabIndex = 9;
            // 
            // lblOldInfo_PhoneNumber_input
            // 
            this.lblOldInfo_PhoneNumber_input.AutoSize = true;
            this.lblOldInfo_PhoneNumber_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_PhoneNumber_input.Location = new System.Drawing.Point(146, 100);
            this.lblOldInfo_PhoneNumber_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_PhoneNumber_input.Name = "lblOldInfo_PhoneNumber_input";
            this.lblOldInfo_PhoneNumber_input.Size = new System.Drawing.Size(0, 16);
            this.lblOldInfo_PhoneNumber_input.TabIndex = 8;
            // 
            // lblOldInfo_SecondName_input
            // 
            this.lblOldInfo_SecondName_input.AutoSize = true;
            this.lblOldInfo_SecondName_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_SecondName_input.Location = new System.Drawing.Point(146, 71);
            this.lblOldInfo_SecondName_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_SecondName_input.Name = "lblOldInfo_SecondName_input";
            this.lblOldInfo_SecondName_input.Size = new System.Drawing.Size(0, 16);
            this.lblOldInfo_SecondName_input.TabIndex = 7;
            // 
            // lblOldInfo_FirstName_input
            // 
            this.lblOldInfo_FirstName_input.AutoSize = true;
            this.lblOldInfo_FirstName_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_FirstName_input.Location = new System.Drawing.Point(146, 44);
            this.lblOldInfo_FirstName_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_FirstName_input.Name = "lblOldInfo_FirstName_input";
            this.lblOldInfo_FirstName_input.Size = new System.Drawing.Size(0, 16);
            this.lblOldInfo_FirstName_input.TabIndex = 6;
            // 
            // lblOldInfo_ICErelation
            // 
            this.lblOldInfo_ICErelation.AutoSize = true;
            this.lblOldInfo_ICErelation.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_ICErelation.Location = new System.Drawing.Point(15, 160);
            this.lblOldInfo_ICErelation.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_ICErelation.Name = "lblOldInfo_ICErelation";
            this.lblOldInfo_ICErelation.Size = new System.Drawing.Size(93, 16);
            this.lblOldInfo_ICErelation.TabIndex = 5;
            this.lblOldInfo_ICErelation.Text = "ICE relation:";
            // 
            // lblOldInfo_ICEnumber
            // 
            this.lblOldInfo_ICEnumber.AutoSize = true;
            this.lblOldInfo_ICEnumber.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_ICEnumber.Location = new System.Drawing.Point(15, 130);
            this.lblOldInfo_ICEnumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_ICEnumber.Name = "lblOldInfo_ICEnumber";
            this.lblOldInfo_ICEnumber.Size = new System.Drawing.Size(93, 16);
            this.lblOldInfo_ICEnumber.TabIndex = 4;
            this.lblOldInfo_ICEnumber.Text = "ICE number:";
            // 
            // lblOldInfo_PhoneNumber
            // 
            this.lblOldInfo_PhoneNumber.AutoSize = true;
            this.lblOldInfo_PhoneNumber.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_PhoneNumber.Location = new System.Drawing.Point(15, 100);
            this.lblOldInfo_PhoneNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_PhoneNumber.Name = "lblOldInfo_PhoneNumber";
            this.lblOldInfo_PhoneNumber.Size = new System.Drawing.Size(116, 16);
            this.lblOldInfo_PhoneNumber.TabIndex = 4;
            this.lblOldInfo_PhoneNumber.Text = "Phone Number:";
            // 
            // lblOldInfo_SecondName
            // 
            this.lblOldInfo_SecondName.AutoSize = true;
            this.lblOldInfo_SecondName.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_SecondName.Location = new System.Drawing.Point(15, 71);
            this.lblOldInfo_SecondName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_SecondName.Name = "lblOldInfo_SecondName";
            this.lblOldInfo_SecondName.Size = new System.Drawing.Size(107, 16);
            this.lblOldInfo_SecondName.TabIndex = 4;
            this.lblOldInfo_SecondName.Text = "Second name:";
            // 
            // lblOldInfo_FirstName
            // 
            this.lblOldInfo_FirstName.AutoSize = true;
            this.lblOldInfo_FirstName.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo_FirstName.Location = new System.Drawing.Point(15, 44);
            this.lblOldInfo_FirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOldInfo_FirstName.Name = "lblOldInfo_FirstName";
            this.lblOldInfo_FirstName.Size = new System.Drawing.Size(90, 16);
            this.lblOldInfo_FirstName.TabIndex = 2;
            this.lblOldInfo_FirstName.Text = "First name: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 27);
            this.label26.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 18);
            this.label26.TabIndex = 0;
            // 
            // gbNewInfo
            // 
            this.gbNewInfo.Controls.Add(this.lblNewInfo_iceRelation_input);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_iceNumber_input);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_PhoneNumber_input);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_SecondName_input);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_FirstName_input);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_ICErelation);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_ICEnumber);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_PhoneNumber);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_SecondName);
            this.gbNewInfo.Controls.Add(this.lblNewInfo_FirstName);
            this.gbNewInfo.Controls.Add(this.btnDeclineInfoChanges);
            this.gbNewInfo.Controls.Add(this.btnApproveInfoChanges);
            this.gbNewInfo.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewInfo.Location = new System.Drawing.Point(686, 282);
            this.gbNewInfo.Margin = new System.Windows.Forms.Padding(1);
            this.gbNewInfo.Name = "gbNewInfo";
            this.gbNewInfo.Padding = new System.Windows.Forms.Padding(1);
            this.gbNewInfo.Size = new System.Drawing.Size(381, 251);
            this.gbNewInfo.TabIndex = 3;
            this.gbNewInfo.TabStop = false;
            this.gbNewInfo.Text = "New info";
            // 
            // lblNewInfo_iceRelation_input
            // 
            this.lblNewInfo_iceRelation_input.AutoSize = true;
            this.lblNewInfo_iceRelation_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_iceRelation_input.Location = new System.Drawing.Point(146, 155);
            this.lblNewInfo_iceRelation_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_iceRelation_input.Name = "lblNewInfo_iceRelation_input";
            this.lblNewInfo_iceRelation_input.Size = new System.Drawing.Size(0, 16);
            this.lblNewInfo_iceRelation_input.TabIndex = 26;
            // 
            // lblNewInfo_iceNumber_input
            // 
            this.lblNewInfo_iceNumber_input.AutoSize = true;
            this.lblNewInfo_iceNumber_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_iceNumber_input.Location = new System.Drawing.Point(146, 125);
            this.lblNewInfo_iceNumber_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_iceNumber_input.Name = "lblNewInfo_iceNumber_input";
            this.lblNewInfo_iceNumber_input.Size = new System.Drawing.Size(0, 16);
            this.lblNewInfo_iceNumber_input.TabIndex = 25;
            // 
            // lblNewInfo_PhoneNumber_input
            // 
            this.lblNewInfo_PhoneNumber_input.AutoSize = true;
            this.lblNewInfo_PhoneNumber_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_PhoneNumber_input.Location = new System.Drawing.Point(146, 95);
            this.lblNewInfo_PhoneNumber_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_PhoneNumber_input.Name = "lblNewInfo_PhoneNumber_input";
            this.lblNewInfo_PhoneNumber_input.Size = new System.Drawing.Size(0, 16);
            this.lblNewInfo_PhoneNumber_input.TabIndex = 24;
            // 
            // lblNewInfo_SecondName_input
            // 
            this.lblNewInfo_SecondName_input.AutoSize = true;
            this.lblNewInfo_SecondName_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_SecondName_input.Location = new System.Drawing.Point(146, 67);
            this.lblNewInfo_SecondName_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_SecondName_input.Name = "lblNewInfo_SecondName_input";
            this.lblNewInfo_SecondName_input.Size = new System.Drawing.Size(0, 16);
            this.lblNewInfo_SecondName_input.TabIndex = 23;
            // 
            // lblNewInfo_FirstName_input
            // 
            this.lblNewInfo_FirstName_input.AutoSize = true;
            this.lblNewInfo_FirstName_input.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_FirstName_input.Location = new System.Drawing.Point(146, 40);
            this.lblNewInfo_FirstName_input.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_FirstName_input.Name = "lblNewInfo_FirstName_input";
            this.lblNewInfo_FirstName_input.Size = new System.Drawing.Size(0, 16);
            this.lblNewInfo_FirstName_input.TabIndex = 22;
            // 
            // lblNewInfo_ICErelation
            // 
            this.lblNewInfo_ICErelation.AutoSize = true;
            this.lblNewInfo_ICErelation.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_ICErelation.Location = new System.Drawing.Point(15, 155);
            this.lblNewInfo_ICErelation.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_ICErelation.Name = "lblNewInfo_ICErelation";
            this.lblNewInfo_ICErelation.Size = new System.Drawing.Size(93, 16);
            this.lblNewInfo_ICErelation.TabIndex = 21;
            this.lblNewInfo_ICErelation.Text = "ICE relation:";
            // 
            // lblNewInfo_ICEnumber
            // 
            this.lblNewInfo_ICEnumber.AutoSize = true;
            this.lblNewInfo_ICEnumber.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_ICEnumber.Location = new System.Drawing.Point(15, 125);
            this.lblNewInfo_ICEnumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_ICEnumber.Name = "lblNewInfo_ICEnumber";
            this.lblNewInfo_ICEnumber.Size = new System.Drawing.Size(93, 16);
            this.lblNewInfo_ICEnumber.TabIndex = 18;
            this.lblNewInfo_ICEnumber.Text = "ICE number:";
            // 
            // lblNewInfo_PhoneNumber
            // 
            this.lblNewInfo_PhoneNumber.AutoSize = true;
            this.lblNewInfo_PhoneNumber.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_PhoneNumber.Location = new System.Drawing.Point(15, 95);
            this.lblNewInfo_PhoneNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_PhoneNumber.Name = "lblNewInfo_PhoneNumber";
            this.lblNewInfo_PhoneNumber.Size = new System.Drawing.Size(116, 16);
            this.lblNewInfo_PhoneNumber.TabIndex = 19;
            this.lblNewInfo_PhoneNumber.Text = "Phone Number:";
            // 
            // lblNewInfo_SecondName
            // 
            this.lblNewInfo_SecondName.AutoSize = true;
            this.lblNewInfo_SecondName.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_SecondName.Location = new System.Drawing.Point(15, 67);
            this.lblNewInfo_SecondName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_SecondName.Name = "lblNewInfo_SecondName";
            this.lblNewInfo_SecondName.Size = new System.Drawing.Size(107, 16);
            this.lblNewInfo_SecondName.TabIndex = 20;
            this.lblNewInfo_SecondName.Text = "Second name:";
            // 
            // lblNewInfo_FirstName
            // 
            this.lblNewInfo_FirstName.AutoSize = true;
            this.lblNewInfo_FirstName.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo_FirstName.Location = new System.Drawing.Point(15, 40);
            this.lblNewInfo_FirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNewInfo_FirstName.Name = "lblNewInfo_FirstName";
            this.lblNewInfo_FirstName.Size = new System.Drawing.Size(90, 16);
            this.lblNewInfo_FirstName.TabIndex = 17;
            this.lblNewInfo_FirstName.Text = "First name: ";
            // 
            // btnDeclineInfoChanges
            // 
            this.btnDeclineInfoChanges.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeclineInfoChanges.Location = new System.Drawing.Point(202, 199);
            this.btnDeclineInfoChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeclineInfoChanges.Name = "btnDeclineInfoChanges";
            this.btnDeclineInfoChanges.Size = new System.Drawing.Size(160, 35);
            this.btnDeclineInfoChanges.TabIndex = 16;
            this.btnDeclineInfoChanges.Text = "❌ Decline changes";
            this.btnDeclineInfoChanges.UseVisualStyleBackColor = true;
            this.btnDeclineInfoChanges.Click += new System.EventHandler(this.btnDeclineInfoChanges_Click);
            // 
            // btnApproveInfoChanges
            // 
            this.btnApproveInfoChanges.Font = new System.Drawing.Font("Arial", 12F);
            this.btnApproveInfoChanges.Location = new System.Drawing.Point(18, 199);
            this.btnApproveInfoChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnApproveInfoChanges.Name = "btnApproveInfoChanges";
            this.btnApproveInfoChanges.Size = new System.Drawing.Size(160, 35);
            this.btnApproveInfoChanges.TabIndex = 15;
            this.btnApproveInfoChanges.Text = "✔️ Approve changes";
            this.btnApproveInfoChanges.UseVisualStyleBackColor = true;
            this.btnApproveInfoChanges.Click += new System.EventHandler(this.btnApproveInfoChanges_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(32, 26);
            this.label22.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 15);
            this.label22.TabIndex = 0;
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
            this.pnlBar.Size = new System.Drawing.Size(1154, 32);
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
            this.pnlDragBar.Size = new System.Drawing.Size(1122, 31);
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
            this.lblClose.Location = new System.Drawing.Point(1125, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✖";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
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
            // dvgContractHours
            // 
            this.dvgContractHours.HeaderText = "Contract Hours";
            this.dvgContractHours.Name = "dvgContractHours";
            this.dvgContractHours.ReadOnly = true;
            // 
            // lblContractHours
            // 
            this.lblContractHours.AutoSize = true;
            this.lblContractHours.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContractHours.Location = new System.Drawing.Point(2, 507);
            this.lblContractHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContractHours.Name = "lblContractHours";
            this.lblContractHours.Size = new System.Drawing.Size(136, 22);
            this.lblContractHours.TabIndex = 67;
            this.lblContractHours.Text = "Contract Hours";
            // 
            // tbxEmployeeAdd_ContractHours
            // 
            this.tbxEmployeeAdd_ContractHours.Font = new System.Drawing.Font("Arial", 14F);
            this.tbxEmployeeAdd_ContractHours.Location = new System.Drawing.Point(232, 504);
            this.tbxEmployeeAdd_ContractHours.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmployeeAdd_ContractHours.Name = "tbxEmployeeAdd_ContractHours";
            this.tbxEmployeeAdd_ContractHours.Size = new System.Drawing.Size(235, 29);
            this.tbxEmployeeAdd_ContractHours.TabIndex = 68;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1154, 690);
            this.MinimumSize = new System.Drawing.Size(719, 435);
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
            this.tpSchedulesCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulesCreate)).EndInit();
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
        private System.Windows.Forms.Label lblScheduleCurrentWeekEmp;
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
        private System.Windows.Forms.Label lblOldInfo_iceRelation_input;
        private System.Windows.Forms.Label lblOldInfo_iceNumber_input;
        private System.Windows.Forms.Label lblOldInfo_PhoneNumber_input;
        private System.Windows.Forms.Label lblOldInfo_SecondName_input;
        private System.Windows.Forms.Label lblOldInfo_FirstName_input;
        private System.Windows.Forms.Label lblNewInfo_iceRelation_input;
        private System.Windows.Forms.Label lblNewInfo_iceNumber_input;
        private System.Windows.Forms.Label lblNewInfo_PhoneNumber_input;
        private System.Windows.Forms.Label lblNewInfo_SecondName_input;
        private System.Windows.Forms.Label lblNewInfo_FirstName_input;
        private System.Windows.Forms.Label lblNewInfo_ICErelation;
        private System.Windows.Forms.Label lblNewInfo_ICEnumber;
        private System.Windows.Forms.Label lblNewInfo_PhoneNumber;
        private System.Windows.Forms.Label lblNewInfo_SecondName;
        private System.Windows.Forms.Label lblNewInfo_FirstName;
        private System.Windows.Forms.DataGridView dgvSchedulesCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulesCreateDay;
        private System.Windows.Forms.DataGridViewButtonColumn SchedulesCreateMorning;
        private System.Windows.Forms.DataGridViewButtonColumn SchedulesCreateAfternoon;
        private System.Windows.Forms.DataGridViewButtonColumn SchedulesCreateEvening;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulesCreateMinMorning;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulesCreateMinAfternoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulesCreateMinEvening;
        private System.Windows.Forms.Label lblScheduleCurrentWeekCreate;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgContractHours;
        private System.Windows.Forms.TextBox tbxEmployeeAdd_ContractHours;
        private System.Windows.Forms.Label lblContractHours;
    }
}