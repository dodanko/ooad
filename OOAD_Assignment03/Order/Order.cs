using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class Order : Entity
    {
        private ICollection<OrderItem> _orderItems;

        public int StoreId { get; set; }
        public int CustomerId { get; set; }

        public int BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? PickupAddressId { get; set; }

        public bool PickUpInStore { get; set; }

        public int OrderStatusId { get; set; }
        public int ShippingStatusId { get; set; }
        public int PaymentStatusId { get; set; }

        public string PaymentMethodSystemName { get; set; }

        public string CustomerCurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }

        public string VatNumber { get; set; }
        public decimal OrderDiscount { get; set; }
        public decimal OrderTotal { get; set; }

        public int CustomerLanguageId { get; set; }
        public string CustomerIp { get; set; }

        public string CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardCvv2 { get; set; }
        public string CardExpirationMonth { get; set; }
        public string CardExpirationYear { get; set; }

        public string AuthorizationTransactionId { get; set; }
        public string AuthorizationTransactionResult { get; set; }
        public string CaptureTransactionId { get; set; }
        public string CaptureTransactionResult { get; set; }

        public DateTime? PaidDateUtc { get; set; }
        public string ShippingMethod { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address BillingAddress { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual Address PickupAddress { get; set; }

        public virtual ICollection<OrderItem> OrderItems
        {
            get { return _orderItems ?? (_orderItems = new List<OrderItem>()); }
            protected set { _orderItems = value; }
        }
    }
}
