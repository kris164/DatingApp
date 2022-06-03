using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Schemat stref kodowych
    /// </summary>
    public partial class KodStrefa
    {
        public int IdKodStrefa { get; set; }
        /// <summary>
        /// Nazwa schemtau
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy schemat dotyczy struktury sieci
        /// </summary>
        public int? StrukturaSieci { get; set; }
        /// <summary>
        /// Flaga, czy schemat dotyczy cennika
        /// </summary>
        public int? Cennik { get; set; }
        /// <summary>
        /// Typ schematu: P - dla podjęć, D - dla doreczeń
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Flaga, czy schemat dotyczy giełdy
        /// </summary>
        public int? GieldaPojazdow { get; set; }
        /// <summary>
        /// Flaga, czy schemat dotyczy odpraw celnych
        /// </summary>
        public int? Clenie { get; set; }
        /// <summary>
        /// Data początkowa okresu ważności
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data końcowa okresu ważności
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Flaga, czy schemat dotyczy tabeli kalendarza
        /// </summary>
        public int? Kalendarz { get; set; }
    }
}
