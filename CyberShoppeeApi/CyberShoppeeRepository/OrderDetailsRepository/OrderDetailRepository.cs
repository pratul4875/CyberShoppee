using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberShoppeeDataAccessLayer.CyberShoppeeContext;
using CyberShoppeeDataAccessLayer.Entity;

namespace CyberShoppeeApi.CyberShoppeeRepository.OrderDetailsRepository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private CyberShoppeeContext context = new CyberShoppeeContext();
        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            var orderDetails = context.OrderDetails.ToList();
            if (orderDetails.Count == 0)
            {
                throw new OrderDetailDataUnavailableException("No Order Details Available");
            }
            return orderDetails;
        }

        public OrderDetail GetOrderDetailById(int id)
        {
           OrderDetail orderDetail = context.OrderDetails.Find(id);
            if (orderDetail == null)
            {
                throw new OrderDetailDataUnavailableException("No Order Details Available");
            }
            return orderDetail;
        }
    }
}