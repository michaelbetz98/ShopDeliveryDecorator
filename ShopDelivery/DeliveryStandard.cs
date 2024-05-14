using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public class DeliveryStandard : DeliveryDecorator
    {
        public DeliveryStandard(Delivery delivery) : base(delivery)
        {
        }

        public override string Chosen() => base.Chosen() + " Standard";
        public override float Price() => base.Price() + 5.99f;
    }
}
