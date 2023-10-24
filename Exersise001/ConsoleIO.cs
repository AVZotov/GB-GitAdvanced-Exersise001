using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace Exersise001;

public abstract class ConsoleIO
{
    public static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    public static string? GetUserInput()
    {
        return Console.ReadLine();
    }


    public static void PrintDate()
    {
        System.Console.WriteLine(DateTime.Now);
    }
}

