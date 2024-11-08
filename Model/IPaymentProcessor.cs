using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public interface IPaymentProcessor
    {
        TransactionResult ProcessPayment(int amount);
        TransactionResult CancelPayment(int amount);
    }

}
