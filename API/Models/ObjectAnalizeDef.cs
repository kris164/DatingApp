using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Analizy dla obiektów
    /// </summary>
    public partial class ObjectAnalizeDef
    {
        public int IdObjectAnalizeDef { get; set; }
        /// <summary>
        /// Relacja do OBJECT
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>
        /// Relacja do OLAP_DEFINICJE
        /// </summary>
        public int AnalizeId { get; set; }
        /// <summary>
        /// Nazwa analizy
        /// </summary>
        public string Name { get; set; }
    }
}
