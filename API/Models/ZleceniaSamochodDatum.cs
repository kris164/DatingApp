using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaSamochodDatum
    {
        public int IdZlecenia { get; set; }
        public int? SamochodId { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
