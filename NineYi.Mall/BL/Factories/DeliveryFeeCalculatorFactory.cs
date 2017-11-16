using NineYi.Mall.BE;
using NineYi.Mall.BL.DeliveryFeeCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.Mall.BL.Factories
{
    /// <summary>
    /// 取得運費計算方式的簡單工廠
    /// </summary>
    public static class DeliveryFeeCalculatorFactory
    {
        public static IDeliveryFeeCalculator GetCalculator(DeliveryTypeEnum deliveryType)
        {
            switch (deliveryType)
            {
                case DeliveryTypeEnum.TCat:
                    return new TCatCalculator();

                case DeliveryTypeEnum.KTJ:
                    return new KTJCalculator();

                case DeliveryTypeEnum.PostOffice:
                    return new PostOfficeCalculator();

                default:
                    throw new ArgumentException("DeliveryType沒有對應的運費計算器:{0}", deliveryType.ToString());
            }
        }
    }
}
