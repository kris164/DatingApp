using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// *kontrahenci dla e-speed*
    /// </summary>
    public partial class KontrahenciWww
    {
        public int IdKontrahenciWww { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KlientId { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Ulica { get; set; }
        public string NrDom { get; set; }
        public string NrLok { get; set; }
        public string Miejscowosc { get; set; }
        public string Kod { get; set; }
        public string Kraj { get; set; }
        public string OsobaKontaktowa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
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
