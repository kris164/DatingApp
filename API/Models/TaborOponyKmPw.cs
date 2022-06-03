using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przebiegi dla opon wg PW
    /// </summary>
    public partial class TaborOponyKmPw
    {
        public int IdTaborOponyKmPw { get; set; }
        /// <summary>
        /// Relacja do opony - tab: TABOR_OPONY
        /// </summary>
        public int TaborOponyId { get; set; }
        /// <summary>
        /// Relacja do wyjazdu - tab: WYJAZDY
        /// </summary>
        public int WyjazdyId { get; set; }
        /// <summary>
        /// Przejechane km
        /// </summary>
        public int Odleglosc { get; set; }
    }
}
