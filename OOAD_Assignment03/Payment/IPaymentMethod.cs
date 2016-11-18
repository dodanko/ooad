using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial interface IPaymentMethod
    {
        ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest);
        CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest);
    }
}
