using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Operacje na magazynie opakowań - pozycje
    /// </summary>
    public partial class MagOpakZdarzPoz
    {
        public int IdMagOpakZdarzPoz { get; set; }
        /// <summary>
        /// Relacja do MAG_OPAK_ZDARZ
        /// </summary>
        public int MagOpakZdarzId { get; set; }
        /// <summary>
        /// Lp pozycji
        /// </summary>
        public int Lp { get; set; }
        /// <summary>
        /// Relacja do OPAKOWANIA
        /// </summary>
        public int OpakowaniaId { get; set; }
        /// <summary>
        /// Ilość opakowań na dokumencie
        /// </summary>
        public int Ilosc { get; set; }
        /// <summary>
        /// Relacja do LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Relacja do PRZESYLKI
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do PACZKI
        /// </summary>
        public int? PaczkiId { get; set; }
        /// <summary>
        /// Flaga, czy rozliczona
        /// </summary>
        public int? Rozl { get; set; }
        /// <summary>
        /// Relacja do ZLECENIA
        /// </summary>
        public int? ZleceniaId { get; set; }
        /// <summary>
        /// Relacja do TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rej pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Dotyczy
        /// </summary>
        public string Dotyczy { get; set; }
        /// <summary>
        /// Relacja do FAKTURY
        /// </summary>
        public int? FakturyId { get; set; }
    }
}
