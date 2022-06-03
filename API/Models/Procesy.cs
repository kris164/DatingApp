using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje automat. procesów sytemowych
    /// </summary>
    public partial class Procesy
    {
        public int IdProcesy { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Nazwa procesu
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// Plik BPL z akcją do wykonania
        /// </summary>
        public string Plik { get; set; }
        /// <summary>
        /// Wskaźnik do procedury w pliku BPL
        /// </summary>
        public string Procedura { get; set; }
        /// <summary>
        /// Częsctotliwość wykonywania
        /// </summary>
        public string Czestotliwosc { get; set; }
        /// <summary>
        /// Data następnego wykonania
        /// </summary>
        public DateTime? DataNastWykonania { get; set; }
        /// <summary>
        /// Data poprzedniego wykonania
        /// </summary>
        public DateTime? DataPoprzWykonania { get; set; }
        /// <summary>
        /// Godzina poprzedniego wykonania
        /// </summary>
        public DateTime? GodzPoprzWykonania { get; set; }
        /// <summary>
        /// Kto moze wykonywać - lista symboli użytkowników rozdzielona średnikami
        /// </summary>
        public string KtoMoze { get; set; }
        /// <summary>
        /// Kto ostatnio wykonywał
        /// </summary>
        public string KtoOstatnio { get; set; }
        /// <summary>
        /// Czy proces aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// W jakiej aplikacji ma się uruchamiać (SPEED, WARSZTAT etc)
        /// </summary>
        public string Aplikacja { get; set; }
    }
}
