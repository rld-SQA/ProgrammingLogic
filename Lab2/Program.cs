using System.Security;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        /* Name: Rich DeLoof
        Title: IT-1050 - Lab 2 */

        // Part 1: Operator Practice
        Console.WriteLine("Lab 2, Part 1: Operator Practice");
        int a = 10, b = 5, c = 15;  // Integer variable declaration
        Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);    // Print starting integer values
        Console.WriteLine("a > b?: " + (a > b));    // Checks if 'a' is greater than 'b' using the '>' comparison operator; returns a value of True or False and prints result
        Console.WriteLine("a < c?: " + (a < c));    // Checks if 'a' is less than 'c' using the '<' comparision operator; returns a value of True or False and prints result
        Console.WriteLine("a > b AND a > c?: " + (a > b && a > c));     // Checks if 'a' is greater than both 'b' and 'c' using the '&&' (AND) logical operator; returns a value of True or False and prints result
        Console.WriteLine("a > b OR a > c?: " + (a > b || a > c));      // Checks if 'a' is greater than 'b' or 'c' using the '||' (OR) logical operator; returns a value of True or False and prints result
        Console.WriteLine();

        // Part 2: Boolean Logic
        Console.WriteLine("Lab 2, Part 2: Boolean Logic");
        bool isRaining = true;  // Declare boolean type 'isRaining' with value 'true'
        bool haveUmbrella = false;  // Declare boolean type 'haveUmbrella' with value 'false'

        if (isRaining == true && haveUmbrella == false) // Uses the '&&' (AND) logical operator in a combined expression to evaluate (using the '==' comparison operator) whether or not it is raining (true) AND whether or not someone has an umbrella (false); it is precisely for these two conditions being satisfied that results in the the first block of code after the 'if' being executed.  All other combination of values of balnl and bal result in 
        {
            Console.WriteLine("Take an umbrella!"); // The logical result of it is raining, and someone does not have an umbrella.  For the given values of isRaining and haveUmbrella declared above, this will be the code output (confirmed when the program compiled and run)
        }
        else    // All combination of values other than...will result in the...
        {
            Console.WriteLine("You're good to go!");
        }
        Console.WriteLine();

        // Part 3: Conditional Logic - Movie Ticket Pricing
        Console.WriteLine("Lab 2, Part 3: Conditional Logic - Movie Ticket Pricing");
        Console.WriteLine("Our movie ticket prices are: Under age 5 - free!, Ages 5 to 12 - $5, Ages 13 to 64 - $10, 65 and older - $6");
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());    // Gets the movie-goer's age from console input, using the Parse() method. as a new learning in lieu of the Convert.ToInt32() method 

        if (age < 5)   // Age test for free ticket
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (5 <= age && age <= 12)    // Age test for child ticket
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (13 <= age && age <= 64)   // Age test for standard ticket
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (age >= 65) /* Age test for senior ticket.  An 'else' statement could also be used here as any age 65 or older would fail all preceding age tests and the 'else' condition would be executed.
                               The 'else if' explicity shows the age test (vs. executing this code block due to all previous tests failing) but is it better form to use 'else' as it clearly delineates the end of the comparison chain? */
        {
            Console.WriteLine("Senior ticket: $6");
        }
        Console.WriteLine();

        //Part 4: Using a Switch Statement
        Console.WriteLine("Lab 2, Part 4: Using a Switch Statement");
        Console.WriteLine("Please enter a day of the week (e.g. 1-7)");
        int dayNum = int.Parse(Console.ReadLine();
    }
}
