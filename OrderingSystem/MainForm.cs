using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.Global;
using OrderingSystem.Admin;

namespace OrderingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement goToProductMgmt = new ProductManagement();
            GlobalClass.CheckMdiChildren(goToProductMgmt);
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList goToCustomerList = new CustomerList();
            GlobalClass.CheckMdiChildren(goToCustomerList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(126, 64, 0);
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(126, 64, 0);
                    break;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string sbtn = btn.Name;

            switch (sbtn)
            {
                case "btnExit":
                    Environment.Exit(0);
                    break;
                case "btnResize":

                    break;
                case "btnMinimize":
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    break;
                default:
                    //MessageBox.Show("The event is : " + e.GetType().ToString());
                    break;
            }
        }
        


    }
}
