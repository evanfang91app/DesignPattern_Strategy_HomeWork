using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.Mall.BE;

namespace NineYi.Mall.BL.DeliveryFeeCalculators
{
    public class PostOfficeCalculator : IDeliveryFeeCalculator
    {
        public double Calculate(DeliveryEntity item)
        {
            if (item.ProductLength == 30)
            {
                return 330;
            }
            else if (item.ProductLength == 60)
            {
                return 316.8;
            }

            return 0;
        }
    }
}
