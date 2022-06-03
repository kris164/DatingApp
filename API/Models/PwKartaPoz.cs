using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PwKartaPoz
    {
        public int IdPwKartaPoz { get; set; }
        public short? Status { get; set; }
        public int? IdPwKarta { get; set; }
        public int? IdWyjazdyZdarzenia { get; set; }
        public int? IdSfmCosts { get; set; }
        public int? IdSfmMsg { get; set; }
        public DateTime? DtSave { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtStop { get; set; }
        public string ExtId { get; set; }
        public string ExtCode { get; set; }
        public string ExtData { get; set; }
    }
}
