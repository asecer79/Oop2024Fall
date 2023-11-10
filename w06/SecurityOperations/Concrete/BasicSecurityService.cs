using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.SecurityOperations.Abstract;

namespace w06.SecurityOperations.Concrete
{
    public class BasicSecurityService:ISecurityService
    {
        public bool AuthenticateUser(string username, string password)
        {
            // Basic authentication logic
            return username == "user" && password == "pass";
        }

        public bool AuthorizeUser(string username, string permission)
        {
            // Basic authorization logic, maybe checking a list of permissions
            return permission == "read";
        }
    }
}
