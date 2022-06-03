using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOTermin
    {
        public int IdTaborOTermin { get; set; }
        public int? TaborOId { get; set; }
        public string CzynnoscId { get; set; }
        public string Czynnosc { get; set; }
        public DateTime? Data { get; set; }
    }
}
