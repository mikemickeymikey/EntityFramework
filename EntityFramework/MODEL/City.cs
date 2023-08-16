using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public ushort CityId { get; set; }
        public string City1 { get; set; }
        public ushort CountryId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
