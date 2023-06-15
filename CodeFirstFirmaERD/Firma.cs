using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstFirmaERD
{

    public partial class Firma
    {
        [Key]
        public int FirmaId { get; set; }

        public string? FirmaRegNr { get; set; }

        public string? Nimi { get; set; }

        public string? Lühinimi { get; set; }

        public string? Koduleht { get; set; }

        public string? Aadress { get; set; }

        public string? Kontaktisik { get; set; }

        public int? KontaktTel { get; set; }

        public string? KontaktEmail { get; set; }

        public string? Kommentaar { get; set; }

        public virtual ICollection<Harukontor> Harukontors { get; set; } = new List<Harukontor>();

        public virtual ICollection<Töötaja> Töötajas { get; set; } = new List<Töötaja>();
    }
}