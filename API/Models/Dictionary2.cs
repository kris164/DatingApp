using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Dictionary2
    {
        public Dictionary2()
        {
            DictionaryText1s = new HashSet<DictionaryText1>();
        }

        public int DictionaryId { get; set; }
        public int? ApplicationId { get; set; }
        public int? ApplicationModuleId { get; set; }
        public int? ApplicationContextId { get; set; }
        public string ApplicationContextReference { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DictionaryText1> DictionaryText1s { get; set; }
    }
}
