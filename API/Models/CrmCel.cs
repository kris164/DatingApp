using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CrmCel
    {
        public int IdCrmCel { get; set; }
        public string Nazwa { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
