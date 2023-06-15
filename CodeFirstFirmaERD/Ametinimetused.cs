using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstFirmaERD
{

    public partial class Ametinimetused
    {
        [Key]
        public int AmetinimetuseId { get; set; }

        public int TöötajaId { get; set; }

        public string? Ametinimetus { get; set; }

        public DateTime? AmetisAl { get; set; }

        public DateTime? AmetisKuni { get; set; }

        public string? Osakond { get; set; }

        public string? OtseseÜlemuseEesnimi { get; set; }

        public string? OtseseÜlemusePerenimi { get; set; }

        public int? OtseseÜlemuseKontakttel { get; set; }

        public string? OtseseÜlemuseEpost { get; set; }

        public string? Kommentaar { get; set; }

        public virtual ICollection<Töötaja> Töötajas { get; set; } = new List<Töötaja>();
    }
}