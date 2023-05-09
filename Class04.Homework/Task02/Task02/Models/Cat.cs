using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Models
{
    internal class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: {Type}\nAge: {Age}\nLazy: {Lazy}\nLives Left: {LivesLeft}");
        }
    }
}
