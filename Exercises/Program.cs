using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    static class Program
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

            //Interval interval = new Interval(1, 10);
            //interval.Product();

            //int[] numbers = { 2, 5, 19 };
            //IntArrayOperations array_operations = new IntArrayOperations(numbers);
            //Console.WriteLine(array_operations.Product());

            var CounterList = new List<Counter>();
            CounterList.Add(new Counter());

            var result = CounterList.Map(c => c.Tick());

            Counter counter = new Counter();
            counter.Tick();

            Console.Read();
        }

        public static IEnumerable<X> Map<T, X>(this List<T> list, Func<T, X> mapper) => list.Select(mapper);

        public static IEnumerable<X> Map<T,X>(this IEnumerable<T> list, Func<T, X> mapper)
        {
            foreach(T item in list)
                yield return mapper.Invoke(item);
        }
    }
}
