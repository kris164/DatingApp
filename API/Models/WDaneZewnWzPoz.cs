using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WDaneZewnWzPoz
    {
        public int IdWDaneZewnWzPoz { get; set; }
        public int? WDaneZewnWzId { get; set; }
        public string Status { get; set; }
        public DateTime? DataGodz { get; set; }
        public double? Ilosc { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public string Magazyn { get; set; }
        public int? WMagTowaryId { get; set; }
        public string WMagTowary { get; set; }
        public string OpisDod { get; set; }
        public int? WZleceniaId { get; set; }
        public string WZlecenia { get; set; }
        public int? WWzId { get; set; }
        public string WWz { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? WZleceniaPozId { get; set; }
        public string Bledy { get; set; }
        public int? UzytkownikId { get; set; }
    }
}
