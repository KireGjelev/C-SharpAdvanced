using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Models
{
    internal class Fish : Pet
    {
        public string Color { get; set; }
        public double Size { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: {Type}\nAge: {Age}\nColor: {Color}\nSize: {Size}");
        }
    }
}
