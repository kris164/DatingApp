using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiAdr
    {
        public int IdTmpPrzesylkiAdr { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// ADR - kod UN
        /// </summary>
        public string Un { get; set; }
        /// <summary>
        /// ADR - Grupa
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// ADR - Klasa
        /// </summary>
        public string Klasa { get; set; }
        /// <summary>
        /// ADR - Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// ADR - Ograniczenia tuneli
        /// </summary>
        public string Tunele { get; set; }
        /// <summary>
        /// ADR - Ilosć
        /// </summary>
        public double? Ilosc { get; set; }
        /// <summary>
        /// ADR - Ilość opis opakowania
        /// </summary>
        public string IloscOpisOpak { get; set; }
        /// <summary>
        /// ADR - Ilość całkowita
        /// </summary>
        public double? IloscCalk { get; set; }
        /// <summary>
        /// ADR - Nalepki
        /// </summary>
        public string Nalepki { get; set; }
        /// <summary>
        /// ADR - Miara
        /// </summary>
        public string Miara { get; set; }
        /// <summary>
        /// ADR - Kategoria transp
        /// </summary>
        public string KatTransp { get; set; }
        /// <summary>
        /// ADR - Dodatkowy opis
        /// </summary>
        public string OpisDod { get; set; }
        /// <summary>
        /// ADR - Ilość do wyliczeń
        /// </summary>
        public double? IloscDoWyliczen { get; set; }
        /// <summary>
        /// Id
        /// </summary>
        public int? IdPrzesylkiAdr { get; set; }
        /// <summary>
        /// ADR - Ilość do wyliczeń
        /// </summary>
        public double? PktOblicz { get; set; }
        /// <summary>
        /// ADR - Ilość do wyliczeń
        /// </summary>
        public double? PktRecznie { get; set; }
        public double? IloscLqAdr { get; set; }
        public string IloscOgrLq { get; set; }
        public double? IloscOgrLqObl { get; set; }
        public int? AdrEnv { get; set; }
        public int? IsP274 { get; set; }
        /// <summary>
        /// Przepisy szczególne
        /// </summary>
        public string PrzepisySzcz { get; set; }
    }
}
