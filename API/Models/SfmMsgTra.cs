using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgTra
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public short? Smsc { get; set; }
        public short? Kind { get; set; }
        public short? MsgSrc { get; set; }
        public int? TnrIdFwd { get; set; }
        public int? TnrId { get; set; }
        public int? TnrDisp { get; set; }
        public int? TnrDriver { get; set; }
        public int? TnrPriveDisp { get; set; }
        public int? TnrCodriver { get; set; }
        public int? TnrMat { get; set; }
        public int? TnrTrailer { get; set; }
        public string Adres { get; set; }
        public short? StatusVeh { get; set; }
        public double? Speed { get; set; }
        public string Prop { get; set; }
        public string Pto { get; set; }
        public DateTime? DtDelivered { get; set; }
        public DateTime? DtMade { get; set; }
        public DateTime? DtPc { get; set; }
        public DateTime? DtReadchauf { get; set; }
        public DateTime? DtReaddeadline { get; set; }
        public DateTime? DtSend { get; set; }
        public DateTime? DtTrailer { get; set; }
        public short? NrSystem { get; set; }
        public short? NrVersion { get; set; }
        public int? TnrTripinfo { get; set; }
        public int? LAnomaly { get; set; }
    }
}
