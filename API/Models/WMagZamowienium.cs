using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagZamowienium
    {
        public int IdWMagZamowienia { get; set; }
        public string Magazyn { get; set; }
        public DateTime? DataZam { get; set; }
        public string NrZam { get; set; }
        public int? NrZamKolejny { get; set; }
        public int? NrZamRok { get; set; }
        public int? NrZamMies { get; set; }
        public string Status { get; set; }
        public int KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public int? IloscPoz { get; set; }
        public double? WartoscZakupuPozN { get; set; }
        public string NrFaktury { get; set; }
        public int? NrFakturyId { get; set; }
        public string NrPz { get; set; }
        public int? NrPzId { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? Zalaczniki { get; set; }
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
