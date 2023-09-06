using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperAndEFcore.Service.EFcore
{
    public class OrderService
    {
        private readonly ShopDB _db;

        public OrderService() 
        {
            _db = new ShopDB();
        }
        public void AddOrder(Order order) 
        {
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }
        public void RemoveOrder(int orderId)
        {
            var entity = GetOrderById(orderId);
            if (entity != null)
            {
                _db.Orders.Remove(entity);
                _db.SaveChanges();
            }
        }
        public void UpdateOrder(Order order)
        {
            if(order != null)
            {
                _db.Orders.Update(order);
                _db.SaveChanges();
            }
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _db.Orders.ToList();
        }
        public Order GetOrderById(int orderId) 
        {
            return _db.Orders.FirstOrDefault(o => o.Id == orderId);
        }
    }
}
