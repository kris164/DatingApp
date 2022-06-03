using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WezwaniaDoZapl
    {
        public int IdWezwaniaDoZapl { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataWyslania { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public int? Ostateczne { get; set; }
        public int? LiczOdsetki { get; set; }
        public double? KosztMonitu { get; set; }
        public string KosztMonituWal { get; set; }
        public double? KosztWind { get; set; }
        public string KosztWindWal { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public string Naglowek { get; set; }
        public string Tresc { get; set; }
        public string JezykWydruku { get; set; }
        public string Stopka { get; set; }
        public int? NotaId { get; set; }
        public string Nota { get; set; }
        public int? KontoId { get; set; }
        public string Konto { get; set; }
        public int? Iban { get; set; }
        public string WydrukSporzadzil { get; set; }
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
        public string Waluta { get; set; }
        public int? StatusWindykacji { get; set; }
        public int? Aktywne { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public string KontrahTyp { get; set; }
    }
}
