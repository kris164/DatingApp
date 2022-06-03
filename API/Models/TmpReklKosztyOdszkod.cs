using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpReklKosztyOdszkod
    {
        public int IdTmpReklKosztyOdszkod { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? ReklamacjeId { get; set; }
        public int? TypKosztuId { get; set; }
        /// <summary>
        /// Kwota kosztu
        /// </summary>
        public double? Kwota { get; set; }
        /// <summary>
        /// Waluta kosztu
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Kwota kosztu w walucie kalkulacji
        /// </summary>
        public double? KwotaK { get; set; }
        /// <summary>
        /// Waluta kalkulacji kosztu
        /// </summary>
        public string WalutaK { get; set; }
        public DateTime? KursWgDaty { get; set; }
        public int? TypTab { get; set; }
        public string TypKurs { get; set; }
        public double? KursWym { get; set; }
    }
}
