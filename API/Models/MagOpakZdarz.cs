using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Operacje na magazynie opakowań
    /// </summary>
    public partial class MagOpakZdarz
    {
        public int IdMagOpakZdarz { get; set; }
        /// <summary>
        /// Typ operacji PZ/WZ/MM/BO
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Lokalizacja, a zarazem magazyn
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Godzina
        /// </summary>
        public DateTime? Godz { get; set; }
        /// <summary>
        /// Numer dokumentu PZ/WZ/MM/BO
        /// </summary>
        public string Numer { get; set; }
        /// <summary>
        /// Numer - kolejny
        /// </summary>
        public int NumerKolejny { get; set; }
        /// <summary>
        /// Numer - rok
        /// </summary>
        public int NumerRok { get; set; }
        /// <summary>
        /// Numer - miesiąc
        /// </summary>
        public int NumerMies { get; set; }
        /// <summary>
        /// Relacja do KONTRAHENCI
        /// </summary>
        public int? PrzewoznikId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Przewoznik { get; set; }
        /// <summary>
        /// Relacja do KIEROWCY
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// Nazwisko i imie kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// Suma ilość na dokumencie
        /// </summary>
        public int SumaIlosc { get; set; }
        /// <summary>
        /// Status dokumentu O/Z
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Uwagi
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
        /// Relacja do KONTRAHENCI
        /// </summary>
        public int? KontrahentId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrahent { get; set; }
        /// <summary>
        /// Flaga, czy wewnętrzne
        /// </summary>
        public int Wewn { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Żródło
        /// </summary>
        public string Zrodlo { get; set; }
    }
}
