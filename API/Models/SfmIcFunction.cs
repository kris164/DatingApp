using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// funkcja interfejsu po stronie SPEED
    /// </summary>
    public partial class SfmIcFunction
    {
        public int IdSfmIcFunction { get; set; }
        /// <summary>
        /// (0/1) aktywny
        /// </summary>
        public short? Isactive { get; set; }
        /// <summary>
        /// identyfikator funkcji
        /// </summary>
        public string Fid { get; set; }
        /// <summary>
        /// wersja definicji
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// opis funkcji
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// czas utworzenia
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej modyfikacji
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// importowana - (0-nie/1-tak)
        /// </summary>
        public short? Isimported { get; set; }
    }
}
