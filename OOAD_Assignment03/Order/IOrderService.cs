using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial interface IOrderService
    {
        Order GetOrderById(int orderId);
        IList<Order> GetOrdersByIds(int[] orderIds);
        void DeleteOrder(Order order);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
    }
}
