using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Blokady obiektów - logi
    /// </summary>
    public partial class TmpBlokadyZbiorcze
    {
        public int IdTmpBlokadyZbiorcze { get; set; }
        public int? SessionId { get; set; }
        public int? CheckPointId { get; set; }
        public int? LockType { get; set; }
        public int? ActionType { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? State { get; set; }
        public int? UserId { get; set; }
    }
}
