using System;
using System.Collections.Generic;

#nullable disable

namespace PM_SLABCODE.Context
{
    public partial class RolesMaster
    {
        public RolesMaster()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
