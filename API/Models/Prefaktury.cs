using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Nagłówek prefaktury/bilingu
    /// </summary>
    public partial class Prefaktury
    {
        public int IdPrefaktury { get; set; }
        /// <summary>
        /// Data utworzenia bilingu
        /// </summary>
        public DateTime DataUtworzenia { get; set; }
        /// <summary>
        /// Numer bilingu
        /// </summary>
        public string Numer { get; set; }
        /// <summary>
        /// Numer bilingu - licznik
        /// </summary>
        public int? NumerKolejny { get; set; }
        /// <summary>
        /// Numer bilingu - rok
        /// </summary>
        public int NumerRok { get; set; }
        /// <summary>
        /// Numer bilingu - miesiąc
        /// </summary>
        public int NumerMiesiac { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrah { get; set; }
        /// <summary>
        /// Relacja do kontrahenta, tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Dane wg dat
        /// </summary>
        public int? WgDat { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Suma PREFAKTURY
        /// </summary>
        public double? Suma { get; set; }
        /// <summary>
        /// Suma FAKTUR
        /// </summary>
        public double? SumaF { get; set; }
        /// <summary>
        /// Procedura generująca pozycje PREFAKTURY
        /// </summary>
        public string ProceduraSql { get; set; }
        /// <summary>
        /// Uwagi do prefaktury
        /// </summary>
        public string Uwagi { get; set; }
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
        /// <summary>
        /// 0 - pojedyncza, 1 - zbiorcza z zest, 2 - zbiorcza bez zest
        /// </summary>
        public int? Zbiorcza { get; set; }
        /// <summary>
        /// Grupowanie zbiorcze z zest.
        /// </summary>
        public string ZbGrupujWg { get; set; }
    }
}
