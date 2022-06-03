using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyAloty
    {
        public int IdPromyAloty { get; set; }
        public string Status { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public int? RelacjaId { get; set; }
        public string Relacja { get; set; }
        public string RelacjaSymbol { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Uwagi { get; set; }
        public DateTime? UtwOd { get; set; }
        public DateTime? UtwDo { get; set; }
        public int? ProcWyk { get; set; }
        public int? Korekta { get; set; }
        public int? KorektaDoId { get; set; }
        public int? LiniaId { get; set; }
        public string Linia { get; set; }
        public string SrTransp { get; set; }
        public int? CennikId { get; set; }
    }
}
