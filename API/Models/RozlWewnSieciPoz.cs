using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlWewnSieciPoz
    {
        public int IdRozlWewnSieciPoz { get; set; }
        public int? RozlWewnSieciId { get; set; }
        public DateTime? Data { get; set; }
        public int? ObiektTyp { get; set; }
        public int? ObiektId { get; set; }
        public string Obiekt { get; set; }
    }
}
