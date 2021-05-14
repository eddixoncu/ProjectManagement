using System;
using System.Collections.Generic;

#nullable disable

namespace PM_SLABCODE.Context
{
    public partial class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual RolesMaster Role { get; set; }
        public virtual UsersMaster User { get; set; }
    }
}
