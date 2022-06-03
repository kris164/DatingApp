using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapWidoki
    {
        public int IdOlapWidoki { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public string Nazwa { get; set; }
        public string UtworzylKto { get; set; }
        public DateTime? UtworzylKiedy { get; set; }
        public int? Widok { get; set; }
        public byte[] Dane { get; set; }
        public byte[] DaneBaza { get; set; }
        public byte[] DaneParams { get; set; }
    }
}
