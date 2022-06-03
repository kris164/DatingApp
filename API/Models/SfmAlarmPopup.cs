using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmAlarmPopup
    {
        public int IdSfmAlarmPopup { get; set; }
        public int IdSfmAlarm { get; set; }
        public int IdUzytk { get; set; }
        public DateTime? DtZapis { get; set; }
        public DateTime? DtTermin { get; set; }
        public DateTime? DtOdczyt { get; set; }
        public short? Przeczytany { get; set; }
    }
}
