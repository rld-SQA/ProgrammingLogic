using System.Drawing;
using System.Dynamic;
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
    public string GetDescription()
    {
        return year + " " + color + " " + model;    /* Applying the "Separation of Concerns" principle such that only the return is executed by the method; the result is printed in Main().
                                                        This is done as the car description may be needed more globally in Main() (e.g., a report on the car, including its description) */
    }

    // Lab 4, Problem 4: Add a Method that Updates a Field; called from Main()
    public void Repaint(string newColor)
    {
        color = newColor;   // Updates the color field to a new color, sent in by the user     
        Console.WriteLine();
        Console.WriteLine("The car has been repainted to " + color + ".");    // Prints the confirmation message that the color field has been updated
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

        myCar.Display(); // Calls the Display method

        myCar.Start();  // Calls the Start method

        myCar.Drive(50);  // Calls the Drive method, sending in an argument of '50'

        string desc = myCar.GetDescription();   // Calls the GetDescription method and stores the returned string in the variable 'desc'
        Console.WriteLine();
        Console.WriteLine(desc);    // Prints the variable 'desc' containing the stored return value

        myCar.Repaint("red");   // Calls the Repaint method, with argument 'red', to change the car color, and confirm that the color field has been updated
        Console.WriteLine("Test in Main() that the myCar.color has been updated: myCar.color now = " + myCar.color);     // Tests in Main() that myCar.color has been updated
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
