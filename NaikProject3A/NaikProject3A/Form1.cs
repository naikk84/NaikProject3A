using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaikProject3A
{ 
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class startwithfive : Exception
        {


            public startwithfive()
            {
                MessageBox.Show("An exception has occured the number cannot start with 5 for the first number");
            }
        }
        private void butCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string a = First1.Text;
                decimal Number1 = Convert.ToDecimal(First1.Text);
                decimal Number2 = Convert.ToDecimal(Second2.Text);
                decimal number3 = Number1 / Number2;
                if (Number1 > 8000)
                {
                    throw new OverflowException();
                };
                if (a.StartsWith("5"))
                {
                    throw new startwithfive();
                }
                Result.Text = number3.ToString();
                First1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception has occured enter values in numbers only");
                First1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception has occured enter First Number less then 8000");
                First1.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by zero exception has occured enter a number greater than zero for Second Number");
                Second2.Focus();
            }
            catch (startwithfive)
            {
                First1.Focus();
            }

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
