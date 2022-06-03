using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik rodzajów kosztów
    /// </summary>
    public partial class RodzKosztow
    {
        public int IdRodzKosztow { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Opis rodzaju kosztów
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy rodzaj kosztu dotyczy zakupu paliwa
        /// </summary>
        public int? Paliwo { get; set; }
        /// <summary>
        /// Flaga, czy rodzaj kosztu dotyczy diet
        /// </summary>
        public int? Dieta { get; set; }
        /// <summary>
        /// Konto księgowe
        /// </summary>
        public string Konto { get; set; }
        /// <summary>
        /// Wyróznik kosztu 1
        /// </summary>
        public string Wyroznik { get; set; }
        /// <summary>
        /// Flaga, czy rodzaj kosztu jest systemowy - utworzony przez InterLAN
        /// </summary>
        public int? Systemowy { get; set; }
        /// <summary>
        /// Flaga, czy koszty danego rodzaju uwzględniać w rozl. kierowców (podst. prowizji)
        /// </summary>
        public int? UwzglRozlKier { get; set; }
        /// <summary>
        /// Flaga, czy koszty danego rodzaju uwzględniać w rozl. spedytorów
        /// </summary>
        public int? UwzglRozlSped { get; set; }
        /// <summary>
        /// Flaga czy dodatek (0) czy obicążenie (1) od podst. prowizji
        /// </summary>
        public int? StrRozlKier { get; set; }
        /// <summary>
        /// Flaga, czy uwzględniać przy rejestracji kosztów na liście kierowców
        /// </summary>
        public int? DodKosztyOg { get; set; }
        /// <summary>
        /// Flaga, czy koszt z danym rodzajem kosztu wymaga podania licznika pojazdu
        /// </summary>
        public int? WymagLicznik { get; set; }
        /// <summary>
        /// Flaga, czy koszty danego rodzaju uwzględniać w rozl. kierowców (pensja)
        /// </summary>
        public int? UwzglRozlKier2 { get; set; }
        /// <summary>
        /// Flaga czy dodatek (0) czy obicążenie (1) od pensji
        /// </summary>
        public int? StrRozlKier2 { get; set; }
        /// <summary>
        /// Flaga, czy rodzaj kosztu dotyczy zakupu AdBlue
        /// </summary>
        public int? Adblue { get; set; }
        /// <summary>
        /// Konto księgowe grupy 5
        /// </summary>
        public string Konto5 { get; set; }
        /// <summary>
        /// Flaga, czy dodawać koszt do rejestru kosztów międzyokresowych
        /// </summary>
        public int? DodKosztyMo { get; set; }
        /// <summary>
        /// Flaga, czy koszt z danym rodzajem kosztu wymaga podania pojazdu
        /// </summary>
        public int? WymagTabor { get; set; }
        /// <summary>
        /// Konto księgowe rezerw
        /// </summary>
        public string KontoRezerw { get; set; }
        /// <summary>
        /// Wyróżnik kosztu 2
        /// </summary>
        public string Wyroznik1 { get; set; }
        /// <summary>
        /// Grupa rodzajów kosztów
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Flaga, czy rodzaj kosztu jest aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy koszt nieudokumentowany (dla potrzeb rozl. zaliczek)
        /// </summary>
        public int? Nieudokumentowany { get; set; }
        /// <summary>
        /// Konto księgowe warsztatu
        /// </summary>
        public string KontoWar { get; set; }
        public int? RozlMo { get; set; }
        public int? BezKsiegowania { get; set; }
        public int? SplitPayment { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
