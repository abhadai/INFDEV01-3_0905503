using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Calculation
    {
        public Calculation()
        {
        }

        public int sumTwo(int a, int b) { return a + b; }

        public int smallestTwo(int a, int b)
        {
            int smallest = 0;

            if(a < b)
            {
                smallest = a;
            }
            else
            {
                smallest = b;
            }

            return smallest;
        }

        public int smallestThree(int a, int b, int c)
        {
            int smallest = 0;

            if(a < b && a < c)
            {
                smallest = a;
            }

            if(b < a && b < c)
            {
                smallest = b;
            }

            if(c < a && c < b)
            {
                smallest = c;
            }

            return smallest;
        }

        public string ageDescription(int age)
        {
            string legally_done = "";

            if(age < 3)
            {
                legally_done = "Nothing!";
            }

            if(age >= 3 && age < 13)
            {
                legally_done = "You can shoot semi-automated guns in the USA!";
            }

            if(age >= 13 && age < 17)
            {
                legally_done = "You can go to highschool and think your life is really tough!";
            }

            if(age >= 16 && age < 25)
            {
                legally_done = "You can go to an HBO and think highschool was really easy in comparison!";
            }

            if(age >= 25 && age < 65)
            {
                legally_done = "You can go to work!";
            }

            if(age > 65)
            {
                legally_done = "You can retire now!";
            }

            return legally_done;
        }

        /*public void interval(int a, int b)
        {
            for(int i = 0; i < (a - b); i++)
            {
                Console.WriteLine(i);
            }
        }*/

        public int intervalRec(int a, int b)
        {
            if(a > b)
            {
                return a;
            }

            return intervalRec(a + 1, b);
        }
    }
}
