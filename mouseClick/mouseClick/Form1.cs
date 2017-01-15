/*
    Innocent Niyibizi
    3-9-16
    Create a program that uses the mouse down event to change the text of the form title to the location of the mouse location
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

namespace mouseClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event that occurs when the user clicks on the form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Changing the text of the label and the title of the form
            Text = e.Location.ToString();
            lblLocation.Text = e.Location.ToString();
        }
    }
}
