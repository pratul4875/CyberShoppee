using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShoppeeApi.CyberShoppeeRepository;
using CyberShoppeeApi.CyberShoppeeRepository.CustomersRepository;

namespace CyberShoppeeApi.Controllers

{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private ICustomerRepository _customerRepository = new CustomerRepository();


        // route for getting all product details in a list
        [Route("")]
        public IHttpActionResult GetAllCustomers()
        {
            try { 
                return Ok(_customerRepository.GetAllCustomers());
            }
            catch(CutomerDataUnavailableException e) {
                return BadRequest(e.Message); 
            }

        }
        [Route("{id}")]
        public IHttpActionResult GetCustomerById(int id) {
            try
            {
                return Ok(_customerRepository.GetCustomerById(id));
            }
            catch (CutomerDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
