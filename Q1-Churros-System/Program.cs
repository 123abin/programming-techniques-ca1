using System;
using System.Collections.Generic;

class Program
{
    // The Queue to store orders
    static Queue<Order> orderQueue = new Queue<Order>();

    // The order number counter
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

            if (choice == 1)
            {
                PlaceOrder();
            }
            else if (choice == 2)
            {
                DeliverOrder();
            }

        } while (choice != 0);
    }

    // Method to place order
    static void PlaceOrder()
    {
        Console.WriteLine("\nChoose Churros Type:");
        Console.WriteLine("1. Plain Sugar (€6)");
        Console.WriteLine("2. Cinnamon Sugar (€6)");
        Console.WriteLine("3. Chocolate Sauce (€8)");
        Console.WriteLine("4. Nutella (€8)");

        Console.Write("Enter option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        string item = "";
        double price = 0;

        if (option == 1)
        {
            item = "Plain Sugar";
            price = 6;
        }
        else if (option == 2)
        {
            item = "Cinnamon Sugar";
            price = 6;
        }
        else if (option == 3)
        {
            item = "Chocolate Sauce";
            price = 8;
        }
        else if (option == 4)
        {
            item = "Nutella";
            price = 8;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Create new order
        Order newOrder = new Order(orderNumber, item, qty, price);

        Console.WriteLine("Total Bill: €" + newOrder.Getbill());

        // Add order to queue
        orderQueue.Enqueue(newOrder);

        Console.WriteLine("Your Order Number: " + orderNumber);

        orderNumber++;
    }

    // Method to deliver order
    static void DeliverOrder()
    {
        if (orderQueue.Count > 0)
        {
            Order ord = orderQueue.Dequeue();
            ord.Collectorder();
        }
        else
        {
            Console.WriteLine("No orders in queue.");
        }
    }
}

public class Order
{
    public int orderNumber;
    public string itemName;
    public int quantity;
    public double totalbill;

    // constructor
    public Order(int number, string name, int qty, double price)
    {
        orderNumber = number;
        itemName = name;
        quantity = qty;
        totalbill = qty * price;
    }

    // method to return bill
    public double Getbill()
    {
        return totalbill;
    }

    // method when order is collected
    public void Collectorder()
    {
        Console.WriteLine("Order " + orderNumber + " is ready to collect.");
    }
}

public class Churros
{
    public string name;
    public double price;

    // constructor
    public Churros(string n, double p)
    {
        name = n;
        price = p;
    }
}
