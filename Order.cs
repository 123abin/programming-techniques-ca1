using System;

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