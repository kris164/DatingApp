using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rodzaje operacji w plikach bilingowych GSM
    /// </summary>
    public partial class BilingiOper
    {
        public int IdBilingiOper { get; set; }
        /// <summary>
        /// Symbol operacji
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Opis operacji
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahentId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrahent { get; set; }
        /// <summary>
        /// Znacznik, czy wczytywać kwote VAT-u
        /// </summary>
        public int? WczytujVat { get; set; }
        /// <summary>
        /// Domyślna stawka VAT
        /// </summary>
        public double? DomyslnyVat { get; set; }
        /// <summary>
        /// Domyślny rodzaj kosztu
        /// </summary>
        public string DomyslnyRodzKosztow { get; set; }
    }
}
