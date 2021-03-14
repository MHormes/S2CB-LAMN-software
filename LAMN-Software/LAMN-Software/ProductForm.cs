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

namespace LAMN_Software
{
    public partial class ProductForm : Form
    {

        StockHandler SH;
        EmployeeHandler EH;
        public ProductForm()
        {
            InitializeComponent();
            SH = new StockHandler();
            EH = new EmployeeHandler();
            FillStockListBox();
            FillEmployeeListBox();

            //Method to enable buttons based on indicator

        }

        //STOCK MANAGEMENT

        //Navigation Stock button click
        private void btnStock_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStock;
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
            //IMPLEMENT SPECIFIC EXCEPTION HANDLING FOR TEXTFIELDS!!!!!
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
            if (SH.GetAllStockFromDB() == null)
            {
                foreach (Product p in SH.GetAllProducts())
                {
                    lbxAllStock.Items.Add(p);
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


        //SCHEDULES

        //Navigation button to schedule page
        private void btnSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedules;
        }


        

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatistics;
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
                                                           Color.RoyalBlue,
                                                           Color.FromArgb(26, 61, 166),
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

        

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployeeAdd;
            tbxEmployeeAdd_FirstName.Text = "";
            tbxEmployeeAdd_SecondName.Text = "";
            tbxEmployeeAdd_BSN.Text = "";
            tbxEmployeeAdd_ICENumber.Text = "";
            tbxEmployeeAdd_AdditonalInfo.Text = "";
            cbxEmployeeAdd_ICERelationship.SelectedIndex = -1;
            cbxEmployeeAdd_Position.SelectedIndex = -1;

            cbxEmployeeAdd_ICERelationship.DataSource = Enum.GetNames(typeof(ICERelation));
            cbxEmployeeAdd_Position.DataSource = Enum.GetNames(typeof(JobPosition));
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            // code goes here
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }
            List<Employee> employees = EH.GetAllEmployees();

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

        //need to do autogenerated username and password
        private void btnEmployeeAdd_Confirm_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var add = EH.AddEmployee(tbxEmployeeAdd_FirstName.Text, tbxEmployeeAdd_SecondName.Text, (USERNAME), Convert.ToInt32(tbxEmployeeAdd_BSN.Text), Convert.ToDateTime(dtpEmployeeAdd_DateOfBirth), (EMAIL), tbxEmployeeAdd_PhoneNumber.Text, tbxEmployeeAdd_ICENumber.Text, (ICERelation)Enum.Parse(typeof(ICERelation), cbxEmployeeAdd_ICERelationship.SelectedText), (JobPosition)Enum.Parse(typeof(JobPosition), cbxEmployeeAdd_Position.SelectedText), null, tbxEmployeeAdd_AdditonalInfo.Text, null );

            //    if (add == null)
            //    {
            //        FillEmployeeListBox();
            //        MessageBox.Show("Employee added succesfully");
            //        return;
            //    }
            //    MessageBox.Show(add.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
