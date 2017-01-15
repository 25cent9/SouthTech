using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //AddUp(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            AddUp(num1, num2);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int returnVal = Subtract(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
            
        }

        private void txtDivd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            Divid(num1, num2);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            Mult(num1, num2);
        }

        /**Methods
        void AddUp() {
            MessageBox.Show("Add up here");
            txtResult = int.Parse(txtNum1) + int.Parse(txtNum2);
        } 
        * */
        private void AddUp(int firstNum, int secNum) {
            int answer = firstNum + secNum;
            txtResult.Text = answer.ToString();
            if(btmProgress.Value<=95)btmProgress.Value += 5;
        }
        private void Mult(int firstNum, int secNum)
        {
            int answer = firstNum * secNum;
            txtResult.Text = answer.ToString();
            if(btmProgress.Value<95)btmProgress.Value += 5;
        }
        private void Divid(int firstNum, int secNum)
        {
            int answer = firstNum / secNum;
            txtResult.Text = answer.ToString();
            if(btmProgress.Value<=95)btmProgress.Value += 5;
        }
        private int Subtract(int firstNum, int secondNum) {
            int answer;
            if (firstNum > secondNum){
                answer = firstNum - secondNum;
            }
            else {
               answer  = secondNum - firstNum;
            }
            txtResult.Text = answer.ToString();
            if(btmProgress.Value<=95)btmProgress.Value += 20;
            return answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++ ){
                btmProgress.Value += 1;
            }
        }
    }
}
