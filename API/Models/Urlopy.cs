using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Urlopy
    {
        public int IdUrlopy { get; set; }
        public int? KierowcyId { get; set; }
        public string Kierowcy { get; set; }
        public string Rodzaj { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? IloscDni { get; set; }
        public int? Platny { get; set; }
        public int? Kolor { get; set; }
        public string RodzajKod { get; set; }
        public DateTime? CzasOd { get; set; }
        public DateTime? CzasDo { get; set; }
        public string KodNieobecnosci { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public int? WTacho { get; set; }
        public int? ZdjetoPrzydzial { get; set; }
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
        public int? Cykliczny { get; set; }
        public int? CyklicznyGenerujCoIle { get; set; }
        public DateTime? CyklicznyGenerujDoDnia { get; set; }
        public int? CyklicznyUrlopyId { get; set; }
        public int? PoiId { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        public int? IloscDniR { get; set; }
        /// <summary>
        /// Status urlopu
        /// </summary>
        public string Status { get; set; }
    }
}
