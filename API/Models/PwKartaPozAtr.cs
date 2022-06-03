using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PwKartaPozAtr
    {
        public int IdPwKartaPozAtr { get; set; }
        public short? Status { get; set; }
        public int? IdPwKartaPoz { get; set; }
        public string ExtCode { get; set; }
        public string ExtValue { get; set; }
        public string ExtData { get; set; }
    }
}
