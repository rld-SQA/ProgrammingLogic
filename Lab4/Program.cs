using Microsoft.VisualBasic;

namespace Lab4;

/* Name: Rich DeLoof
   Title: IT-1050 - Lab 4 */
class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Lab 4, Problem 1: Add a Method with No Parameters; called from Main()
    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine("The car is starting.");
    }

    // Lab 4, Problem 2: Add a Method with Parameters; called from Main()
    public void Drive(int miles)
    {
        Console.WriteLine();
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    // Lab 4, Problem 3: Add a Method with a Return Value; called from Main()
    public string GetDescription(string descript)
    {
        return $"{year}{color}{model}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start();  // Calling the Start method
        myCar.Drive(50);  // Calling the Drive method
        myCar.GetDescription(); // Calling the GetDescription method
    }
        
        /* The code block below inserted here to run two test cases for Discussion 4 - Software Testing
        
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("The sum is: " + sum);
        
        */
}
