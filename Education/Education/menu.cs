using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Education
{
    public partial class menu : Education.Form1
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (textBox1.Text.Length <= 0){
                ToolTip tool = new ToolTip();
                tool.ToolTipIcon = ToolTipIcon.Error;
                tool.Show("Please enter a name!",textBox1,1500);
                valid = false;
            }
            if (valid == true)
            {
                //Checking to see if the first radio button is selected, if so then the Graduate form will load and current form will be hidden
                if (rdioBtnGrad.Checked)
                {
                    Form grad = new Grad();
                    grad.Show();
                    grad.Text += " - " + textBox1.Text;
                    this.Hide();
                }
                //If the second radio button is selected then the undergraduate form will be loaded and current form hidden
                else {

                    Form underGrade = new underGraduate();
                    underGrade.Show();
                    underGrade.Text += " - " + textBox1.Text;
                    this.Hide();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
