using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RejKosztOg
    {
        public int IdRejKosztOg { get; set; }
        public int? Rok { get; set; }
        public int? Mies { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
    }
}
