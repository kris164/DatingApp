using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje obsługi opon
    /// </summary>
    public partial class TaborOponyObsl
    {
        public int IdTaborOponyObsl { get; set; }
        /// <summary>
        /// Relacja do opony - tab: TABOR_OPONY
        /// </summary>
        public int TaborOponyId { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Typ zdarzenia obsługi
        /// </summary>
        public string TypObsl { get; set; }
        /// <summary>
        /// Data zdarzenia
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina zdarzenia
        /// </summary>
        public DateTime? Godz { get; set; }
        /// <summary>
        /// Licznik pojazdu w chwili kontroli
        /// </summary>
        public double? Licznik { get; set; }
        /// <summary>
        /// Ciśnienie w oponie w chwili kontroli
        /// </summary>
        public double? Cisnienie { get; set; }
        /// <summary>
        /// Wysokość bieżnika w chwili kontroli
        /// </summary>
        public double? WysBiezn { get; set; }
        /// <summary>
        /// Dowolne uwagi do pozycji obsługi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Numer osi pojazdu
        /// </summary>
        public int? NrOsi { get; set; }
        /// <summary>
        /// Strona montażu opony
        /// </summary>
        public string Strona { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrah { get; set; }
        /// <summary>
        /// Relacja do nagłówka zlecenia warsztatowego - tab: W_ZLECENIA
        /// </summary>
        public int? WZleceniaId { get; set; }
        /// <summary>
        /// Relacja do pozycji zlecenia warsztatowego - tab: W_ZLECENIA_POZ
        /// </summary>
        public int? WZleceniaPozId { get; set; }
        /// <summary>
        /// Numer boczny pojazdu
        /// </summary>
        public string TaborNrB { get; set; }
        /// <summary>
        /// Flaga, czy reklamacja
        /// </summary>
        public int? Reklamacja { get; set; }
        /// <summary>
        /// Wysokość bieżnika w chwili kontroli 2
        /// </summary>
        public double? WysBiezn2 { get; set; }
        /// <summary>
        /// Wysokość bieżnika w chwili kontroli 3
        /// </summary>
        public double? WysBiezn3 { get; set; }
        /// <summary>
        /// Obwód opony przy legalizacji tacho
        /// </summary>
        public double? ObwodOpony { get; set; }
    }
}
