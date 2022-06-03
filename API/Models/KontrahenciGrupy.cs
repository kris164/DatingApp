using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje grup kontrahentów
    /// </summary>
    public partial class KontrahenciGrupy
    {
        public int IdKontrahenciGrupy { get; set; }
        /// <summary>
        /// Nazwa grupy
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Ikonka
        /// </summary>
        public int? Flaga { get; set; }
        /// <summary>
        /// Flaga, czy dana grupa ma blokadę na bycie zleceniodawcą
        /// </summary>
        public int? BlokadaZlecen { get; set; }
        /// <summary>
        /// Kto ma prawo na tworzenie/edycję zleceń dla danej grupy - symbole użytkowników rozdzielane średnikiem
        /// </summary>
        public string KtoMoze { get; set; }
        /// <summary>
        /// Flaga, czy dana grupa jest domyślna
        /// </summary>
        public int? Domyslna { get; set; }
        /// <summary>
        /// Flaga, czy dana grupa ma blokadę na bycie przewoźnikiem
        /// </summary>
        public int? BlokadaPrzewozn { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
