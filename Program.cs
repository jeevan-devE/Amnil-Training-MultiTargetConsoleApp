using System;

class Program
{
    static void Main()
    {
#if NET5_0
            Console.WriteLine("Running on .NET 5.0");
#elif NET6_0
            Console.WriteLine("Running on .NET 6.0");
#elif NET7_0
            Console.WriteLine("Running on .NET 7.0");
#else
        Console.WriteLine("Running on an unknown version");
#endif
        Console.WriteLine("Hello, World!");
    }
}
