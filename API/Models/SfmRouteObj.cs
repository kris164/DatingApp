using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRouteObj
    {
        public SfmRouteObj()
        {
            SfmRouteObjItems = new HashSet<SfmRouteObjItem>();
        }

        public int IdSfmRouteObj { get; set; }
        public int IdObj { get; set; }
        public int IdRec { get; set; }

        public virtual ICollection<SfmRouteObjItem> SfmRouteObjItems { get; set; }
    }
}
