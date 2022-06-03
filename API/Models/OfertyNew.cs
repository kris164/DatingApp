using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyNew
    {
        public int IdOfertyNew { get; set; }
        public string NrOferty { get; set; }
        public int? NrOfertyKolejny { get; set; }
        public int? NrOfertyRok { get; set; }
        public int? NrOfertyMies { get; set; }
        public int? Zalaczniki { get; set; }
        public string JezykOferty { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public DateTime? DataOferty { get; set; }
        public DateTime? DataWaznOferty { get; set; }
        public DateTime? DataWaznWyceny { get; set; }
        public int? MinTermAwizacji { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientOsobaKont { get; set; }
        public string KlientOsobaTel { get; set; }
        public string KlientOsobaEmail { get; set; }
        public int? PlatnikId { get; set; }
        public string PlatnikSymbol { get; set; }
        public string PlatnikNazwa { get; set; }
        public string PlatnikAdres { get; set; }
        public string PlatnikMiasto { get; set; }
        public string PlatnikKod { get; set; }
        public string PlatnikKraj { get; set; }
        public string PlatnikNip { get; set; }
        public string Uwagi { get; set; }
        public string Status { get; set; }
        public DateTime? DataZlozenia { get; set; }
        public string SposobZlozenia { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string NrZleceniaK { get; set; }
        public int Anulowana { get; set; }
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
        public DateTime? DataWaznOfertyOd { get; set; }
    }
}
