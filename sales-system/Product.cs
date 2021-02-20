﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Product
    {
       public String Name;
       public float Price;

        public void SetPrice(int newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
            }
            else
            {
                Console.WriteLine("The price cannot be less than 0");
            }

        }

    }
}
