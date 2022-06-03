using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KalkStawkiAir
    {
        public int IdKalkStawkiAir { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI_AIR
        /// </summary>
        public int? PrzesylkiAirId { get; set; }
        public string Grupa { get; set; }
        public int? Wybrana { get; set; }
        public int? Lp { get; set; }
        public int? KlientId { get; set; }
        public int? OpisId { get; set; }
        public string OpisDod { get; set; }
        public double? Ilosc { get; set; }
        public string Jm { get; set; }
        public double? CenaJedn { get; set; }
        public double? Netto { get; set; }
        public string Waluta { get; set; }
        public string Info { get; set; }
    }
}
