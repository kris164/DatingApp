using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TimeSheet
    {
        public int TimeSheetId { get; set; }
        public int RecordId { get; set; }
        public int PositionId { get; set; }
        public int OperatorId { get; set; }
        public int TimeSheetCodeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Stop { get; set; }
        public int? LocalizationId { get; set; }
    }
}
