using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class Staff
    {
        public Staff()
        {
            StoreNavigation = new HashSet<Store>();
        }

        public byte StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort AddressId { get; set; }
        public byte[] Picture { get; set; }
        public string Email { get; set; }
        public byte StoreId { get; set; }
        public bool? Active { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Store> StoreNavigation { get; set; }
    }
}
