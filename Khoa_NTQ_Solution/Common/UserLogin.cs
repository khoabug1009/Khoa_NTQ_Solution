using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khoa_NTQ_Solution
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { get; set; }
        public string Email { get; set; }
        
    }
}