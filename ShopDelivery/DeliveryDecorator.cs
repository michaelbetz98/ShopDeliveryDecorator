using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public class DeliveryDecorator : Delivery
    {
        private Delivery _delivery;

        public DeliveryDecorator(Delivery delivery)
        {
            _delivery = delivery;
        }

        public override string Chosen() => _delivery.Chosen();
        public override float Price() => _delivery.Price();
    }
}
