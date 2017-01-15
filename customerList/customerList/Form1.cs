/*
    Innocent Niyibizi
    3-22-16
    Create program to hold customer name and country
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace customerList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCountryFilter.Text.Length > 0) {
                FilterData(txtCountryFilter.Text);
            }
        }

        //Method to filter customers based on the country entered
        private void FilterData(string country) {
            //Try statement to try and connect to database to display customers in that country
            string database = Application.StartupPath + ".../../../\\customers.accdb";
            OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database + ";";
            try
            {
                conn.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT customerName,customerCountry FROM Customers WHERE(customerCountry = '" + country + "')", conn);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Customer Name";
                dataGridView1.Columns[1].HeaderText = "Country";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }

        //Event that loads when the form is loaded
        //Autocompletion will be added to the country text boxes
        private void Form1_Load(object sender, EventArgs e)
        {
            string database = Application.StartupPath + ".../../../\\customers.accdb";
            OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database + ";";
            AutoCompleteStringCollection country = new AutoCompleteStringCollection();
            using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString)) {
                OleDbCommand command = new OleDbCommand("SELECT customerCountry FROM Customers", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    country.Add(reader.GetValue(0).ToString());
                }
            }
            txtCountry.AutoCompleteCustomSource = country;
            txtCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCountry.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtCountryFilter.AutoCompleteCustomSource = country;
            txtCountryFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCountryFilter.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Event that occurs when the Sumbit button is pressed
        //Validate to see that input length is more than 0 for both text boxes and then makes changes to databae
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text.Length == 0 || txtName.Text.Length == 0)
            {
                if (txtCountry.Text.Length == 0)
                {
                    ToolTip tool = new ToolTip();
                    tool.ToolTipIcon = ToolTipIcon.Error;
                    tool.Show("Please enter a country", txtCountry, 1500);
                }
                else {
                    ToolTip tool = new ToolTip();
                    tool.ToolTipIcon = ToolTipIcon.Error;
                    tool.Show("Please enter a name", txtName, 1500);
                }
                GC.Collect();
            }
            else {
                string database = Application.StartupPath + ".../../../\\customers.accdb";
                OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database + ";";
                try
                {
                    conn.Open();
                    string command = "INSERT INTO Customers (customerName, customerCountry) VALUES('" + txtName.Text.ToString() + "','" + txtCountry.Text.ToString() + "')";
                    OleDbCommand cmd = new OleDbCommand(command, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    conn.Close();
                }
            }
        }
    }
}
