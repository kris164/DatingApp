using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozliczenia palet w drobnicy
    /// </summary>
    public partial class KwitPalRozl
    {
        public int IdKwitPalRozl { get; set; }
        /// <summary>
        /// Data ROZL
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Numer ROZL
        /// </summary>
        public string NrRozl { get; set; }
        /// <summary>
        /// Numer kolejny z licznika
        /// </summary>
        public int? NrRozlKolejny { get; set; }
        /// <summary>
        /// Rok z licznika
        /// </summary>
        public int? NrRozlRok { get; set; }
        /// <summary>
        /// Miesiac z licznika
        /// </summary>
        public int? NrRozlMies { get; set; }
        /// <summary>
        /// Typ klienta 0 - odbiorca, 1 - przewoznik, 2 - nadawca
        /// </summary>
        public int? KlientTyp { get; set; }
        /// <summary>
        /// Relacja do klienta
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol klienta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
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
        /// 0 - z doreczeń, 1 - z magazynu
        /// </summary>
        public int? RozlZ { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        public string TypFv { get; set; }
        public int? FakturaId { get; set; }
        public string Uwagi { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
    }
}
