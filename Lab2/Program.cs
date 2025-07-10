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

    }
}
