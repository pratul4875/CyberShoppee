using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShoppeeApi.CyberShoppeeRepository;
using CyberShoppeeApi.CyberShoppeeRepository.OrdersRepository;

namespace CyberShoppeeApi.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        private IOrderRepository _orderRepository = new OrderRepository();
        [Route("")]
        public IHttpActionResult GetAllOrders()
        {
            try {
                return Ok(_orderRepository.GetAllOrders());
            }
            catch (ProductDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
            
        }
        [Route("{id}")]
        public IHttpActionResult GetOrderById(int id)
        {
            try
            {
                return Ok(_orderRepository.GetOrderById(id));
            }
            catch (OrderDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
