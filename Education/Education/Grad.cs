using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Education
{
    public partial class Grad : Education.Form1
    {
        public Grad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = "";   //String that hold the type of degree

            //Determining the type of degreee from the radio button
            if (radioButton1.Checked == true) {
                type = "Bachelor of Arts";
            }
            else {
                type = "Bachelor of Science";
            }

            //Showing an error if the length of the text box is less than or equal to 0
            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Error; You must enter a location");
            }
            else {
                //If text box is valid then display a confirmation box and close the application if the user presses yes
                DialogResult results = MessageBox.Show("The location of the instituiton is "+textBox1.Text+"? \nYou are pursuing a " + type+"?","Confirmation",MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes) {
                    Application.Exit();
                }
            }
        }
    }
}
