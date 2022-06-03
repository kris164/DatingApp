using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzFtlKosztFrachtStawki
    {
        public string Przewoznik { get; set; }
        public string Nrrejestracyjny { get; set; }
        public string Waluta { get; set; }
        public string DataOd { get; set; }
        public string Aktywny { get; set; }
        public string WierszTytulowy { get; set; }
        public int? Wie { get; set; }
        public int? Kol { get; set; }
        public string Wynik { get; set; }
    }
}
