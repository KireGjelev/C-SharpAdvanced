using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(int id, double width, double height) : base(id) 
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width must be greater than 0");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than 0");
            }

            Width = width;
            Height = height;
        }


        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
