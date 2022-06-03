using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MiejscaZaWyZakazy
    {
        public int IdMiejscaZaWyZakazy { get; set; }
        public int MiejscaZaRozladunkuId { get; set; }
        public string ObiektTyp { get; set; }
        public int ObiektId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
    }
}
