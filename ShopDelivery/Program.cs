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

    public abstract class DeliveryDecorator : Delivery
    {
        private Delivery _delivery;

        public DeliveryDecorator(Delivery delivery)
        {
            _delivery = delivery;
        }

        public override string Chosen() => _delivery.Chosen();
        public override float Price() => _delivery.Price();
    }
    public class DeliveryStandard : DeliveryDecorator
    {
        public DeliveryStandard(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " Standard";
        public override float Price() => base.Price() + 5.99f;
    }

    public class DeliveryExpress : DeliveryDecorator
    {
        public DeliveryExpress(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " Express";
        public override float Price() => base.Price() + 9.99f;
    }

    public class DeliveryGiftBox : DeliveryDecorator
    {
        public DeliveryGiftBox(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " GiftBox";
        public override float Price() => base.Price() + 3.99f;
    }
}
