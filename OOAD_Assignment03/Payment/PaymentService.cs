using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class PaymentService : IPaymentService
    {
        #region Fields
        #endregion
        #region Ctor
        public PaymentService()
        {
        }

        #endregion

        #region Methods
        public virtual IList<IPaymentMethod> LoadActivePaymentMethods(int? filterByCustomerId = null, int storeId = 0, int filterByCountryId = 0)
        {
            return LoadAllPaymentMethods(storeId, filterByCountryId);
        }
        public virtual IPaymentMethod LoadPaymentMethodBySystemName(string systemName)
        {
            return null;
        }

        public virtual IList<IPaymentMethod> LoadAllPaymentMethods(int storeId = 0, int filterByCountryId = 0)
        {
            var paymentMetodsByCountry = new List<IPaymentMethod>();
            return paymentMetodsByCountry;
        }

        public virtual ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest)
        {
            var paymentMethod = LoadPaymentMethodBySystemName(processPaymentRequest.PaymentMethodSystemName);
            if (paymentMethod == null)
                throw new Exception("Payment method couldn't be loaded");
            return paymentMethod.ProcessPayment(processPaymentRequest);
        }

        public virtual CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest)
        {
            var paymentMethod = LoadPaymentMethodBySystemName(capturePaymentRequest.Order.PaymentMethodSystemName);
            if (paymentMethod == null)
                throw new Exception("Payment method couldn't be loaded");
            return paymentMethod.Capture(capturePaymentRequest);
        }

        #endregion
    }
}
