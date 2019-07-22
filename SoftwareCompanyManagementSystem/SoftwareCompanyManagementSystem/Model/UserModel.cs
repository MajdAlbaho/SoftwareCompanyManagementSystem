using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareCompanyManagementSystem.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
