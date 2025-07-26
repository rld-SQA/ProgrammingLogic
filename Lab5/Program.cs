namespace Lab5;

/* Name: Rich DeLoof
   Title: IT-1050 - Lab 5: Illustrates inheritance, polymorphism, and overriding methods */

class Animal   // Creates a base class (parent)
{
    public virtual void animalSound()   // A virtual method belonging to the base class Animal1.  Virtual indicates that the base class method can be overridden, as will be demonstrated below.
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal // Derived class (child)
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}
