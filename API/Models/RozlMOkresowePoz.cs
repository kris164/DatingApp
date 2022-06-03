using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlMOkresowePoz
    {
        public int IdRozlMOkresowePoz { get; set; }
        public int? RozlMOkresoweId { get; set; }
        public DateTime? Data { get; set; }
        public double? Kwota { get; set; }
        public string Waluta { get; set; }
        public int? Rozl { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
    }
}
