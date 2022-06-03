using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Załączniki do poczty przychodzącej (E-Mail integrator)
    /// </summary>
    public partial class MailInAttach
    {
        public int IdMailInAttach { get; set; }
        /// <summary>
        /// Relacja do nagłówka wiadomości - tab: MAIL_IN
        /// </summary>
        public int? MailInId { get; set; }
        /// <summary>
        /// Nazwa pliku
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Zawartość pliku
        /// </summary>
        public byte[] Body { get; set; }
    }
}
