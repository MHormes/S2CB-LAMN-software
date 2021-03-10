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
    public partial class Form1 : Form
    {

        //CODE FOR THE VISUAL DESIGN.
        //mouse coords which are needed for GUI drag bar functionality
        public Point mouseLocation;
        

        public Form1()
        {
            InitializeComponent();
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

        //'X' icon used to close current form
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBackground_Click(object sender, EventArgs e)
        {
            textBox_defocus.Focus();
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

        private void textBox_accountName_Enter(object sender, EventArgs e)
        {
            if (textBox_accountName.Text == "Account name")
            {
                textBox_accountName.Text = "";
                textBox_accountName.ForeColor = Color.Black;
                textBox_accountName.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBox_accountName_Leave(object sender, EventArgs e)
        {
            if (textBox_accountName.Text == "")
            {
                textBox_accountName.Text = "Account name";
                textBox_accountName.ForeColor = Color.Gray;
                textBox_accountName.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBox_accountPassword_Enter(object sender, EventArgs e)
        {
            if (textBox_accountPassword.Text == "Password")
            {
                textBox_accountPassword.UseSystemPasswordChar = true;
                textBox_accountPassword.Clear();
                textBox_accountPassword.ForeColor = Color.Black;
                textBox_accountPassword.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBox_accountPassword_Leave(object sender, EventArgs e)
        {
            if (textBox_accountPassword.Text == "")
            {
                textBox_accountPassword.UseSystemPasswordChar = false;
                textBox_accountPassword.Text = "Password";
                textBox_accountPassword.ForeColor = Color.Gray;
                textBox_accountPassword.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBox_accountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textBox_accountPassword.Focus();
            }
        }

        private void textBox_accountPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox_accountName.Focus();
            }
        }

        private void textBox_defocus_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_accountName.Focus();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.ShowDialog();
            //code needs to be added
        }
    }
}
