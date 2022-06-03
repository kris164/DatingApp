using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WzorceCmr
    {
        public int IdWzorceCmr { get; set; }
        public string Nazwa { get; set; }
        public int? Krajowy { get; set; }
        public int? KlientId { get; set; }
        public string KlientNazwa { get; set; }
        public DateTime? DataZaladunku { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string Lokalizacja { get; set; }
        public string Xml { get; set; }
        public string Dzial { get; set; }
    }
}
