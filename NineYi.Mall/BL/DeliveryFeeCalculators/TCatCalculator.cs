using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.Mall.BE;

namespace NineYi.Mall.BL.DeliveryFeeCalculators
{
    public class TCatCalculator : IDeliveryFeeCalculator
    {
        public double Calculate(DeliveryEntity item)
        {
            double fee = 0;

            var weight = item.ProductWeight;

            if (weight > 20)
            {
                fee = 400d;
            }
            else
            {
                fee = 100 + weight * 10;
            }

            return fee;
        }
    }
}
