using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMN_Software
{
    public partial class EmploymentTermination : Form
    {
        EmployeeHandler eh;
        Employee employee;

        public EmploymentTermination(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            eh = new EmployeeHandler();
        }

        private void btnConfirmTermination_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tbxTerminationReason.Text))
            {
                MessageBox.Show("Please enter a reason for termination");
            }
            else
            {
                var delete = eh.TerminateEmployee(employee, tbxTerminationReason.Text);
                if (delete == null)
                {
                    MessageBox.Show("Employee terminated succesfully");
                    this.Hide();
                    this.Close();
                    return;
                }
                MessageBox.Show(delete.Message);
            }
        }

        private void btnCancel_termination_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
