using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaZbZdarzenium
    {
        public int IdTmpZleceniaZbZdarzenia { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? LpZleceniaZb { get; set; }
        public string Typ { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
    }
}
