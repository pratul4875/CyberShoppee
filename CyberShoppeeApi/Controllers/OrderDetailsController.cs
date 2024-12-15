using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShoppeeApi.CyberShoppeeRepository;
using CyberShoppeeApi.CyberShoppeeRepository.OrderDetailsRepository;

namespace CyberShoppeeApi.Controllers
{
    [RoutePrefix("api/orderdetails")]
    public class OrderDetailsController : ApiController
    {
        private IOrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        public IHttpActionResult GetAllOrderDetails()
        {
            try
            {
                return Ok(_orderDetailRepository.GetAllOrderDetails());
            }
            catch (OrderDetailDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
        [Route("{id}")]
        public IHttpActionResult GetOrderDetailById(int id)
        {
            try
            {
                return Ok(_orderDetailRepository.GetOrderDetailById(id));
            }
            catch (OrderDetailDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
