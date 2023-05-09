using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(int id, double radius) : base(id)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }

            Radius = radius;
        }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
