using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeApi.AdditionalModels
{
    public class ChangePasswordModel
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}