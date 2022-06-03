using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyGrupy
    {
        public int IdKierowcyGrupy { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string KontoFk { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
