using System;
using System.Collections.Generic;
class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();
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

    Order newOrder = new Order(orderNumber, item, qty, price);

    Console.WriteLine("Total Bill: €" + newOrder.GetBill());

    orderQueue.Enqueue(newOrder);

    Console.WriteLine("Your Order Number: " + orderNumber);

    orderNumber++;
}

     static void DeliverOrder()
    {
        if (orderQueue.Count > 0)
        {
            Order orderToDeliver = orderQueue.Dequeue();
            orderToDeliver.CollectOrder();
        }
        else
        {
            Console.WriteLine("No orders in the queue.");
        }

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

