using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Załączniki systemowe
    /// </summary>
    public partial class ZalacznikiRodzaj
    {
        public int IdZalacznikiRodzaj { get; set; }
        /// <summary>
        /// Rodzaj załącznika
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Nie wysyłaj w mailach
        /// </summary>
        public int? BezEmail { get; set; }
        /// <summary>
        /// Symbol zewnętrzny
        /// </summary>
        public string SymbolExt { get; set; }
        /// <summary>
        /// Uwzględniaj w wysyłkach ftp
        /// </summary>
        public int? FtpKontrahenta { get; set; }
        /// <summary>
        /// Dostępny na WWW - klient
        /// </summary>
        public int? WwwK { get; set; }
        /// <summary>
        /// Dostępny na WWW - przewoźnik
        /// </summary>
        public int? WwwP { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Visible { get; set; }
    }
}
