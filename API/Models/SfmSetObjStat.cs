using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmSetObjStat
    {
        public int IdSfmSetObjStat { get; set; }
        public int? IdSfmSystem { get; set; }
        public string ExternalId { get; set; }
        public DateTime? DtEvent { get; set; }
        public int? StatusSfm { get; set; }
        public int? OrderType { get; set; }
        public int? OrderId { get; set; }
        public int? TaskType { get; set; }
        public int? TaskId { get; set; }
        public short? IsForceSet { get; set; }
        public short? IsDone { get; set; }
        public string ExtraFields { get; set; }
    }
}
