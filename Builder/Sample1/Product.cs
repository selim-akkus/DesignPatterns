﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public void Show()
        {
            Console.WriteLine("Name : " + Name + "\nCategory :"  + Category + "\n--------------------\n");
        }
    }
}
