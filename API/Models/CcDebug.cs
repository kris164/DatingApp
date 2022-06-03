using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CcDebug
    {
        public CcDebug()
        {
            CcDebugPos = new HashSet<CcDebugPo>();
        }

        public int IdCcDebug { get; set; }
        public DateTime? Dt { get; set; }

        public virtual ICollection<CcDebugPo> CcDebugPos { get; set; }
    }
}
