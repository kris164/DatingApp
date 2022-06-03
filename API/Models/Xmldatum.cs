using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Xmldatum
    {
        public int Xmldataid { get; set; }
        public string Xmldata { get; set; }
        public DateTime Createdate { get; set; }
        public string Method { get; set; }
    }
}
