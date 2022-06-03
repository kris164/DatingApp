using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaczkiLokHist
    {
        public int IdPaczkiLokHist { get; set; }
        public int? PaczkiId { get; set; }
        public string MagLokKod { get; set; }
        public DateTime? DataGodzOd { get; set; }
        public DateTime? DataGodzDo { get; set; }
        public int? WejMagazynZdarzeniaId { get; set; }
        public int? WyjMagazynZdarzeniaId { get; set; }
    }
}
