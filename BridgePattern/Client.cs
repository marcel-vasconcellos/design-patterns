using System;

namespace BridgePattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            // Decouple an abstraction from its implementation
            // so that the two can vary independently.
            Console.WriteLine("***Bridge Pattern Demo***");
            Console.WriteLine("Verifying the market price of a television.");
            ElectronicGoods eItem = new Television();
            eItem.ProductType = "Sony Television";

            IPrice price = new OnlinePrice();
            eItem.Price = price;
            eItem.Details();
            price = new ShowroomPrice();
            eItem.Price = price;
            eItem.Details();
        }
    }
}
