using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRouteObjItem
    {
        public int IdSfmRouteObjItem { get; set; }
        public int? IdSfmRouteObj { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public int? Direction { get; set; }
        public short? Kind { get; set; }
        public string Description { get; set; }

        public virtual SfmRouteObj IdSfmRouteObjNavigation { get; set; }
    }
}
