using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DpsStateInfo
    {
        public int State { get; set; }
        public int? StateNext { get; set; }
        public string Step { get; set; }
        public string LogStep { get; set; }
        public string LogInfo { get; set; }
    }
}
