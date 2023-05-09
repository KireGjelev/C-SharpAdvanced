using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01.Database
{
    public class Db<T> where T : Shape
    {
        public List<T> _shapes;

        public Db()
        {
            _shapes = new List<T>();
        }

        public void AddShape(T shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveShape(T shape)
        {
            _shapes.Remove(shape);
        }

        public List<T> GetShapes()
        {
            return _shapes;
        }

        public void PrintAreas()
        {
            Console.WriteLine("Printing areas of all shapes in the list:");
            foreach (T shape in _shapes)
            {
                Console.WriteLine($"Shape Id: {shape.Id}, Area: {shape.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            Console.WriteLine("Printing perimeters of all shapes in the list:");
            foreach (T shape in _shapes)
            {
                Console.WriteLine($"Shape Id: {shape.Id}, Perimeter: {shape.GetPerimeter()}");
            }
        }
    }
}
