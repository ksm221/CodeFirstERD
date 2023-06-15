using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstFirmaERD
{

    public partial class Laenutu
    {
        [Key]
        public int LaenutuseId { get; set; }

        public int TöötajaId { get; set; }

        public string? LaenutatavaKaubaNimi { get; set; }

        public DateTime? LaenutuseAlgus { get; set; }

        public DateTime? LaenutuseLõpp { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}