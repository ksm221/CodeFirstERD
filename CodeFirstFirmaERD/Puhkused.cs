using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFirmaERD
{

    public partial class Puhkused
    {
        [Key]
        public int PuhkuseId { get; set; }

        [ForeignKey("TöötajaId")]
        public int? TöötajaId { get; set; }

        public int? PuhkusePäevi { get; set; }

        public DateTime? PuhkuseAlgus { get; set; }

        public DateTime? PuhkuseLõpp { get; set; }

        public int? KasutatudPäevad { get; set; }

        public int? AllesolevadPäevad { get; set; }

        public int? AegunudPuhkusepäevad { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}