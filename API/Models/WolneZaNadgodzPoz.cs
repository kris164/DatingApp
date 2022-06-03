using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WolneZaNadgodzPoz
    {
        public int IdWolneZaNadgodzPoz { get; set; }
        public int WolneZaNadgodzId { get; set; }
        public DateTime? Data { get; set; }
        public int? LGodz { get; set; }
    }
}
