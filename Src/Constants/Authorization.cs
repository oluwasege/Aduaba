using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Constants
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            User
        }
        public const string default_username = "admin";
        public const string default_email = "admin@secureapi.com";
        public const string default_password = "Pa$$w0rd.";
        public const Roles default_role = Roles.Administrator;
    }
}
