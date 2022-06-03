using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborAdrSprzet
    {
        public int IdTaborAdrSprzet { get; set; }
        public int TaborId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public int? Arch { get; set; }
        public DateTime? DataArch { get; set; }
        public string Uwagi { get; set; }
    }
}
