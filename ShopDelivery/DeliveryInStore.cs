using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public class DeliveryInStore : Delivery
    {
        public override string Chosen() => "Delivery";
        public override float Price() => 0f;
    }
}
