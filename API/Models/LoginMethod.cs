using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LoginMethod
    {
        public int LoginMethodId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
