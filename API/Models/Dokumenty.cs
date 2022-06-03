using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik dokumentów wymaganych
    /// </summary>
    public partial class Dokumenty
    {
        public int IdDokumenty { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod dokumentu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis dokumentu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy dokument domyślnie dodawany do obiektu (widoczny)
        /// </summary>
        public int? DomyslnieWidoczny { get; set; }
        /// <summary>
        /// Flaga, czy dokument domyślnie wymagany
        /// </summary>
        public int? DomyslnieWymagany { get; set; }
        /// <summary>
        /// Flaga, czy dokument systemowy - dodany przez InterLAN
        /// </summary>
        public int? Systemowy { get; set; }
        /// <summary>
        /// Oznaczenie z jakim procesem zwiazane są dokumnety: UBEZPIECZENIA,FTL..
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Status danego dokumentu w grupie np. w UBEZPIECZENIU moze byc ZGLOSZENIE
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Flaga, czy dokument domyślnie jest ROD
        /// </summary>
        public int? DomyslnieRod { get; set; }
        /// <summary>
        /// Flaga, czy dokument wymaga wprowadzenie numeru
        /// </summary>
        public int? WymagajNumer { get; set; }
        /// <summary>
        /// Do kogo zwrot ROD
        /// </summary>
        public string DomyslnieRodDo { get; set; }
        /// <summary>
        /// Flaga, czy dokument domyślnie jest eROD
        /// </summary>
        public int? DomyslnieErod { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
