using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// nagłówek definicji interfejsu
    /// </summary>
    public partial class SfmIcDefHeader
    {
        public int IdSfmIcDefHeader { get; set; }
        /// <summary>
        /// aktywny - (0-nie/1-tak)
        /// </summary>
        public short? Isactive { get; set; }
        /// <summary>
        /// typ terminala - kod operatora
        /// </summary>
        public string Termtype { get; set; }
        /// <summary>
        /// identyfikator definicji
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// wersja definicji
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// punkt startowy ścieżki pytań
        /// </summary>
        public string QidStart { get; set; }
        /// <summary>
        /// opis definicji interfejsu
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
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// importowany - (0-nie/1-tak)
        /// </summary>
        public short? Isimported { get; set; }
    }
}
