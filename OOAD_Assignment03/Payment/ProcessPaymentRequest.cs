using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class ProcessPaymentRequest
    {
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderTotal { get; set; }
        public string PaymentMethodSystemName { get; set; }

        public string CreditCardType { get; set; }
        public string CreditCardName { get; set; }
        public string CreditCardNumber { get; set; }
        public int CreditCardExpireYear { get; set; }
        public int CreditCardExpireMonth { get; set; }
        public string CreditCardCvv2 { get; set; }
    }
}
