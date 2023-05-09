using Task02.Models;
using Task02;

// Create some pets for the dog store
Dog dog1 = new Dog { Name = "Max", Type = "Labrador", Age = 5, FavoriteFood = "Steak" };
Dog dog2 = new Dog { Name = "Bully", Type = "Poodle", Age = 3, FavoriteFood = "Chicken" };
List<Dog> dogs = new List<Dog> { dog1, dog2 };
PetStore<Dog> dogStore = new PetStore<Dog>(dogs);

// Create some pets for the cat store
Cat cat1 = new Cat { Name = "Luna", Type = "Persian", Age = 3, Lazy = true, LivesLeft = 8 };
Cat cat2 = new Cat { Name = "Dolly", Type = "Siamese", Age = 2, Lazy = false, LivesLeft = 9 };
List<Cat> cats = new List<Cat> { cat1, cat2 };
PetStore<Cat> catStore = new PetStore<Cat>(cats);

// Create some pets for the fish store
Fish fish1 = new Fish { Name = "Orca", Type = "Goldfish", Age = 1, Color = "Orange", Size = 5 };
Fish fish2 = new Fish { Name = "Oscar", Type = "Clownfish", Age = 2, Color = "Orange", Size = 3 };
List<Fish> fish = new List<Fish> { fish1, fish2 };
PetStore<Fish> fishStore = new PetStore<Fish>(fish);

// Buy a dog and a cat from the dog and cat stores
dogStore.BuyPet("Max");
catStore.BuyPet("Dolly");

// Print the available pets for all stores
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();