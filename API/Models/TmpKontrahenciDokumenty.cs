using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenciDokumenty
    {
        public int IdTmpKontrahenciDokumenty { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod dokumentu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy domyślny
        /// </summary>
        public int? Domyslny { get; set; }
        /// <summary>
        /// Flaga, czy wymagany
        /// </summary>
        public int? Wymagany { get; set; }
        /// <summary>
        /// Flaga, czy ROD
        /// </summary>
        public int? Rod { get; set; }
        /// <summary>
        /// Flaga, czy eROD
        /// </summary>
        public int? Erod { get; set; }
        /// <summary>
        /// Do kogo zwrot ROD
        /// </summary>
        public string RodDo { get; set; }
        /// <summary>
        /// Grupa dokumentu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Status dokumentu
        /// </summary>
        public string Status { get; set; }
        public int? IdKontrahenciDokumenty { get; set; }
    }
}
