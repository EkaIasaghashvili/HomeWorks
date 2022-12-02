using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Models.Users
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public IList<UserRole> UserRoles { get; set; }
    }
}
