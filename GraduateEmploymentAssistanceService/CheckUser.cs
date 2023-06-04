using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateEmploymentAssistanceService
{
    public class CheckUser
    {
        
        public string Login { get; set; }

        public bool IsUser { get; }
        public string Status => IsUser ? "Personal" : "Student";

        public CheckUser(string login, bool isUser) { 
            Login = login;
            IsUser = isUser;
        }
    }
}
