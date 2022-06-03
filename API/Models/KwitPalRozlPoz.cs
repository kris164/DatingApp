using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KwitPalRozlPoz
    {
        public int IdKwitPalRozlPoz { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL_ROZL
        /// </summary>
        public int? KwitPalRozlId { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL_POZ
        /// </summary>
        public int? KwitPalPozId { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL
        /// </summary>
        public int? KwitPalId { get; set; }
        /// <summary>
        /// Numer kwitu
        /// </summary>
        public string KwitPal { get; set; }
        /// <summary>
        /// Data kwitu
        /// </summary>
        public DateTime? DataKw { get; set; }
        /// <summary>
        /// Relacja do trasy
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Nr trasy
        /// </summary>
        public string ListyLiniowe { get; set; }
        /// <summary>
        /// Relacja do przesyłki
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Nr przesyłki
        /// </summary>
        public string Przesylki { get; set; }
        /// <summary>
        /// Lokalizacja nadzorująca z przesyłki
        /// </summary>
        public string LokalizacjaNadz { get; set; }
        /// <summary>
        /// Relacja do paczki
        /// </summary>
        public int? PaczkiId { get; set; }
        /// <summary>
        /// Nr paczki
        /// </summary>
        public string Paczki { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Opakowanie
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Ilość opakowań
        /// </summary>
        public int? Ilosc { get; set; }
        /// <summary>
        /// * nie używane *
        /// </summary>
        public int? KwitPalRozlLokId { get; set; }
        /// <summary>
        /// Ilość opakowań rozliczona na ROZL_LOK
        /// </summary>
        public int? IloscRozlLok { get; set; }
        /// <summary>
        /// 0 - DORĘCZENIE, 1 - PZ, 2 - WZ, 3 - KWIT
        /// </summary>
        public int? TypRozl { get; set; }
        public int? ObjId { get; set; }
        public int? ObjPozId { get; set; }
        public int? BilansOpakLokId { get; set; }
        /// <summary>
        /// Relacja do zlecenia FTL
        /// </summary>
        public int? ZleceniaId { get; set; }
        /// <summary>
        /// Nr zlecenia FTL
        /// </summary>
        public string Zlecenia { get; set; }
    }
}
