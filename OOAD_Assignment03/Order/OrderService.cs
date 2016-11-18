using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    class OrderService
    {
        #region Fields
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderItem> _orderItemRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Customer> _customerRepository;
        #endregion

        #region Ctor
        public OrderService(IRepository<Order> orderRepository,
            IRepository<OrderItem> orderItemRepository,
            IRepository<Product> productRepository,
            IRepository<Customer> customerRepository)
        {
            this._orderRepository = orderRepository;
            this._orderItemRepository = orderItemRepository;
            this._productRepository = productRepository;
            this._customerRepository = customerRepository;
        }
        #endregion

        #region Methods
        public virtual Order GetOrderById(int orderId)
        {
            if (orderId == 0)
                return null;

            return _orderRepository.GetById(orderId);
        }

        public virtual IList<Order> GetOrdersByIds(int[] orderIds)
        {
            if (orderIds == null || orderIds.Length == 0)
                return new List<Order>();

            var query = from o in _orderRepository.Table
                        where orderIds.Contains(o.Id)
                        select o;
            var orders = query.ToList();

            return orders;
        }

        public virtual void DeleteOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order");

            order.Deleted = true;
            UpdateOrder(order);
        }

        public virtual void InsertOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order");

            _orderRepository.Insert(order);
        }

        public virtual void UpdateOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order");

            _orderRepository.Update(order);
        }

        public virtual OrderItem GetOrderItemById(int orderItemId)
        {
            if (orderItemId == 0)
                return null;

            return _orderItemRepository.GetById(orderItemId);
        }

        public virtual void DeleteOrderItem(OrderItem orderItem)
        {
            if (orderItem == null)
                throw new ArgumentNullException("orderItem");

            _orderItemRepository.Delete(orderItem);
        }

        #endregion
    }
        
}
