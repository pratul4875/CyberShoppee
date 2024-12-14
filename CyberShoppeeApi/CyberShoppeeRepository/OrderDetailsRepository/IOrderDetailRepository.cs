using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberShoppeeDataAccessLayer.Entity;

namespace CyberShoppeeApi.CyberShoppeeRepository.OrderDetailsRepository
{
    internal interface IOrderDetailRepository
    {
         IEnumerable<OrderDetail> GetAllOrderDetails();
         OrderDetail GetOrderDetailById(int id);
    }
}
