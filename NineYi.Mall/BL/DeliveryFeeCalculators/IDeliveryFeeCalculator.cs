using NineYi.Mall.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BL.DeliveryFeeCalculators
{
    public interface IDeliveryFeeCalculator
    {
        double Calculate(DeliveryEntity item);
    }
}
