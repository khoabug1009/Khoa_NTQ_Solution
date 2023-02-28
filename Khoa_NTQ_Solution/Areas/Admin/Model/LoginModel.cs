using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khoa_NTQ_Solution.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PassWord không được để trống")]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }
    }
}