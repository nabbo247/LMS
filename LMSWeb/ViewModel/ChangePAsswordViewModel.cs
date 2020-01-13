using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LMSWeb.ViewModel
{
    public class ChangePasswordViewModel
    {
        public int UserId { get; set; }

        [DisplayName("Old Password")]
        public string OldPassword { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}