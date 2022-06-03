using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapUserSetting
    {
        public int IdOlapUserSettings { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public int? Domyslny { get; set; }
        public int? UserId { get; set; }
        public byte[] GridSet { get; set; }
        public byte[] PivotSet { get; set; }
        public int? QueryParamsBoxH { get; set; }
        public int? QueryParamsBoxW { get; set; }
        public int? QueryParamsBoxL { get; set; }
        public int? QueryParamsBoxT { get; set; }
        public byte[] GridPrntSet { get; set; }
        public byte[] PivotPrntSet { get; set; }
    }
}
