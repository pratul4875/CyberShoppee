using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberShoppeeApi.AdditionalModels;
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
        Boolean ICustomerRepository.validateCustomer(string email, string password)
        {
            var customer = context.Customers.Where(c => c.EmailAddress == email && c.Password == password).FirstOrDefault();
            if (customer == null)
            {
                return false;
            }
            return true;
        }
        public void UpdateCustomerProfile(Customer customer)
        {
            var customerToUpdate = context.Customers.Find(customer.CustomerId);
            if (customerToUpdate == null)
            {
                throw new CutomerDataUnavailableException("No Customers Found");
            }
            //update only attributes that are present in the customer object
            // set the atrributes that are available in the customer object
            customerToUpdate.DeliveryAddress = customer.DeliveryAddress ?? customerToUpdate.DeliveryAddress;
            customerToUpdate.FullName = customer.FullName ?? customerToUpdate.FullName;
            customerToUpdate.EmailAddress = customer.EmailAddress ?? customerToUpdate.EmailAddress;

            context.SaveChanges();
        }
        public string UpdatePassword(ForgotPasswordModel request)
        {
            // request contains id , email and new password
            // check if the customer exists via id and email if both are correct then update the password
            var customer = context.Customers.Where(c => c.CustomerId == request.CustomerId && c.EmailAddress == request.Email).FirstOrDefault();
            if (customer == null)
            {
                throw new CutomerDataUnavailableException("No Customers Found for given details");
            }
            customer.Password = request.NewPassword;
            context.SaveChanges();
            return "Password Updated Successfully";

        }
       public  string ChangePassword(ChangePasswordModel request)
        {
            var customer = context.Customers.Where(c =>  c.Password == request.OldPassword && c.EmailAddress == request.Email).FirstOrDefault();
            if (customer == null)
            {
                throw new CutomerDataUnavailableException("Customer does not exist with given email and password");
            }
            customer.Password = request.NewPassword;
            context.SaveChanges();
            return $" Successfully changed password for {request.Email}";
        }
    }
}