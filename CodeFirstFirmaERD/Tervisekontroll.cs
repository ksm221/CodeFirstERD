using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Tervisekontroll
    {
        [Key]
        public int TervisekontrolliId { get; set; }

        [ForeignKey("TöötajaId")]
        public int? TöötajaId { get; set; }

        public bool? TervisekontrolliVajadus { get; set; }

        public DateTime? EelmiseTervisekontrolliKp { get; set; }

        public DateTime? UueTervisekontrolliKp { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}