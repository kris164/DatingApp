using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpWydrukiAutomat
    {
        /// <summary>
        /// Unikalny identyfikator sesji wydruków
        /// </summary>
        public int IdSesjiKalk { get; set; }
        public string AktLokalizacja { get; set; }
        public string AktDzial { get; set; }
        public int? AktUzytkId { get; set; }
        public int? AktSystemId { get; set; }
        public int? AktSysWymDanychId { get; set; }
        public string AktZrodlo { get; set; }
    }
}
