using Task.Domain;

Db<Dog> dogs = new Db<Dog>();

List<Dog> readingFromFile = dogs.ReadFromFile();
foreach (Dog dogsFromFile in readingFromFile)
{
    Console.WriteLine($"Name: {dogsFromFile.Name}, Age: {dogsFromFile.Age}, Color: {dogsFromFile.Color}");
}

Console.WriteLine("Enter the name of the dog:");
string inputName = Console.ReadLine();

Console.WriteLine("Enter how old is the dog");
int inputAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the color of the dog");
string inputColor = Console.ReadLine();


Dog dog = new Dog(inputName, inputAge, inputColor);
dogs.Insert(dog);