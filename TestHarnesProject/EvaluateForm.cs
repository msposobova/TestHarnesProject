using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHarnesProject
{
    public partial class EvaluateForm : Form
    {
        public EvaluateForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblGCD.Text = "";
            lblMax.Text = "";
            lblMin.Text = "";
            lblAvg.Text = "";
            lblCharNum1.Text = "";
            lblCharNum2.Text = "";
            txtNum1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaring variables
            
            int num1, num2, gcd, max, min;
            double avg;
            string charNum1, charNum2;

            //TryParse Method for reading an input and checking if an input string value can be converted into a numeric value
            
            if (!int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Please enter a valid whole number into Number 1 box", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }

            if (!int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter a valid whole number into Number 2 box", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum2.SelectAll();
                txtNum2.Focus();
                return;
            }
            
            //-------------------------------------------------------------------------------------------------------------------
            //displaying GCD Value using try-catch block for throwing an exception
            
            try
            {
                gcd = Evaluate.EvaluateGCD(num1, num2);
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }
            lblGCD.Text = gcd.ToString();
            
            //-------------------------------------------------------------------------------------------------------------------
            //displaying Max Value using try-catch block for throwing an exception
            
            try
            {
                max = Evaluate.EvaluateMaxMin(num1, num2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }
            lblMax.Text = max.ToString();
            
            //-------------------------------------------------------------------------------------------------------------------
            //displaying Min Value using try-catch block for throwing an exception
           
            try
            {
                min = Evaluate.EvaluateMaxMin(num1, num2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }
            lblMin.Text = min.ToString();
            
            //-------------------------------------------------------------------------------------------------------------------
            //displaying Avg Value using try-catch block for throwing an exception
            
            try
            {
                avg = Evaluate.EvaluateAvg (num1, num2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }
            lblAvg.Text = avg.ToString();

            //-------------------------------------------------------------------------------------------------------------------
            //displaying Number1 to Char Value using try-catch block for throwing an exception

            try
            {
                charNum1 = Evaluate.EvaluateCharNum(num1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.SelectAll();
                txtNum1.Focus();
                return;
            }
            lblCharNum1.Text = charNum1.ToString();

            //-------------------------------------------------------------------------------------------------------------------
            //displaying Number2 to Char Value using try-catch block for throwing an exception

            try
            {
                charNum2 = Evaluate.EvaluateCharNum(num2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum2.SelectAll();
                txtNum2.Focus();
                return;
            }
            lblCharNum2.Text = charNum2.ToString();
        }
    }
}
