using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlMOkresowe
    {
        public int IdRozlMOkresowe { get; set; }
        public DateTime? DataOd { get; set; }
        public string Rodzaj { get; set; }
        public string Opis { get; set; }
        public int? IleRat { get; set; }
        public int? CzestotliwoscRat { get; set; }
        public double? Kwota { get; set; }
        public string Waluta { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string RodzKosztow { get; set; }
        public int? Rozl { get; set; }
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
        public int? CzestotliwoscRatKMies { get; set; }
        public int? DekrPw { get; set; }
        public int? DekrPwAlg { get; set; }
        public int? DekrPwWgDaty { get; set; }
        public int? DekrZlec { get; set; }
        public int? DekrZlecAlg { get; set; }
        public int? DekrZlecWgDaty { get; set; }
        public string ProceduraSql { get; set; }
        public int? Aktywne { get; set; }
        public int? DekrBezLok { get; set; }
        public int? FakturyPozycjeId { get; set; }
    }
}
