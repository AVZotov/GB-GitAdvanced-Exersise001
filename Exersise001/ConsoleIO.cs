﻿using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace Exersise001;

public abstract class ConsoleIO
{
    public static string? GetUserInput()
    {
        return Console.ReadLine();
    }
}

