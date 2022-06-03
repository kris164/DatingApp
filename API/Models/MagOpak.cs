using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Magazyny opakowań
    /// </summary>
    public partial class MagOpak
    {
        public int IdMagOpak { get; set; }
        /// <summary>
        /// Lokalizacja, a zarazem magazyn
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Relacja do OPAKOWANIA
        /// </summary>
        public int OpakowaniaId { get; set; }
        /// <summary>
        /// Suma przyjęć
        /// </summary>
        public int Przyjeto { get; set; }
        /// <summary>
        /// Suma wydań
        /// </summary>
        public int Wydano { get; set; }
        /// <summary>
        /// Stan magazynu
        /// </summary>
        public int Stan { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
    }
}
