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
        elements.Add(6, "Carbon - Nonmetal");
        elements.Add(7, "Nitrogen - Nonmetal");
        elements.Add(8, "Oxygen - Nonmetal");
        elements.Add(9, "Fluorine - Halogen");
        elements.Add(10, "Neon - Noble Gas");
        elements.Add(11, "Sodium - Alkali Metal");
        elements.Add(12, "Magnesium - Alkaline Earth Metal");
        elements.Add(13, "Aluminium - Metal");
        elements.Add(14, "Silicon - Metalloid");
        elements.Add(15, "Phosphorus - Nonmetal");
        elements.Add(16, "Sulfur - Nonmetal");
        elements.Add(17, "Chlorine - Halogen");
        elements.Add(18, "Argon - Noble Gas");
        elements.Add(19, "Potassium - Alkali Metal");
        elements.Add(20, "Calcium - Alkaline Earth Metal");
        elements.Add(21, "Scandium - Transition Metal");
        elements.Add(22, "Titanium - Transition Metal");
        elements.Add(23, "Vanadium - Transition Metal");
        elements.Add(24, "Chromium - Transition Metal");
        elements.Add(25, "Manganese - Transition Metal");
        elements.Add(26, "Iron - Transition Metal");
        elements.Add(27, "Cobalt - Transition Metal");
        elements.Add(28, "Nickel - Transition Metal");
        elements.Add(29, "Copper - Transition Metal");
        elements.Add(30, "Zinc - Transition Metal");

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