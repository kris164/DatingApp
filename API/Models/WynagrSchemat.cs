using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrSchemat
    {
        public int IdWynagrSchemat { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Aktywny { get; set; }
        public string RodzKosztow { get; set; }
        public string ProceduraDbDekr { get; set; }
    }
}
