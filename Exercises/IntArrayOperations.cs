using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class IntArrayOperations
    {
        private int[] numbers;

        public IntArrayOperations(int[] _numbers)
        {
            numbers = _numbers;
        }

        public int Sum()
        {
            int sum = 0;
            int count = 0;

            foreach(int n in numbers)
            {
                count++;

                if(count != 0 || count != numbers.Length + 1)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public int Product()
        {
            int product = 0;

            foreach(int n in numbers)
            {
                product += n * n - 1;
            }

            return product;
        }
    }
}
