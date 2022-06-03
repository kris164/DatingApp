using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MiejscaZaWyMyjnieProc
    {
        public int IdMiejscaZaWyMyjnieProc { get; set; }
        public int MiejscaZaRozladunkuId { get; set; }
        public int PoiMyjnieProceduryId { get; set; }
    }
}
