using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }


        public Animal()
        {

        }

        public Animal(string name, int age, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Name can't be null or empty.");
                throw new ArgumentException(nameof(name));
            }
            if (age <= 0)
            {
                Console.WriteLine("Error: Age must be greater than zero.");
                throw new ArgumentOutOfRangeException(nameof(age));
            }
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Error: Color can't be null or empty.");
                throw new ArgumentException(nameof(color));
            }

            Name = name;
            Age = age;
            Color = color;
        }

        public abstract void PrintAnimal();

    }
}
