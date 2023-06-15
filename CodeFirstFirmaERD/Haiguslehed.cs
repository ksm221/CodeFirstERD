using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstFirmaERD
{

    public partial class Haiguslehed
    {
        [Key]
        public int HaigusleheId { get; set; }

        public int TöötajaId { get; set; }

        public bool? ÕigusHaiguslehele { get; set; }

        public int? HaiguspäeviKokku { get; set; }

        public DateTime? HaigusleheAlgus { get; set; }

        public DateTime? HaigusleheLõpp { get; set; }

        public int? KasutatudHaigusepäevi { get; set; }

        public int? AllesolevaidHaigusepäevi { get; set; }

        public int? AegunudHaigusepäevi { get; set; }

        public string? Kommentaar { get; set; }

        public virtual Töötaja Töötaja { get; set; } = null!;
    }
}