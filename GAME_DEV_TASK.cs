using System;

class Animal
{
    // Private attributes
    public string name;
    public string breed;
    public int age;

    // Constructor
    public Animal(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }

    // Setters
    public void SetName(string name) { this.name = name; }
    public void SetBreed(string breed) { this.breed = breed; }
    public void SetAge(int age) { this.age = age; }

    // Getters
    public string GetName() { return this.name; }
    public string GetBreed() { return this.breed; }
    public int GetAge() { return this.age; }


    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
    }
}
// inheretance 
class Dog : Animal
{

    public string favoriteToy;

    // Constructor
    public Dog(string name, string breed, int age, string favoriteToy)
        : base(name, breed, age) // like super in java to call the parent class constructor
    {
        this.favoriteToy = favoriteToy;
    }

    // Setter and Getter for favoriteToy
    public void SetFavoriteToy(string favoriteToy) { this.favoriteToy = favoriteToy; }
    public string GetFavoriteToy() { return this.favoriteToy; }

    // Overriding the Bark method
    public override void Bark()
    {
        Console.WriteLine($"{GetName()} says: Woof! Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Animal
        Animal animal = new Animal("Animal", "Unknown Breed", 5);
        animal.SetName("Animal");
        animal.SetBreed("Unknown Breed");
        animal.SetAge(5);

        // Creating an instance of Dog
        Dog dog = new Dog("Rex", "Husky", 3, "Bone");
        dog.SetFavoriteToy("Ball");

        // Calling Bark method for Animal and Dog
        Console.WriteLine("Animal Bark:");
        animal.Bark(); // Should print: Animal sound!

        Console.WriteLine("Dog Bark:");
        dog.Bark(); // Should print: Buddy says: Woof! Woof!

        
        Console.WriteLine("\nAnimal Attributes:");
        Console.WriteLine($"Name: {animal.GetName()}");
        Console.WriteLine($"Breed: {animal.GetBreed()}");
        Console.WriteLine($"Age: {animal.GetAge()}");

        Console.WriteLine("\nDog Attributes:");
        Console.WriteLine($"Name: {dog.GetName()}");
        Console.WriteLine($"Breed: {dog.GetBreed()}");
        Console.WriteLine($"Age: {dog.GetAge()}");
        Console.WriteLine($"Favorite Toy: {dog.GetFavoriteToy()}");
    }
}
