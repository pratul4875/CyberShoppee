using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShoppeeApi.CyberShoppeeRepository.CustomersRepository;

namespace CyberShoppeeApi.Controllers

{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private ICustomerRepository _customerRepository = new CustomerRepository();



        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
