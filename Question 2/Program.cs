using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> elements = new Dictionary<int, string>();

        elements.Add(1, "Hydrogen");
        elements.Add(2, "Helium");
        elements.Add(3, "Lithium");
        elements.Add(4, "Beryllium");
        elements.Add(5, "Boron");

        Console.WriteLine("Elements List:");

        foreach (var element in elements)
        {
            Console.WriteLine(element.Key + " - " + element.Value);
        }
    }
}