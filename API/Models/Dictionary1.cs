using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabela słowników
    /// </summary>
    public partial class Dictionary1
    {
        public int IdDictionaries { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ReadOnly { get; set; }
    }
}
