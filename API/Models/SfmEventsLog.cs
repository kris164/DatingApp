using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// rejestrowanie dodawania/aktualizacji GWY/GWJ/P/W/JAZ
    /// </summary>
    public partial class SfmEventsLog
    {
        public int IdSfmEventsLog { get; set; }
        /// <summary>
        /// typ operacji OLD/INS/UPD/SPL
        /// </summary>
        public string Akcja { get; set; }
        /// <summary>
        /// id pojazdu
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id zlecenia
        /// </summary>
        public int? IdZlecenia { get; set; }
        /// <summary>
        /// id wyjazdu
        /// </summary>
        public int? IdWyjazdy { get; set; }
        /// <summary>
        /// id zdarzenia
        /// </summary>
        public int? IdWyjazdyZdarzenia { get; set; }
        /// <summary>
        /// typ zdarzenia
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// id POI
        /// </summary>
        public int? MiejsceId { get; set; }
        /// <summary>
        /// miejsce zdarzenia
        /// </summary>
        public string Miejsce { get; set; }
        /// <summary>
        /// miasto zdarzenia
        /// </summary>
        public string Miasto { get; set; }
        /// <summary>
        /// kraj zdarzenia
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// czas trwania zdarzenia (godz)
        /// </summary>
        public double? CzasTrwania { get; set; }
        /// <summary>
        /// data-godz początku zdarzenia
        /// </summary>
        public DateTime? CzasP { get; set; }
        /// <summary>
        /// data-godz końca zdarzenia
        /// </summary>
        public DateTime? CzasK { get; set; }
        /// <summary>
        /// licznik początkowy
        /// </summary>
        public double? LkmP { get; set; }
        /// <summary>
        /// licznik końcowy
        /// </summary>
        public double? LkmK { get; set; }
        /// <summary>
        /// spalone paliwo
        /// </summary>
        public double? Paliwo { get; set; }
        /// <summary>
        /// długość geograficzna
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// szerokość geograficzna
        /// </summary>
        public double? Lat { get; set; }
    }
}
