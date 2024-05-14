using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public class DeliveryExpress : DeliveryDecorator
    {
        public DeliveryExpress(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " Express";
        public override float Price() => base.Price() + 9.99f;
    }
}
