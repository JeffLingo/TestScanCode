using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter ESN:");

        string userInput = Console.ReadLine();

        string ESN_len = string.Format("{0:X2}", userInput.Length);
        string convert_ESN = string.Empty;
        foreach (var c in userInput) convert_ESN = convert_ESN + string.Format("{0:X2}", (int)c);

        Console.WriteLine($"ESN：{userInput}");
        Console.WriteLine($"Converted ESN：{ESN_len}{convert_ESN}");

        Console.ReadKey();
    }
}