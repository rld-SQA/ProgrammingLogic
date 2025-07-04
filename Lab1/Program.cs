namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        // Name: Rich DeLoof
        // Title: IT-1050-Lab 1

        // Step 2 - Basic Output
        Console.WriteLine("Rich DeLoof, IT-1050 - Programming Logic");
        Console.WriteLine();

        // Step 3 - Declare and Use Variables
        //Console.WriteLine("Step 2 - Declare and Use Variables");
        int faveNum = 12;
        string faveProgLang = "C#";
        double numProgs = 100.0D;
        bool progExp = true;
        Console.WriteLine("My favorite number is " + faveNum);
        Console.WriteLine("My favorite programming language is " + faveProgLang);
        Console.WriteLine("The number of programs I've written previously is approximately " + numProgs);
        Console.WriteLine("Programming experience? " + progExp);
        Console.WriteLine();

        // Step 4 - Use Constants
        const string schoolName = "Tri-C";
        Console.WriteLine("My school is " + schoolName);
        Console.WriteLine();

        // Step 5 - Type Casting
        double tcVar = 9.78;
        int toInt = (int)tcVar;
        Console.WriteLine("double: " + tcVar);
        Console.WriteLine("integer: " + toInt);
        Console.WriteLine("Convert int to a string: " + Convert.ToString(faveNum));    //Integer variable 'faveNum' declared in Step 3
        Console.WriteLine("Convert bool to a string: " + Convert.ToString(progExp));    //Boolean variable 'proExp' declared in Step 3
        Console.WriteLine();

        // Step 6 - User Input and Type Conversion
        //Console.WriteLine("Enter your name:");
        //string name = Console.ReadLine();
        //Console.WriteLine("Enter your age:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Hello " + name + ", " + age + " is a good age!");
        //Console.WriteLine();

        // Step 7 - Arithmetic Operators
        int num1 = 27;
        int num2 = 48;
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
        int sum1 = num1 + 10;
        int sum2 = num2 + 10;
        Console.WriteLine("num1 plus 10: " + sum1);
        Console.WriteLine("num2 plus 10: " + sum2);
        int diff1 = num1 - 2;
        int diff2 = num2 - 2;
        Console.WriteLine("num1 minus 2: " + diff1);
        Console.WriteLine("num2 minus 2: " + diff2);
        int prod1 = num1 * 3;
        int prod2 = num2 * 3;
        Console.WriteLine("num1 times 3: " + prod1);
        Console.WriteLine("num2 times 3: " + prod2);
        double div1 = Convert.ToDouble(num1) / 2;
        double div2 = Convert.ToDouble(num2) / 2;
        Console.WriteLine("num1 divided by 2: " + div1);
        Console.WriteLine("num2 divided by 2: " + div2);
        int mod1 = num1 % 2;
        int mod2 = num2 % 2;
        Console.WriteLine("num1 modulus 2: " + mod1);
        Console.WriteLine("num2 modulus 2: " + mod2);
        Console.WriteLine();

        // Step 8 - Floating Point Precision
        float test = 1.123456789F;
        double test1 = 1.123456789D;
        Console.WriteLine("float: " + test);
        Console.WriteLine("double: " + test1);
        Console.WriteLine("Higher precision is obtained with double precision variables");
        Console.WriteLine();

        //Step 9 - Increment and Decrement
        int x = 10;
        Console.WriteLine("Starting value: " + x);
        int inc = x++;
        Console.WriteLine("Increment operator results in: " + x);
        int dec = x--;
        Console.WriteLine("Decrement operator results in: " + x);


        //The code below was used when setting up the codespace in GitHub, retained here but commented out
        //string name = "Rich";
        //Console.WriteLine("Hello. " + name + "!");
        //Console.WriteLine("Welcome to IT-1050!");
    }
}