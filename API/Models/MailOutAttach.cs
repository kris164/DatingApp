using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Załączniki do poczty wychodzącej (E-Mail integrator)
    /// </summary>
    public partial class MailOutAttach
    {
        public int IdMailOutAttach { get; set; }
        /// <summary>
        /// Relacja do nagłówka wiadomości - tab: MAIL_OUT
        /// </summary>
        public int? MailOutId { get; set; }
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
