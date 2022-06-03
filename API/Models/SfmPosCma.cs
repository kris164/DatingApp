using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosCma
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? LocId { get; set; }
        public int? DevId { get; set; }
        public int? Wysokosc { get; set; }
        public double? Dystans { get; set; }
        public string Opis { get; set; }
        public int? DrvId { get; set; }
        public int? TraId { get; set; }
        public string TraNr { get; set; }
    }
}
