using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Education
{
    public partial class underGraduate : Education.Form1
    {
        public underGraduate()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string student = "";
            if (radioButton1.Checked == true) {
                 student = "Freshman";
            }
            else if (radioButton2.Checked == true) {
                 student = "Sophomore";
            }
            else if (radioButton3.Checked == true){
                 student = "Junior";
            }
            else{
                 student = "Senior";
            }
            if (textBox2.Text.Length <= 0) {
                ToolTip tool = new ToolTip();
                tool.UseAnimation = true;
                tool.ToolTipIcon = ToolTipIcon.Error;
                tool.Show("Please enter an address!!", textBox2, 1500);
                valid = false;
            }
            else if (textBox1.Text.Length <= 0) {
                ToolTip tool = new ToolTip();
                tool.UseAnimation = true;
                tool.ToolTipIcon = ToolTipIcon.Error;
                tool.Show("Please enter a name!!", textBox1, 1500);
                valid = false;
            }

            if (valid == true) {
                DialogResult result = MessageBox.Show("The student is a "+student+"\n Parent's name: "+textBox1.Text+"\nAddress: "+textBox2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes ) {
                    Application.Exit();
                }
            }
        }
    }
}
