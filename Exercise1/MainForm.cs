using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class MainForm : Form
    {
        public int recursiveFunction(int a, int b)
        {
            if(a >= b)
            {
                return a;
            }

            return recursiveFunction(a + 1, b);
        }

        public void evens(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            evens(10, 13);
        }

        private void IterateButton_Click(object sender, EventArgs e)
        {
            //Calculation calculation = new Calculation();

            //// Calling methods
            //int sum_two = calculation.sumTwo(11, 11);
            //int smallest_twp = calculation.smallestTwo(14, 11);
            //int smallest_three = calculation.smallestThree(2, 3, 1);
            //string legally_done = calculation.ageDescription(12);
            //string between = calculation.interval(1, 10);

            //// Printing results
            //Console.WriteLine(sum_two);
            //Console.WriteLine(smallest_twp);
            //Console.WriteLine(smallest_three);
            //Console.WriteLine(legally_done);
            //Console.WriteLine(between);

            //int count = 0;
            //int total = recursiveFunction(1, ref count);

            //Console.WriteLine(total);
        }
    }
}
