using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiNosnikiUwagi
    {
        public int IdPrzesylkiNosnikiUwagi { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? OpakowaniaId { get; set; }
        public int? NosnikiUwagiId { get; set; }
        public int? Ilosc { get; set; }
        public string OpisDod { get; set; }
        public int? KwitPalId { get; set; }
    }
}
