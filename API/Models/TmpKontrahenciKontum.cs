using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenciKontum
    {
        public int IdTmpKontrahenciKonta { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Oznaczenie kraju dla formatu IBAN
        /// </summary>
        public string KrajIban { get; set; }
        /// <summary>
        /// Numer rachunku
        /// </summary>
        public string Konto { get; set; }
        /// <summary>
        /// Bank w którym prowadzony jest rachunek
        /// </summary>
        public string Bank { get; set; }
        /// <summary>
        /// Kod SWIFT - dla operacji miedzynarodowych
        /// </summary>
        public string SwiftCode { get; set; }
        /// <summary>
        /// Waluta rachunku
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Flaga czy konto domyslne (dla waluty)
        /// </summary>
        public int? Domyslne { get; set; }
        /// <summary>
        /// Flaga czy konto dla COD
        /// </summary>
        public int? Cod { get; set; }
        /// <summary>
        /// Flaga czy subkonto z generatora
        /// </summary>
        public int? SubGener { get; set; }
        /// <summary>
        /// Relacja do kontrahenta dla któego wygenerowano to subkonto - tab: KONTRAHENCI
        /// </summary>
        public int? SubGenerKontrahId { get; set; }
        /// <summary>
        /// Relacja do definicji subkont - tab: SUBKONTO_MNEMONIC
        /// </summary>
        public int? SubkontoMnemonicId { get; set; }
        /// <summary>
        /// Symbol kontrahenta-faktora
        /// </summary>
        public string Faktor { get; set; }
        /// <summary>
        /// Relacja do kontrahenta-faktora - tab: KONTRAHENCI
        /// </summary>
        public int? FaktorId { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
    }
}
