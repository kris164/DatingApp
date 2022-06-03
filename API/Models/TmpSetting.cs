using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpSetting
    {
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int IdSesjiKalk { get; set; }
        public string AktLokalizacja { get; set; }
        public string AktDzial { get; set; }
        public int? AktUzytkId { get; set; }
        public int? AktSystemId { get; set; }
        public int? AktSysWymDanychId { get; set; }
        public string AktZrodlo { get; set; }
        public string Recordcheckdata { get; set; }
        public int? AktLangId { get; set; }
    }
}
