using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class Film
    {
        public ushort FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public short? ReleaseYear { get; set; }
        public byte LanguageId { get; set; }
        public byte? OriginalLanguageId { get; set; }
        public byte RentalDuration { get; set; }
        public decimal RentalRate { get; set; }
        public ushort? Length { get; set; }
        public decimal ReplacementCost { get; set; }
        public string Rating { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Language Language { get; set; }
        public virtual Language OriginalLanguage { get; set; }
    }
}
