using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmStatusForActivity
    {
        public int IdSfmStatusForActivity { get; set; }
        public int? StatOrder { get; set; }
        public int? IdSfmSystem { get; set; }
        public string ActivityId { get; set; }
        public string ActivityDescr { get; set; }
        public int? SfmStatusNo { get; set; }
        public int? SfmStatusActivityKindId { get; set; }
        public int? SfmStatusSourceDateKindId { get; set; }
    }
}
