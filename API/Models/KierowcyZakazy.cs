using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyZakazy
    {
        public int IdKierowcyZakazy { get; set; }
        public int KierowcyId { get; set; }
        public string ObiektTyp { get; set; }
        public int ObiektId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
    }
}
