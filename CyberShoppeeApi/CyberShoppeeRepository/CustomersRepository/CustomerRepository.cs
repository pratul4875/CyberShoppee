using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberShoppeeDataAccessLayer.CyberShoppeeContext;
using CyberShoppeeDataAccessLayer.Entity;

namespace CyberShoppeeApi.CyberShoppeeRepository.CustomersRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        CyberShoppeeContext context = new CyberShoppeeContext();

        public Customer GetCustomerById(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer == null)
            {
                throw new CutomerDataUnavailableException("No Customers Found");
            }
            return customer;


           
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = context.Customers.ToList();
            if (customers == null)
            {
                throw new CutomerDataUnavailableException("No Customers Found");
            }
            return customers; 
        }
    }
}