using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMN_Software.DataClasses;
using LAMN_Software.DBHandling;
using LAMN_Software.GUI;

namespace LAMN_Software
{
    public partial class ProductForm : Form
    {
        StockHandler SH;
        EmployeeHandler EH;
        ScheduleHandler SCH;
        ScheduleTemplateHandler SCTH;
        ScheduleAutomaticHandler SCHAH;
        LoginHandler LH;
        ScheduleMinimumHandler SCMH;
        EmployeeChangeHandler ECH;
        SellingTrackerHandler STH;
        PreferenceHandler PH;
        HolidayHandler HOH;

        List<Product> itemsToBePurchased = new List<Product>();

        public ProductForm(JobPosition position)
        {
            InitializeComponent();

            SH = new StockHandler();
            EH = new EmployeeHandler();
            SCH = new ScheduleHandler();
            SCTH = new ScheduleTemplateHandler();
            SCHAH = new ScheduleAutomaticHandler();
            LH = new LoginHandler();
            SCMH = new ScheduleMinimumHandler();
            ECH = new EmployeeChangeHandler();
            STH = new SellingTrackerHandler();
            PH = new PreferenceHandler();
            HOH = new HolidayHandler();

            FillStockViewActive();
            FillScheduleGridViewEmp();
            FillScheduleGridViewCreate();
            FillScheduleMinimumGridView();
            FillActiveEmployees();
            FillChangeEmployeeListBox();
            FillHolidayRequestListBox();


            UpdateEmployeeChartNationalities();
            UpdateEmployeeChartPositions();
            UpdateEmployeeChartGender();
            UpdateEmployeeChartContractType();
            UpdateEmployeeAverageSalaryPerHour();
            UpdateMostPopularStock();
            ResetSalesShowcase();

            cbxStats1.SelectedIndex = 1;
            cbxStats2.SelectedIndex = 2;
            cbxStats3.SelectedIndex = 3;

            AdjustColumnWidthStock();
            AdjustColumnWidthSchedules();
            AdjustColumnWidthEmployees();
            AdjustColumnWidthSales();
            AdjustColumnWidthSalesInfo();

            this.dgvSales_ManualInfo.DefaultCellStyle.Font = new Font("Arial", 10);
            this.dgvSales_Reciept.DefaultCellStyle.Font = new Font("Arial", 10);
            this.dgvSales_Reciept.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSales_Reciept.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSales_Reciept.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 194, 102);
            dgvSales_Reciept.DefaultCellStyle.SelectionForeColor = Color.Black;
            btnStock.Font = new Font("Arial", 18, FontStyle.Bold);
            //Method to enable buttons based on indicator
            cbxStockCurrentlyShowing.SelectedIndex = 0;
            cbxActiveInactiveEmployees.SelectedIndex = 0;
            dgvAllStock.Font = new Font("Arial", 11);
            dgvEmployees.Font = new Font("Arial", 8);
            dgvSchedulesCreate.Font = new Font("Arial", 11);
            updateTabWithPosition(position);

        }

        //Method to show correct buttons based on the user permission
        private void updateTabWithPosition(JobPosition position)
        {
            if (position.ToString() == "HR")
            {
                tcNavigator.TabPages.Remove(tpStock);
                tcNavigator.TabPages.Remove(tpStockAdd);
                tcNavigator.TabPages.Remove(tpStatsStock);
                btnStatistics.Enabled = false;
                btnStockStats.Visible = false;
                btnEmpStats.Visible = false;
                btnStock.Enabled = false;
            }
            else if (position.ToString() == "DEPOT")
            {
                tcNavigator.TabPages.Remove(tpEmployees);
                tcNavigator.TabPages.Remove(tpEmployeeAdd);
                tcNavigator.TabPages.Remove(tpStatsStock);
                btnStockStats.Visible = false;
                btnEmpStats.Visible = false;
                btnEmployees.Enabled = false;
            }
        }

        //STOCK MANAGEMENT

        #region Navbar -----------------
        private void btnStock_Click(object sender, EventArgs e)
        {
            // Changes tab
            tcNavigator.SelectedTab = tpStock;
            btnStock.Font = new Font("Arial", 18, FontStyle.Bold);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);

            btnStock.ForeColor = Color.White;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;

            cbxStatsType.Visible = false;
            gpnlStatsType.Visible = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSales;
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 18, FontStyle.Bold);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.White;

            cbxStatsType.Visible = false;
            gpnlStatsType.Visible = false;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployees;
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 18, FontStyle.Bold);
            btnStatistics.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.White;
            btnStatistics.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;

            cbxStatsType.Visible = false;
            gpnlStatsType.Visible = false;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatsTypeCheck();
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Bold);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.White;

            cbxStatsType.Visible = true;
            gpnlStatsType.Visible = true;
        }

        private void btnEmpStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsEmployee;
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Bold);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.White;

            cbxStatsType.Visible = true;
            gpnlStatsType.Visible = true;

            cbxStatsType.SelectedItem = "Employees";
        }

        private void btnStockStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsStock;
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 16, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Bold);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.WhiteSmoke;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.White;

            cbxStatsType.Visible = true;
            gpnlStatsType.Visible = true;

            cbxStatsType.SelectedItem = "Stock";
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpScheduleChoise;
            btnStock.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 18, FontStyle.Bold);
            btnEmployees.Font = new Font("Arial", 16, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 16, FontStyle.Regular);
            btnSales.Font = new Font("Arial", 16, FontStyle.Regular);

            btnStock.ForeColor = Color.WhiteSmoke;
            btnSchedules.ForeColor = Color.White;
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnStatistics.ForeColor = Color.WhiteSmoke;
            btnSales.ForeColor = Color.WhiteSmoke;

            cbxStatsType.Visible = false;
            gpnlStatsType.Visible = false;
        }

        #endregion

        //Back to stock button in edit/add page
        private void btnBackToStockPage_click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStock;
        }

        //Method for selecting active/inactive stock. 
        private void cbxStockCurrentlyShowing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbxStockCurrentlyShowing.SelectedItem == "Active")
            {
                FillStockViewActive();
                btnDeActivateStock.Visible = true;
                btnStock_ReActivateProduct.Visible = false;
            }
            else
            {
                FillStockViewNotActive();
                btnDeActivateStock.Visible = false;
                btnStock_ReActivateProduct.Visible = true;
            }
        }

        //onClick for add stock button. Will direct to stock add page
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            //Go to page and disable correct button
            tcNavigator.SelectedTab = tpStockAdd;
            btnStockAdd_ConfirmEdit.Visible = false;
            btnStockAdd_ConfirmAdd.Visible = true;
            //clear all fields/disable
            tbxStockAdd_ID.Text = "";
            tbxStockAdd_ID.Enabled = false;
            tbxStockAdd_EANCode.Text = "";
            tbxStockAdd_EANCode.Enabled = true;
            tbxStockAdd_ProductName.Text = "";
            tbxStockAdd_WarehouseQuantity.Text = "";
            tbxStockAdd_WarehouseLocation.Text = "";
            tbxStockAdd_StoreQuantity.Text = "";
            tbxStockAdd_StoreLocation.Text = "";
            tbxStockAdd_Cost.Text = "";
            tbxStockAdd_Cost.Enabled = true;
            tbxStockAdd_Sell.Text = "";
            tbxStockAdd_Sell.Enabled = true;
            tbxStockAdd_MinimumStock.Text = "";
            tbxStockAdd_AddInfo.Text = "";
            tbxStockAdd_TotalSold.Text = "";
            tbxStockAdd_TotalSold.Enabled = false;
        }

        //onClick for confirming the add product
        private void btnStockAdd_ConfirmAdd_Click(object sender, EventArgs e)
        {
            //method to call for adding
            var add = SH.AddProduct(tbxStockAdd_EANCode.Text, tbxStockAdd_ProductName.Text, tbxStockAdd_StoreQuantity.Text, tbxStockAdd_WarehouseQuantity.Text, tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, tbxStockAdd_Cost.Text, tbxStockAdd_Sell.Text, tbxStockAdd_MinimumStock.Text, tbxStockAdd_AddInfo.Text);

            if (add == null)
            {
                FillStockViewActive();
                MessageBox.Show("Item added succesfully");
                return;
            }
            MessageBox.Show(add.Message);
        }

        //onClick for edit stock button. Will take selected.
        private void btnEditStock_Click(object sender, EventArgs e)
        {
            //save object
            if (dgvAllStock.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one product to edit");
                return;
            }
            Product p = (Product)dgvAllStock.CurrentRow.Cells[0].Value;
            //Go to page and disable correct button
            tcNavigator.SelectedTab = tpStockAdd;
            btnStockAdd_ConfirmAdd.Visible = false;
            btnStockAdd_ConfirmEdit.Visible = true;
            //fill in all fields/disable
            tbxStockAdd_ID.Text = $"{p.Id}";
            tbxStockAdd_ID.Enabled = false;
            tbxStockAdd_EANCode.Text = p.Ean;
            tbxStockAdd_EANCode.Enabled = false;
            tbxStockAdd_ProductName.Text = p.Name;
            tbxStockAdd_WarehouseQuantity.Text = $"{p.QuantityWH}";
            tbxStockAdd_WarehouseLocation.Text = $"{p.LocationWH}";
            tbxStockAdd_StoreQuantity.Text = $"{p.QuantityS}";
            tbxStockAdd_StoreLocation.Text = $"{p.LocationS}";
            tbxStockAdd_Cost.Text = $"{p.CostPrice}";
            tbxStockAdd_Cost.Enabled = false;
            tbxStockAdd_Sell.Text = $"{p.SellPrice}";
            tbxStockAdd_Sell.Enabled = false;
            tbxStockAdd_MinimumStock.Text = $"{p.MinimumStockRequired}";
            tbxStockAdd_AddInfo.Text = p.AddInformation;
            tbxStockAdd_TotalSold.Text = $"{p.TotalSold}";
            tbxStockAdd_TotalSold.Enabled = false;
        }

        //onclick for confirming edit 
        private void btnStockAdd_ConfirmEdit_Click(object sender, EventArgs e)
        {
            //method to call for changing
            var update = SH.ChangeProduct(Convert.ToInt32(tbxStockAdd_ID.Text), tbxStockAdd_ProductName.Text, tbxStockAdd_StoreQuantity.Text, tbxStockAdd_WarehouseQuantity.Text, tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, tbxStockAdd_MinimumStock.Text, tbxStockAdd_AddInfo.Text);

            if (update == null)
            {
                FillStockViewActive();
                MessageBox.Show("Item edited succesfully");
                return;
            }
            MessageBox.Show(update.Message);
        }

        //onclick for delete button. Opens new tab for quitting reason
        private void btnDeActivateStock_Click(object sender, EventArgs e)
        {
            if (dgvAllStock.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one product to deactivate");
                return;
            }
            Product p = (Product)dgvAllStock.CurrentRow.Cells[0].Value;
            //method to call for deleting
            var deactivate = SH.DeactivateProduct(p);
            if (deactivate == null)
            {
                FillStockViewActive();
                MessageBox.Show("Product sucessfully deactivated");
                return;
            }
            MessageBox.Show(deactivate.Message);
        }

        private void btnStock_ReActivateProduct_Click(object sender, EventArgs e)
        {
            if (dgvAllStock.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one product to Activate");
                return;
            }
            Product p = (Product)dgvAllStock.CurrentRow.Cells[0].Value;
            //method to call for deleting
            var reactivate = SH.ReactivateProduct(p);
            if (reactivate == null)
            {
                FillStockViewNotActive();
                MessageBox.Show("Product sucessfully reactivated");
                return;
            }
            MessageBox.Show(reactivate.Message);
        }

        //onClick for search button. Shows all matching products
        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            dgvAllStock.Rows.Clear();
            string searchName = tbxSearchStock.Text.ToLower();

            int count = 0;

            if (cbxStockCurrentlyShowing.SelectedIndex == 0)
            {
                foreach (Product p in SH.GetAllProducts())
                {
                    if ((p.Name.ToLower().Contains(searchName)) && (p.Active == 1))
                    {
                        FillDataGridViewStock(p, count);
                        UpdateStatsComboboxes(p.Name);
                        count++;
                    }
                }
            }
            else
            {
                foreach (Product p in SH.GetAllProducts())
                {
                    if ((p.Name.ToLower().Contains(searchName)) && (p.Active == 0))
                    {
                        FillDataGridViewStock(p, count);
                        UpdateStatsComboboxes(p.Name);
                        count++;
                    }
                }
            }
        }

        //method for updateing/filling listbox for stock items that are still active
        public void FillStockViewActive()
        {
            cbxStats1.Items.Clear();
            cbxStats2.Items.Clear();
            cbxStats3.Items.Clear();

            cbxStatsPeriod1.Items.Clear();
            cbxStatsPeriod2.Items.Clear();
            cbxStatsPeriod3.Items.Clear();

            cbxStatsProfit1.Items.Clear();
            cbxStatsProfit2.Items.Clear();
            cbxStatsProfit3.Items.Clear();

            cbxStatsRevenue1.Items.Clear();
            cbxStatsRevenue2.Items.Clear();
            cbxStatsRevenue3.Items.Clear();

            dgvAllStock.Rows.Clear();
            //Check if connection is successfull
            if (SH.GetAllStockFromDB() == null)
            {
                int count = 0;
                //for each active product add the value to the correct cell
                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Active == 1)
                    {
                        FillDataGridViewStock(p, count);
                        UpdateStatsComboboxes(p.Name);
                        count++;
                    }
                }
            }
            else
            {
                MessageBox.Show(SH.GetAllStockFromDB().Message);
            }
        }

        //method for updating/filling listbox for stock items that are inactive
        public void FillStockViewNotActive()
        {
            cbxStats1.Items.Clear();
            cbxStats2.Items.Clear();
            cbxStats3.Items.Clear();

            cbxStatsPeriod1.Items.Clear();
            cbxStatsPeriod2.Items.Clear();
            cbxStatsPeriod3.Items.Clear();

            cbxStatsRevenue1.Items.Clear();
            cbxStatsRevenue2.Items.Clear();
            cbxStatsRevenue3.Items.Clear();

            dgvAllStock.Rows.Clear();
            //Check if connection is successfull
            if (SH.GetAllStockFromDB() == null)
            {
                int count = 0;
                //for each active product add the value to the correct cell
                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Active == 0)
                    {
                        FillDataGridViewStock(p, count);
                        UpdateStatsComboboxes(p.Name);
                        count++;
                    }
                }
            }
            else
            {
                MessageBox.Show(SH.GetAllStockFromDB().Message);
            }
        }

        public void FillDataGridViewStock(Product p, int count)
        {
            dgvAllStock.Rows.Add();
            dgvAllStock.Rows[count].Cells[0].Value = p;
            dgvAllStock.Rows[count].Cells[1].Value = p.Ean;
            dgvAllStock.Rows[count].Cells[2].Value = p.Name;
            dgvAllStock.Rows[count].Cells[3].Value = p.QuantityS;
            dgvAllStock.Rows[count].Cells[4].Value = p.LocationS;
            dgvAllStock.Rows[count].Cells[5].Value = p.QuantityWH;
            dgvAllStock.Rows[count].Cells[6].Value = p.LocationWH;
            dgvAllStock.Rows[count].Cells[7].Value = p.CostPrice; // "‎€" +
            dgvAllStock.Rows[count].Cells[8].Value = p.SellPrice; // "‎€" +
            dgvAllStock.Rows[count].Cells[9].Value = p.MinimumStockRequired;
            dgvAllStock.Rows[count].Cells[10].Value = p.TotalSold;
        }

        //EMPLOYEE MANAGEMENT




        public void FillActiveEmployees()
        {
            dgvEmployees.Rows.Clear();
            if (EH.GetAllEmployeesFromDB() == null)
            {
                foreach (Employee e in EH.GetAllEmployees())
                {
                    if (string.IsNullOrEmpty((e.QuittingReason).ToString()))
                    {
                        FillEmployeeCells(e);
                    }
                }
                UpdateEmployeeChartPositions();
                UpdateEmployeeChartNationalities();
            }
            else
            {
                MessageBox.Show(EH.GetAllEmployeesFromDB().Message);
            }
        }

        public void FillTerminatedEmployees()
        {
            dgvEmployees.Rows.Clear();
            if (EH.GetAllEmployeesFromDB() == null)
            {
                foreach (Employee e in EH.GetAllEmployees())
                {
                    if (!string.IsNullOrEmpty((e.QuittingReason).ToString()))
                    {
                        FillEmployeeCells(e);
                    }
                }
            }
            else
            {
                MessageBox.Show(EH.GetAllEmployeesFromDB().Message);
            }
        }

        private void FillEmployeeCells(Employee e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvEmployees);
            newRow.Cells[0].Value = e;
            newRow.Cells[1].Value = e.FirstName;
            newRow.Cells[2].Value = e.SecondName;
            newRow.Cells[3].Value = e.Position;
            newRow.Cells[4].Value = String.Format("€{0:0.00}", e.SalaryPerHour);
            newRow.Cells[5].Value = e.Bsn;
            newRow.Cells[6].Value = e.DateOfBirth;
            newRow.Cells[7].Value = e.PhoneNumber;
            newRow.Cells[8].Value = e.Email;
            newRow.Cells[9].Value = e.IceNumber;
            newRow.Cells[10].Value = e.IceRelationship;
            newRow.Cells[11].Value = e.QuittingReason;
            newRow.Cells[12].Value = e.StartingDate;
            newRow.Cells[13].Value = e.EndingDate;
            newRow.Cells[14].Value = e.ContractType;
            newRow.Cells[15].Value = e.Gender;
            newRow.Cells[16].Value = e.Degree;
            newRow.Cells[17].Value = e.Nationality;
            newRow.Cells[18].Value = e.ContractHours;
            newRow.Cells[19].Value = e.Adress;
            dgvEmployees.Rows.Add(newRow);
        }


        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one employee");
                return;
            }
            Employee emp = (Employee)dgvEmployees.CurrentRow.Cells[0].Value;

            EmploymentTermination et = new EmploymentTermination(emp);
            et.Show();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();
            string searchName = tbxSearchEmployee.Text.ToLower();

            if (cbxActiveInactiveEmployees.SelectedIndex == 0)
            {
                foreach (Employee emp in EH.GetAllEmployees())
                {
                    if ((emp.GetFullName().ToLower().Contains(searchName)) && (string.IsNullOrEmpty((emp.QuittingReason).ToString())))
                    {
                        FillEmployeeCells(emp);
                    }
                }
            }

            else
            {
                foreach (Employee emp in EH.GetAllEmployees())
                {
                    if ((emp.GetFullName().ToLower().Contains(searchName)) && (!string.IsNullOrEmpty((emp.QuittingReason).ToString())))
                    {
                        FillEmployeeCells(emp);
                    }
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployeeAdd;
            tbxEmployeeAdd_FirstName.Text = "";
            tbxEmployeeAdd_SecondName.Text = "";
            tbxEmployeeAdd_BSN.Text = "";
            tbxEmployeeAdd_PhoneNumber.Text = "";
            tbxEmployeeAdd_ICENumber.Text = "";
            tbxEmployeeAdd_AdditonalInfo.Text = "";
            tbxSalary.Text = "";
            dtpEmployeeAdd_DateOfBirth.Enabled = true;
            cbxEmployeeAdd_ICERelationship.SelectedIndex = -1;
            cbxEmployeeAdd_Position.SelectedIndex = -1;
            tbxEmployeeAdd_BSN.Enabled = true;
            cbxEmployeeAdd_ContractType.SelectedIndex = 0;
            cbxEmployeeAdd_Gender.SelectedIndex = 0;
            //buttons
            btnEmployeeAdd_Confirm.Visible = true;
            btnEmployeeAdd_ConfirmEdit.Visible = false;

            cbxEmployeeAdd_ICERelationship.DataSource = Enum.GetNames(typeof(ICERelation));
            cbxEmployeeAdd_Position.DataSource = Enum.GetNames(typeof(JobPosition));

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one employee to edit");
                return;
            }
            Employee emp = (Employee)dgvEmployees.CurrentRow.Cells[0].Value;

            //buttons
            btnEmployeeAdd_Confirm.Visible = false;
            btnEmployeeAdd_ConfirmEdit.Visible = true;

            //fill in all fields/disable
            tcNavigator.SelectedTab = tpEmployeeAdd;
            tbxEmployeeAdd_FirstName.Text = $"{emp.FirstName}";
            tbxEmployeeAdd_SecondName.Text = $"{emp.SecondName}";
            tbxEmployeeAdd_BSN.Text = $"{emp.Bsn}";
            tbxEmployeeAdd_BSN.Enabled = false;
            dtpEmployeeAdd_DateOfBirth.Value = emp.DateOfBirth;
            dtpEmployeeAdd_DateOfBirth.Enabled = false;
            tbxEmployeeAdd_PhoneNumber.Text = $"{emp.PhoneNumber}";
            tbxEmployeeAdd_ICENumber.Text = $"{emp.IceNumber}";
            tbxEmployeeAdd_AdditonalInfo.Text = $"{emp.AddInformation}";
            tbxSalary.Text = $"{emp.SalaryPerHour}";
            cbxEmployeeAdd_ICERelationship.SelectedIndex = -1;
            cbxEmployeeAdd_Position.SelectedIndex = -1;
            cbxEmployeeAdd_Gender.Text = emp.Gender;
            tbxEmployeeAdd_Degree.Text = emp.Degree;
            tbxEmployeeAdd_Nationality.Text = emp.Nationality;
            nudEmpContractHours.Value = emp.ContractHours;



            //populating combobox with enums
            cbxEmployeeAdd_ICERelationship.DataSource = Enum.GetNames(typeof(ICERelation));
            cbxEmployeeAdd_Position.DataSource = Enum.GetNames(typeof(JobPosition));

            switch (emp.Position)
            {
                case JobPosition.MANAGER:
                    cbxEmployeeAdd_Position.SelectedIndex = 0;
                    break;
                case JobPosition.HR:
                    cbxEmployeeAdd_Position.SelectedIndex = 1;
                    break;
                case JobPosition.SALES:
                    cbxEmployeeAdd_Position.SelectedIndex = 2;
                    break;
                case JobPosition.DEPOT:
                    cbxEmployeeAdd_Position.SelectedIndex = 3;
                    break;
                case JobPosition.SECURITY:
                    cbxEmployeeAdd_Position.SelectedIndex = 4;
                    break;
            }

            switch (emp.IceRelationship)
            {
                case ICERelation.PARTNER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 0;
                    break;
                case ICERelation.FATHER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 1;
                    break;
                case ICERelation.MOTHER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 2;
                    break;
                case ICERelation.BROTHER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 3;
                    break;
                case ICERelation.SISTER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 4;
                    break;
                case ICERelation.UNCLE:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 5;
                    break;
                case ICERelation.AUNT:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 6;
                    break;
                case ICERelation.COUSIN:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 7;
                    break;
                case ICERelation.FRIEND:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 8;
                    break;
                case ICERelation.OTHER:
                    cbxEmployeeAdd_ICERelationship.SelectedIndex = 9;
                    break;
            }

            switch (emp.ContractType)
            {
                case "Full Time":
                    cbxEmployeeAdd_ContractType.SelectedIndex = 0;
                    break;
                case "Part Time":
                    cbxEmployeeAdd_ContractType.SelectedIndex = 1;
                    break;
            }

            switch (emp.Gender)
            {
                case "Male":
                    cbxEmployeeAdd_Gender.SelectedIndex = 0;
                    break;
                case "Female":
                    cbxEmployeeAdd_Gender.SelectedIndex = 1;
                    break;
                case "Other":
                    cbxEmployeeAdd_Gender.SelectedIndex = 2;
                    break;
            }
        }


        private void btnEmployeeAdd_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbxEmployeeAdd_FirstName.Text.Substring(0, 3).ToLower() + tbxEmployeeAdd_SecondName.Text.Substring(0, 3).ToLower();
                string email = tbxEmployeeAdd_FirstName.Text.ToLower() + tbxEmployeeAdd_SecondName.Text.ToLower() + "@mediabazaar.nl";
                string password = tbxEmployeeAdd_FirstName.Text + tbxEmployeeAdd_BSN.Text.Substring(0, 1) + tbxEmployeeAdd_BSN.Text.Substring(tbxEmployeeAdd_BSN.Text.Length - 1, 1);
                int contractHours;
                if (cbxEmployeeAdd_ContractType.SelectedItem.ToString() == "Full Time")
                {
                    contractHours = 40;
                }
                else
                {
                    contractHours = Convert.ToInt32(Convert.ToInt32(Math.Round(nudEmpContractHours.Value)));
                }
                EH = new EmployeeHandler();
                var add = EH.AddEmployee(tbxEmployeeAdd_FirstName.Text, tbxEmployeeAdd_SecondName.Text, username, tbxEmployeeAdd_BSN.Text.ToString(), dtpEmployeeAdd_DateOfBirth.Value.Date, email, tbxEmployeeAdd_PhoneNumber.Text, tbxEmployeeAdd_ICENumber.Text, cbxEmployeeAdd_ICERelationship.SelectedItem.ToString(), cbxEmployeeAdd_Position.SelectedItem.ToString(), tbxEmployeeAdd_AdditonalInfo.Text, "", Convert.ToDouble(tbxSalary.Text), dtpEmployeeAdd_StartingDate.Value.Date, dtpEmployeeAdd_EndingDate.Value.Date, cbxEmployeeAdd_ContractType.SelectedItem.ToString(), cbxEmployeeAdd_Gender.SelectedItem.ToString(), tbxEmployeeAdd_Degree.Text, tbxEmployeeAdd_Nationality.Text, contractHours, tbxEmployeeAdd_Adress.Text);

                if (add == null)
                {
                    add = LH.AddLoginDetails(username, password);
                    FillActiveEmployees();
                    MessageBox.Show("Employee added succesfully.");
                    return;
                }
                MessageBox.Show(add.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBackToEmpPage_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployees;
            FillActiveEmployees();
            cbxActiveInactiveEmployees.SelectedIndex = 0;
        }

        private void btnEmployeeAdd_ConfirmEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EH = new EmployeeHandler();
                var update = EH.ChangeEmployee(tbxEmployeeAdd_FirstName.Text, tbxEmployeeAdd_SecondName.Text, tbxEmployeeAdd_BSN.Text, dtpEmployeeAdd_DateOfBirth.Value.Date, tbxEmployeeAdd_PhoneNumber.Text, tbxEmployeeAdd_ICENumber.Text, cbxEmployeeAdd_ICERelationship.SelectedItem.ToString(), cbxEmployeeAdd_Position.SelectedItem.ToString(), tbxEmployeeAdd_AdditonalInfo.Text, Convert.ToDouble(tbxSalary.Text), Convert.ToDateTime(dtpEmployeeAdd_StartingDate.Value.Date), Convert.ToDateTime(dtpEmployeeAdd_EndingDate.Value.Date), cbxEmployeeAdd_ContractType.SelectedItem.ToString(), cbxEmployeeAdd_Gender.SelectedItem.ToString(), tbxEmployeeAdd_Degree.Text, tbxEmployeeAdd_Nationality.Text, Convert.ToInt32(Math.Round(nudEmpContractHours.Value)), tbxEmployeeAdd_Adress.Text); ;

                if (update == null)
                {
                    FillActiveEmployees();
                    cbxActiveInactiveEmployees.SelectedIndex = 0;
                    MessageBox.Show("Employee edited succesfully");
                    return;
                }
                MessageBox.Show(update.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //SCHEDULES

        //method for filling schedule grid view for viewing emp
        public void FillScheduleGridViewEmp()
        {
            dgvSchedulesEmp.Rows.Clear();
            if (EH.GetAllEmployeesFromDB() == null)
            {
                int i = 0;
                foreach (Employee employee in EH.GetAllEmployees())
                {
                    dgvSchedulesEmp.Rows.Add(employee);
                    dgvSchedulesEmp.Rows[i].Cells[9].Value = employee.ContractHours.ToString();
                    dgvSchedulesEmp.Rows[i].Cells[10].Value = (employee.ContractHours / 40.00).ToString(); ;
                    i++;
                }
            }
            else
            {
                MessageBox.Show(EH.GetAllEmployeesFromDB().Message);
            }

            //Assign correct enum value to comboboxes
            schedulesEmpMonday.ValueType = typeof(TimeSlot);
            schedulesEmpMonday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpTuesday.ValueType = typeof(TimeSlot);
            schedulesEmpTuesday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpWednesday.ValueType = typeof(TimeSlot);
            schedulesEmpWednesday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpThursday.ValueType = typeof(TimeSlot);
            schedulesEmpThursday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpFriday.ValueType = typeof(TimeSlot);
            schedulesEmpFriday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpSaturday.ValueType = typeof(TimeSlot);
            schedulesEmpSaturday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesEmpSunday.ValueType = typeof(TimeSlot);
            schedulesEmpSunday.DataSource = Enum.GetValues(typeof(TimeSlot));
        }

        public void FillScheduleGridViewCreate()
        {
            dgvSchedulesCreate.Rows.Clear();
            foreach (Day day in (Day[])Enum.GetValues(typeof(Day)))
            {
                dgvSchedulesCreate.Rows.Add(day);
            }

            if (SCMH.GetMinimumPeopleFromDB() == null)
            {
                foreach (SchedulesMinimum schedulesMinimum in SCMH.GetSchedulesMinimum())
                {
                    int i = 0;

                    if (schedulesMinimum.TimeSlot == TimeSlot.MORNING)
                        i = 4;
                    else if (schedulesMinimum.TimeSlot == TimeSlot.AFTERNOON)
                        i = 5;
                    else if (schedulesMinimum.TimeSlot == TimeSlot.EVENING)
                        i = 6;

                    if (schedulesMinimum.Day == Day.MONDAY)
                        dgvSchedulesCreate.Rows[0].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.TUESDAY)
                        dgvSchedulesCreate.Rows[1].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.WEDNESDAY)
                        dgvSchedulesCreate.Rows[2].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.THURDAY)
                        dgvSchedulesCreate.Rows[3].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.FRIDAY)
                        dgvSchedulesCreate.Rows[4].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.SATURDAY)
                        dgvSchedulesCreate.Rows[5].Cells[i].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.SUNDAY)
                        dgvSchedulesCreate.Rows[6].Cells[i].Value = schedulesMinimum.MinimumPeople;


                }
            }
        }

        //Method for filling dgv minumum people per shift page
        public void FillScheduleMinimumGridView()
        {
            dgvScheduleMinP.Rows.Clear();
            foreach (TimeSlot timeSlot in (TimeSlot[])Enum.GetValues(typeof(TimeSlot)))
            {
                if (timeSlot == TimeSlot.NO_SHIFT)
                    continue;
                dgvScheduleMinP.Rows.Add(timeSlot);
            }

            if (SCMH.GetMinimumPeopleFromDB() == null)
            {
                foreach (SchedulesMinimum schedulesMinimum in SCMH.GetSchedulesMinimum())
                {
                    int i = 0;

                    if (schedulesMinimum.TimeSlot == TimeSlot.MORNING)
                        i = 0;
                    else if (schedulesMinimum.TimeSlot == TimeSlot.AFTERNOON)
                        i = 1;
                    else if (schedulesMinimum.TimeSlot == TimeSlot.EVENING)
                        i = 2;

                    if (schedulesMinimum.Day == Day.MONDAY)
                        dgvScheduleMinP.Rows[i].Cells[1].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.TUESDAY)
                        dgvScheduleMinP.Rows[i].Cells[2].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.WEDNESDAY)
                        dgvScheduleMinP.Rows[i].Cells[3].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.THURDAY)
                        dgvScheduleMinP.Rows[i].Cells[4].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.FRIDAY)
                        dgvScheduleMinP.Rows[i].Cells[5].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.SATURDAY)
                        dgvScheduleMinP.Rows[i].Cells[6].Value = schedulesMinimum.MinimumPeople;
                    else if (schedulesMinimum.Day == Day.SUNDAY)
                        dgvScheduleMinP.Rows[i].Cells[7].Value = schedulesMinimum.MinimumPeople;
                }
            }
        }



        //button for viewing emp schedules in schedule choise menu
        private void gpnlViewSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedulesEmp;
        }

        private void lblViewSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedulesEmp;
        }

        //button for creating the schedules in schedule choise menu
        private void gpnlCreateSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedulesCreate;
        }

        private void lblCreateSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedulesCreate;
        }



        //button for searching a specific employee in the view employee schedule page
        private void btnScheduleEmpSearch_Click(object sender, EventArgs e)
        {
            dgvSchedulesEmp.CurrentCell = null;
            //check for each emp in the schedule dgv if searched name is included 
            for (int i = 0; i < EH.GetAllEmployees().Count(); i++)
            {
                //create temp emp object based on the state of the for loop
                Employee emp = (Employee)dgvSchedulesEmp.Rows[i].Cells[0].Value;
                if (emp.FirstName.Contains(tbxScheduleEmpSearch.Text))
                {
                    dgvSchedulesEmp.Rows[i].Selected = true;
                }
            }
        }

        //Button to load schedule of chosen week in view emp schedule tab.
        private void btnSchedulesEmpShowWeek_Click(object sender, EventArgs e)
        {
            FillScheduleGridViewEmp();
            int weekNmr = Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value));
            if (SCH.GetAllSchedulesFromDB(weekNmr) == null)
            {
                lblScheduleCurrentWeekEmp.Text = $"Currently showing week: {weekNmr}";
                foreach (Schedule schedule in SCH.GetAllSchedules())
                {
                    //check for each schedule object if any of the employeeBsn's are the same. 
                    for (int i = 0; i < EH.GetAllEmployees().Count(); i++)
                    {
                        //create temp emp object based on the state of the for loop
                        Employee emp = EH.GetAllEmployees()[i];
                        if (emp.Bsn == schedule.EmployeeBSN)
                        {
                            emp.WorkedHours += 4;
                            if (schedule.Day == Day.MONDAY)
                                dgvSchedulesEmp.Rows[i].Cells[1].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.TUESDAY)
                                dgvSchedulesEmp.Rows[i].Cells[2].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.WEDNESDAY)
                                dgvSchedulesEmp.Rows[i].Cells[3].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.THURDAY)
                                dgvSchedulesEmp.Rows[i].Cells[4].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.FRIDAY)
                                dgvSchedulesEmp.Rows[i].Cells[5].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.SATURDAY)
                                dgvSchedulesEmp.Rows[i].Cells[6].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.SUNDAY)
                                dgvSchedulesEmp.Rows[i].Cells[7].Value = schedule.TimeSlot;

                            dgvSchedulesEmp.Rows[i].Cells[8].Value = emp.WorkedHours;
                            if (emp.WorkedHours < emp.ContractHours - 2 || emp.WorkedHours > emp.ContractHours + 2)
                            {
                                dgvSchedulesEmp.Rows[i].Cells[8].Style.BackColor = Color.Red;
                            }
                            else { dgvSchedulesEmp.Rows[i].Cells[8].Style.BackColor = Color.Green; }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show(SCH.GetAllSchedulesFromDB(weekNmr).Message);
            }
        }

        //Method for saving the schedule for the week you are viewing in the view emp schedule tab.
        private void btnScheduleEmpSaveCurrentWeek_Click(object sender, EventArgs e)
        {
            SCH.DeleteWeekSchedule(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)));

            try
            {
                for (int rows = 0; rows < dgvSchedulesEmp.Rows.Count; rows++)
                {
                    for (int col = 1; col < dgvSchedulesEmp.Rows[rows].Cells.Count; col++)
                    {
                        Employee emp = (Employee)dgvSchedulesEmp.Rows[rows].Cells[0].Value;

                        string slot = null;
                        if (dgvSchedulesEmp.Rows[rows].Cells[col].Value != null)
                        {
                            slot = dgvSchedulesEmp.Rows[rows].Cells[col].Value.ToString();
                        }

                        if (col == 1 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.MONDAY, emp.Bsn, slot);
                        }
                        if (col == 2 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.TUESDAY, emp.Bsn, slot);
                        }
                        if (col == 3 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.WEDNESDAY, emp.Bsn, slot);
                        }
                        if (col == 4 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.THURDAY, emp.Bsn, slot);
                        }
                        if (col == 5 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.FRIDAY, emp.Bsn, slot);
                        }
                        if (col == 6 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.SATURDAY, emp.Bsn, slot);
                        }
                        else if (col == 7 && !string.IsNullOrEmpty(slot) && (slot != TimeSlot.NO_SHIFT.ToString()))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleEmpWeek.Value)), Day.SUNDAY, emp.Bsn, slot);
                        }
                    }
                }
                btnSchedulesEmpShowWeek.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //button for saving the current schedule as the template
        private void btnSchedulesCreateSaveTempalte_Click(object sender, EventArgs e)
        {
            SCTH.DeleteWeekScheduleTemplate();
            try
            {
                //for everyday
                for (int d = 0; d < 7; d++)
                {
                    //for every timeslot
                    for (int s = 1; s < 4; s++)
                    {
                        //take all names and split them up
                        string allEmp = (string)dgvSchedulesCreate.Rows[d].Cells[s].Value;
                        //check if there are any people scheduled
                        if (allEmp != null)
                        {
                            string[] bsnArray = allEmp.Split('.');
                            List<Employee> empList = new List<Employee>();
                            foreach (string empName in bsnArray)
                            {
                                Employee emp = EH.GetEmployeeByName(empName);
                                if (emp != null)
                                {
                                    empList.Add(emp);
                                }
                            }
                            //foreach bsn add to the db
                            foreach (Employee emp in empList)
                            {
                                TimeSlot slot = (TimeSlot)s;
                                SCTH.SaveCurrentWeekTemplate((Day)d, emp.Bsn, slot.ToString());
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //button for inserting the template in the currently showing week in the create schedule view
        private void btnSchedulesCreateLoadTemplate_Click(object sender, EventArgs e)
        {
            if (SCTH.GetWeekScheduleTemplateFromDB() == null)
            {
                FillScheduleGridViewCreate();
                SCH.DeleteWeekSchedule(Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)));
                List<int> peopleCount = new List<int>();
                for (int i = 0; i <= 21; i++)
                {
                    peopleCount.Add(0);
                }
                foreach (ScheduleTemplate scheduleTemplate in SCTH.GetScheduleTemplate())
                {
                    SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)), scheduleTemplate.Day, scheduleTemplate.EmployeeBSN, scheduleTemplate.TimeSlot.ToString());

                    int i = 0;
                    if (scheduleTemplate.TimeSlot == TimeSlot.MORNING) { i = 1; }
                    else if (scheduleTemplate.TimeSlot == TimeSlot.AFTERNOON) { i = 2; }
                    else { i = 3; }

                    switch (scheduleTemplate.Day)
                    {
                        case Day.MONDAY: peopleCount[i] += 1; dgvSchedulesCreate.Rows[0].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.TUESDAY: peopleCount[i + 3] += 1; dgvSchedulesCreate.Rows[1].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.WEDNESDAY: peopleCount[i + 6] += 1; dgvSchedulesCreate.Rows[2].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.THURDAY: peopleCount[i + 9] += 1; dgvSchedulesCreate.Rows[3].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.FRIDAY: peopleCount[i + 12] += 1; dgvSchedulesCreate.Rows[4].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.SATURDAY: peopleCount[i + 15] += 1; dgvSchedulesCreate.Rows[5].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                        case Day.SUNDAY: peopleCount[i + 18] += 1; dgvSchedulesCreate.Rows[6].Cells[i].Value += EH.GetEmployee(scheduleTemplate.EmployeeBSN) + "."; break;
                    }

                }
                CheckForMinPeopleMet(peopleCount);
            }
            else
            {
                MessageBox.Show("Template not present in database.");
            }

        }

        //method for showing the schedule of the chosen week in the create view
        private void btnSchedulesCreateShowWeek_Click(object sender, EventArgs e)
        {
            FillScheduleGridViewCreate();
            int weekNmr = Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value));
            if (SCH.GetAllSchedulesFromDB(weekNmr) == null)
            {
                List<int> peopleCount = new List<int>();
                for (int i = 0; i <= 21; i++)
                {
                    peopleCount.Add(0);
                }
                lblScheduleCurrentWeekCreate.Text = $"Currently showing week: {weekNmr}";
                foreach (Schedule schedule in SCH.GetAllSchedules())
                {
                    int i = 0;
                    if (schedule.TimeSlot == TimeSlot.MORNING) { i = 1; }
                    else if (schedule.TimeSlot == TimeSlot.AFTERNOON) { i = 2; }
                    else { i = 3; }


                    switch (schedule.Day)
                    {
                        case Day.MONDAY: peopleCount[i] += 1; dgvSchedulesCreate.Rows[0].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.TUESDAY: peopleCount[i + 3] += 1; dgvSchedulesCreate.Rows[1].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.WEDNESDAY: peopleCount[i + 6] += 1; dgvSchedulesCreate.Rows[2].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.THURDAY: peopleCount[i + 9] += 1; dgvSchedulesCreate.Rows[3].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.FRIDAY: peopleCount[i + 12] += 1; dgvSchedulesCreate.Rows[4].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.SATURDAY: peopleCount[i + 15] += 1; dgvSchedulesCreate.Rows[5].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                        case Day.SUNDAY: peopleCount[i + 18] += 1; dgvSchedulesCreate.Rows[6].Cells[i].Value += EH.GetEmployee(schedule.EmployeeBSN) + "."; break;
                    }
                }
                CheckForMinPeopleMet(peopleCount);
            }
            else
            {
                MessageBox.Show(SCH.GetAllSchedulesFromDB(weekNmr).Message);
            }
        }

        //method for auto creating a schedule for the selected week
        private void btnScheduleCreateAutoGenerate_Click(object sender, EventArgs e)
        {
            PH.GetAllPreferencesFromDB();
            SCH.GetAllSchedulesFromDB(Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)));
            SCH.DeleteWeekSchedule(Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)));
            foreach (Schedule sch in SCHAH.CreateAutomaticSchedule(Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)), SCMH.GetSchedulesMinimum(), EH.GetAllEmployees(), SCH.GetAllSchedules(), PH.GetAllPreferences(), EH))
            {
                SCH.SaveCurrentWeek(sch.Week, sch.Day, sch.EmployeeBSN, sch.TimeSlot.ToString());
            }
            btnSchedulesCreateShowWeek.PerformClick();
        }


        //method to check if the min people per shift is met
        private void CheckForMinPeopleMet(List<int> peopleCount)
        {
            SetScheduleCreateColorsToRed();

            //change to green if min people is met
            if ((int)dgvSchedulesCreate.Rows[0].Cells[4].Value <= peopleCount[1])
            {
                dgvSchedulesCreate.Rows[0].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[0].Cells[5].Value <= peopleCount[2])
            {
                dgvSchedulesCreate.Rows[0].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[0].Cells[6].Value <= peopleCount[3])
            {
                dgvSchedulesCreate.Rows[0].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[1].Cells[4].Value <= peopleCount[4])
            {
                dgvSchedulesCreate.Rows[1].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[1].Cells[5].Value <= peopleCount[5])
            {
                dgvSchedulesCreate.Rows[1].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[1].Cells[6].Value <= peopleCount[6])
            {
                dgvSchedulesCreate.Rows[1].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[2].Cells[4].Value <= peopleCount[7])
            {
                dgvSchedulesCreate.Rows[2].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[2].Cells[5].Value <= peopleCount[8])
            {
                dgvSchedulesCreate.Rows[2].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[2].Cells[6].Value <= peopleCount[9])
            {
                dgvSchedulesCreate.Rows[2].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[3].Cells[4].Value <= peopleCount[10])
            {
                dgvSchedulesCreate.Rows[3].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[3].Cells[5].Value <= peopleCount[11])
            {
                dgvSchedulesCreate.Rows[3].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[3].Cells[6].Value <= peopleCount[12])
            {
                dgvSchedulesCreate.Rows[3].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[4].Cells[4].Value <= peopleCount[13])
            {
                dgvSchedulesCreate.Rows[4].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[4].Cells[5].Value <= peopleCount[14])
            {
                dgvSchedulesCreate.Rows[4].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[4].Cells[6].Value <= peopleCount[15])
            {
                dgvSchedulesCreate.Rows[4].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[5].Cells[4].Value <= peopleCount[16])
            {
                dgvSchedulesCreate.Rows[5].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[5].Cells[5].Value <= peopleCount[17])
            {
                dgvSchedulesCreate.Rows[5].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[5].Cells[6].Value <= peopleCount[18])
            {
                dgvSchedulesCreate.Rows[5].Cells[6].Style.BackColor = Color.Green;
            }

            if ((int)dgvSchedulesCreate.Rows[6].Cells[4].Value <= peopleCount[19])
            {
                dgvSchedulesCreate.Rows[6].Cells[4].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[6].Cells[5].Value <= peopleCount[20])
            {
                dgvSchedulesCreate.Rows[6].Cells[5].Style.BackColor = Color.Green;
            }
            if ((int)dgvSchedulesCreate.Rows[6].Cells[6].Value <= peopleCount[21])
            {
                dgvSchedulesCreate.Rows[6].Cells[6].Style.BackColor = Color.Green;
            }
        }

        private void btnSchedulesSaveMinPeople_Click(object sender, EventArgs e)
        {
            SCMH.DeleteMinimumPeople();
            try
            {
                for (int rows = 0; rows < dgvScheduleMinP.Rows.Count; rows++)
                {
                    for (int col = 1; col < dgvScheduleMinP.Rows[rows].Cells.Count; col++)
                    {
                        TimeSlot timeSlot = (TimeSlot)dgvScheduleMinP.Rows[rows].Cells[0].Value;

                        string slot = null;
                        if (dgvScheduleMinP.Rows[rows].Cells[col].Value != null)
                        {
                            slot = dgvScheduleMinP.Rows[rows].Cells[col].Value.ToString();
                        }

                        if (col == 1 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.MONDAY, timeSlot, slot);
                        }
                        if (col == 2 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.TUESDAY, timeSlot, slot);
                        }
                        if (col == 3 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.WEDNESDAY, timeSlot, slot);
                        }
                        if (col == 4 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.THURDAY, timeSlot, slot);
                        }
                        if (col == 5 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.FRIDAY, timeSlot, slot);
                        }
                        if (col == 6 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.SATURDAY, timeSlot, slot);
                        }
                        else if (col == 7 && !string.IsNullOrEmpty(slot))
                        {
                            SCMH.SaveNewMinimumPeople(Day.SUNDAY, timeSlot, slot);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Button click for minimum amount of people per shift
        private void btnScheduleCreateMinimumPeople_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpScheduleMin;
        }


        //button click for assigning shifts
        private void dgvSchedulesCreate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ScheduleCreateAddEmployee SCAE = new ScheduleCreateAddEmployee(EH, SCH, Convert.ToInt32(Math.Round(nudSchedulesCreateWeek.Value)), (Day)e.RowIndex, (TimeSlot)e.ColumnIndex, (int)dgvSchedulesCreate.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value);
                SCAE.RefreshPageEvent -= new ScheduleCreateAddEmployee.RefreshingSchedulePage(btnSchedulesCreateShowWeek_Click);
                SCAE.RefreshPageEvent += new ScheduleCreateAddEmployee.RefreshingSchedulePage(btnSchedulesCreateShowWeek_Click);
                SCAE.ShowDialog();
            }
        }

        //method for clearing the schedule view grid.
        private void clearGrid()
        {
            for (int i = 0; i < EH.GetAllEmployees().Count(); i++)
            {
                dgvSchedulesEmp.Rows[i].Cells[1].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[2].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[3].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[4].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[5].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[6].Value = null;
                dgvSchedulesEmp.Rows[i].Cells[7].Value = null;
            }
        }

        //STATISTICS



        //DESIGN

        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        //'X' icon used to close current form
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //updates mouse position when the panel is clicked
        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        //updates window position based on the movement on mouse to simulate the default 'drag bar' that was removed due to design reasons
        private void pnlDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
            //creates a color gradient as the background to make the form more visually appealing
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                           Color.FromArgb(255, 158, 0),
                                                           Color.FromArgb(212, 95, 0),
                                                           90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            //creates a border in order to better differenciate the form from any other applications behind it
            int borderThickness = 4;
            using (Pen p = new Pen(Color.FromArgb(66, 66, 66), borderThickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle((borderThickness / 2),
                                                          (borderThickness / 2),
                                                          pnlBackground.ClientSize.Width - borderThickness,
                                                          pnlBackground.ClientSize.Height - borderThickness));
            }
        }

        private void tbxSearchStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchStock.PerformClick();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Gray;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        public void UpdateStatsComboboxes(string name)
        {
            cbxStats1.Items.Add(name);
            cbxStats2.Items.Add(name);
            cbxStats3.Items.Add(name);

            cbxStatsPeriod1.Items.Add(name);
            cbxStatsPeriod2.Items.Add(name);
            cbxStatsPeriod3.Items.Add(name);

            cbxStatsProfit1.Items.Add(name);
            cbxStatsProfit2.Items.Add(name);
            cbxStatsProfit3.Items.Add(name);

            cbxStatsRevenue1.Items.Add(name);
            cbxStatsRevenue2.Items.Add(name);
            cbxStatsRevenue3.Items.Add(name);
        }


        public void UpdateMostPopularStock()
        {
            Product winner;
            float mostStockMax = 0.0f;
            foreach (Product p in SH.GetAllProducts())
            {
                if (p.Active == 1)
                {
                    if (p.TotalSold > mostStockMax)
                    {
                        mostStockMax = p.TotalSold;
                        winner = p;
                        lblStatsStock_MostPopular.Text = $"{winner.Name}";
                        lblStatsStock_MostPopularAmount.Text = $"{winner.TotalSold} total items sold";
                    }
                }
            }

        }

        public void UpdateStockGraph()
        {
            foreach (var series in chartStock.Series)
            {
                series.Points.Clear();
            }
            foreach (Product p in SH.GetAllProducts())
            {
                if (cbxStats1.SelectedIndex > -1)
                {
                    if (p.Name.Contains(cbxStats1.SelectedItem.ToString()))
                    {
                        this.chartStock.Series["Store Stock Total"].Points.AddXY(p.Name, p.QuantityS);
                        this.chartStock.Series["Warehouse Stock Total"].Points.AddXY(p.Name, p.QuantityWH);
                        btnDeselectStatsStock1.Visible = true;
                    }
                }

                if (cbxStats2.SelectedIndex > -1)
                {
                    if (p.Name.Contains(cbxStats2.SelectedItem.ToString()))
                    {
                        this.chartStock.Series["Store Stock Total"].Points.AddXY(p.Name, p.QuantityS);
                        this.chartStock.Series["Warehouse Stock Total"].Points.AddXY(p.Name, p.QuantityWH);
                        btnDeselectStatsStock2.Visible = true;
                    }
                }

                if (cbxStats3.SelectedIndex > -1)
                {
                    if (p.Name.Contains(cbxStats3.SelectedItem.ToString()))
                    {
                        this.chartStock.Series["Store Stock Total"].Points.AddXY(p.Name, p.QuantityS);
                        this.chartStock.Series["Warehouse Stock Total"].Points.AddXY(p.Name, p.QuantityWH);
                        btnDeselectStatsStock3.Visible = true;
                    }
                }
            }
        }

        public void UpdateStockPeriodGraph()
        {
            if (cbxStatsPeriod1.Text == "Stock 1" && cbxStatsPeriod2.Text == "Stock 2" && cbxStatsPeriod3.Text == "Stock 3")
                lbStatsNotAvailable1.Visible = true;
            else
                lbStatsNotAvailable1.Visible = false;

            foreach (var series in chartStockSoldPeriod.Series)
            {
                series.Points.Clear();
            }
            foreach (SellingTracker s in STH.GetAllSellings())
            {
                if (cbxStatsPeriod1.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsPeriod1.SelectedItem.ToString()))
                    {
                        int sold = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTime.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTime.Value.Date) <= 0))
                                sold += sell.QuantitySold;
                        }

                        this.chartStockSoldPeriod.Series["Store stock sold in the period"].Points.AddXY(s.Name, sold.ToString());
                        this.chartStockSoldPeriod.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsPeriodStock1.Visible = true;
                    }
                }

                if (cbxStatsPeriod2.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsPeriod2.SelectedItem.ToString()))
                    {
                        int sold = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTime.Value) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTime.Value) <= 0))
                                sold += sell.QuantitySold;
                        }

                        this.chartStockSoldPeriod.Series["Store stock sold in the period"].Points.AddXY(s.Name, sold.ToString());
                        this.chartStockSoldPeriod.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsPeriodStock2.Visible = true;
                    }
                }

                if (cbxStatsPeriod3.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsPeriod3.SelectedItem.ToString()))
                    {
                        int sold = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTime.Value) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTime.Value) <= 0))
                                sold += sell.QuantitySold;
                        }

                        this.chartStockSoldPeriod.Series["Store stock sold in the period"].Points.AddXY(s.Name, sold.ToString());
                        this.chartStockSoldPeriod.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsPeriodStock3.Visible = true;
                    }
                }
            }
        }

        public void UpdateEmployeeChartPositions()
        {
            int depotCount = 0;
            int hrCount = 0;
            int managerCount = 0;
            int salesCount = 0;
            int securityCount = 0;

            foreach (var series in chartEmployeesPosition.Series)
            {
                series.Points.Clear();
            }
            foreach (Employee e in EH.GetAllEmployees())
            {
                if (string.IsNullOrEmpty((e.QuittingReason).ToString()))
                {
                    switch (e.Position)
                    {
                        case JobPosition.DEPOT:
                            depotCount++;
                            break;
                        case JobPosition.HR:
                            hrCount++;
                            break;
                        case JobPosition.MANAGER:
                            managerCount++;
                            break;
                        case JobPosition.SALES:
                            salesCount++;
                            break;
                        case JobPosition.SECURITY:
                            securityCount++;
                            break;
                    }
                }
            }

            int totalCount = depotCount + hrCount + managerCount + salesCount + securityCount;

            if (depotCount > 0)
            {
                this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"Depot\n[{depotCount}]", depotCount);
                //this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"Depot\n[{depotCount}/{totalCount}]", depotCount);
            }
            if (hrCount > 0)
            {
                this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"HR\n[{hrCount}]", hrCount);
            }
            if (managerCount > 0)
            {
                this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"Manager\n[{managerCount}]", managerCount);
            }
            if (salesCount > 0)
            {
                this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"Sales\n[{salesCount}]", salesCount);
            }
            if (securityCount > 0)
            {
                this.chartEmployeesPosition.Series["Positions"].Points.AddXY($"Security\n[{securityCount}]", securityCount);
            }
        }

        public void UpdateEmployeeChartGender()
        {
            int maleCount = 0;
            int femaleCount = 0;
            int otherCount = 0;

            foreach (var series in chartEmployeesGender.Series)
            {
                series.Points.Clear();
            }
            foreach (Employee e in EH.GetAllEmployees())
            {
                if (string.IsNullOrEmpty((e.QuittingReason).ToString()))
                {
                    switch (e.Gender)
                    {
                        case "Male":
                            maleCount++;
                            break;
                        case "Female":
                            femaleCount++;
                            break;
                        case "Other":
                            otherCount++;
                            break;
                    }
                }
            }

            int totalCount = maleCount + femaleCount + otherCount;

            double malePercentage = Math.Ceiling(Convert.ToDouble(maleCount) / totalCount * 100);
            double femalePercentage = Math.Ceiling(Convert.ToDouble(femaleCount) / totalCount * 100);
            double otherPercentage = Math.Ceiling(Convert.ToDouble(otherCount) / totalCount * 100);

            if (maleCount > 0)
            {
                this.chartEmployeesGender.Series["Genders"].Points.AddXY($"Male\n{malePercentage}%", maleCount);
            }
            if (femaleCount > 0)
            {
                this.chartEmployeesGender.Series["Genders"].Points.AddXY($"Female\n{femalePercentage}%", femaleCount);
            }
            if (otherCount > 0)
            {
                this.chartEmployeesGender.Series["Genders"].Points.AddXY($"Other\n{otherPercentage}%", otherCount);
            }
        }

        public void UpdateEmployeeChartContractType()
        {
            int fullTimeCount = 0;
            int partTimeCount = 0;

            foreach (var series in chartEmployeesContractType.Series)
            {
                series.Points.Clear();
            }
            foreach (Employee e in EH.GetAllEmployees())
            {
                if (string.IsNullOrEmpty((e.QuittingReason).ToString()))
                {
                    switch (e.ContractType)
                    {
                        case "Full Time":
                            fullTimeCount++;
                            break;
                        case "Part Time":
                            partTimeCount++;
                            break;
                    }
                }
            }

            int totalCount = fullTimeCount + partTimeCount;
            double fullTimePercentage = Math.Ceiling(Convert.ToDouble(fullTimeCount) / totalCount * 100);
            double partTimePercentage = Math.Ceiling(Convert.ToDouble(partTimeCount) / totalCount * 100);

            if (fullTimeCount > 0)
            {
                this.chartEmployeesContractType.Series["ContractType"].Points.AddXY($"Full Time\n{fullTimePercentage}%", fullTimeCount);
            }
            if (partTimeCount > 0)
            {
                this.chartEmployeesContractType.Series["ContractType"].Points.AddXY($"Part Time\n{partTimePercentage}%", partTimeCount);
            }
        }

        public void UpdateEmployeeAverageSalaryPerHour()
        {
            int counter = 0;
            double total = 0;

            foreach (Employee e in EH.GetAllEmployees())
            {
                if (string.IsNullOrEmpty((e.QuittingReason).ToString()))
                {
                    total += e.SalaryPerHour;
                    counter++;
                }
            }

            double average = Math.Round((total / counter), 2);
            lblStatsEmployee_AverageSalary.Text = $"€{average}";
        }



        private void cbxStats1_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateStockGraph();
        }

        private void cbxStats2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockGraph();
        }

        private void cbxStats3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockGraph();
        }

        private void btnDeselectStatsStock1_Click(object sender, EventArgs e)
        {
            cbxStats1.SelectedIndex = -1;
            cbxStats1.Text = "Stock 1";
            UpdateStockGraph();
            btnDeselectStatsStock1.Visible = false;
        }

        private void btnDeselectStatsStock2_Click(object sender, EventArgs e)
        {
            cbxStats2.SelectedIndex = -1;
            cbxStats2.Text = "Stock 2";
            UpdateStockGraph();
            btnDeselectStatsStock2.Visible = false;
        }

        private void btnDeselectStatsStock3_Click(object sender, EventArgs e)
        {
            cbxStats3.SelectedIndex = -1;
            cbxStats3.Text = "Stock 3";
            UpdateStockGraph();
            btnDeselectStatsStock3.Visible = false;
        }

        private void cbxActiveInactiveEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxActiveInactiveEmployees.SelectedIndex == 0)
            {
                btnDeleteEmployee.Visible = true;
                FillActiveEmployees();
            }
            else
            {
                btnDeleteEmployee.Visible = false;
                FillTerminatedEmployees();
            }
        }

        public void AdjustColumnWidthStock()
        {
            dgvAllStock.RowHeadersWidth = 30;
            dgvAllStock.Columns[0].Width = 30; // ID
            dgvAllStock.Columns[1].Width = 123; // EAN
            dgvAllStock.Columns[2].Width = 247; // Name
            dgvAllStock.Columns[3].Width = 80; // Quantity in store
            dgvAllStock.Columns[4].Width = 80; // Location in store
            dgvAllStock.Columns[5].Width = 130; // Quantity in warehouse
            dgvAllStock.Columns[6].Width = 130; // Location in warehouse
            dgvAllStock.Columns[7].Width = 60; // Cost price
            dgvAllStock.Columns[8].Width = 60; // Sell price
            dgvAllStock.Columns[9].Width = 75; // Minimum stock
            dgvAllStock.Columns[10].Width = 75; // Total sold
        }

        public void AdjustColumnWidthSchedules()
        {
            dgvSchedulesEmp.RowHeadersWidth = 4;
            dgvSchedulesEmp.Columns[0].Width = 130; // Name
            dgvSchedulesEmp.Columns[1].Width = 130; // M
            dgvSchedulesEmp.Columns[2].Width = 130; // T
            dgvSchedulesEmp.Columns[3].Width = 130; // W
            dgvSchedulesEmp.Columns[4].Width = 130; // T
            dgvSchedulesEmp.Columns[5].Width = 130; // F
            dgvSchedulesEmp.Columns[6].Width = 130; // S
            dgvSchedulesEmp.Columns[7].Width = 130; // S
            dgvSchedulesEmp.Columns[8].Width = 0; // WorkedHours
            dgvSchedulesEmp.Columns[9].Width = 0; // Contract hours
            dgvSchedulesEmp.Columns[10].Width = 0; //FTE
        }

        public void AdjustColumnWidthSchedulesFTE()
        {
            dgvSchedulesEmp.RowHeadersWidth = 4;
            dgvSchedulesEmp.Columns[0].Width = 130; // Name
            dgvSchedulesEmp.Columns[1].Width = 114; // M
            dgvSchedulesEmp.Columns[2].Width = 114; // T
            dgvSchedulesEmp.Columns[3].Width = 114; // W
            dgvSchedulesEmp.Columns[4].Width = 114; // T
            dgvSchedulesEmp.Columns[5].Width = 114; // F
            dgvSchedulesEmp.Columns[6].Width = 113; // S
            dgvSchedulesEmp.Columns[7].Width = 113; // S
            dgvSchedulesEmp.Columns[8].Width = 60; // WorkedHours
            dgvSchedulesEmp.Columns[9].Width = 60; //Contrat hours
            dgvSchedulesEmp.Columns[10].Width = 60; // FTE
        }

        public void AdjustColumnWidthEmployees()
        {
            dgvEmployees.RowHeadersWidth = 30;
            dgvEmployees.Columns[1].Width = 80; // First name
            dgvEmployees.Columns[2].Width = 90; // Second name
            dgvEmployees.Columns[3].Width = 65; // Position
            dgvEmployees.Columns[4].Width = 50; // Salary
            dgvEmployees.Columns[5].Width = 70; // BSN
            dgvEmployees.Columns[6].Width = 130; // Date of birth
            dgvEmployees.Columns[7].Width = 80; // Phone number
            dgvEmployees.Columns[8].Width = 180; // Email
            dgvEmployees.Columns[9].Width = 70; // ICE number
            dgvEmployees.Columns[10].Width = 65; // ICE relation
            dgvEmployees.Columns[11].Width = 202; // Quiting reason
            dgvEmployees.Columns[12].Width = 130; // Starting Date
            dgvEmployees.Columns[13].Width = 130; // Ending Date
            dgvEmployees.Columns[14].Width = 65; // Contract Type
            dgvEmployees.Columns[15].Width = 65; // Gender
            dgvEmployees.Columns[16].Width = 130; // Degree
            dgvEmployees.Columns[17].Width = 80; // Nationality
            dgvEmployees.Columns[18].Width = 60; // Contract Hours


        }
        public void AdjustColumnWidthSales()
        {
            dgvSales_Reciept.Columns[0].Width = 35; // Quantity
            dgvSales_Reciept.Columns[1].Width = 225; // Name
            dgvSales_Reciept.Columns[2].Width = 70; // Price
        }

        public void AdjustColumnWidthSalesInfo()
        {
            dgvSales_ManualInfo.Columns[0].Width = 80; // Heading
            dgvSales_ManualInfo.Columns[1].Width = 300; // Value
        }

        public void StatsTypeCheck()
        {
            if (cbxStatsType.SelectedItem.ToString() == "Stock")
            {
                tcNavigator.SelectedTab = tpStatsStock;
                return;
            }
            if (cbxStatsType.SelectedItem.ToString() == "Employees")
            {
                tcNavigator.SelectedTab = tpStatsEmployee;
                return;
            }
        }

        private void cbxStatsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatsTypeCheck();
        }



        private void btnStockStatsRandomize_Click(object sender, EventArgs e)
        {

        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            //select one item
            if (dgvAllStock.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one product to sell.");
                return;
            }
            Product p = (Product)dgvAllStock.CurrentRow.Cells[0].Value;

            //fill in all fields/disable
            tcNavigator.SelectedTab = tpSellProduct;

            //textboxes filled with data
            tbSellID.Text = $"{p.Id.ToString()}";
            tbSellEAN.Text = $"{p.Ean.ToString()}";
            tbSellName.Text = $"{p.Name}";
            tbSellQuantity.Text = "";

            //fields disabled
            tbSellID.Enabled = false;
            tbSellEAN.Enabled = false;
            tbSellName.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //select one item
            if (dgvAllStock.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one product to order.");
                return;
            }
            Product p = (Product)dgvAllStock.CurrentRow.Cells[0].Value;

            //fill in all fields/disable
            tcNavigator.SelectedTab = tpNewOrder;

            //textboxes filled with data
            tbNewOrderID.Text = $"{p.Id.ToString()}";
            tbNewOrderEAN.Text = $"{p.Ean.ToString()}";
            tbNewOrderName.Text = $"{p.Name}";

            //fields disabled
            tbNewOrderID.Enabled = false;
            tbNewOrderEAN.Enabled = false;
            tbNewOrderName.Enabled = false;
        }

        //make a new order of a product
        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //product
                Product p = SH.GetProduct(Int32.Parse(tbNewOrderID.Text));

                //calculations of quantity and exception returned if it occurs
                var newOrder = SH.AddQuantityToProduct(p, tbNewOrderWarehouse.Text, tbNewOrderStore.Text);

                if (newOrder == null)
                {
                    FillStockViewActive();
                    cbxActiveInactiveEmployees.SelectedIndex = 0;
                    MessageBox.Show("New order correctly done.");
                    tcNavigator.SelectedTab = tpStock;
                    return;
                }
                MessageBox.Show(newOrder.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewOrderBack_Click(object sender, EventArgs e)
        {
            tbNewOrderStore.Clear();
            tbNewOrderWarehouse.Clear();
            //back to stock page
            tcNavigator.SelectedTab = tpStock;
        }

        private void btnSellConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //product
                Product p = SH.GetProduct(Int32.Parse(tbSellID.Text));

                //calculations of quantity and exception returned if it occurs
                var sellProduct = SH.SellProduct(p, tbSellQuantity.Text);
                DateTime dateTime = DateTime.Now;
                var sellTracker = STH.AddSelling(p.Id.ToString(), p.Ean, p.Name, dateTime.ToString(), tbSellQuantity.Text);

                if (sellProduct == null && sellTracker == null)
                {
                    FillStockViewActive();
                    cbxActiveInactiveEmployees.SelectedIndex = 0;
                    MessageBox.Show("Sell correctly done.");

                    //if the quantity of the item is below then show the messagebox
                    if (p.QuantityS < p.MinimumStockRequired)
                    {
                        string message = $"The amount of item of {p.Name} in the store is below the minimum. Do you want to make a new order?";
                        string title = "Quantity warning";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            tcNavigator.SelectedTab = tpNewOrder;

                            //textboxes filled with data
                            tbNewOrderID.Text = $"{p.Id.ToString()}";
                            tbNewOrderEAN.Text = $"{p.Ean.ToString()}";
                            tbNewOrderName.Text = $"{p.Name}";

                            //fields disabled
                            tbNewOrderID.Enabled = false;
                            tbNewOrderEAN.Enabled = false;
                            tbNewOrderName.Enabled = false;
                        }
                    }
                    else
                    {
                        tcNavigator.SelectedTab = tpStock;
                    }
                    return;
                }
                MessageBox.Show(sellProduct.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSellProdBack_Click(object sender, EventArgs e)
        {
            tbSellQuantity.Clear();
            //back to stock page
            tcNavigator.SelectedTab = tpStock;
        }

        private void gpnlCreateSchedules_MouseEnter(object sender, EventArgs e)
        {
            lblCreateSchedules.Font = new Font("Arial", 18, FontStyle.Bold);
            pbxAddSchedules.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void gpnlCreateSchedules_MouseLeave(object sender, EventArgs e)
        {
            lblCreateSchedules.Font = new Font("Arial", 18, FontStyle.Regular);
            pbxAddSchedules.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void gpnlViewSchedules_MouseEnter(object sender, EventArgs e)
        {
            lblViewSchedules.Font = new Font("Arial", 18, FontStyle.Bold);
            pbxViewSchedules.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void gpnlViewSchedules_MouseLeave(object sender, EventArgs e)
        {
            lblViewSchedules.Font = new Font("Arial", 18, FontStyle.Regular);
            pbxViewSchedules.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnStockAdjustColumnWidth_Click(object sender, EventArgs e)
        {
            AdjustColumnWidthStock();
        }

        private void chkShowFTE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowFTE.Checked)
            {
                AdjustColumnWidthSchedulesFTE();
            }
            else
            {
                AdjustColumnWidthSchedules();
            }
        }


        private void btnInfoChangeRequest_Click_1(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpRequestChangeInfo;
        }

        private void btnHolidayRequest_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpHolidayRequests;
        }

        public void FillHolidayRequestListBox()
        {
            lbHolidayRequests.Items.Clear();

            if (HOH.GetAllHolidaysFromDB() == null)
            {
                foreach (Holiday h in HOH.GetAllHolidayRequests())
                {
                    if (h.HolidayStatus == "Request Holiday" && !lbHolidayRequests.Items.Contains(EH.GetEmployee(h.EmpBSN).ToString() + " For week:" + h.WeekNmr))
                    {
                        lbHolidayRequests.Items.Add(EH.GetEmployee(h.EmpBSN).ToString() + " For week:" + h.WeekNmr);
                    }

                }
            }
            else
            {
                MessageBox.Show(HOH.GetAllHolidaysFromDB().Message);
            }
        }

        private void lbHolidayRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHolidaySchedule.Rows.Clear();
            string selectedRequest = (string)lbHolidayRequests.SelectedItem;
            string selectedEmpName = selectedRequest.Substring(0, selectedRequest.IndexOf(" For week:"));
            Employee employeeToHandle = null;
            foreach (Employee emp in EH.GetAllEmployees())
            {
                if (emp.GetFullName() == selectedEmpName)
                {
                    employeeToHandle = emp;
                }
            }

            for (int i = 0; i < EH.GetEmployeesWIthRole(employeeToHandle.Position).Count; i++)
            {
                dgvHolidaySchedule.Rows.Add(EH.GetEmployeesWIthRole(employeeToHandle.Position)[i]);
                foreach (Holiday h in HOH.GetAllHolidayRequests())
                {
                    if (h.EmpBSN == EH.GetEmployeesWIthRole(employeeToHandle.Position)[i].Bsn && h.WeekNmr == selectedRequest.Substring(selectedRequest.IndexOf(":") + 1))
                    {
                        if (h.FreeDay == Day.MONDAY)
                            dgvHolidaySchedule.Rows[i].Cells[1].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.TUESDAY)
                            dgvHolidaySchedule.Rows[i].Cells[2].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.WEDNESDAY)
                            dgvHolidaySchedule.Rows[i].Cells[3].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.THURDAY)
                            dgvHolidaySchedule.Rows[i].Cells[4].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.FRIDAY)
                            dgvHolidaySchedule.Rows[i].Cells[5].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.SATURDAY)
                            dgvHolidaySchedule.Rows[i].Cells[6].Value = h.HolidayStatus;
                        else if (h.FreeDay == Day.SUNDAY)
                            dgvHolidaySchedule.Rows[i].Cells[7].Value = h.HolidayStatus;
                    }
                }

            }


        }

        private void btnHolidayRequestApprove_Click(object sender, EventArgs e)
        {
            string selectedRequest = (string)lbHolidayRequests.SelectedItem;
            string selectedEmpName = selectedRequest.Substring(0, selectedRequest.IndexOf(" For week:"));
            Employee employeeToHandle = null;
            foreach (Employee emp in EH.GetAllEmployees())
            {
                if (emp.GetFullName() == selectedEmpName)
                {
                    employeeToHandle = emp;
                }
            }
            var approve = HOH.ApproveHolidayRequest(selectedRequest.Substring(selectedRequest.IndexOf(":") + 1), employeeToHandle.Bsn);
            if (approve == null)
            {
                FillHolidayRequestListBox();
            }
            else
            {
                MessageBox.Show(approve.Message);
            }
        }

        private void btnHolidayRequestReject_Click(object sender, EventArgs e)
        {
            string selectedRequest = (string)lbHolidayRequests.SelectedItem;
            string selectedEmpName = selectedRequest.Substring(0, selectedRequest.IndexOf(" For week:"));
            Employee employeeToHandle = null;
            foreach (Employee emp in EH.GetAllEmployees())
            {
                if (emp.GetFullName() == selectedEmpName)
                {
                    employeeToHandle = emp;
                }
            }
            var reject = HOH.RejectHolidayRequest(selectedRequest.Substring(selectedRequest.IndexOf(":") + 1), employeeToHandle.Bsn);
            if (reject == null)
            {
                FillHolidayRequestListBox();
            }
            else
            {
                MessageBox.Show(reject.Message);
            }
        }

        public void FillChangeEmployeeListBox()
        {
            lbChangeInfo.Items.Clear();

            if (ECH.GetAllEmployeesFromDB() == null)
            {
                foreach (Employee e in ECH.GetAllChangedEmployees())
                {
                    lbChangeInfo.Items.Add(e);
                }
            }
            else
            {
                MessageBox.Show(ECH.GetAllEmployeesFromDB().Message);
            }
        }


        private void btnDeclineInfoChanges_Click(object sender, EventArgs e)
        {
            if (lbChangeInfo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee");
            }
            else
            {
                Employee E = (Employee)lbChangeInfo.SelectedItem;
                EmployeeChange empChange = ECH.GetEmployeeChange(E.Bsn);
                DeclineChangeOfInfo declineForm = new DeclineChangeOfInfo(empChange, ECH);
                tcNavigator.SelectedTab = tpEmployees;
                declineForm.Show();
            }
        }

        private void btnApproveInfoChanges_Click(object sender, EventArgs e)
        {
            Employee E = (Employee)lbChangeInfo.SelectedItem;
            EmployeeChange empChange = ECH.GetEmployeeChange(E.Bsn);

            try
            {
                var update = EH.ApproveEmployeeChange(E.Bsn, lblNewInfo_FirstName_input.Text, lblNewInfo_SecondName_input.Text, lblNewInfo_PhoneNumber_input.Text, lblNewInfo_iceNumber_input.Text, lblNewInfo_iceRelation_input.Text, lblNewInfo_Address_input.Text);

                if ((update == null) && (ECH.ApproveRequest(empChange) == null))
                {
                    FillChangeEmployeeListBox();
                    MessageBox.Show("Succesfully approved");
                }
                else
                {
                    MessageBox.Show(update.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetScheduleCreateColorsToRed()
        {
            //set all backgrounds to red
            dgvSchedulesCreate.Rows[0].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[0].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[0].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[1].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[1].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[1].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[2].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[2].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[2].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[3].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[3].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[3].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[4].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[4].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[4].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[5].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[5].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[5].Cells[6].Style.BackColor = Color.Red;

            dgvSchedulesCreate.Rows[6].Cells[4].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[6].Cells[5].Style.BackColor = Color.Red;
            dgvSchedulesCreate.Rows[6].Cells[6].Style.BackColor = Color.Red;
        }

        private void tpStatsStock_Click(object sender, EventArgs e)
        {

        }

        private void lbChangeInfo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Employee E = (Employee)lbChangeInfo.SelectedItem;

            lblOldInfo_FirstName_input.Text = E.FirstName;
            lblOldInfo_SecondName_input.Text = E.SecondName;
            lblOldInfo_PhoneNumber_input.Text = E.PhoneNumber;
            lblOldInfo_iceNumber_input.Text = E.IceNumber;
            lblOldInfo_iceRelation_input.Text = (E.IceRelationship).ToString();
            lblOldInfo_Address_input.Text = E.Adress;

            EmployeeChange empChange = ECH.GetEmployeeChange(E.Bsn);

            lblNewInfo_FirstName_input.Text = empChange.FirstName;
            lblNewInfo_SecondName_input.Text = empChange.SecondName;
            lblNewInfo_PhoneNumber_input.Text = empChange.PhoneNumber;
            lblNewInfo_iceNumber_input.Text = empChange.IceNumber;
            lblNewInfo_iceRelation_input.Text = (empChange.IceRelationship).ToString();
            lblNewInfo_Address_input.Text = empChange.Address;
        }

        public void StatsStockRandom()
        {
            Random rnd = new Random();
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            while (number1 == number2 && number2 == number3 && number1 == number3)
            {
                int counter = 0;

                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Active == 1)
                    {
                        counter++;
                    }
                }
                number1 = rnd.Next(0, counter);
                number2 = rnd.Next(0, counter);
                number3 = rnd.Next(0, counter);
            }

            cbxStats1.SelectedIndex = number1;
            cbxStats2.SelectedIndex = number2;
            cbxStats3.SelectedIndex = number3;
        }

        private void btnStatsStockRandom_Click(object sender, EventArgs e)
        {
            StatsStockRandom();
        }

        private void tbxSales_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            bool isDuplicate = false;
            bool isEnoughStock = true;


            if (tbxSales_Barcode.TextLength == 13)
            {
                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Active == 1)
                    {
                        if (p.Ean == tbxSales_Barcode.Text)
                        {
                            for (int i = 0; i < dgvSales_Reciept.Rows.Count; i++)
                            {
                                //MessageBox.Show(dgvSales_Reciept.Rows[i].Cells[1].Value.ToString() + "\n" + p.Name);
                                if ((dgvSales_Reciept.Rows[i].Cells[1].Value.ToString()).Equals(p.Name))
                                {
                                    if (Convert.ToInt32(dgvSales_Reciept.Rows[i].Cells[0].Value) > p.QuantityS)
                                    {
                                        isEnoughStock = false;
                                        MessageBox.Show("Not enough stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        dgvSales_Reciept.Rows[i].Cells[0].Value = Convert.ToInt32(dgvSales_Reciept.Rows[i].Cells[0].Value) + 1;
                                        dgvSales_Reciept.Rows[i].Cells[2].Value = $"€{String.Format("{0:0.00}", (Convert.ToDouble(dgvSales_Reciept.Rows[i].Cells[0].Value) * p.SellPrice))}";

                                        //dgvSales_Reciept.Rows[i].Selected = true;

                                        isDuplicate = true;
                                        break;
                                    }
                                }
                            }
                            if (!isDuplicate && isEnoughStock)
                            {
                                dgvSales_Reciept.Rows.Add(p);
                                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[0].Value = 1;
                                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[1].Value = p.Name;
                                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[2].Value = $"€{String.Format("{0:0.00}", p.SellPrice)}";

                                // dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Selected = true;
                            }
                            DisplaySalesShowcase(p.Name, p.Ean, p.SellPrice);
                            tbxSales_Barcode.Clear();
                            CalculateSalesTotal();
                            return;
                        }
                    }
                }
                MessageBox.Show($"The EAN {tbxSales_Barcode.Text} is invalid.");
                tbxSales_Barcode.Clear();
            }
        }


        public void FillSalesDGV()
        {
            dgvSales_Reciept.Rows.Clear();
            int index = 0;
            //for (int i = 0; i < itemsToBePurchased.Count; i++)
            //{
            //    MessageBox.Show(itemsToBePurchased[i].Name + itemsToBePurchased[i].SellPrice);
            //    dgvSales_Reciept.Rows.Add(i);
            //    dgvSales_Reciept.Rows[i].Cells[0].Value = 1;
            //    dgvSales_Reciept.Rows[i].Cells[1].Value = itemsToBePurchased[i].Name;
            //    dgvSales_Reciept.Rows[i].Cells[2].Value = itemsToBePurchased[i].SellPrice;
            //}


            //if (itemsToBePurchased.Count > 1)
            //{
            //    if (itemsToBePurchased.Count > 0)
            //    {
            //        var item = itemsToBePurchased[itemsToBePurchased.Count - 1];
            //    }
            //    foreach (Product p in itemsToBePurchased)
            //    {
            //        if(p.Ean == itemsToBePurchased[itemsToBePurchased.Count].Ean)
            //        {

            //        }
            //    }
            //}

            foreach (Product p in itemsToBePurchased)
            {
                //MessageBox.Show(p.Name + p.SellPrice);
                dgvSales_Reciept.Rows.Add(p);
                dgvSales_Reciept.Rows[index].Cells[0].Value = 1;
                dgvSales_Reciept.Rows[index].Cells[1].Value = p.Name;
                dgvSales_Reciept.Rows[index].Cells[2].Value = Convert.ToDouble(dgvSales_Reciept.Rows[index].Cells[0].Value) * p.SellPrice;
                index++;
            }

        }

        public void CalculateSalesTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvSales_Reciept.Rows.Count; i++)
            {
                String number = Convert.ToString(dgvSales_Reciept.Rows[i].Cells[2].Value).Replace("€", String.Empty);
                total += Convert.ToDecimal(number);
                //total += Convert.ToDecimal(dgvSales_Reciept.Rows[i].Cells[2].Value);
            }
            lblSales_TotalPrice.Text = $"€{String.Format("{0:0.00}", total)}";
        }

        private void dgvSales_Reciept_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvSales_Reciept.CurrentCell.RowIndex;
                MessageBox.Show(index.ToString());
                pnlSales_QuantityControl.Visible = true;
                if (dgvSales_Reciept.Rows[index].Cells[0].Value.ToString() == "1")
                {
                    btnSales_Remove1Quantity.Enabled = false;
                }
                else
                {
                    btnSales_Remove1Quantity.Enabled = true;
                }

                //if()
                //{
                //    DisplaySalesShowcase(p.Name, p.Ean, p.SellPrice);
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void cbxStatsPeriod1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockPeriodGraph();
        }

        private void cbxStatsPeriod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockPeriodGraph();
        }

        private void cbxStatsPeriod3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockPeriodGraph();
        }

        private void btnDeselectStatsPeriodStock1_Click(object sender, EventArgs e)
        {
            cbxStatsPeriod1.SelectedIndex = -1;
            cbxStatsPeriod1.Text = "Stock 1";
            UpdateStockPeriodGraph();
            btnDeselectStatsPeriodStock1.Visible = false;
        }

        private void btnDeselectStatsPeriodStock2_Click(object sender, EventArgs e)
        {
            cbxStatsPeriod2.SelectedIndex = -1;
            cbxStatsPeriod2.Text = "Stock 2";
            UpdateStockPeriodGraph();
            btnDeselectStatsPeriodStock2.Visible = false;
        }

        private void btnDeselectStatsPeriodStock3_Click(object sender, EventArgs e)
        {
            cbxStatsPeriod3.SelectedIndex = -1;
            cbxStatsPeriod3.Text = "Stock 3";
            UpdateStockPeriodGraph();
            btnDeselectStatsPeriodStock3.Visible = false;
        }

        private void dtStartTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateStockPeriodGraph();
        }

        private void dtEndTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateStockPeriodGraph();
        }

        private void tbxSales_Search_TextChanged(object sender, EventArgs e)
        {
            lbxSales_SearchBox.Items.Clear();
            string search = tbxSales_Search.Text;
            if (String.IsNullOrEmpty(tbxSales_Search.Text))
            {
                pnlSales_Search2.Visible = false;
            }
            else
            {
                pnlSales_Search2.Visible = true;

                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Active == 1)
                    {
                        if (p.Name.ToLower().Contains(search.ToLower()) || p.Ean.ToLower().Contains(search.ToLower()))
                        {
                            lbxSales_SearchBox.Items.Add($"     {p.Name} [{p.Ean}]");
                        }
                    }
                }
            }


            switch (lbxSales_SearchBox.Items.Count)
            {
                case 0:
                    lbxSales_SearchBox.Items.Add("     No items found");
                    lbxSales_SearchBox.Size = new Size(916, 30);
                    pnlSales_Search2.Size = new Size(496, 30);
                    break;
                case 1:
                    lbxSales_SearchBox.Size = new Size(916, 30);
                    pnlSales_Search2.Size = new Size(496, 30);
                    break;
                case 2:
                    lbxSales_SearchBox.Size = new Size(916, 60);
                    pnlSales_Search2.Size = new Size(496, 55);
                    break;
                case 3:
                    lbxSales_SearchBox.Size = new Size(916, 90);
                    pnlSales_Search2.Size = new Size(496, 75);
                    break;
                case 4:
                    lbxSales_SearchBox.Size = new Size(916, 120);
                    pnlSales_Search2.Size = new Size(496, 105);
                    break;
                case 5:
                    lbxSales_SearchBox.Size = new Size(916, 150);
                    pnlSales_Search2.Size = new Size(496, 115);
                    break;
                case 6:
                    lbxSales_SearchBox.Size = new Size(916, 180);
                    pnlSales_Search2.Size = new Size(496, 140);
                    break;
                case 7:
                    lbxSales_SearchBox.Size = new Size(916, 210);
                    pnlSales_Search2.Size = new Size(496, 160);
                    break;
                case 8:
                    lbxSales_SearchBox.Size = new Size(916, 240);
                    pnlSales_Search2.Size = new Size(496, 180);
                    break;
                case 9:
                    lbxSales_SearchBox.Size = new Size(916, 270);
                    pnlSales_Search2.Size = new Size(496, 200);
                    break;
                case 10:
                    lbxSales_SearchBox.Size = new Size(916, 300);
                    pnlSales_Search2.Size = new Size(496, 225);
                    break;
                    if (lbxSales_SearchBox.Items.Count > 10)
                    {
                        lbxSales_SearchBox.ScrollAlwaysVisible = true;
                    }
                    else
                    {
                        lbxSales_SearchBox.ScrollAlwaysVisible = false;
                    }
            }
        }

        private void tpSales_Click(object sender, EventArgs e)
        {
            pnlSales_Search2.Visible = false;
            tbxSales_Defocus.Focus();
            pnlSales_QuantityControl.Visible = false;
            dgvSales_Reciept.ClearSelection();
            ResetSalesShowcase();
        }

        private void lbxSales_SearchBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbxSales_SearchBox_Click(object sender, EventArgs e)
        {
            string selectedItem = lbxSales_SearchBox.SelectedItem.ToString();
            string ean = selectedItem.Split('[', ']')[1];
            Product p = SH.GetProductByEAN(ean);
            pnlSales_Search2.Visible = false;

            dgvSales_ManualInfo.RowCount = 5;
            dgvSales_ManualInfo.Rows[0].Cells[0].Value = "EAN";
            dgvSales_ManualInfo.Rows[0].Cells[1].Value = p.Ean;
            dgvSales_ManualInfo.Rows[1].Cells[0].Value = "Name";
            dgvSales_ManualInfo.Rows[1].Cells[1].Value = p.Name;
            dgvSales_ManualInfo.Rows[2].Cells[0].Value = "Price";
            dgvSales_ManualInfo.Rows[2].Cells[1].Value = $"€{String.Format("{0:0.00}", p.SellPrice)}";
            dgvSales_ManualInfo.Rows[3].Cells[0].Value = "Stock";
            dgvSales_ManualInfo.Rows[3].Cells[1].Value = p.QuantityS;
            dgvSales_ManualInfo.Rows[4].Cells[0].Value = "Info";

            if (String.IsNullOrEmpty(p.AddInformation))
            {
                dgvSales_ManualInfo.Rows[4].Cells[1].Value = "No additional information";
            }
            else
            {
                dgvSales_ManualInfo.Rows[4].Cells[1].Value = p.AddInformation;
            }

            tbxSales_ManualQuantity.Text = "1";
            tbxSales_ManualQuantity.Enabled = true;
            btnSales_ManualQuantityUp.Enabled = true;
            btnSales_ManualQuantityDown.Enabled = false;
            btnSales_ManualAddToList.Enabled = true;
            btnSales_ManualCancel.Visible = true;
        }

        private void tbxSales_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSales_Search.Text))
            {
                pnlSales_Search2.Visible = false;
            }
            else
            {
                pnlSales_Search2.Visible = true;
            }
        }

        private void btnSales_ManualCancel_Click(object sender, EventArgs e)
        {
            tbxSales_ManualQuantity.Enabled = false;
            btnSales_ManualQuantityUp.Enabled = false;
            btnSales_ManualQuantityDown.Enabled = false;
            btnSales_ManualAddToList.Enabled = false;
            tbxSales_ManualQuantity.Text = "";
            btnSales_ManualCancel.Visible = false;
            dgvSales_ManualInfo.Rows.Clear();
            tbxSales_Search.Clear();
        }

        private void tbxSales_ManualQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnSales_ManualQuantityUp_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tbxSales_ManualQuantity.Text);
            quantity++;
            tbxSales_ManualQuantity.Text = quantity.ToString();
        }

        private void btnSales_ManualQuantityDown_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tbxSales_ManualQuantity.Text);
            quantity--;
            tbxSales_ManualQuantity.Text = quantity.ToString();
        }

        private void tbxSales_ManualQuantity_TextChanged(object sender, EventArgs e)
        {
            if (btnSales_ManualAddToList.Enabled)
            {
                if (tbxSales_ManualQuantity.Text == "1")
                {
                    btnSales_ManualQuantityDown.Enabled = false;
                }
                else
                {
                    btnSales_ManualQuantityDown.Enabled = true;
                }

                if (Convert.ToInt32(tbxSales_ManualQuantity.Text) >= Convert.ToInt32(dgvSales_ManualInfo.Rows[3].Cells[1].Value))
                {
                    btnSales_ManualQuantityUp.Enabled = false;
                    tbxSales_ManualQuantity.Text = dgvSales_ManualInfo.Rows[3].Cells[1].Value.ToString();
                }
                else
                {
                    btnSales_ManualQuantityUp.Enabled = true;
                }
            }

        }

        private void dgvSales_ManualInfo_SelectionChanged(object sender, EventArgs e)
        {
            dgvSales_ManualInfo.ClearSelection();
        }

        private void btnSales_ManualAddToList_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;
            bool isEnoughStock = true;
            Product p = SH.GetProductByEAN(dgvSales_ManualInfo.Rows[0].Cells[1].Value.ToString());

            for (int i = 0; i < dgvSales_Reciept.Rows.Count; i++)
            {
                //MessageBox.Show(dgvSales_Reciept.Rows[i].Cells[1].Value.ToString() + "\n" + p.Name);
                if ((dgvSales_Reciept.Rows[i].Cells[1].Value.ToString()).Equals(p.Name))
                {
                    if (Convert.ToInt32(dgvSales_Reciept.Rows[i].Cells[0].Value) > p.QuantityS)
                    {
                        isEnoughStock = false;
                        MessageBox.Show("Not enough stock", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int quantityCurrent = Convert.ToInt32(dgvSales_Reciept.Rows[i].Cells[0].Value);
                        int quantityNew = Convert.ToInt32(tbxSales_ManualQuantity.Text);
                        dgvSales_Reciept.Rows[i].Cells[0].Value = quantityCurrent + quantityNew;
                        dgvSales_Reciept.Rows[i].Cells[2].Value = $"€{String.Format("{0:0.00}", (Convert.ToDouble(dgvSales_Reciept.Rows[i].Cells[0].Value) * p.SellPrice))}";

                        //dgvSales_Reciept.Rows[i].Selected = true;

                        isDuplicate = true;
                        break;
                    }
                }
            }
            if (!isDuplicate && isEnoughStock)
            {
                dgvSales_Reciept.Rows.Add(p);
                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[0].Value = tbxSales_ManualQuantity.Text;
                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[1].Value = p.Name;
                dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Cells[2].Value = $"€{String.Format("{0:0.00}", (p.SellPrice * Convert.ToDouble(tbxSales_ManualQuantity.Text)))}";

                // dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Selected = true;
            }
            DisplaySalesShowcase(p.Name, p.Ean, p.SellPrice);
            tbxSales_Barcode.Clear();
            CalculateSalesTotal();
            dgvSales_Reciept.ClearSelection();
            dgvSales_Reciept.Rows[dgvSales_Reciept.Rows.Count - 1].Selected = true;

            return;
        }

        public void DisplaySalesShowcase(string name, string ean, double price)
        {
            lblSales_ItemShowcaseName.Text = name;
            lblSales_ItemShowcaseEAN.Text = ean;

            String quantity = "";
            for (int i = 0; i < dgvSales_Reciept.Rows.Count; i++)
            {
                if ((dgvSales_Reciept.Rows[i].Cells[1].Value.ToString()).Equals(name))
                {
                    quantity = dgvSales_Reciept.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
            lblSales_ItemShowcaseQuantityPrice.Text = $"{quantity}x  €{ String.Format("{0:0.00}", price)} each";
        }

        public void ResetSalesShowcase()
        {
            lblSales_ItemShowcaseName.Text = "";
            lblSales_ItemShowcaseEAN.Text = "";
            lblSales_ItemShowcaseQuantityPrice.Text = "";
        }

        private void btnSales_Remove1Quantity_Click(object sender, EventArgs e)
        {
            int index = dgvSales_Reciept.CurrentCell.RowIndex;
            Product p = SH.GetProductByName(dgvSales_Reciept.Rows[index].Cells[1].Value.ToString());
            dgvSales_Reciept.Rows[index].Cells[0].Value = Convert.ToInt32(dgvSales_Reciept.Rows[index].Cells[0].Value) - 1;
            dgvSales_Reciept.Rows[index].Cells[2].Value = $"€{String.Format("{0:0.00}", (Convert.ToDouble(dgvSales_Reciept.Rows[index].Cells[0].Value) * p.SellPrice))}";

            if (Convert.ToInt32(dgvSales_Reciept.Rows[index].Cells[0].Value) <= 1)
            {
                btnSales_Remove1Quantity.Enabled = false;
            }
            else
            {
                btnSales_Remove1Quantity.Enabled = true;
            }
            DisplaySalesShowcase(p.Name, p.Ean, p.SellPrice);
            CalculateSalesTotal();
        }

        private void cbxStatsProfit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockProfitGraph();
        }

        private void cbxStatsProfit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockProfitGraph();
        }

        private void cbxStatsProfit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockProfitGraph();
        }

        private void btnDeselectStatsProfitStock1_Click(object sender, EventArgs e)
        {
            cbxStatsProfit1.SelectedIndex = -1;
            cbxStatsProfit1.Text = "Stock 1";
            UpdateStockProfitGraph();
            btnDeselectStatsProfitStock1.Visible = false;
        }

        private void btnDeselectStatsProfitStock2_Click(object sender, EventArgs e)
        {
            cbxStatsProfit2.SelectedIndex = -1;
            cbxStatsProfit2.Text = "Stock 2";
            UpdateStockProfitGraph();
            btnDeselectStatsProfitStock2.Visible = false;
        }

        private void btnDeselectStatsProfitStock3_Click(object sender, EventArgs e)
        {
            cbxStatsProfit3.SelectedIndex = -1;
            cbxStatsProfit3.Text = "Stock 3";
            UpdateStockProfitGraph();
            btnDeselectStatsProfitStock3.Visible = false;
        }

        public void UpdateStockProfitGraph()
        {
            if (cbxStatsProfit1.Text == "Stock 1" && cbxStatsProfit2.Text == "Stock 2" && cbxStatsProfit3.Text == "Stock 3")
                lbStatsProfit.Visible = true;
            else
                lbStatsProfit.Visible = false;

            foreach (var series in chartStockProfit.Series)
            {
                series.Points.Clear();
            }
            foreach (SellingTracker s in STH.GetAllSellings())
            {
                if (cbxStatsProfit1.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsProfit1.SelectedItem.ToString()))
                    {
                        double profit = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeProfit.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeProfit.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                profit = profit + (sell.QuantitySold * (p.SellPrice - p.CostPrice));
                            }
                        }

                        this.chartStockProfit.Series["Profit in the period"].Points.AddXY(s.Name, profit.ToString());
                        this.chartStockProfit.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsProfitStock1.Visible = true;
                    }
                }

                if (cbxStatsProfit2.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsProfit2.SelectedItem.ToString()))
                    {
                        double profit = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeProfit.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeProfit.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                profit = profit + (sell.QuantitySold * (p.SellPrice - p.CostPrice));
                            }
                        }

                        this.chartStockProfit.Series["Profit in the period"].Points.AddXY(s.Name, profit.ToString());
                        this.chartStockProfit.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsProfitStock2.Visible = true;
                    }
                }

                if (cbxStatsProfit3.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsProfit3.SelectedItem.ToString()))
                    {
                        double profit = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeProfit.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeProfit.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                profit = profit + (sell.QuantitySold * (p.SellPrice - p.CostPrice));
                            }
                        }

                        this.chartStockProfit.Series["Profit in the period"].Points.AddXY(s.Name, profit.ToString());
                        this.chartStockProfit.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsProfitStock3.Visible = true;
                    }
                }
            }
        }

        private void dtStartTimeProfit_ValueChanged(object sender, EventArgs e)
        {
            UpdateStockProfitGraph();
        }

        private void dtEndTimeProfit_ValueChanged(object sender, EventArgs e)
        {
            UpdateStockProfitGraph();
        }


        public void UpdateStockRevenueGraph()
        {
            if (cbxStatsRevenue1.Text == "Stock 1" && cbxStatsRevenue2.Text == "Stock 2" && cbxStatsRevenue3.Text == "Stock 3")
                lbStatsRevenue.Visible = true;
            else
                lbStatsRevenue.Visible = false;

            foreach (var series in chartStockRevenue.Series)
            {
                series.Points.Clear();
            }
            foreach (SellingTracker s in STH.GetAllSellings())
            {
                if (cbxStatsRevenue1.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsRevenue1.SelectedItem.ToString()))
                    {
                        double revenue = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeRevenue.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeRevenue.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                revenue = revenue + (sell.QuantitySold * p.SellPrice);
                            }
                        }

                        this.chartStockRevenue.Series["Revenue in the period"].Points.AddXY(s.Name, revenue.ToString());
                        this.chartStockRevenue.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsRevenueStock1.Visible = true;
                    }
                }

                if (cbxStatsProfit2.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsRevenue2.SelectedItem.ToString()))
                    {
                        double revenue = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeProfit.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeProfit.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                revenue = revenue + (sell.QuantitySold * p.SellPrice);
                            }
                        }

                        this.chartStockRevenue.Series["Revenue in the period"].Points.AddXY(s.Name, revenue.ToString());
                        this.chartStockRevenue.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsRevenueStock2.Visible = true;
                    }
                }

                if (cbxStatsProfit3.SelectedIndex > -1)
                {
                    if (s.Name.Contains(cbxStatsProfit3.SelectedItem.ToString()))
                    {
                        double revenue = 0;

                        foreach (SellingTracker sell in STH.GetSellings(s.Name))
                        {
                            if ((DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtStartTimeProfit.Value.Date) >= 0) && (DateTime.Compare(Convert.ToDateTime(sell.DateAndTime), dtEndTimeProfit.Value.Date) <= 0))
                            {
                                Product p = null;
                                p = SH.GetProduct(s.Id);

                                revenue = revenue + (sell.QuantitySold * p.SellPrice);
                            }
                        }

                        this.chartStockRevenue.Series["Revenue in the period"].Points.AddXY(s.Name, revenue.ToString());
                        this.chartStockRevenue.Series["Current stock in store"].Points.AddXY(s.Name, SH.GetProductByName(s.Name).QuantityS);
                        btnDeselectStatsRevenueStock3.Visible = true;
                    }
                }
            }
        }

        private void cbxStatsRevenue1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockRevenueGraph();
        }

        private void cbxStatsRevenue2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockRevenueGraph();
        }

        private void cbxStatsRevenue3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockRevenueGraph();
        }

        private void btnDeselectStatsRevenueStock1_Click_1(object sender, EventArgs e)
        {
            cbxStatsRevenue1.SelectedIndex = -1;
            cbxStatsRevenue1.Text = "Stock 1";
            UpdateStockRevenueGraph();
            btnDeselectStatsRevenueStock1.Visible = false;
        }

        private void btnDeselectStatsRevenueStock2_Click_1(object sender, EventArgs e)
        {
            cbxStatsRevenue2.SelectedIndex = -1;
            cbxStatsRevenue2.Text = "Stock 2";
            UpdateStockRevenueGraph();
            btnDeselectStatsRevenueStock2.Visible = false;
        }

        private void btnDeselectStatsRevenueStock3_Click_1(object sender, EventArgs e)
        {
            cbxStatsRevenue3.SelectedIndex = -1;
            cbxStatsRevenue3.Text = "Stock 3";
            UpdateStockRevenueGraph();
            btnDeselectStatsRevenueStock3.Visible = false;
        }

        private void dtStartTimeRevenue_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateStockRevenueGraph();
        }

        private void dtEndTimeRevenue_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateStockRevenueGraph();
        }

        private void btnToSellingStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsPeriod;
        }

        private void btnToProfitStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsProfit;
        }

        private void btnToRevenueStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsRevenue;
        }

        private void btnToStockStats1_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsStock;
        }

        private void btnToProfitStats1_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsProfit;
        }

        private void btnToRevenueStats1_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsRevenue;
        }

        private void btnToStockStats2_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsStock;
        }

        private void btnToSellingStats2_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsPeriod;
        }

        private void btnToRevenueStats2_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsRevenue;
        }

        private void btnToStockStats3_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsStock;
        }

        private void btnToSellingStats3_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsPeriod;
        }

        private void btnToProfitStats3_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsProfit;
        }

        private void btnSales_RemoveAllQuantity_Click(object sender, EventArgs e)
        {
            int index = dgvSales_Reciept.CurrentCell.RowIndex;
            Product p = SH.GetProductByName(dgvSales_Reciept.Rows[index].Cells[1].Value.ToString());
            //dgvSales_Reciept.Rows[index].Cells[0].Value = Convert.ToInt32(dgvSales_Reciept.Rows[index].Cells[0].Value) - 1;
            //dgvSales_Reciept.Rows[index].Cells[2].Value = $"€{String.Format("{0:0.00}", (Convert.ToDouble(dgvSales_Reciept.Rows[index].Cells[0].Value) * p.SellPrice))}";

            //if (dgvSales_Reciept.Rows[index].Cells[0].Value.ToString() == "1")
            //{
            //    btnSales_Remove1Quantity.Enabled = false;
            //}
            //else
            //{
            //    btnSales_Remove1Quantity.Enabled = true;
            //}
            dgvSales_Reciept.ClearSelection();
            dgvSales_Reciept.Rows.RemoveAt(index);

            //DisplaySalesShowcase(p.Name, p.Ean, p.SellPrice);
            CalculateSalesTotal();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tbxSales_Barcode.Focused)
            {
                lblBarcodeActiveIcon2.Font = new Font("Arial", 18, FontStyle.Regular);
                lblBarcodeActiveIcon.Font = new Font("Arial", 20, FontStyle.Bold);
                gpnlSales_BarcodeIndicator2.Visible = false;
                gpnlSales_BarcodeIndicator.Visible = true;
            }
            else
            {
                lblBarcodeActiveIcon2.Font = new Font("Arial", 20, FontStyle.Bold);
                lblBarcodeActiveIcon.Font = new Font("Arial", 18, FontStyle.Regular);
                gpnlSales_BarcodeIndicator2.Visible = true;
                gpnlSales_BarcodeIndicator.Visible = false;
            }
        }

        private void lblBarcodeActiveIcon_Click_1(object sender, EventArgs e)
        {
            tbxSales_Barcode.Focus();
        }

        private void lblBarcodeActiveIcon2_Click(object sender, EventArgs e)
        {
            tbxSales_Barcode.Focus();
        }

        private void btnSales_MakeSale_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvSales_Reciept.Rows.Count; i++)
                {
                    Product p = SH.GetProductByName(dgvSales_Reciept.Rows[i].Cells[1].Value.ToString());
                    int quantity = Convert.ToInt32(dgvSales_Reciept.Rows[i].Cells[0].Value);


                    //calculations of quantity and exception returned if it occurs
                    var sellProduct = SH.SellProduct(p, quantity.ToString());
                    DateTime dateTime = DateTime.Now;
                    var sellTracker = STH.AddSelling(p.Id.ToString(), p.Ean, p.Name, dateTime.ToString(), quantity.ToString());

                    if (sellProduct == null && sellTracker == null)
                    {
                        FillStockViewActive();
                        cbxActiveInactiveEmployees.SelectedIndex = 0;

                        //if the quantity of the item is below then show the messagebox
                        if (p.QuantityS < p.MinimumStockRequired)
                        {
                            string message = $"The amount of item of {p.Name} in the store is below the minimum. Do you want to make a new order?";
                            string title = "Quantity warning";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                tcNavigator.SelectedTab = tpNewOrder;

                                //textboxes filled with data
                                //tbNewOrderID.Text = $"{p.Id.ToString()}";
                                //tbNewOrderEAN.Text = $"{p.Ean.ToString()}";
                                //tbNewOrderName.Text = $"{p.Name}";

                                //fields disabled
                                //tbNewOrderID.Enabled = false;
                                //tbNewOrderEAN.Enabled = false;
                                //tbNewOrderName.Enabled = false;
                            }
                        }
                        else
                        {
                            // tcNavigator.SelectedTab = tpStock;
                        }
                    }
                }
                MessageBox.Show("Sell correctly done.");
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToContractStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsEmpContract;
        }

        private void btnToPersStats_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatsEmployee;
        }

        public void UpdateEmployeeChartNationalities()
        {
            var nationalities = new Dictionary<string, int>();

            foreach (var series in chartNationalities.Series)
            {
                series.Points.Clear();
            }
            foreach (Employee e in EH.GetAllEmployees())
            {
                if (nationalities.ContainsKey(e.Nationality))
                    nationalities[e.Nationality]++;
                else
                    nationalities.Add(e.Nationality, 1);
            }

            foreach (KeyValuePair<string, int> nat in nationalities)
            {
                this.chartNationalities.Series["Nationality"].Points.AddXY(nat.Key, nat.Value);
            }
        }


    }
}
