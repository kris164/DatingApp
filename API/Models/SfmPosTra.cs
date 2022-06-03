using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosTra
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? TnrId { get; set; }
        public int? TnrMat { get; set; }
        public int? TnrTrailer { get; set; }
        public int? TnrPerson { get; set; }
        public short? Codriver { get; set; }
        public short? Smsc { get; set; }
        public DateTime? DtBegin { get; set; }
        public DateTime? DtPc { get; set; }
        public string Pto { get; set; }
        public int? Km { get; set; }
        public string Pos1 { get; set; }
        public string Pos2 { get; set; }
        public string Pos3 { get; set; }
        public string Pos4 { get; set; }
    }
}
