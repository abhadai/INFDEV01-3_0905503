using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Interval
    {
        private int start;
        private int end;

        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;

            Sum(_start, _end);
        }

        public int Sum(int x, int y)
        {
            return start + end;
        }

    }
}
