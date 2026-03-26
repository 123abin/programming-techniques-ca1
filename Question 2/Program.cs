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
        elements.Add(6, ("Carbon", "Nonmetal"));
        elements.Add(7, ("Nitrogen", "Nonmetal"));
        elements.Add(8, ("Oxygen", "Nonmetal"));
        elements.Add(9, ("Fluorine", "Halogen"));
        elements.Add(10, ("Neon", "Noble gas"));
        elements.Add(11, ("Sodium", "Alkali metal"));
        elements.Add(12, ("Magnesium", "Alkaline earth metal"));
        elements.Add(13, ("Aluminium", "Metal"));
        elements.Add(14, ("Silicon", "Metalloid"));
        elements.Add(15, ("Phosphorus", "Nonmetal"));
        elements.Add(16, ("Sulfur", "Nonmetal"));
        elements.Add(17, ("Chlorine", "Halogen"));
        elements.Add(18, ("Argon", "Noble gas"));
        elements.Add(19, ("Potassium", "Alkali metal"));
        elements.Add(20, ("Calcium", "Alkaline earth metal"));
        elements.Add(21, ("Scandium", "Transition metal"));
        elements.Add(22, ("Titanium", "Transition metal"));
        elements.Add(23, ("Vanadium", "Transition metal"));
        elements.Add(24, ("Chromium", "Transition metal"));
        elements.Add(25, ("Manganese", "Transition metal"));
        elements.Add(26, ("Iron", "Transition metal"));
        elements.Add(27, ("Cobalt", "Transition metal"));
        elements.Add(28, ("Nickel", "Transition metal"));
        elements.Add(29, ("Copper", "Transition metal"));
        elements.Add(30, ("Zinc", "Transition metal"));


        Console.WriteLine("Elements List:");

        foreach (var element in elements)
{
    Console.WriteLine(element.Key + " - " + element.Value.Name + " (" + element.Value.Type + ")");
}

char choice;

do
{
    Console.WriteLine("\nEnter element number to search:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (elements.ContainsKey(number))
    {
        var element = elements[number];
        Console.WriteLine("Atomic Number: " + number);
        Console.WriteLine("Name: " + element.Name);
        Console.WriteLine("Class: " + element.Type);
    }
    else
    {
        Console.WriteLine("Element not found");
    }

        Console.WriteLine("\nDo you want to know more elements? (y/n):");
    string input = Console.ReadLine() ?? "n";
    choice = input[0];

} while (choice == 'y' || choice == 'Y');

        Console.WriteLine("Thanks!");

    }
}