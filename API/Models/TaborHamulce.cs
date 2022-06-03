using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborHamulce
    {
        public int IdTaborHamulce { get; set; }
        public int? TaborId { get; set; }
        public string NrOsi { get; set; }
        public int? TarczoweBebnowe { get; set; }
        public string Rodzaj { get; set; }
        public string Marka { get; set; }
        public string NrId { get; set; }
        public string TarczaRodzaj { get; set; }
        public string TarczaRozm { get; set; }
        public string TarczaNr { get; set; }
        public string ZaciskRodzaj { get; set; }
        public string ZaciskRozm { get; set; }
        public string ZaciskNr { get; set; }
        public DateTime? TarczaDataGwarancji { get; set; }
        public int? TarczaKmGwarancji { get; set; }
    }
}
