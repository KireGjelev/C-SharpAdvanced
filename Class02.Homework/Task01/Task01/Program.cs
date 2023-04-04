using Task01.Domain.Models;

Dog dog = new Dog("Snoopy", 3, "white");
dog.PrintAnimal();
dog.Bark();

Cat cat = new Cat("Bella", 4, "gray");
cat.PrintAnimal();
cat.Eat("Fish");