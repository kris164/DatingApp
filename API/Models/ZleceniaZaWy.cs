using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaZaWy
    {
        public int IdZleceniaZaWy { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? ZlecenieId { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
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
        public double? Licznik { get; set; }
        public double? Waga { get; set; }
        public string JednWagi { get; set; }
        public double? Palety { get; set; }
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
        public double? CzasTrwania { get; set; }
        public double? MaxOpozn { get; set; }
        public int? WysylacUwagi { get; set; }
        public string TempPrzewozuO { get; set; }
        public double? PaletyWym { get; set; }
        public DateTime? DataRzK { get; set; }
        public DateTime? GodzRzK { get; set; }
        public int? Pusty { get; set; }
        public long? Idpoiextn { get; set; }
        public int? Automat { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public DateTime? DataRzP { get; set; }
        public DateTime? GodzRzP { get; set; }
        public int? LadunekId { get; set; }
        public double? WagaZestawu { get; set; }
        public string TempPrzewozuORz { get; set; }
        public double? WagaRz { get; set; }
        public int? ZaWyNadrzId { get; set; }
        public int? ZaWyGlowneId { get; set; }
        public int? KorGodz { get; set; }
        public DateTime? DyspGodzOd { get; set; }
        public DateTime? DyspGodzDo { get; set; }
        /// <summary>
        /// Status SFM (jak dla zleceń)
        /// </summary>
        public int? SfmStatus { get; set; }
        /// <summary>
        /// Status SPEED
        /// </summary>
        public string Status { get; set; }
        public int? EtaEventsId { get; set; }
        public int? KontenerId { get; set; }
        public string Kontener { get; set; }
        public int? Kontener2Id { get; set; }
        public string Kontener2 { get; set; }
        public int? LpPw { get; set; }
        public int? PromyId { get; set; }
        public double? GeoLongiRz { get; set; }
        public double? GeoLatRz { get; set; }
        public int? AnulZl { get; set; }
        public int? AnulPw { get; set; }
        /// <summary>
        /// id definicji geofencingu (referencja do tabeli GF_DEF)
        /// </summary>
        public int? GfDefId { get; set; }
        /// <summary>
        /// końcowy stan licznika paliwa
        /// </summary>
        public double? PaliwoLicznik { get; set; }
        public int? Pietrowanie { get; set; }
        public double? IloscRz { get; set; }
        public int? LpZleceniaZb { get; set; }
        public short? NieWysylaj { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Obj { get; set; }
        public double? Ldm { get; set; }
        public string Kontakt { get; set; }
        /// <summary>
        /// czy wysłano trasę do zdarzenia (0-NIE /1-TAK)
        /// </summary>
        public int? CcIssent { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na rekord ZA/WY z którego powstała bieżąca pozycja
        /// </summary>
        public int? MaszonskiMasterZleceniaZaWyId { get; set; }
        public string Email { get; set; }
        public DateTime? DataRzW { get; set; }
        public DateTime? GodzRzW { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public double? ObjRz { get; set; }
        public int? PoPrzeladunku { get; set; }
        public string Adres { get; set; }
        public int? TrasaKm { get; set; }
        public int? TrasaKmRosn { get; set; }
        public int? TrasaCzas { get; set; }
        public int? TrasaCzasRosn { get; set; }
        public string SqlDebugInfo { get; set; }
        public DateTime? AwizacjaPrzed { get; set; }
        public DateTime? Eta { get; set; }
        public string Nazwa { get; set; }
        public string Kod { get; set; }
        public DateTime? UsrFldPoprzedniaData { get; set; }
        public int? UsrFldPoprzednieMiejsceId { get; set; }
        public string DataGodz { get; set; }
        public string DataGodzOd { get; set; }
        public string DataGodzDo { get; set; }
        /// <summary>
        /// Wyłączenie analizy ETA
        /// </summary>
        public int? DisableEta { get; set; }
    }
}
