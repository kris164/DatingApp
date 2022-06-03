using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OpisyTowarow
    {
        public int IdOpisyTowarow { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string NazwaUzytk { get; set; }
        public string Opakowanie { get; set; }
        public string Jednostka { get; set; }
        public int RecznaEdycja { get; set; }
        public int IsAdr { get; set; }
        public string NazwaTaryfa { get; set; }
        public string NazwaPrzewozowa { get; set; }
        public string NumerUn { get; set; }
        public string Klasa { get; set; }
        public string Gp { get; set; }
        public string KodKlasy { get; set; }
        public string KatTransp { get; set; }
        public string NumerZag { get; set; }
        public int IsProzny { get; set; }
        public double? Gestosc { get; set; }
        public string InfoDod { get; set; }
        public string Nalepki { get; set; }
        public int Is640 { get; set; }
        public int Is274 { get; set; }
        public int IsOdpad { get; set; }
        public int IsOpakAw { get; set; }
        public int IsGoracy { get; set; }
        public int Is541115 { get; set; }
        public string ProznyOkrNaLp { get; set; }
        public string ProznyKatTransp { get; set; }
        public double? TempPrzewozu { get; set; }
        public string TempPrzewozuO { get; set; }
        public string Haccp { get; set; }
        public string Sqas { get; set; }
        public string Grupa { get; set; }
        public string KodOpak { get; set; }
        public int? Zalaczniki { get; set; }
        public int? IsTwr { get; set; }
        public string NazwaEn { get; set; }
        public string OpisDod { get; set; }
        public int? Wsk { get; set; }
        public string Symbol { get; set; }
        public double? JmKg { get; set; }
        public int? LiczJmKgIloscJt { get; set; }
        public int? WagaOpakDoCal { get; set; }
        public int? IsSent { get; set; }
        public string Nhm { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        public double? TempOd { get; set; }
        public double? TempDo { get; set; }
        public int? IsPapier { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
