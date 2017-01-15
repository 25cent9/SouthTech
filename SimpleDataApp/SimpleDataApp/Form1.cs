using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes application, not just this form
            Application.Exit();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            //Open the NewCust form as a dialog box which will return focus to the calling form when it closes
            Form customer = new frmNewCustomer();
            customer.ShowDialog();
        }

        private void btnFillOrCancel_Click(object sender, EventArgs e)
        {
            //Open the FillorCancel form as a dialog box
            Form fill = new frmFillOrCancel();
            fill.ShowDialog();
        }
    }
}
