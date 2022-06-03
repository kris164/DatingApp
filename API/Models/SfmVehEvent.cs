using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// wybrane zdarzenia z pojazdu (np granice)
    /// </summary>
    public partial class SfmVehEvent
    {
        public int IdSfmVehEvents { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// ID terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// typ terminala (operator)
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// ID taboru
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// ID naczepy
        /// </summary>
        public int? IdNaczepa { get; set; }
        /// <summary>
        /// ID pierwszego kierowcy
        /// </summary>
        public int? IdKierowcy1 { get; set; }
        /// <summary>
        /// ID drugiego kierowcy
        /// </summary>
        public int? IdKierowcy2 { get; set; }
        /// <summary>
        /// typ zdarzenia
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// czas zdarzenia
        /// </summary>
        public DateTime? Dt { get; set; }
        /// <summary>
        /// GPS E/W (+/-)
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// GPS N/S (+/-)
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// licznik kilometrów [km]
        /// </summary>
        public int? Lkm { get; set; }
        /// <summary>
        /// P0 - ID pozycji
        /// </summary>
        public int? P0IdSfmPos { get; set; }
        /// <summary>
        /// P0 - ID_MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? P0MiejsceId { get; set; }
        /// <summary>
        /// P0 - Kraj
        /// </summary>
        public string P0Kraj { get; set; }
        /// <summary>
        /// P0 - Miasto
        /// </summary>
        public string P0Miasto { get; set; }
        /// <summary>
        /// P1 - ID pozycji
        /// </summary>
        public int? P1IdSfmPos { get; set; }
        /// <summary>
        /// P1 - ID_MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? P1MiejsceId { get; set; }
        /// <summary>
        /// P1 - Kraj
        /// </summary>
        public string P1Kraj { get; set; }
        /// <summary>
        /// P1 - Miasto
        /// </summary>
        public string P1Miasto { get; set; }
        /// <summary>
        /// status zdarzenia (-1-nowe /0-gotowe /1-przetworzone /99-błąd)
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// treść błędu
        /// </summary>
        public string Statustxt { get; set; }
    }
}
