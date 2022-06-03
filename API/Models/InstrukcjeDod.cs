using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class InstrukcjeDod
    {
        public int IdInstrukcjeDod { get; set; }
        public string Kod { get; set; }
        public string OpisPl { get; set; }
        public string OpisDe { get; set; }
        public string OpisGb { get; set; }
        public int? WymaganyOpis { get; set; }
        public int? WymaganaData { get; set; }
        public string OpisDaty { get; set; }
        public int? WymaganaKwota { get; set; }
        public string OpisKwoty { get; set; }
        public int? Cod { get; set; }
        public int? Cennik { get; set; }
        public int? Systemowa { get; set; }
        /// <summary>
        /// Dotyczy obiektów: 0 - bez przypisania, 1 - DROBN, 2 - FTL
        /// </summary>
        public int? Dotyczy { get; set; }
        /// <summary>
        /// Flaga, czy instrukcja opcjonalna
        /// </summary>
        public int? Opcjonalna { get; set; }
        /// <summary>
        /// Flaga, czy instrukcja widoczna na WWW
        /// </summary>
        public int? Www { get; set; }
        public int? WymaganaIlosc { get; set; }
        public string OpisIlosci { get; set; }
        public int? WymaganaJt { get; set; }
        public string OpisJt { get; set; }
        public int? WymaganyOpisDod { get; set; }
        public string OpisOpisuDod { get; set; }
        public int? Aktywna { get; set; }
        public string Dzial { get; set; }
        public int? Standardowa { get; set; }
        public int? Wymagana { get; set; }
        public string CennikPodstawa { get; set; }
        public int? CennikKalkulacja { get; set; }
        public int? WymaganyCheck { get; set; }
        public string OpisCheck { get; set; }
        public int? DotKlienta { get; set; }
        public int? DotPrzewoznika { get; set; }
    }
}
