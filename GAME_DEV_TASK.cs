using System;

class Animal
{
  
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, string breed, int age)
    {
        this.Name = name;
        this.Breed = breed;
        this.Age = age;
    }

    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
    }
}

// Inheritance 
class Dog : Animal
{
    public string FavoriteToy { get; set; }

    // Constructor
    public Dog(string name, string breed, int age, string favoriteToy)
        : base(name, breed, age) // Calls the parent class constructor like super in java
    {
        this.FavoriteToy = favoriteToy;
    }

    public override void Bark()
    {
        Console.WriteLine($"{Name} says: Woof! Woof!"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Animal
        Animal animal = new Animal("Animal", "Unknown Breed", 5);

        // Creating an instance of Dog
        Dog dog = new Dog("Rex", "Husky", 3, "Bone");


        Console.WriteLine("Animal Bark:");
        animal.Bark(); //Animal sound!

        Console.WriteLine("Dog Bark:");
        dog.Bark(); // Rex says: Woof! Woof!

        Console.WriteLine("\nAnimal Attributes:");
        Console.WriteLine($"Name: {animal.Name}");
        Console.WriteLine($"Breed: {animal.Breed}");
        Console.WriteLine($"Age: {animal.Age}");

        Console.WriteLine("\nDog Attributes:");
        Console.WriteLine($"Name: {dog.Name}");
        Console.WriteLine($"Breed: {dog.Breed}");
        Console.WriteLine($"Age: {dog.Age}");
        Console.WriteLine($"Favorite Toy: {dog.FavoriteToy}");
    }
}
