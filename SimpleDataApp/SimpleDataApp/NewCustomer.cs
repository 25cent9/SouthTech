using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SimpleDataApp
{
    public partial class frmNewCustomer : Form
    {
        //IDENTITY values returned form databasae
        private int parseCustomerID;
        private int orderID;

        //Specify a connection string 
        string connstr = SimpleDataApp.Util.GetConnectionString();
        public frmNewCustomer()
        {
            
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (isCustomerName()){

                //Create the connection
                SqlConnection conn = new SqlConnection(connstr);

                //Create a sqlcommand and identify it as a stored procedure
                SqlCommand cmdNewCustomer = new SqlCommand("Sales.uspNewCustomer", conn);
                cmdNewCustomer.CommandType = CommandType.StoredProcedure;

                //Now add input parameter form the stored procedure and specify what to use as its value
                cmdNewCustomer.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                cmdNewCustomer.Parameters["@CustomerName"].Value = txtCustName.Text;

                //Add output parameter
                
            }
        }
    }
}
