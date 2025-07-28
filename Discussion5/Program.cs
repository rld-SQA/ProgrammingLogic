namespace Discussion5;

/*class electricalBus
{
    public void monitorVoltage(double voltage)
    {
        //while (voltage >= 28.0 && voltage <= 30.0)
        try
        {
            if (voltage >= 28.0 && voltage <= 30.0)
                Console.WriteLine("good");
        }
        catch (Exception e)
        {
            Console.WriteLine("bad");
        }
    }

}*/

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int num = 0;
            int division = 10 / num;    // Code that may throw an exception
        }
        catch (Exception e)
        {
            Console.WriteLine("Division by 0 results in NaN, please set 'num' to a non-zero integer."); // Code that handles the exception
        }    
    }
}
