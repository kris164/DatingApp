using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Cmr
    {
        public int IdCmr { get; set; }
        public string NrCmr { get; set; }
        public int? NrCmrKolejny { get; set; }
        public int? NrCmrRok { get; set; }
        public int? NrCmrMies { get; set; }
        public int? Krajowy { get; set; }
        public int? Drobnica { get; set; }
        public int? KlientId { get; set; }
        public string KlientNazwa { get; set; }
        public DateTime? DataZaladunku { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string Lokalizacja { get; set; }
        public string Xml { get; set; }
        public string Dzial { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
    }
}
