using System;
using NineYi.Mall.BE;
using NineYi.Mall.BL.DeliveryFeeCalculators;
using NineYi.Mall.BL.Factories;

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
                throw new ArgumentNullException("DeliveryItem不應為null");
            }

            //// 取得運費計算方式
            this._deliveryFeeCalculator = DeliveryFeeCalculatorFactory.GetCalculator(deliveryItem.DeliveryType);

            //// 計算運費
            var fee = this._deliveryFeeCalculator.Calculate(deliveryItem);

            return fee;
        }
    }
}
