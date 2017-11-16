using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.Mall.BE;

namespace NineYi.Mall.BL.DeliveryFeeCalculators
{
    public class KTJCalculator : IDeliveryFeeCalculator
    {
        public double Calculate(DeliveryEntity item)
        {
            double fee = 0;

            var length = item.ProductLength;
            var width = item.ProductWidth;
            var height = item.ProductHeight;
            var size = length * width * height;

            if (length > 50 || width > 50 || height > 50)
            {
                fee = size * 0.00001 * 110 + 50;
            }
            else
            {
                fee = size * 0.00001 * 120;
            }

            return fee;
        }
    }
}
