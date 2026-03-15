using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Periodic Table Program");

        Dictionary<int, string> elements = new Dictionary<int, string>();

        elements.Add(1, "Hydrogen - Nonmetal");
        elements.Add(2, "Helium - Noble Gas");
        elements.Add(3, "Lithium - Alkali Metal");
        elements.Add(4, "Beryllium - Alkaline Earth Metal");
        elements.Add(5, "Boron - Metalloid");

        Console.Write("Enter atomic number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (elements.ContainsKey(number))
        {
            Console.WriteLine("Atomic Number: " + number);
            Console.WriteLine("Element: " + elements[number]);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }
}