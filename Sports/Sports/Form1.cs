/*
    Innocent Niyibizi
    3-23-16
    Create program that will read a sports database in order to return data about any given sport
*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sports
{
    public partial class Form1 : Form
    {
            //Creating the path to the database
            string databasePath = Application.StartupPath + ".../../../Database\\Team.accdb";
            public static OleDbConnection conn = new OleDbConnection();
            
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath + ";";
            
        }

        //Function used to get athletes from tha appropriate sport
        private void getSport(string sport) {
            //Trying to open the conncetion to the database
            //If it fails then an error message will appear
            try
            {
                conn.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT StudentNumber, StudentFirstName,StudentLastName FROM Athlete WHERE(Sport = '"+sport+"')", conn);
                DataTable table = new DataTable();

                //Filling the Datagridview with the information from the database
                //Changing the header text of each column to the appropriate name
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                
                dataGridView1.Columns[0].HeaderText = "Student Number";
                dataGridView1.Columns[1].HeaderText = "Student First Name";
                dataGridView1.Columns[2].HeaderText = "Student Last Name";

                //Creating a new command that will get the coach's name based on the sport 
                OleDbCommand getCoach = new OleDbCommand("SELECT CoachFirstName, CoachLastName FROM Team WHERE(Sport = '"+sport+"')", conn);

                //Creating a new reader that will execute the command to find the coach's name and place the name into the coachName label
                OleDbDataReader reader = getCoach.ExecuteReader();
                reader.Read();
                coachName.Text = reader.GetValue(0).ToString();
                coachName.Text += " ";
                coachName.Text += reader.GetValue(1).ToString();

                //Creating a command that will return just the first name of the coach of the team
                OleDbCommand cmd = new OleDbCommand("SELECT CoachFirstName FROM Team WHERE(Sport = '" + sport + "')", conn);
                //Showing the result of the executed function
                MessageBox.Show(cmd.ExecuteScalar().ToString());

                //Changing the sport label to match that of the sport that was passed through
                lblCoachSport.Text = sport;
                cmbSports.Text = sport;

                //Changing the width of the columns to fit the width of the window
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //Region of events that occur based on the button that is pressed
        //When a button is pressed, the text from that button will be passed into the getSports function
        #region "Button clicks"
        private void btnBasketball_Click(object sender, EventArgs e)
        {
            getSport(btnBasketball.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnCrew_Click(object sender, EventArgs e)
        {
            getSport(btnCrew.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            getSport(btnFootball.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnLacrosse_Click(object sender, EventArgs e)
        {
            getSport(btnLacrosse.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSoccer_Click(object sender, EventArgs e)
        {
            getSport(btnSoccer.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            getSport(btnTennis.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
        }

        //Region for both buttons that make changes to the database
        #region "Database Changes"
            //Button event to add a student to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {

            ToolTip tool = new ToolTip();
            tool.ToolTipIcon = ToolTipIcon.Error;
            int num;
            if (txtStudentNumber.Text.Length != 6 || int.TryParse(txtStudentNumber.Text, out num) == false)
            {
                tool.Show("Please enter a six digit number!!", txtStudentNumber, 1500);
            }
            else if (txtFirstName.Text.Length == 0)
            {
                tool.Show("Please enter a first name!!", txtFirstName, 1500);
            }
            else if (txtLastName.Text.Length == 0)
            {
                tool.Show("Please enter a last name!!", txtLastName, 1500);
            }
            else {
                try
                {
                    conn.Open();
                    string command = "INSERT INTO Athlete (StudentNumber, StudentLastName, StudentFirstName, Sport) VALUES('"+txtStudentNumber.Text.ToString()+"','"+txtLastName.Text.ToString()+"','"+txtFirstName.Text.ToString()+"','"+cmbSports.Text.ToString()+"')";
                    OleDbCommand cmd = new OleDbCommand(command, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added");
                    conn.Close();
                    getSport(cmbSports.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
            //Button event to update the indicated student's information in the database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.ToolTipIcon = ToolTipIcon.Error;
            int num;
            if (txtStudentNumber.Text.Length != 6 || int.TryParse(txtStudentNumber.Text, out num) == false)
            {
                tool.Show("Please enter a six digit number!!", txtStudentNumber, 1500);
            }
            else if (txtFirstName.Text.Length == 0)
            {
                tool.Show("Please enter a first name!!", txtFirstName, 1500);
            }
            else if (txtLastName.Text.Length == 0)
            {
                tool.Show("Please enter a last name!!", txtLastName, 1500);
            }
            else{
                try
                {
                    conn.Open();
                    string command = "UPDATE Athlete SET StudentFirstName = '"+txtFirstName.Text+"',StudentLastName='"+txtLastName.Text+"',Sport='"+cmbSports.Text+"' WHERE StudentNumber='"+txtStudentNumber.Text+"'";
                    OleDbCommand cmd = new OleDbCommand(command, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    conn.Close();
                    getSport(cmbSports.Text);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    conn.Close();
                }
            }
            txtStudentNumber.Enabled = true;
        }
        #endregion
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSports.SelectedIndex = 0;    //Setting the default index of the combo box for the sports to zero
        }

        //Event that occurs when the datagridview is clicked
        //Textboxes will have values of the appropriate column in the datagridview
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtStudentNumber.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            btnAdd.Enabled = false;
            txtStudentNumber.Enabled = false;
            btnUpdate.Enabled = true;
        }

        //Event that occurs when the mouse hovers over the clear button
        //Tip will show the user what will happen upon pressing the clear button
        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.ToolTipIcon = ToolTipIcon.Info;
            tool.Show("Clear textboxes",btnClear, 1500);
        }

        //Event that occurs when the clear button is pressed
        //All text boxes will be cleared and buttons will be enabled
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        //Event that occurs when the enabled state of the update button is changed
        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled == true)
            {
                btnAdd.Enabled = false;
            }
            else {
                btnAdd.Enabled = true;
            }
        }

    }
}
