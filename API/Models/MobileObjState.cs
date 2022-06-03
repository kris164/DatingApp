using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileObjState
    {
        public int MobileObjStateId { get; set; }
        public int? ObjType { get; set; }
        public int? ObjId { get; set; }
        public int? DriverId { get; set; }
        public int? State { get; set; }
    }
}
