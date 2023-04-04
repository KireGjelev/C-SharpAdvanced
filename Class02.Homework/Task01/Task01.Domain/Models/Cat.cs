using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public Cat()
        {

        }
        public Cat(string name, int age, string color) : base(name, age, color)
        {

        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"I'm a {Age} years old {Color} cat named {Name}.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{food} is my favourite lunch.");
        }
    }
}
