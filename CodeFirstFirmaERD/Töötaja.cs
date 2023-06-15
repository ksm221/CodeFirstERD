using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Töötaja
    {
        [Key]
        public int TöötajaId { get; set; }

        public string? Eesnimi { get; set; }

        public string? Perekonnanimi { get; set; }

        public int? Isikukood { get; set; }

        public string? Kontaktaadress { get; set; }

        public DateTime? TöölAl { get; set; }

        public DateTime? TöölKuni { get; set; }

        [ForeignKey("AmetinimetuseId")]
        public int? AmetinimetuseId { get; set; }

        [ForeignKey("FirmaId")]
        public int? FirmaId { get; set; }

        [ForeignKey("HarukontoriId")]
        public int? HarukontoriId { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Ametinimetused Ametinimetuse { get; set; } = null!;

        public virtual Firma Firma { get; set; } = null!;

        public virtual ICollection<Haiguslehed> Haigusleheds { get; set; } = new List<Haiguslehed>();

        public virtual Harukontor Harukontori { get; set; } = null!;

        public virtual ICollection<Laenutu> Laenutus { get; set; } = new List<Laenutu>();

        public virtual ICollection<Lapsed> Lapseds { get; set; } = new List<Lapsed>();

        public virtual ICollection<Ligipääsuload> Ligipääsuloads { get; set; } = new List<Ligipääsuload>();

        public virtual ICollection<Puhkused> Puhkuseds { get; set; } = new List<Puhkused>();

        public virtual ICollection<Tervisekontroll> Tervisekontrolls { get; set; } = new List<Tervisekontroll>();
    }
}