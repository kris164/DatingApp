using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Paczkianomalie
    {
        public int Paczkianomalieid { get; set; }
        public int? NadwyzkowaWy { get; set; }
        public int? PaczkiId { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? LokalizacjaId { get; set; }
        public int? Wirtualna { get; set; }
        public int? Brak { get; set; }
        public int? BrakWy { get; set; }
    }
}
