using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public class DeliveryGiftBox : DeliveryDecorator
    {
        public DeliveryGiftBox(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " GiftBox";
        public override float Price() => base.Price() + 3.99f;
    }
}
