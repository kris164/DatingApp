using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje schematu stref kodowych - detal do KOD_STREFA
    /// </summary>
    public partial class KodStrefaPoz
    {
        public int IdKodStrefaPoz { get; set; }
        /// <summary>
        /// Relacja do schematu - tab: KOD_STREFA
        /// </summary>
        public int? KodStrefaId { get; set; }
        /// <summary>
        /// Nazwa schemtau
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Strefa
        /// </summary>
        public string Strefa { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
        public DateTime? ZalGodzOd { get; set; }
        public DateTime? ZalGodzDo { get; set; }
        public DateTime? RozGodzOd { get; set; }
        public DateTime? RozGodzDo { get; set; }
        public DateTime? DostawyNaGodzOd { get; set; }
        public DateTime? DostawyNaGodzDo { get; set; }
        public DateTime? GodzGraniczna { get; set; }
        public int? MaxDniOpoznienia { get; set; }
        public string Podstrefa1 { get; set; }
        public string Podstrefa2 { get; set; }
        public string Podstrefa3 { get; set; }
        public string GlowneMiasto { get; set; }
        public string Gmina { get; set; }
        public string Gmina2 { get; set; }
        public string Rejon { get; set; }
        public string TypAglomeracji { get; set; }
        public string StrefaOdleglosci { get; set; }
        public double? OdlegloscOdHub { get; set; }
        public int? PartnerId { get; set; }
        public string Partner { get; set; }
        public int? Sekwencja { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Numeryczna postac kodu
        /// </summary>
        public int? Zip { get; set; }
        public double? OdlegloscDoHubNadrz { get; set; }
    }
}
