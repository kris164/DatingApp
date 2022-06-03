using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Harmonogramy tras międzyoddziałowych
    /// </summary>
    public partial class RouteTimetab
    {
        public int IdRouteTimetab { get; set; }
        /// <summary>
        /// Oznaczenie relacji np. POZ-WAW
        /// </summary>
        public string Relacja { get; set; }
        /// <summary>
        /// Numer LH np. POZWAW1
        /// </summary>
        public string NrLinii { get; set; }
        /// <summary>
        /// Z jakiej lokalizacji
        /// </summary>
        public string LokalizacjaOd { get; set; }
        /// <summary>
        /// Do jakiej lokalizacji
        /// </summary>
        public string LokalizacjaDo { get; set; }
        /// <summary>
        /// Data ważności od
        /// </summary>
        public DateTime? WaznaOd { get; set; }
        /// <summary>
        /// Data wazności do
        /// </summary>
        public DateTime? WaznaDo { get; set; }
        /// <summary>
        /// Rodzaj generowanych tras
        /// </summary>
        public string RodzajTrasy { get; set; }
        /// <summary>
        /// Data/godz ostatniego generowania
        /// </summary>
        public DateTime? DtGeneracji { get; set; }
        /// <summary>
        /// Automatyczne anulowanie
        /// </summary>
        public double? GodzAutoAnul { get; set; }
        /// <summary>
        /// Przez jaką lokalizację
        /// </summary>
        public string LokalizacjaVia { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Przez jaką lokalizację 2
        /// </summary>
        public string LokalizacjaVia2 { get; set; }
        /// <summary>
        /// Czy trasa łamana
        /// </summary>
        public int? Lamana { get; set; }
        /// <summary>
        /// Czy trasa z podłogi
        /// </summary>
        public int? ZPodlogi { get; set; }
        /// <summary>
        /// Czy trasa w kółku
        /// </summary>
        public int? Kolko { get; set; }
        /// <summary>
        /// Czy trasa DIRECT
        /// </summary>
        public int? Direct { get; set; }
        /// <summary>
        /// Czy trasa TEMP+
        /// </summary>
        public int? TempPlus { get; set; }
        /// <summary>
        /// TEMP+ wartość
        /// </summary>
        public double? TempPlusWart { get; set; }
        /// <summary>
        /// Czy wymagany pojazd ADR
        /// </summary>
        public int? WymagAdr { get; set; }
        /// <summary>
        /// Norma EU
        /// </summary>
        public string NormaEu { get; set; }
        /// <summary>
        /// Inne parametry 1
        /// </summary>
        public string Inne1 { get; set; }
        /// <summary>
        /// Inne parametry 2
        /// </summary>
        public string Inne2 { get; set; }
        /// <summary>
        /// Inne parametry 3
        /// </summary>
        public string Inne3 { get; set; }
        /// <summary>
        /// Inne parametry 4
        /// </summary>
        public string Inne4 { get; set; }
        /// <summary>
        /// Inne parametry 5
        /// </summary>
        public string Inne5 { get; set; }
        /// <summary>
        /// Inne parametry 6
        /// </summary>
        public string Inne6 { get; set; }
    }
}
