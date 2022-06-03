using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaczkiRel
    {
        public int IdPaczkiRel { get; set; }
        /// <summary>
        /// Relacja do przesyłki pierwotnej
        /// </summary>
        public int PPrzesylkiId { get; set; }
        /// <summary>
        /// Relacja do paczki pierwotnej
        /// </summary>
        public int PPaczkiId { get; set; }
        /// <summary>
        /// Relacja do przesyłki zbiorczej
        /// </summary>
        public int ZbPrzesylkiId { get; set; }
        /// <summary>
        /// Relacja do paczki zbiorczej
        /// </summary>
        public int ZbPaczkiId { get; set; }
    }
}
