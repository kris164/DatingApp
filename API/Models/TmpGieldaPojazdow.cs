using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpGieldaPojazdow
    {
        public int IdTmpGieldaPojazdow { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdGieldaPojazdow { get; set; }
        public int? Zrodlo { get; set; }
        public string Rodzaj { get; set; }
        public int? Anulowany { get; set; }
        public DateTime? DataGodz { get; set; }
        public DateTime? DataGodzOd { get; set; }
        public DateTime? DataGodzDo { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public string TaborNrB { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrB { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public string Kierowca1Tel { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public string Kierowca2Tel { get; set; }
        public int? ObiektTyp { get; set; }
        public int? ObiektId { get; set; }
        public string Obiekt { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public int? Odeslac { get; set; }
        public int? Adr { get; set; }
        public string PoczPoiTyp { get; set; }
        public int? PoczPoiId { get; set; }
        public string PoczPoiNazwa { get; set; }
        public string PoczPoiAdres { get; set; }
        public string PoczPoiMiasto { get; set; }
        public string PoczPoiKod { get; set; }
        public string PoczPoiKraj { get; set; }
        public string PoczPoiTel { get; set; }
        public string PoczPoiFax { get; set; }
        public double? PoczPoiGeoLongi { get; set; }
        public double? PoczPoiGeoLat { get; set; }
        public string PoczPoiLokalizacja { get; set; }
        public string PoczStrefa { get; set; }
        public string OstPoiTyp { get; set; }
        public int? OstPoiId { get; set; }
        public string OstPoiNazwa { get; set; }
        public string OstPoiAdres { get; set; }
        public string OstPoiMiasto { get; set; }
        public string OstPoiKod { get; set; }
        public string OstPoiKraj { get; set; }
        public string OstPoiTel { get; set; }
        public string OstPoiFax { get; set; }
        public double? OstPoiGeoLongi { get; set; }
        public double? OstPoiGeoLat { get; set; }
        public string OstPoiLokalizacja { get; set; }
        public string Strefa { get; set; }
        public int? Rez { get; set; }
        public DateTime? RezDataGodz { get; set; }
        public string RezLokalizacja { get; set; }
        public int? RezPracownikId { get; set; }
        public string RezPracownik { get; set; }
        public int? Pobr { get; set; }
        public DateTime? PobrDataGodz { get; set; }
        public string PobrLokalizacja { get; set; }
        public int? PobrPracownikId { get; set; }
        public string PobrPracownik { get; set; }
        public int? PobrObiektTyp { get; set; }
        public int? PobrObiektId { get; set; }
        public string PobrObiekt { get; set; }
        public int? Dorazny { get; set; }
        public string UwagiDoPojazdu { get; set; }
        public string WarunkiDodatkowe { get; set; }
        public string Status { get; set; }
    }
}
