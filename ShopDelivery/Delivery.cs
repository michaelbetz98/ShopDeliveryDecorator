using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDelivery
{
    public abstract class Delivery
    {
        public abstract string Chosen();
        public abstract float Price();
    }
}
