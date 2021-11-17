using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car: Venicle,  ICar
    {
        public string model;
        public Car()
        {
           
        }
        public  string Model { get; set; }
    }
}
