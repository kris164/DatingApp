using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpCalcCarwash
    {
        public int IdTmpCalcCarwash { get; set; }
        /// <summary>
        /// id sesji kalkulacji
        /// </summary>
        public int? SessionId { get; set; }
        /// <summary>
        /// 0-via /1-start /2-stop
        /// </summary>
        public int? Kind { get; set; }
        /// <summary>
        /// id POI
        /// </summary>
        public int? PoiId { get; set; }
        /// <summary>
        /// id typu obiektu SPEED zdarzenia zlecenia
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// id zdarzenia zlecenia
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// id zlecenia
        /// </summary>
        public int? OrderId { get; set; }
        /// <summary>
        /// longitude
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// latitude
        /// </summary>
        public double? Lat { get; set; }
    }
}
