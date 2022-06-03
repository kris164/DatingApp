using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Kompensaty
    {
        public int IdKompensaty { get; set; }
        public string Numer { get; set; }
        public int? NumerKolejny { get; set; }
        public int? NumerRok { get; set; }
        public int? NumerMies { get; set; }
        public DateTime? Data { get; set; }
        public string Status { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string Waluta { get; set; }
        public string Naglowek { get; set; }
        public string Stopka { get; set; }
        public double? DoRozliczenia { get; set; }
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
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? TylkoLokAkt { get; set; }
        public int? RowniezWarsztat { get; set; }
        public string WalutaDok { get; set; }
        public int? TabKursId { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
