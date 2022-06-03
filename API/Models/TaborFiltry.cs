using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborFiltry
    {
        public int IdTaborFiltry { get; set; }
        public int? TaborId { get; set; }
        public string Rodzaj { get; set; }
        public string Marka { get; set; }
        public string Symbol { get; set; }
    }
}
