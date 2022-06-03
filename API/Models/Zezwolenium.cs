using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Zezwolenium
    {
        public int IdZezwolenia { get; set; }
        public string NrZezwSymbol { get; set; }
        public string NrZezw { get; set; }
        public string Typ { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public double? WartoscNetto { get; set; }
        public string Waluta { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? WydanyPrzezId { get; set; }
        public string WydanyPrzez { get; set; }
        public DateTime? DataWydania { get; set; }
        public int? Zwrot { get; set; }
        public DateTime? DataZwrotu { get; set; }
        public int? Rozliczono { get; set; }
        public DateTime? DataRozliczenia { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? Zalaczniki { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public int? Zlecenie2Id { get; set; }
        public string Zlecenie2 { get; set; }
        public int? RodzajZezw { get; set; }
        public int? IloscStron { get; set; }
        public string Kraje { get; set; }
        public DateTime? DataWaznosciOd { get; set; }
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
    }
}
