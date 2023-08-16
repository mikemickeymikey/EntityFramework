using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class Store
    {
        public Store()
        {
            Staff = new HashSet<Staff>();
        }

        public byte StoreId { get; set; }
        public byte ManagerStaffId { get; set; }
        public ushort AddressId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Staff ManagerStaff { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
