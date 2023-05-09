using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Models;

namespace Task02
{
    public class PetStore<T> where T : Pet
    {
        public List<T> pets;

        public PetStore(List<T> pets)
        {
            this.pets = pets;
        }

        public void PrintPets()
        {
            Console.WriteLine($"Available {typeof(T).Name}s:");
            foreach (T pet in pets)
            {
                pet.PrintInfo();
                Console.WriteLine();
            }
        }

        public void BuyPet(string name)
        {
            T pet = pets.FirstOrDefault(p => p.Name == name);
            if (pet == null)
            {
                Console.WriteLine($"Sorry, we don't have a {typeof(T).Name} named {name}.");
            }
            else
            {
                pets.Remove(pet);
                Console.WriteLine($"Congratulations, you've just bought a {typeof(T).Name} named {name}!");
            }
        }
    }
}
