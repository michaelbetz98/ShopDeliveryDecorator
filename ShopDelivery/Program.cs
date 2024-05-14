namespace ShopDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new DeliveryInStore();
            Console.WriteLine($"{delivery.Chosen()} price: {delivery.Price()}" );

            var deliverStandard = new DeliveryStandard(delivery);
            Console.WriteLine($"{deliverStandard.Chosen()} price: {deliverStandard.Price()}");

            var deliveryExpress = new DeliveryExpress(deliverStandard);
            Console.WriteLine($"{deliveryExpress.Chosen()} price: {deliveryExpress.Price()}");

            var deliveryExpressGiftBox = new DeliveryGiftBox(deliveryExpress);
            Console.WriteLine($"{deliveryExpressGiftBox.Chosen()} price: {deliveryExpressGiftBox.Price()}");
        }
    }
}
