using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class FilmCategory
    {
        public ushort FilmId { get; set; }
        public byte CategoryId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
