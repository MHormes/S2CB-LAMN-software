using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMN_Software.DataClasses;
using LAMN_Software.DBHandling;

namespace LAMN_Software.GUI
{
    public partial class DeclineChangeOfInfo : Form
    {
        EmployeeChange empChange;
        EmployeeChangeHandler ECH;
        public DeclineChangeOfInfo(EmployeeChange empChange, EmployeeChangeHandler ECH)
        {
            InitializeComponent();
            this.empChange = empChange;
            this.ECH = ECH;
        }

        private void btnCancel_decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmDecline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxDeclineReason.Text))
            {
                MessageBox.Show("Please enter a reason of decline");
            }
            else
            {
                var decline = ECH.DeclineRequest(tbxDeclineReason.Text, empChange);
                if (decline == null)
                {
                    MessageBox.Show("Employee's request declined succesfully");
                    this.Hide();
                    this.Close();
                    return;
                }
                MessageBox.Show(decline.Message);
            }
        }
    }
}
