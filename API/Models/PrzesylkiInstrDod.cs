using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiInstrDod
    {
        public int IdPrzesylkiInstrDod { get; set; }
        /// <summary>
        /// Relacja do przesyłki, tab: PRZESYLKI
        /// </summary>
        public int PrzesylkiId { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? WymaganyOpis { get; set; }
        public string Uwagi { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? WymaganaData { get; set; }
        public DateTime? Data { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? WymaganaKwota { get; set; }
        public double? Kwota { get; set; }
        public string KwotaWal { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Cod { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Cennik { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Opcjonalna { get; set; }
        public int? WymaganaIlosc { get; set; }
        public double? Ilosc { get; set; }
        public int? WymaganaJt { get; set; }
        public double? IloscJt { get; set; }
        public string Jt { get; set; }
        public int? WymaganyOpisDod { get; set; }
        public string OpisDod { get; set; }
        public int? InstrukcjeDodKonfigId { get; set; }
        public string CennikPodstawa { get; set; }
        public int? CennikKalkulacja { get; set; }
        public int? WymaganyCheckbox { get; set; }
        public double? Checkbox { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? DotKlienta { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? DotPrzewoznika { get; set; }
    }
}
