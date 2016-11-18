using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class OrderItem : Entity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal OriginalProductCost { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
