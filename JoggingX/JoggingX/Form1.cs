using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoggingX
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            GatherInput();
        }

        private void Form1_Load(object sender, EventArgs e){
            DisplayInstructs();
        }
        public void DisplayInstructs(){
            MessageBox.Show("Please input your first stride, your last stride, and total time in minutes");
        }
        public int GatherInput(){
              double fStride = int.Parse(txtBoxFirst.Text);
              double lStride = int.Parse(txtBoxLast.Text);
              double time = GatherTotalTime();
              double avgStride = (fStride + lStride) / 2;
              double distanceTraveled = CalcDistance(avgStride, time);
              DisplayInfo(distanceTraveled, avgStride, time);
              return 0; 
        }
        public double GatherTotalTime() { 
            return double.Parse(txtBoxMinutes.Text);
        }
        public double CalcDistance(double average, double time) { 
           const double FEET_PER_STRIDE = 2.5d;
            const int FEET_PER_MILE = 5280;
            return (((average*FEET_PER_STRIDE)*time)/FEET_PER_MILE);
        }
        public void DisplayInfo(double distance, double strides, double time) {
            MessageBox.Show("Total Distance: " + distance.ToString() + "\n" + "Stides: " + strides.ToString() + "\n" + "Time: " + time.ToString());
        }
    }
}
