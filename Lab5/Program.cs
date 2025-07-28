using System.Linq.Expressions;

namespace Lab5;

/* Name: Rich DeLoof
   Title: IT-1050 - Lab 5: Illustrates inheritance and runtime polymorphism, using overriden methods and base class references. */

class Animal   // Creates a base class (parent)
{
    public virtual void animalSound()   // A virtual sound method belonging to the base class Animal.  Virtual indicates that the base class method can be overridden, as will be demonstrated below.
    {
        Console.WriteLine("The animal makes a sound");  // Sound message specific to the Animal class
    }
}

class Cat : Animal // Creates a derived class (child).  The ':' indicates that the Cat class inherits fields and methods from the Animal class
{
    public override void animalSound()  // A sound method belonging to the Cat class.  Override indicates that the Cat class sound method overrides the Animal class sound method, which it inherited.
    {
        Console.WriteLine("The cat says: meow");    // Sound message specific to the Cat class
    }
}

class Dog : Animal  // Creates a derived class (child).  The ':' indicates that the Dog class inherits fields and methods from the Animal class
{
    public override void animalSound()  // A sound method belong to the Dog class.  Override indicates that the Dog class sound method overrides the Animal class sound method, which it inherited.
    {
        Console.WriteLine("The dog says: bow wow");     // Sound message specific to the Dog class
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();     // Creates the myAnimal object, typed by the Animal class
        Animal myCat = new Cat();       // Creates the myCat object, typed by the Animal class
        Animal myDog = new Dog();       // Creates the myDog object, typed by the Animal class

        myAnimal.animalSound();     // Calls the Animal class sound method; produces the sound message specific to the Animal class
        myCat.animalSound();        // Calls the Animal class sound method; produces the sound message specific to the Cat class due to the override of the Animal class sound method
        myDog.animalSound();        // Calls the Animal class sound method; produces the sound message specific to the Dog class due to the override of the Animal class sound method
    }
}
