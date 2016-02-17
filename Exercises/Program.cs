using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        public static int sumTwo(int a, int b)
        {
            int sum = 0;

            for(int i = a + 1; i < b; i ++)
            {
                sum += i;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            //string result = "";

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        result += "*";
            //    }

            //    result += "\n";
            //}

            //int x = Int32.Parse(Console.ReadLine());
            //int y = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(sumTwo(x, y));

            //Interval interval = new Interval(1, 10);
            //Console.WriteLine(interval.Sum(x, y);

            Interval interval = new Interval(1, 10);
            interval.Product();

            Console.Read();
        }
    }
}
