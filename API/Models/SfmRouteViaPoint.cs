using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRouteViaPoint
    {
        public int IdSfmRouteViaPoint { get; set; }
        public int? IdSfmRoute { get; set; }
        public int? DstObjType { get; set; }
        public int? DstObjId { get; set; }
        public int? Enabled { get; set; }
        public int? Lp { get; set; }
        public string ViaType { get; set; }
        public string Description { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public int? Direction { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Place { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public string NamePoi { get; set; }

        public virtual SfmRoute IdSfmRouteNavigation { get; set; }
    }
}
