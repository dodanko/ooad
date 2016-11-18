using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial interface IPaymentService
    {
        IList<IPaymentMethod> LoadActivePaymentMethods(int? filterByCustomerId = null, int storeId = 0, int filterByCountryId = 0);
        IList<IPaymentMethod> LoadAllPaymentMethods(int storeId = 0, int filterByCountryId = 0);
        ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest);
        CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest);
    }
}
