using System;

class Program
{
    static int orderNumber = 1;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Delicious Churros ---");
            Console.WriteLine("1. Place Order");
            Console.WriteLine("2. Deliver Order");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice != 0);
    }
}

public class Order
{
    public int orderNumber;
    public string itemName;
    public int quantity;
    public double totalbill;

    public Order(int number, string name, int qty, double price)
    {
        orderNumber = number;
        itemName = name;
        quantity = qty;
        totalbill = qty * price;
    }

    public double GetBill()
    {
        return totalbill;
    }

    public void CollectOrder()
    {
        Console.WriteLine("Order " + orderNumber + " is ready to collect.");
    }
}
