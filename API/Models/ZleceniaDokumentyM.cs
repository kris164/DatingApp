using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Dokumenty do zleceń morskich
    /// </summary>
    public partial class ZleceniaDokumentyM
    {
        public int IdZleceniaDokumentyM { get; set; }
        public int? ZlecenieId { get; set; }
        public int? Lp { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Wymagany { get; set; }
        public int? Wplynal { get; set; }
        public DateTime? DataWplywu { get; set; }
        public string Uzytkownik { get; set; }
        public int? Rod { get; set; }
        public string RodDo { get; set; }
        public int? RodWyszedl { get; set; }
        public DateTime? RodDataWyjscia { get; set; }
        public string RodUzytkownik { get; set; }
        public string Uwagi { get; set; }
        public string KodKreskowy { get; set; }
        public int? Ilosc { get; set; }
        public int? IloscRozl { get; set; }
        public int? Erod { get; set; }
        public int? WydrEtyk { get; set; }
        public string UzytkownikPotw { get; set; }
    }
}
