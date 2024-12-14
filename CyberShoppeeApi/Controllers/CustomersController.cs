using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShoppeeApi.AdditionalModels;
using CyberShoppeeApi.CyberShoppeeRepository;
using CyberShoppeeApi.CyberShoppeeRepository.CustomersRepository;
using CyberShoppeeDataAccessLayer.Entity;

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
        [Route("validate")]
        // Login working properly
        [HttpPost]
        public IHttpActionResult ValidateCustomer([FromBody] CustomerValidate request)
        {
            


            Boolean result = _customerRepository.validateCustomer(request.Email, request.Password);
            if (result)
                return Ok("Han theek hai chal kaam kar apna");


            return BadRequest("Email/password mismatch.. Please register first");

        }
        [Route("{id}")]
        public IHttpActionResult GetCustomerById(int id)
        {
            try
            {
                return Ok(_customerRepository.GetCustomerById(id));
            }
            catch (CutomerDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
        [Route("UpdateProfile")]
        [HttpPost]
        public IHttpActionResult UpdateCustomerProfile([FromBody] Customer customer)
        {
            try
            {
                _customerRepository.UpdateCustomerProfile(customer);
                return Ok("Profile Updated Successfully");
            }
            catch (CutomerDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
        [Route("UpdatePassword")]
        [HttpPost]
        public IHttpActionResult UpdatePassword([FromBody] ForgotPasswordModel request)
        {
            try
            {
                return Ok(_customerRepository.UpdatePassword(request));
            }
            catch (CutomerDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
        [Route ("ChangePassword")]
        [HttpPost]
        public IHttpActionResult ChangePassword([FromBody] ChangePasswordModel request)
        {
            try
            {
                return Ok(_customerRepository.ChangePassword(request));
            }
            catch (CutomerDataUnavailableException e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("Register")]

        public IHttpActionResult RegisterCustomer(Customer customer)
        {
            try
            {
                return Ok(_customerRepository.Register(customer));
            }
            catch (CutomerDataUnavailableException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("AccountDelete/{id}")]
        public IHttpActionResult DeleteCustomer(int id)
        {
            try
            {
                return Ok(_customerRepository.DeleteAccount(id));
            }
            catch (CutomerDataUnavailableException ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
