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
            string result = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result += "*";
                }

                result += "\n";
            }

            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(result);
            Console.WriteLine(sumTwo(2, 5));
            Console.Read();
        }
    }
}
