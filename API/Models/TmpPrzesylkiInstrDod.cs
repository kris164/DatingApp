using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiInstrDod
    {
        public int IdTmpPrzesylkiInstrDod { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Kod { get; set; }
        public int? WymaganyOpis { get; set; }
        public string Uwagi { get; set; }
        public int? WymaganaData { get; set; }
        public DateTime? Data { get; set; }
        public int? WymaganaKwota { get; set; }
        public double? Kwota { get; set; }
        public string KwotaWal { get; set; }
        public int? Cod { get; set; }
        public int? Cennik { get; set; }
        public int? WymaganaIlosc { get; set; }
        public double? Ilosc { get; set; }
        public int? WymaganaJt { get; set; }
        public double? IloscJt { get; set; }
        public string Jt { get; set; }
        public int? WymaganyOpisDod { get; set; }
        public string OpisDod { get; set; }
        public int? WymaganyCheckbox { get; set; }
        public int? Checkbox { get; set; }
    }
}
