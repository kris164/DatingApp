using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTaborParam
    {
        public int IdSfmTaborParams { get; set; }
        public int? IdTabor { get; set; }
        public int? IdSfmSystem { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }
    }
}
