using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class Address
    {
        public Address()
        {
            Staff = new HashSet<Staff>();
            Store = new HashSet<Store>();
        }

        public ushort AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public ushort CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
