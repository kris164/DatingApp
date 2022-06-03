using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabela słowników - wartości
    /// </summary>
    public partial class DictionaryValue
    {
        public int IdDictionaryValues { get; set; }
        public int DictionariesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
        public string ExtValue1 { get; set; }
        public string ExtValue2 { get; set; }
        public string ExtValue3 { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? ImageIndex { get; set; }
        public int? Visible { get; set; }
    }
}
