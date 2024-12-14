using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberShoppeeApi.AdditionalModels;
using CyberShoppeeDataAccessLayer.Entity;

namespace CyberShoppeeApi.CyberShoppeeRepository.CustomersRepository
{
    public interface ICustomerRepository
    {
         IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Boolean validateCustomer(string email, string password);
        void UpdateCustomerProfile(Customer customer);
        string UpdatePassword(ForgotPasswordModel request);
        string ChangePassword(ChangePasswordModel request);
        string Register(Customer customer);

        string DeleteAccount(int id);
    }
}
