using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Akumulatory
    /// </summary>
    public partial class TaborAkum
    {
        public int IdTaborAkum { get; set; }
        /// <summary>
        /// Numer seryjny akumulatora
        /// </summary>
        public string NrSeryjny { get; set; }
        /// <summary>
        /// Numer fabryczny akumulatora
        /// </summary>
        public string NrFabryczny { get; set; }
        /// <summary>
        /// Rodzaj akumulatora
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Marka akumulatora
        /// </summary>
        public string Marka { get; set; }
        /// <summary>
        /// Adres strony producenta
        /// </summary>
        public string AdresHttp { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string UwagiDod { get; set; }
        /// <summary>
        /// Norma
        /// </summary>
        public string Norma { get; set; }
        /// <summary>
        /// Pojemność w Ah
        /// </summary>
        public double? Ah { get; set; }
        /// <summary>
        /// Prąd rozruchu
        /// </summary>
        public double? En { get; set; }
        /// <summary>
        /// Długość
        /// </summary>
        public double? Dl { get; set; }
        /// <summary>
        /// Szerokość
        /// </summary>
        public double? Sz { get; set; }
        /// <summary>
        /// Wysokość
        /// </summary>
        public double? Wy { get; set; }
        /// <summary>
        /// Znacznik, czy zacisk dodatni znajduje sie po prawej stronie
        /// </summary>
        public int? PlusPrawa { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - typ
        /// </summary>
        public string OstTypObsl { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - nr rejstracyjny pojazdu
        /// </summary>
        public string OstTabor { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? OstTaborId { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - napięcie
        /// </summary>
        public double? OstNapiecie { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - gęstość elektrolitu
        /// </summary>
        public double? OstGestosc { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - data
        /// </summary>
        public DateTime? OstData { get; set; }
        /// <summary>
        /// Data montażu akumulatora
        /// </summary>
        public DateTime? DataZalozenia { get; set; }
        /// <summary>
        /// Data zużycia akumulatora
        /// </summary>
        public DateTime? DataZuzycia { get; set; }
        /// <summary>
        /// Data gwarancji
        /// </summary>
        public DateTime? DataGwarancji { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
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
        /// <summary>
        /// Ostatnie zdarzenie - nr boczny pojazdu
        /// </summary>
        public string OstTaborNrB { get; set; }
    }
}
