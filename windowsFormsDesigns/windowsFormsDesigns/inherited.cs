using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windowsFormsDesigns
{
    public partial class inherited : windowsFormsDesigns.Form1
    {
        public inherited()
        {
            InitializeComponent();
        }

        private void inherited_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}
