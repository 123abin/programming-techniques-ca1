using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, (string Name, string Type)> elements = new Dictionary<int, (string, string)>();
        
        elements.Add(1, ("Hydrogen", "Nonmetal"));
        elements.Add(2, ("Helium", "Noble gas"));
        elements.Add(3, ("Lithium", "Alkali metal"));
        elements.Add(4, ("Beryllium", "Alkaline earth metal"));
        elements.Add(5, ("Boron", "Metalloid"));

        Console.WriteLine("Elements List:");

        foreach (var element in elements)
{
    Console.WriteLine(element.Key + " - " + element.Value.Name + " (" + element.Value.Type + ")");
}
    }
}