namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        /* Name: Rich DeLoof
        Title: IT-1050 - Lab 3 */

        // Lab 3, Problem 1: Simple For Loop
        // A for loop that prints the numbers from 1 to 10, each on a new line
        Console.WriteLine("Lab 3, Problem 1: Simple For Loop");
        Console.WriteLine("A for loop that prints the numbers from 1 to 10, each on a new line");
        Console.WriteLine("=========================================================================");
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine();


        // Lab 3, Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        // A for loop that loops from 1 to 20, incrementing by 1 each time; uses an 'if' statement and the modulus operator
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Lab 3, Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)");
        Console.WriteLine("Outputs even values from 1 to 20, using a for loop and modulus operator");
        Console.WriteLine();

        for (int j = 1; j < 21; j++)
        {
            if (j % 2 == 0)
            {
                Console.WriteLine(j);
            }
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine();

        /* The code block below does the same thing but using a while loop
            int j = 1;
            while (j < 21)
            {
                if ((j % 2) == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine();
           */


        // Lab 3, Problem 3: While Loop Countdown
        // This program executes a while loop that prints numbers from 5 down to 1, counting backward (using the decrement operator)
        Console.WriteLine("Lab 3, Problem 3: While Loop Countdown");
        Console.WriteLine("A while loop that prints numbers from 5 down to 1, counting backward (using the decrement operator)");
        Console.WriteLine();

        int k = 5;
        while (k >= 1)
        {
            Console.WriteLine(k);
            k--;
        }
        Console.WriteLine();


        // Lab 3, Problem 4: While Loop - Multiples of 10 from 10 to 1000
        // Uses a while loop to print all multiples of 10 starting at 10 and ending at 1000 (inclusive)
        Console.WriteLine("Lab 3, Problem 4: While Loop - Multiples of 10 from 10 to 1000");
        Console.WriteLine("Uses a while loop to print all multiples of 10 starting at 10 and ending at 1000 (inclusive)");
        Console.WriteLine();

        int l = 10;
        while (l <= 1000)
        {
            Console.WriteLine(l);
            l = l + 10;
        }
        Console.WriteLine();


        // Lab 3, Problem 5: Seasons of the Year
        // Uses a string array and a foreach loop to display the seasons of the year
        Console.WriteLine("Lab 3, Problem 5: Seasons of the Year");
        Console.WriteLine("Uses a string array and a foreach loop to display the seasons of the year");
        Console.WriteLine();

        string[] seasons = new string[4];    /* The array values could also be assigned using {"Spring", "Summer", "Fall", "Winter"}, appended to this initialization line.
                                                That would be my personal preference as a C# programmer. */

        seasons[0] = "Spring";
        seasons[1] = "Summer";
        seasons[2] = "Fall";
        seasons[3] = "Winter";

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        Console.WriteLine();


        // Lab 3, Problem 6: Days of the Week (1-7)
        // Creates an array to hold the names of the days of the week.  Asks user to enter a weekday number (e.g., 1-7) and displays the corresponding day name using a switch code block.
        Console.WriteLine("Lab 3, Problem 6: Days of the Week (1-7)");
        Console.WriteLine("Creates an array to hold the names of the days of the week.  Asks user to enter a weekday number (e.g., 1-7) and displays the corresponding day name using a switch code block.");
        Console.WriteLine();

        string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }; // Create and initialize array, and assign values.  The '7' could be omitted in this case

        Console.WriteLine("Please enter a weekday number (e.g. 1-7) to display the name of the corresponding day:"); //Asks the user to input a weekday number to display the corresponding weekday name
        int dayNum = int.Parse(Console.ReadLine());     // Gets the weekday number from user console input using the Parse() method; stores the weekday number in integer variable 'dayNum'
        switch (dayNum)
        {
            case 1:
                Console.WriteLine("Weekday number 1 corresponds to " + days[0]);
                break;
            case 2:
                Console.WriteLine("Weekday number 2 corresponds to " + days[1]);
                break;
            case 3:
                Console.WriteLine("Weekday number 3 corresponds to " + days[2]);
                break;
            case 4:
                Console.WriteLine("Weekday number 4 corresponds to " + days[3]);
                break;
            case 5:
                Console.WriteLine("Weekday number 5 corresponds to " + days[4]);
                break;
            case 6:
                Console.WriteLine("Weekday number 6 corresponds to " + days[5]);
                break;
            case 7:
                Console.WriteLine("Weekday number 7 corresponds to " + days[6]);
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
        Console.WriteLine();


        // Lab 3, Problem 7: Favorite Books and Authors
        // Creates two arrays, one for favorite book titles and one for corresponding authors of each book.  Uses a for loop to print each book title followed by the author's name.
        Console.WriteLine("Lab 3, Problem 7: Favorite Books and Authors");
        Console.WriteLine("Creates two arrays, one for favorite book titles and one for corresponding authors of each book.  Uses a for loop to print each book title followed by the author's name.");

        string[] titles = new string[3];
        titles[0] = "Macbeth";
        titles[1] = "SysML Distilled";
        titles[2] = "Fundamentals of Aerodynamics";

        string[] authors = new string[3];
        authors[0] = "William Shakespeare";
        authors[1] = "Lenny Delligatti";
        authors[2] = "John Anderson";

        Console.WriteLine();
        Console.WriteLine("Here is each book title and its corresponding author:");
        Console.WriteLine();

        for (int m = 0; m < 3; m++)
        {
            Console.WriteLine(titles[m] + " by " + authors[m]);
        }
        Console.WriteLine();


        // Lab 3, Problem 8: Temperature Tracker
        // Creates an interger array with 5 temperature values.  Uses Array.Sort() to print them in ascending order.  Prints the highest and lowest temperatures
        Console.WriteLine("Lab 3, Problem 8: Temperature Tracker");
        Console.WriteLine("Creates an interger array with 5 temperature values (degrees Fahrenheit).  Uses Array.Sort() to print them in ascending order.  Prints the highest and lowest temperatures.");
        Console.WriteLine();

        int[] temps = new int[5] { 95, 20, 76, 44, 51 };

        Console.WriteLine("Unsorted temperatures (degrees Fahrenheit): ");
        foreach (int temp in temps)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();

        Array.Sort(temps);

        Console.WriteLine();
        Console.WriteLine("Temperatures (degrees Fahrenheit) sorted in ascending order:");
        foreach (int temp in temps)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temps[4] + " degrees Fahrenheit");  // After sorting in ascending order we know that the highest temperature will be the last element of the array
        Console.WriteLine("Lowest Temperature: " + temps[0] + " degrees Fahrenheit");   // After sorting in ascending order we know that the lowest temperature will be the first element of the array
        Console.WriteLine();


        // Lab 3, Problem 9: Reverse Countdown
        // Uses Array.Reverse() to perform a reverse countdown and display the new order using a for loop
        Console.WriteLine("===================================");
        Console.WriteLine("Lab 3, Problem 9: Reverse Countdown");
        Console.WriteLine("Uses Array.Reverse() to perform a reverse countdown and display the new order using a for loop");

            
    }
}
