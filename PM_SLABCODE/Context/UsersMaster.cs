using System;
using System.Collections.Generic;

#nullable disable

namespace PM_SLABCODE.Context
{
    public partial class UsersMaster
    {
        public UsersMaster()
        {
            RefreshTokens = new HashSet<RefreshToken>();
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
