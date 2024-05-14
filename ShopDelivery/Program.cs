namespace ShopDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new DeliveryInStore();
            Console.WriteLine("Do you want it to be delivered? (yes/no)");
            string deliver = Console.ReadLine();
            if(deliver == "yes")
            {
                delivery = new DeliveryStandard(delivery);
            }
            Console.WriteLine("Do you want to have and express delivery? (yes/no)");
            string express = Console.ReadLine();
            if (express == "yes")
            {
                delivery = new DeliveryExpress(delivery);
            }
            Console.WriteLine("Do you want it ina gift box? (yes/no)");
            string gift = Console.ReadLine();
            if (gift == "yes")
            {
                delivery = new DeliveryGiftBox(delivery);
            }
            Console.WriteLine($"{delivery.Chosen()} price: {delivery.Price()}");
            Console.ReadLine();
        }
    }
}
