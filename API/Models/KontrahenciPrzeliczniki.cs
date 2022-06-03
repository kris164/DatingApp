using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje przeliczników wartości dla kontrahenta
    /// </summary>
    public partial class KontrahenciPrzeliczniki
    {
        public int IdKontrahenciPrzeliczniki { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Z jakiej wartości
        /// </summary>
        public int? WartoscZ { get; set; }
        /// <summary>
        /// Z jakiej jednostki miary
        /// </summary>
        public string JmZ { get; set; }
        /// <summary>
        /// Do jakiej wartości
        /// </summary>
        public int? WartoscDo { get; set; }
        /// <summary>
        /// Do jakiej jednostki miary
        /// </summary>
        public string JmDo { get; set; }
        public double? Jt { get; set; }
    }
}
