using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPospool
    {
        public int IdSfmPospool { get; set; }
        public DateTime? Czas { get; set; }
        public int IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public int? IdUzytk { get; set; }
        public string Nazwauzytk { get; set; }
        public short? Stat { get; set; }
        public string Blad { get; set; }
        public int? IdSfmPos { get; set; }
    }
}
