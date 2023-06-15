using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Lapsed
    {
        [Key]
        public int LapseId { get; set; }

        [ForeignKey("TöötajaId")]
        public int? TöötajaId { get; set; }

        public string? LapseEesnimi { get; set; }

        public string? LapsePerenimi { get; set; }

        public DateTime? LapseSünniaeg { get; set; }

        public int? LapseVanus { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}