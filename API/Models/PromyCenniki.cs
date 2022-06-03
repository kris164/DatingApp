using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyCenniki
    {
        public int IdPromyCenniki { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public int? RelacjaId { get; set; }
        public string Relacja { get; set; }
        public string RelacjaSymbol { get; set; }
        public double? KosztyPromu { get; set; }
        public string KosztyPromuWal { get; set; }
        public DateTime? GodzWypl { get; set; }
        public int? DlOd { get; set; }
        public int? DlDo { get; set; }
        public double? CenaSp { get; set; }
        public string CenaSpWal { get; set; }
        public int? LiniaId { get; set; }
        public string Linia { get; set; }
        public int? WszystkieDniTyg { get; set; }
        public string DzienTyg { get; set; }
    }
}
