using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Harukontor
    {
        [Key]
        public int HarukontoriId { get; set; }

        [ForeignKey("FirmaId")]
        public int? FirmaId { get; set; }

        public string? HarukontoriRegNr { get; set; }

        public string? Nimi { get; set; }

        public string? Lühinimi { get; set; }

        public string? Koduleht { get; set; }

        public string? Aadress { get; set; }

        public string? Kontaktisik { get; set; }

        public int? KontaktTel { get; set; }

        public string? KontaktEmail { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Firma Firma { get; set; } = null!;

        public virtual ICollection<Töötaja> Töötajas { get; set; } = new List<Töötaja>();
    }
}