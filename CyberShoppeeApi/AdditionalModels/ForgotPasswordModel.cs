using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeApi.AdditionalModels
{
    public class ForgotPasswordModel
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public int CustomerId { get; set; }
    }
}