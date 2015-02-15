using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AcceptANum
{
    public AcceptANum(int n)
    {
        if (n <= 10)
            Console.WriteLine("Number " + "is valid.");
        else
            throw new Exception(n + " is invalid. Number must be less than or equal to 10.");
    }
}

public class AcceptANumTester
{
    public static void Main(String[] args)
    {
        int trial = 5;

        try
        {
            AcceptANum test = new AcceptANum(trial);
        }
        catch (Exception ex)
        {
            Console.WriteLine(trial + " is invalid.  Number must be less than or equal to 10");
        }

        trial = 11;
        try
        {
            AcceptANum test = new AcceptANum(trial);
        }
        catch (Exception ex)
        {
            Console.WriteLine(trial + " is invalid.  Number must be less than or equal to 10");
        }

        Console.WriteLine("Program ended successfully.");
    }
}
