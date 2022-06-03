using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKwitPalPoz
    {
        public int IdTmpKwitPalPoz { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? KwitPalId { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public string MagazynZdarzenia { get; set; }
        public int? ListyLinioweId { get; set; }
        public string ListyLiniowe { get; set; }
        public int? PrzesylkiId { get; set; }
        public string Przesylki { get; set; }
        public int? ZleceniaId { get; set; }
        public string Zlecenia { get; set; }
        public int? ZleceniaZaWyId { get; set; }
        public string LokalizacjaNadz { get; set; }
        public int? PaczkiId { get; set; }
        public string Paczki { get; set; }
        public string KodOpak { get; set; }
        public string Opakowanie { get; set; }
        public int? Typ { get; set; }
        public int? Ilosc { get; set; }
        public int? IloscRozl { get; set; }
        public string Opis { get; set; }
        public int? WgLp { get; set; }
        public int? BilansOpakPozId { get; set; }
    }
}
