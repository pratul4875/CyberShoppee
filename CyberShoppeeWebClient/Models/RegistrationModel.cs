using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeWebClient.Models
{
    public class LoginModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
