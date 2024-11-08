using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public class MockPaymentProcessor : IPaymentProcessor
    {
        public TransactionResult ProcessPayment(int amount)
        {

            Thread.Sleep(5000);

            // 결제가 성공한 것으로 가정한 결과 반환
            return new TransactionResult
            {
                IsSuccess = true,
                ApprovedAmount = amount,
                ErrorMessage = null
            };
        }

        public TransactionResult CancelPayment(int amount)
        {
            // 결제 취소가 성공한 것으로 가정한 결과 반환
            return new TransactionResult
            {
                IsSuccess = true,
                ApprovedAmount = 0,
                ErrorMessage = null
            };
        }
    }

}
