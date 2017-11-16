using System;
using NineYi.Mall.BE;
using NineYi.Mall.BL.DeliveryFeeCalculators;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 宅配Service
    /// </summary>
    public class DeliveryService
    {
        private IDeliveryFeeCalculator _deliveryFeeCalculator { get; set; }

        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            if (deliveryItem == null)
            {
                throw new ArgumentException("請檢查 deliveryItem 參數");
            }

            var fee = default(double);

            if (deliveryItem.DeliveryType == DeliveryTypeEnum.TCat)
            {
                this._deliveryFeeCalculator = new TCatCalculator();
            }
            else if (deliveryItem.DeliveryType == DeliveryTypeEnum.KTJ)
            {
                this._deliveryFeeCalculator = new KTJCalculator();
            }
            else if (deliveryItem.DeliveryType == DeliveryTypeEnum.PostOffice)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new ArgumentException("請檢查 deliveryItem.DeliveryType 參數");
            }

            fee = this._deliveryFeeCalculator.Calculate(deliveryItem);

            return fee;
        }
    }
}
