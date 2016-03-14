using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Counter
    {
        // Read-only
        public int Ticks { get; }

        public Counter()
        {
            Ticks = 0;
        }

        private Counter(int ticks)
        {
            Ticks = ticks;
        }

        public Counter Reset()
        {
            return new Counter();
        }

        public Counter Tick()
        {
            return new Counter(Ticks + 1);
        }

        public static Counter operator +(Counter counter1, Counter counter2)
        {
            return new Counter(counter1.Ticks + counter2.Ticks);
        }

        public static Counter operator -(Counter counter1, Counter counter2)
        {
            return new Counter(counter1.Ticks - counter2.Ticks);
        }
    }
}
