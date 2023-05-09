using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Models
{
    internal class Dog : Pet
    {
        public string FavoriteFood { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: {Type}\nAge: {Age}\nFavorite Food: {FavoriteFood}");
        }
    }
}
