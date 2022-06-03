using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiZaWy
    {
        public int IdPrzesylkiZaWy { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Telefony { get; set; }
        public string Kraj { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? DataRz { get; set; }
        public DateTime? GodzRz { get; set; }
        public string DodOpis { get; set; }
        public string DodOpisRz { get; set; }
        public double? Opoznienie { get; set; }
        public string OpoznieniePowod { get; set; }
        public string Ladunek { get; set; }
        public string TempPrzewozuO { get; set; }
        public double? Licznik { get; set; }
        public double? Waga { get; set; }
        public string JednWagi { get; set; }
        public double? Palety { get; set; }
        public double? PaletyWym { get; set; }
        public string Jm { get; set; }
        /// <summary>
        /// zużyte paliwo w trakcie zdarzenia
        /// </summary>
        public double? Paliwo { get; set; }
        public int? WyjazdId { get; set; }
        public int? TaborId { get; set; }
        public double? GeoLongi { get; set; }
        public double? GeoLat { get; set; }
        public string InneUwagi { get; set; }
        public int? WysylacUwagi { get; set; }
        public double? CzasTrwania { get; set; }
        public double? MaxOpozn { get; set; }
        public int? ListLiniowyId { get; set; }
        public DateTime? DataRzK { get; set; }
        public DateTime? GodzRzK { get; set; }
        public string Lokalizacja { get; set; }
        public int? Pusty { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public DateTime? DataRzP { get; set; }
        public DateTime? GodzRzP { get; set; }
        public int? LadunekId { get; set; }
        public double? WagaZestawu { get; set; }
        public string Dzial { get; set; }
        public string TempPrzewozuORz { get; set; }
        public double? WagaRz { get; set; }
        public int? KontenerId { get; set; }
        public string Kontener { get; set; }
        public int? Kontener2Id { get; set; }
        public string Kontener2 { get; set; }
        public double? GeoLongiRz { get; set; }
        public double? GeoLatRz { get; set; }
        /// <summary>
        /// końcowy stan licznika paliwa
        /// </summary>
        public double? PaliwoLicznik { get; set; }
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// id definicji geofencingu (referencja do tabeli GF_DEF)
        /// </summary>
        public int? GfDefId { get; set; }
        public double? IloscRz { get; set; }
        public DateTime? DyspGodzOd { get; set; }
        public DateTime? DyspGodzDo { get; set; }
        public int? KorGodz { get; set; }
        public string TypOdcinka { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Obj { get; set; }
        public double? Ldm { get; set; }
        public string AirSymbol { get; set; }
        public string AirNrLotu { get; set; }
        public string SeaSymbol { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public DateTime? DataRzW { get; set; }
        public DateTime? GodzRzW { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string RailSymbol { get; set; }
        public DateTime? AwizacjaPrzed { get; set; }
        public DateTime? Eta { get; set; }
        /// <summary>
        /// Wyłączenie analizy ETA
        /// </summary>
        public int? DisableEta { get; set; }
    }
}
