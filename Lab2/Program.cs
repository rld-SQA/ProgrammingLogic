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

        if (isRaining == true && haveUmbrella == false) /* Uses the '&&' (AND) logical operator in a combined expression to evaluate (using the '==' comparison operator) whether or not it is raining (true) AND whether or not someone has an umbrella (false);
        it is precisely for these two conditions being satisfied that results in the the first block of code after the 'if' being executed.  All other combination of values of balnl and bal result in */
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
        Console.WriteLine("Please enter your age for movie ticket pricing:");   // Asks the movie-goer to enter their age in order to calculate the correct ticket price
        int age = int.Parse(Console.ReadLine());    // Gets the movie-goer's age from console input, using the Parse() method as a new learning in lieu of the Convert.ToInt32() method; stores the movie-goer age in integer variable 'age'

        if (age < 5)   // Age test for free ticket (under 5)
        {
            Console.WriteLine("Ticket is free!");   // Displays ticket price if free ticket test is passed
        }
        else if (5 <= age && age <= 12)    // Age test for child ticket (between 5 and 12, inclusive)
        {
            Console.WriteLine("Child ticket: $5");  // Displays ticket price if child ticket test is passed
        }
        else if (13 <= age && age <= 64)   // Age test for standard ticket (between 13 and 64, inclusive)
        {
            Console.WriteLine("Standard ticket: $10");  // Displays ticket price if standard ticket test is passed
        }
        else if (age >= 65) /* Age test for senior ticket (65 or older).  An 'else' statement could also be used here as any age 65 or older would fail all preceding age tests and the 'else' condition would be executed.
                               The 'else if' explicity shows the age test (vs. executing this code block due to all previous tests failing) but is it better form to use 'else' as it clearly delineates the end of the comparison chain? */
        {
            Console.WriteLine("Senior ticket: $6"); // Displays ticket price if senior ticket test is passed
        }
        Console.WriteLine();

        //Part 4: Using a Switch Statement
        Console.WriteLine("Lab 2, Part 4: Using a Switch Statement");
        Console.WriteLine("Please enter a weekday number (e.g. 1-7) to calculate the name of the corresponding day:"); //Asks the user to input a weekday number to calculate the corresponding weekday name
        int dayNum = int.Parse(Console.ReadLine());     // Gets the weekday number from user console input using the Parse() method; stores the weekday number in integer variable 'dayNum'
        switch (dayNum)     // The 'switch'statement and the corresponding value of the expression ('dayNum' in this case) that is used to compare against any number of 'case' code blocks; the 'case' block, if any, which matches the expression of the value is executed
        {
            case 1: // Contains the value, in this case 1, of the first case to be compared to the switch value
                Console.WriteLine("Weekday number 1 corresponds to Monday");    // Code block to be executed if the swith value is 1
                break;  // Command to break out of the switch block if the switch value is 1
            case 2: // Contains the value, in this case 2, of the second case to be compared to the switch value
                Console.WriteLine("Weekday number 2 corresponds to Tuesday");   // Code block to be executed if the switch value is 2
                break;  // Command to break out of the switch block if the switch value is 2
            case 3: // Contains the value, in this case 3, of the third case to be compared to the switch value
                Console.WriteLine("Weekday number 3 corresponds to Wednesday"); // Code block to be executed if the switch value is 3
                break;  // Command to break out of the switch block if the switch value is 3
            case 4: // Contains the value, in this case 4, of the fourth case to be compared to the switch value
                Console.WriteLine("Weekday number 4 corresponds to Thursday");  // Code block to be executed if the switch value is 4
                break;  // Command to break out of the switch block if the switch value is 4
            case 5: // Contains the value, in this case 5, of the fifth case to be compared to the switch value
                Console.WriteLine("Weekday number 5 corresponds to Friday");    // Code block to be executed if the switch value is 5
                break;  // Command to break out of the switch block if the switch value is 5
            case 6: // Contains the value, in this case 6, of the sixth case to be compared to the switch value
                Console.WriteLine("Weekday number 6 corresponds to Saturday");  // Code block to be executed if the switch value is 6
                break;  // Command to break out of the switch block if the switch value is 6
            case 7: // Contains the value, in this case 7, of the seventh case to be compared to the switch value
                Console.WriteLine("Weekday number 7 corresponds to Sunday");    // Code block to be executed if the switch value is 7
                break;  // Command to break out of the switch block if the switch value is 7
            default:    // An optional command used to specify code to be executed if there is no case match 
                Console.WriteLine("Invalid day!");  // Code to be executed if there is no case match above
                break;  // Command to break out of the switch block at its end
        }
    }
}
