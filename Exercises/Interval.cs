using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Interval
    {
        private int start;
        private int end;

        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;
        }

        public void Sum()
        {
            for(int i = start - 1; i < end; i++)
            {

            }
        }

        public int Product()
        {
            if(start < end)
            {
                start += 1;
                Console.WriteLine(start * end);
            }

            return Product();
        }
    }
}
