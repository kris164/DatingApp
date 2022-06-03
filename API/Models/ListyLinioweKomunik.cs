using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLinioweKomunik
    {
        public int IdListyLinioweKomunik { get; set; }
        public int? ListyLinioweId { get; set; }
        public DateTime? DataGodz { get; set; }
        public int? Przeczytany { get; set; }
        public string Od { get; set; }
        public string Komunikat { get; set; }
        public int? Odrzucony { get; set; }
    }
}
