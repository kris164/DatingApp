using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOAdrSprzet
    {
        public int IdTaborOAdrSprzet { get; set; }
        public int TaborOId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public DateTime? DataWaznosci { get; set; }
    }
}
