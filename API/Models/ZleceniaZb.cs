using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Zlecenia zbiorcze
    /// </summary>
    public partial class ZleceniaZb
    {
        public int IdZleceniaZb { get; set; }
        public DateTime? TrigTimestamp { get; set; }
        public string NrZlecenia { get; set; }
        public int? NrZlecKolejny { get; set; }
        public int? NrZlecRok { get; set; }
        public int? NrZlecMies { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public string Opiekun { get; set; }
        public DateTime? DataZlecenia { get; set; }
        public DateTime? GodzZlecenia { get; set; }
        public string TypZlecenia { get; set; }
        public int? PrzewoznikId { get; set; }
        public string PrzewoznikSymbol { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public string PrzewoznikAdres { get; set; }
        public string PrzewoznikMiasto { get; set; }
        public string PrzewoznikKod { get; set; }
        public string PrzewoznikKraj { get; set; }
        public string PrzewoznikNip { get; set; }
        public string PrzewoznikTel { get; set; }
        public string PrzewoznikKont { get; set; }
        public int? PrzewoznikOddzialId { get; set; }
        public string PrzewoznikOddzialNazwa { get; set; }
        public string PrzewoznikOddzialAdres { get; set; }
        public string PrzewoznikOddzialMiasto { get; set; }
        public string PrzewoznikOddzialKod { get; set; }
        public string PrzewoznikOddzialKraj { get; set; }
        public string SamochodNrBoczny { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string NaczepaNrBoczny { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public string Kierowca1Tel { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public string Kierowca2Tel { get; set; }
        public string ZaMiejsce { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKraj { get; set; }
        public string ZaKod { get; set; }
        public DateTime? ZaData { get; set; }
        public DateTime? ZaGodz { get; set; }
        public DateTime? ZaDataRz { get; set; }
        public DateTime? ZaGodzRz { get; set; }
        public DateTime? ZaGodzOd { get; set; }
        public DateTime? ZaGodzDo { get; set; }
        public string WyMiejsce { get; set; }
        public string WyMiasto { get; set; }
        public string WyKraj { get; set; }
        public string WyKod { get; set; }
        public DateTime? WyData { get; set; }
        public DateTime? WyGodz { get; set; }
        public DateTime? WyDataRz { get; set; }
        public DateTime? WyGodzRz { get; set; }
        public DateTime? WyDataRzK { get; set; }
        public DateTime? WyGodzRzK { get; set; }
        public DateTime? WyGodzOd { get; set; }
        public DateTime? WyGodzDo { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public int? TrasaEdycja { get; set; }
        public double? TrasaOdl { get; set; }
        public double? TrasaOdlDojazd { get; set; }
        public double? TrasaOdlGl { get; set; }
        public double? TrasaZlecOdl { get; set; }
        public double? TrasaZlecOdlDojazd { get; set; }
        public double? TrasaZlecOdlGl { get; set; }
        public double? TrasaOdlRozn { get; set; }
        public double? TrasaMapOdl { get; set; }
        public double? TrasaMapOdlDojazd { get; set; }
        public double? TrasaMapOdlGl { get; set; }
        public int? Adr { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string KosztySql { get; set; }
        public string Status { get; set; }
        public string StatusEmisja { get; set; }
        public int? RknzPlan { get; set; }
        public int? RknzRz { get; set; }
        public int? SfmStatus { get; set; }
        public string InfoDod { get; set; }
        public string Ustalenia { get; set; }
        public int? SfmVer { get; set; }
        public int? SfmLZaWy { get; set; }
        public int? SfmWysl { get; set; }
        public int? DyspozytorId { get; set; }
        public string Dyspozytor { get; set; }
        public int? Zalaczniki { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public int? Prom { get; set; }
        public double? TrasaMapMyto { get; set; }
        public double? TrasaMapKmPlatne { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public double? TrasaCcOdl { get; set; }
        public double? TrasaCcOdlDojazd { get; set; }
        public double? TrasaCcOdlGl { get; set; }
    }
}
