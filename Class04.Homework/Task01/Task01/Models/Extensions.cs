using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public static class CircleExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle Id: {circle.Id}, Radius: {circle.Radius}, Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
        }
    }

    public static class RectangleExtensions
    {
        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle Id: {rectangle.Id}, Width: {rectangle.Width}, Height: {rectangle.Height}, Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}
