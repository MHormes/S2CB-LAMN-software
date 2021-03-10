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
        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;

        StockHandler SH;
        public ProductForm()
        {
            InitializeComponent();
            SH = new StockHandler();
            FillStockListBox();
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
            tbxStockAdd_Sell.Text = "";
            tbxStockAdd_MinimumStock.Text = "";
            tbxStockAdd_AddInfo.Text = "";
            tbxStockAdd_TotalSold.Text = "";
            tbxStockAdd_TotalSold.Enabled = false;
        }

        //onClick for confirming the add product
        private void btnStockAdd_ConfirmAdd_Click(object sender, EventArgs e)
        {
            //method to call for adding
            var add = SH.AddProduct(tbxStockAdd_ProductName.Text, Convert.ToInt32(tbxStockAdd_StoreQuantity.Text), Convert.ToInt32(tbxStockAdd_WarehouseQuantity.Text), tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, Convert.ToDouble(tbxStockAdd_Cost.Text), Convert.ToDouble(tbxStockAdd_Sell.Text), Convert.ToInt32(tbxStockAdd_MinimumStock.Text), tbxStockAdd_AddInfo.Text);
            //IMPLEMENT EXCEPTION HANDLING FOR TEXTFIELDS!!!!!
            if (add == null)
            {
                FillStockListBox();
                MessageBox.Show("Item added succesfully");
                return;
            }
            MessageBox.Show(add.Message);
        }

        //onClick for edit stock button. Will take selected.
        private void btnEditStock_Click(object sender, EventArgs e)
        {
            //IMPLEMENT NO SELECTED ITEM EXCEPTION
            //save object
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
            //method to call for changing
            var update = SH.ChangeProduct(Convert.ToInt32(tbxStockAdd_ID.Text), tbxStockAdd_ProductName.Text, Convert.ToInt32(tbxStockAdd_StoreQuantity.Text), Convert.ToInt32(tbxStockAdd_WarehouseQuantity.Text), tbxStockAdd_StoreLocation.Text, tbxStockAdd_WarehouseLocation.Text, Convert.ToInt32(tbxStockAdd_MinimumStock.Text), tbxStockAdd_AddInfo.Text);
            //IMPLEMENT EXCEPTION HANDLING FOR TEXTFIELDS!!!!!
            if (update == null)
            {
                FillStockListBox();
                MessageBox.Show("Item edited succesfully");
                return;
            }
            MessageBox.Show(update.Message);
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {

            //IMPLEMENT NO ITEM SELECTED EXCEPTION
            Product p = (Product)lbxAllStock.SelectedItem;
            //method to call for deleting
            var delete = SH.DeleteProduct(p);
            //Implement popup for quitting reason
            if (delete == null)
            {
                FillStockListBox();
                MessageBox.Show("Product sucessfully deleted");
                return;
            }
            MessageBox.Show(delete.Message);

        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            // code goes here
        }


        private void btnStock_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStock;
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpSchedules;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpEmployees;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tcNavigator.SelectedTab = tpStatistics;
        }

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
        //DESIGN

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


    }
}
