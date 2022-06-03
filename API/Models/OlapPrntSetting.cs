using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapPrntSetting
    {
        public int IdOlapPrntSettings { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public int? UserId { get; set; }
        public byte[] GridSet { get; set; }
        public byte[] PivotSet { get; set; }
        public byte[] PivotStyleSet { get; set; }
        public byte[] GridStyleSet { get; set; }
    }
}
