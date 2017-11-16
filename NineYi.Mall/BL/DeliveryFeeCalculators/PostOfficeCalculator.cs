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
            var weightFee = item.ProductWeight * 10 + 80;

            var volumeFee = item.ProductLength * item.ProductHeight * item.ProductWidth * 0.00001 * 110;
            
            return Math.Max(weightFee, volumeFee);
        }
    }
}
