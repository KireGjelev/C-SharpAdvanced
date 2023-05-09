using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public abstract class Shape
    {
        public int Id { get; set; }

        protected Shape(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0");
            }

            Id = id;
        }


        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}