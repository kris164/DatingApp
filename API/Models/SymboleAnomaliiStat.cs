using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Symbole anomalii - powiązanie ze statusami
    /// </summary>
    public partial class SymboleAnomaliiStat
    {
        public int IdSymboleAnomaliiStat { get; set; }
        /// <summary>
        /// Relacja do SYMBOLE_ANOMALII
        /// </summary>
        public int SymboleAnomaliiId { get; set; }
        /// <summary>
        /// Relacja do statusu
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Domyślny
        /// </summary>
        public int? Domyslny { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy mSPEED
        /// </summary>
        public short? Mobile { get; set; }
        /// <summary>
        /// Wersja na mobile-u
        /// </summary>
        public int? MobileVersion { get; set; }
        /// <summary>
        /// Flaga, czy kod aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy dana anomalia wymaga podania opisu dodatkowego
        /// </summary>
        public short? WymOpisDod { get; set; }
        /// <summary>
        /// Flaga, czy dana anomalia dotyczy opakowania
        /// </summary>
        public short? DotOpakowan { get; set; }
        /// <summary>
        /// Flaga, czy dana anomalia wymaga podania ilości
        /// </summary>
        public short? WymIlosc { get; set; }
        /// <summary>
        /// Flaga, czy zaznaczyć brak na trasie
        /// </summary>
        public short? Brak { get; set; }
        /// <summary>
        /// Flaga, czy zaznaczyć brak na trasie
        /// </summary>
        public short? BrakWy { get; set; }
        /// <summary>
        /// Flaga, czy udostępnić w skanerze
        /// </summary>
        public short? Skaner { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy uwagi
        /// </summary>
        public short? Uwaga { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy mSPEED
        /// </summary>
        public short? MobilePhotoDoc { get; set; }
    }
}
