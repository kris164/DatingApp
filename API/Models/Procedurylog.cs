using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Procedurylog
    {
        public int IdProcedurylog { get; set; }
        public int? IdProcGrp { get; set; }
        public short? IsNew { get; set; }
        public short? IsEnabled { get; set; }
        public short? IsError { get; set; }
        public string ProcName { get; set; }
        public string ProcType { get; set; }
        public DateTime? DtSave { get; set; }
        public DateTime? DtOff { get; set; }
        public DateTime? DtOn { get; set; }
        public DateTime? DtModify { get; set; }
        public string Text { get; set; }
        public string Error { get; set; }
    }
}
