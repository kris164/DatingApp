using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Numery mnemonic dla generatora subkont
    /// </summary>
    public partial class SubkontoMnemonic
    {
        public int IdSubkontoMnemonic { get; set; }
        /// <summary>
        /// Numer banku
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// Nazwa banku
        /// </summary>
        public string BankNazwa { get; set; }
        /// <summary>
        /// Bank w którym prowadzony jest rachunek
        /// </summary>
        public string Mnemonic { get; set; }
        /// <summary>
        /// Waluta rachunku
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Kod SWIFT - dla operacji miedzynarodowych
        /// </summary>
        public string SwiftCode { get; set; }
        /// <summary>
        /// Oznaczenie kraju dla formatu IBAN
        /// </summary>
        public string KrajIban { get; set; }
    }
}
