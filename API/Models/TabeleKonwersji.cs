using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabele konwersji danych - na potrzeby interfejsów
    /// </summary>
    public partial class TabeleKonwersji
    {
        public int IdTabeleKonwersji { get; set; }
        /// <summary>
        /// Nazwa interfejsu
        /// </summary>
        public string IntfName { get; set; }
        /// <summary>
        /// Nazwa słownika
        /// </summary>
        public string Slownik { get; set; }
        /// <summary>
        /// Kod SPEED. 1
        /// </summary>
        public string KodSpeed { get; set; }
        /// <summary>
        /// Kod zewn. 1
        /// </summary>
        public string KodExt { get; set; }
        /// <summary>
        /// Kod zewn. 2
        /// </summary>
        public string KodExt2 { get; set; }
        /// <summary>
        /// Relacja do systemów wymiany danych - tab: SYST_WYM_DANYCH
        /// </summary>
        public int? SystWymDanychId { get; set; }
        /// <summary>
        /// Kod SPEED. 2
        /// </summary>
        public string KodSpeed2 { get; set; }
        /// <summary>
        /// Opis do pozycji słownikowej zewnetrznej
        /// </summary>
        public string OpisExt { get; set; }
        /// <summary>
        /// Flaga, czy blokować wysyłanie
        /// </summary>
        public int? BlokadaStop { get; set; }
    }
}
