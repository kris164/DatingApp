using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpFaktury2
    {
        public int IdTmpFaktury2 { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string WorkingCurrency { get; set; }
        public string WorkingCountry { get; set; }
        public string Waluta { get; set; }
        public int? FakturaOtrzymana { get; set; }
        public int? FakturaWalutowa { get; set; }
        public int? RozneKursy { get; set; }
        public int? VatWPln { get; set; }
        public int? AlgorytmSum { get; set; }
        public double? KursWaluty { get; set; }
        public double? VKursWaluty { get; set; }
    }
}
