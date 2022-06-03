using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileDriverProfileType
    {
        public int MobileDriverProfileTypeId { get; set; }
        public string Name { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
