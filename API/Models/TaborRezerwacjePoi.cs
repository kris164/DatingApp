using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborRezerwacjePoi
    {
        public int IdTaborRezerwacjePoi { get; set; }
        public int? TaborRezerwacjeId { get; set; }
        public int? MiejscaZaRozladunkuId { get; set; }
    }
}
