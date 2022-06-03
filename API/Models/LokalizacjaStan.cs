using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Powiązanie działó z lokalizacjami
    /// </summary>
    public partial class LokalizacjaStan
    {
        public int IdLokalizacjaStan { get; set; }
        /// <summary>
        /// Kod lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Flaga stanu 0/1
        /// </summary>
        public int Stan { get; set; }
    }
}
