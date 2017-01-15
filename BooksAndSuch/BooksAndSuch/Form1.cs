/*
    Innocent Niyibizi
    3-30-16
    Create a program that gets books that were published between 2011 and 2008
*/
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BooksAndSuch
{
    public partial class Form1 : Form
    {
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbDataReader dbReader;
        private string sConnection;
        private string sql;
        private string book;

        public Form1()
        {
            InitializeComponent();
        }

        //Getting the connection string and the sql command right at the start of the program 
        private void Form1_Load(object sender, EventArgs e)
        {
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Books.accdb";
            dbConn = new OleDbConnection(sConnection);
            sql = "SELECT ISBN, Title, CopyrightDate, Pages, Publisher FROM BookTable WHERE CopyrightDate < '2011' AND CopyrightDate > '2008' ORDER BY Publisher ASC;";
        }

        //Event that occurs when the button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            //Trying to open the database and gather the required data
            try
            {
                dbConn.Open();
                dbCmd = new OleDbCommand(sql, dbConn);
                
                dbReader = dbCmd.ExecuteReader();
                //Loop to run while the reader is still reading
                //Each found element will be added to the book string and then the book string will be added to the listbox
                while (dbReader.Read()) {
                    book = dbReader["ISBN"].ToString();
                    book += "\r\t\t" + dbReader["Title"].ToString();
                    book += "\r\t" + dbReader["CopyrightDate"].ToString();
                    book += "\r\t\t" + dbReader["Pages"].ToString();
                    book += "\r\t\t" + dbReader["Publisher"].ToString();
                    lstBxBooks.Items.Add(book);
                }
            }
            //Catching any exception and displaying the message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Closing the database when execution has finished
            finally {
                dbConn.Close();
            }
        }
    }
}
