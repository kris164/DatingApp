using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyDrobn
    {
        public int IdOfertyDrobn { get; set; }
        public string NrOferty { get; set; }
        public int? NrOfertyKolejny { get; set; }
        public int? NrOfertyRok { get; set; }
        public int? NrOfertyMies { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public string JezykOferty { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientOsobaOdp { get; set; }
        public string KlientTel { get; set; }
        public string KlientFax { get; set; }
        public string KlientEmail { get; set; }
        public DateTime? ZapytanieData { get; set; }
        public int? ZapytanieUzytkownikId { get; set; }
        public string ZapytanieUzytkownik { get; set; }
        public string ZapytanieSposob { get; set; }
        public string ZapytanieInicjujacy { get; set; }
        public int? ZapytanieTermin { get; set; }
        public string ZapytanieUwagi { get; set; }
        public int? Zlozono { get; set; }
        public DateTime? ZlozonoData { get; set; }
        public DateTime? ZlozonoGodz { get; set; }
        public int? ZlozonoUzytkownikId { get; set; }
        public string ZlozonoUzytkownik { get; set; }
        public string ZlozonoSposob { get; set; }
        public string ZlozonoUwagi { get; set; }
        public DateTime? DataNastKont { get; set; }
        public string Status { get; set; }
        public DateTime? StatusData { get; set; }
        public string PrzyczynaOdrzucenia { get; set; }
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
        public string Dzial { get; set; }
        public int? Zalaczniki { get; set; }
        public DateTime? DataWaznWyceny { get; set; }
    }
}
