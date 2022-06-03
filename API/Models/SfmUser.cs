using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmUser
    {
        public int IdUzytk { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public short? Dyspozytor { get; set; }
    }
}
