using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WDaneZewnWz
    {
        public int IdWDaneZewnWz { get; set; }
        public DateTime? DataGodz { get; set; }
        /// <summary>
        /// Nazwa wczytanego pliku
        /// </summary>
        public string NazwaPliku { get; set; }
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Kto wczytał
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Ilość operacji w pliku
        /// </summary>
        public int? IloscOperacji { get; set; }
        public string Status { get; set; }
        public string Sid { get; set; }
    }
}
