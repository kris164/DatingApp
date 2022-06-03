using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TimeSheetCode
    {
        public int TimeSheetCodeId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public string Barcode { get; set; }
        public int? System { get; set; }
        public int? Visible { get; set; }
    }
}
