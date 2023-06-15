using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Ligipääsuload
    {
        [Key]
        public int LigipääsuloaId { get; set; }

        [ForeignKey("TöötajaID")]
        public int? TöötajaId { get; set; }

        public bool? LigipääsuÕigus { get; set; }

        public string? LigipääsuTase { get; set; }

        public DateTime? LigipääsuAlgus { get; set; }

        public DateTime? LigipääsuLõpp { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}