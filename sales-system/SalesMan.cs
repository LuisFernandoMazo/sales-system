using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class SalesMan
    {
        public String Name;
        public int Age;

        public void SetAgeN(int newAge)
        {
            if(newAge >= 0)
            {
                Age = newAge;
            }
            else
            {
                Console.WriteLine("The age of the seller cannot be less than 0");
            }

        }
    }
}
