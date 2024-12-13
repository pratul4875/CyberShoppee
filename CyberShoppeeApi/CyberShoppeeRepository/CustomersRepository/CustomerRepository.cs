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
        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}