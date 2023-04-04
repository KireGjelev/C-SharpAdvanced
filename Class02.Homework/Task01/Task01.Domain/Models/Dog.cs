using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class Dog : Animal, IDog
    {

        public Dog()
        {

        }

        public Dog(string name, int age, string color) : base(name, age, color)
        {

        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"I'm a {Age} years old {Color} dog named {Name}.");
        }

        public void Bark()
        {
            Console.WriteLine($"Woof Woof!");
        }
    }
}
