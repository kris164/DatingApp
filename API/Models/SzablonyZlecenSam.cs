using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzablonyZlecenSam
    {
        public int IdSzablonyZlecenSam { get; set; }
        public int? SzablonyZlecenId { get; set; }
        public int? Lp { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Vin { get; set; }
        public int? RokProd { get; set; }
        public string Uwagi { get; set; }
        public int? MZalId { get; set; }
        public int? MRozId { get; set; }
    }
}
