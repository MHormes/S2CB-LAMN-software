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

namespace LAMN_Software
{
    public partial class ProductForm : Form
    {
        // used for visual distinction
        bool stockClicked = true;
        bool scheduleClicked = false;
        bool employeesClicked = false;
        bool statisticsClicked = false;

        StockHandler SH;
        EmployeeHandler EH;
        ScheduleHandler SCH;
        LoginHandler LH;
        public ProductForm(JobPosition position)
        {
            InitializeComponent();
            SH = new StockHandler();
            EH = new EmployeeHandler();
            SCH = new ScheduleHandler();
            LH = new LoginHandler();
            FillStockListBox();
            FillEmployeeListBox();
            FillScheduleGridView();
            btnStock.Font = new Font("Arial", 18, FontStyle.Bold);
            //Method to enable buttons based on indicator

            updateTabWithPosition(position);
        }

        private void updateTabWithPosition(JobPosition position)
        {
            if (position.ToString() == "HR")
            {
                tcNavigator.TabPages.Remove(tpStock);
                tcNavigator.TabPages.Remove(tpStockAdd);
                tcNavigator.TabPages.Remove(tpStatistics);
                btnStatistics.Enabled = false;
                btnStock.Enabled = false;
            }
            else if (position.ToString() == "DEPOT")
            {
                tcNavigator.TabPages.Remove(tpEmployees);
                tcNavigator.TabPages.Remove(tpEmployeeAdd);
                tcNavigator.TabPages.Remove(tpStatistics);
                btnEmployees.Enabled = false;
            }
        }

        //STOCK MANAGEMENT

        //Navigation Stock button click
        private void btnStock_Click(object sender, EventArgs e)
        {
            // Changes tab
            tcNavigator.SelectedTab = tpStock;

            btnStock.Font = new Font("Arial", 18, FontStyle.Bold);
            btnSchedules.Font = new Font("Arial", 18, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 18, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Regular);

            btnStock.ForeColor = Color.White;
            btnSchedules.ForeColor = Color.LightGray;
            btnEmployees.ForeColor = Color.LightGray;
            btnStatistics.ForeColor = Color.LightGray;
        }

        //Back to stock button in edit/add page
        private void btnBackToStockPage_click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStock;
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
            try
            {
                //method to call for adding
                var add = SH.AddProduct(tbxStockAdd_ProductName.Text, Convert.ToInt32(tbxStockAdd_StoreQuantity.Text), Convert.ToInt32(tbxStockAdd_WarehouseQuantity.Text), tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, Convert.ToDouble(tbxStockAdd_Cost.Text), Convert.ToDouble(tbxStockAdd_Sell.Text), Convert.ToInt32(tbxStockAdd_MinimumStock.Text), tbxStockAdd_AddInfo.Text);

                if (add == null)
                {
                    FillStockListBox();
                    MessageBox.Show("Item added succesfully");
                    return;
                }
                MessageBox.Show(add.Message);
            }
            //IMPLEMENT SPECIFIC EXCEPTION HANDLING FOR TEXTFIELDS!!!!!
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //onClick for edit stock button. Will take selected.
        private void btnEditStock_Click(object sender, EventArgs e)
        {
            //save object
            if (lbxAllStock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product to edit");
                return;
            }
            Product p = (Product)lbxAllStock.SelectedItem;
            //Go to page and disable correct button
            tcNavigator.SelectedTab = tpStockAdd;
            btnStockAdd_ConfirmAdd.Visible = false;
            btnStockAdd_ConfirmEdit.Visible = true;
            //fill in all fields/disable
            tbxStockAdd_ID.Text = $"{p.Id}";
            tbxStockAdd_ID.Enabled = false;
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
            try
            {
                //method to call for changing
                var update = SH.ChangeProduct(Convert.ToInt32(tbxStockAdd_ID.Text), tbxStockAdd_ProductName.Text, Convert.ToInt32(tbxStockAdd_StoreQuantity.Text), Convert.ToInt32(tbxStockAdd_WarehouseQuantity.Text), tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, Convert.ToInt32(tbxStockAdd_MinimumStock.Text), tbxStockAdd_AddInfo.Text);

                if (update == null)
                {
                    FillStockListBox();
                    MessageBox.Show("Item edited succesfully");
                    return;
                }
                MessageBox.Show(update.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //onclick for delete button. Opens new tab for quitting reason
        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (lbxAllStock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }
            Product p = (Product)lbxAllStock.SelectedItem;
            //method to call for deleting
            var delete = SH.DeleteProduct(p);
            if (delete == null)
            {
                FillStockListBox();
                MessageBox.Show("Product sucessfully deleted");
                return;
            }
            MessageBox.Show(delete.Message);

        }

        //onClick for search button. Shows all matching products
        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            lbxAllStock.Items.Clear();
            string searchName = tbxSearchStock.Text.ToLower();
           
                foreach (Product p in SH.GetAllProducts())
                {
                    if (p.Name.ToLower().Contains(searchName))
                    {
                        lbxAllStock.Items.Add(p);
                    }
                }
            
            
        }

        //method for updateing/filling listbox for stock items
        public void FillStockListBox()
        {
            lbxAllStock.Items.Clear();

            cbxStats1.Items.Clear();
            cbxStats2.Items.Clear();
            cbxStats3.Items.Clear();

            if (SH.GetAllStockFromDB() == null)
            {
                foreach (Product p in SH.GetAllProducts())
                {
                    lbxAllStock.Items.Add(p);
                    UpdateStatsComboboxes(p.Name);
                    //CreateListboxGraph();
                }
            }
            else
            {
                MessageBox.Show(SH.GetAllStockFromDB().Message);
            }

        }


        //EMPLOYEE MANAGEMENT

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployees;
            btnStock.Font = new Font("Arial", 18, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 18, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 18, FontStyle.Bold);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Regular);

            btnStock.ForeColor = Color.LightGray;
            btnSchedules.ForeColor = Color.LightGray;
            btnEmployees.ForeColor = Color.White;
            btnStatistics.ForeColor = Color.LightGray;
        }

        public void FillEmployeeListBox()
        {
            lbxAllEmployees.Items.Clear();
            if (EH.GetAllEmployeesFromDB() == null)
            {
                foreach (Employee employee in EH.GetAllEmployees())
                {
                    lbxAllEmployees.Items.Add(employee);
                }
            }
            else
            {
                MessageBox.Show(EH.GetAllEmployeesFromDB().Message);
            }

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }
            List<Employee> employees = EH.GetAllEmployees();
            //IMPLEMENT SCREEN FOR QUITTING REASON!!!
            Employee employee = (Employee)lbxAllEmployees.SelectedItem;
            //method to call for deleting
            var delete = EH.DeleteProduct(employee);
            if (delete == null)
            {
                FillEmployeeListBox();
                MessageBox.Show("Employee sucessfully deleted");
                return;
            }
            MessageBox.Show(delete.Message);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            lbxAllEmployees.Items.Clear();
            string searchName = tbxSearchEmployee.Text.ToLower();
            foreach (Employee employee in EH.GetAllEmployees())
            {
                if (employee.GetFullName().ToLower().Contains(searchName))
                {
                    lbxAllEmployees.Items.Add(employee);
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
            cbxEmployeeAdd_ICERelationship.SelectedIndex = -1;
            cbxEmployeeAdd_Position.SelectedIndex = -1;

            //buttons
            btnEmployeeAdd_Confirm.Visible = true;
            btnEmployeeAdd_ConfirmEdit.Visible = false;

            cbxEmployeeAdd_ICERelationship.DataSource = Enum.GetNames(typeof(ICERelation));
            cbxEmployeeAdd_Position.DataSource = Enum.GetNames(typeof(JobPosition));
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to edit");
                return;
            }
            Employee emp = (Employee)lbxAllEmployees.SelectedItem;

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
            cbxEmployeeAdd_ICERelationship.SelectedIndex = -1;
            cbxEmployeeAdd_Position.SelectedIndex = -1;

            //populating combobox with enums
            cbxEmployeeAdd_ICERelationship.DataSource = Enum.GetNames(typeof(ICERelation));
            cbxEmployeeAdd_Position.DataSource = Enum.GetNames(typeof(JobPosition));
        }

        
        private void btnEmployeeAdd_Confirm_Click(object sender, EventArgs e)
        {
            
            try
            {
                string username = tbxEmployeeAdd_FirstName.Text.Substring(0, 3).ToLower() + tbxEmployeeAdd_SecondName.Text.Substring(0, 3).ToLower();
                string email = tbxEmployeeAdd_FirstName.Text.ToLower() + tbxEmployeeAdd_SecondName.Text.ToLower() + "@mediabazaar.nl";
                string password = tbxEmployeeAdd_FirstName.Text + tbxEmployeeAdd_BSN.Text.Substring(0, 1) + tbxEmployeeAdd_BSN.Text.Substring(tbxEmployeeAdd_BSN.Text.Length - 1, 1);

                var add = EH.AddEmployee(tbxEmployeeAdd_FirstName.Text, tbxEmployeeAdd_SecondName.Text, username, tbxEmployeeAdd_BSN.Text.ToString(), dtpEmployeeAdd_DateOfBirth.Value.Date, email, tbxEmployeeAdd_PhoneNumber.Text, tbxEmployeeAdd_ICENumber.Text, cbxEmployeeAdd_ICERelationship.SelectedItem.ToString(), cbxEmployeeAdd_Position.SelectedItem.ToString(), tbxEmployeeAdd_AdditonalInfo.Text);

                if (add == null)
                {
                    add = LH.AddLoginDetails(username, password);
                    FillEmployeeListBox();
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
            FillEmployeeListBox();
        }

        private void btnEmployeeAdd_ConfirmEdit_Click(object sender, EventArgs e)
        {

            try
            {
                var update = EH.ChangeEmployee(tbxEmployeeAdd_FirstName.Text, tbxEmployeeAdd_SecondName.Text, tbxEmployeeAdd_BSN.Text, dtpEmployeeAdd_DateOfBirth.Value.Date, tbxEmployeeAdd_PhoneNumber.Text, tbxEmployeeAdd_ICENumber.Text, cbxEmployeeAdd_ICERelationship.SelectedItem.ToString(), cbxEmployeeAdd_Position.SelectedItem.ToString(), tbxEmployeeAdd_AdditonalInfo.Text);

                if (update == null)
                {
                    FillEmployeeListBox();
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

        //METHOD FOR FILLING THE SCHEDULES
        public void FillScheduleGridView()
        {
            dgvSchedules.Rows.Clear();
            if (EH.GetAllEmployeesFromDB() == null)
            {
                foreach (Employee employee in EH.GetAllEmployees())
                {
                    dgvSchedules.Rows.Add(employee);
                }
            }
            else
            {
                MessageBox.Show(EH.GetAllEmployeesFromDB().Message);
            }

            //Assign correct enum value to comboboxes
            schedulesMonday.ValueType = typeof(TimeSlot);
            schedulesMonday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesTuesday.ValueType = typeof(TimeSlot);
            schedulesTuesday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesWednesday.ValueType = typeof(TimeSlot);
            schedulesWednesday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesThursday.ValueType = typeof(TimeSlot);
            schedulesThursday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesFriday.ValueType = typeof(TimeSlot);
            schedulesFriday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesSaturday.ValueType = typeof(TimeSlot);
            schedulesSaturday.DataSource = Enum.GetValues(typeof(TimeSlot));
            schedulesSunday.ValueType = typeof(TimeSlot);
            schedulesSunday.DataSource = Enum.GetValues(typeof(TimeSlot));
        }

        //Navigation button to schedule page
        private void btnSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedules;
            btnStock.Font = new Font("Arial", 18, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 18, FontStyle.Bold);
            btnEmployees.Font = new Font("Arial", 18, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Regular);

            btnStock.ForeColor = Color.LightGray;
            btnSchedules.ForeColor = Color.White;
            btnEmployees.ForeColor = Color.LightGray;
            btnStatistics.ForeColor = Color.LightGray;
        }

        //BUTTON TO LOAD SCHEDULE FOR CHOSEN WEEK
        private void btnSchedulesShowWeek_Click(object sender, EventArgs e)
        {
            FillScheduleGridView();
            int weekNmr = Convert.ToInt32(Math.Round(nudScheduleWeek.Value));
            if (SCH.GetAllSchedulesFromDB(weekNmr) == null)
            {
                lblScheduleCurrentWeek.Text = $"Currently showing week: {weekNmr}";
                foreach (Schedule schedule in SCH.GetAllSchedules())
                {
                    //check for each schedule object if any of the employeeBsn's are the same. 
                    for(int i = 0; i < EH.GetAllEmployees().Count(); i++)
                    {
                        //create temp emp object based on the state of the for loop
                        Employee emp = (Employee)dgvSchedules.Rows[i].Cells[0].Value;
                        if (emp.Bsn == schedule.EmployeeBSN)
                        {
                            if (schedule.Day == Day.MONDAY)
                                dgvSchedules.Rows[i].Cells[1].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.TUESDAY)
                                dgvSchedules.Rows[i].Cells[2].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.WEDNESDAY)
                                dgvSchedules.Rows[i].Cells[3].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.THURDAY)
                                dgvSchedules.Rows[i].Cells[4].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.FRIDAY)
                                dgvSchedules.Rows[i].Cells[5].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.SATURDAY)
                                dgvSchedules.Rows[i].Cells[6].Value = schedule.TimeSlot;
                            else if (schedule.Day == Day.SUNDAY)
                                dgvSchedules.Rows[i].Cells[7].Value = schedule.TimeSlot;
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show(SCH.GetAllSchedulesFromDB(weekNmr).Message);
            }
        }

        private void btnScheduleSaveCurrentWeek_Click(object sender, EventArgs e)
        {
            //foreach edited combox push to the DB.
            //Possible to delete the week from the DB, and Add it again. This way there is no need to only push updated.
            //Easier syntax but the semantics could be optimalized.


            SCH.DeleteWeekSchedule(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)));
            
            try
            {
                for (int rows = 0; rows < dgvSchedules.Rows.Count; rows++)
                {
                    for (int col = 1; col < dgvSchedules.Rows[rows].Cells.Count; col++)
                    {
                        Employee emp = (Employee)dgvSchedules.Rows[rows].Cells[0].Value;

                        string slot = null;
                        if(dgvSchedules.Rows[rows].Cells[col].Value != null)
                        {
                            slot = dgvSchedules.Rows[rows].Cells[col].Value.ToString();
                        }

                        if (col == 1 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.MONDAY, emp.Bsn, slot);
                        }
                        if (col == 2 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.TUESDAY, emp.Bsn, slot);
                        }
                        if (col == 3 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.WEDNESDAY, emp.Bsn, slot);
                        }
                        if (col == 4 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.THURDAY, emp.Bsn, slot);
                        }
                        if (col == 5 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.FRIDAY, emp.Bsn, slot);
                        }
                        if (col == 6 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.SATURDAY, emp.Bsn, slot);
                        }
                        else if (col == 7 && !string.IsNullOrEmpty(slot))
                        {
                            SCH.SaveCurrentWeek(Convert.ToInt32(Math.Round(nudScheduleWeek.Value)), Day.SUNDAY, emp.Bsn, slot);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //STATISTICS
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatistics;
            btnStock.Font = new Font("Arial", 18, FontStyle.Regular);
            btnSchedules.Font = new Font("Arial", 18, FontStyle.Regular);
            btnEmployees.Font = new Font("Arial", 18, FontStyle.Regular);
            btnStatistics.Font = new Font("Arial", 18, FontStyle.Bold);

            btnStock.ForeColor = Color.LightGray;
            btnSchedules.ForeColor = Color.LightGray;
            btnEmployees.ForeColor = Color.LightGray;
            btnStatistics.ForeColor = Color.White;
        }


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
                                                           Color.FromArgb(84, 50, 168),
                                                           Color.FromArgb(58, 34, 117),
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
        }

        /*public void CreateListboxGraph()
        {
            //string prod1 = "";
            //lbxGraph.Items.Clear();
            //lbxGraph.Items.Add("");
            //lbxGraph.Items.Add("");
            //foreach (Product p in SH.GetAllProducts())
            //{
            //    if(cbxStats1.SelectedValue == null) // placeholder
            //    {
            //        MessageBox.Show("S");
            //        lbxGraph.Items.Add(cbxStats1.SelectedItem.ToString());
            //        int storeAmount = p.QuantityS / 2;
            //        int warehouseAmount = p.QuantityWH / 2;
            //        for (int i = 0; i < warehouseAmount; i++)
            //        {
            //            prod1 += "▓";
            //        }
            //        for (int i = 0; i < storeAmount; i++)
            //        {
            //            prod1 += "░";
            //        }
            //        prod1 += $" {warehouseAmount} | {storeAmount}";
            //        lbxGraph.Items.Add(prod1);
            //        break;
            //    }
            //}
            
            

        }*/

        private void cbxStats1_SelectedValueChanged(object sender, EventArgs e)
        {
            //CreateListboxGraph();
        }

        
    }
}
