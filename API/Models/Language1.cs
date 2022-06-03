using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Language1
    {
        public int LanguageId { get; set; }
        public int? SysLangId { get; set; }
        public int? CountryId { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Name { get; set; }
        public int? Active { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public byte[] SmallFlag { get; set; }
        public byte[] LargeFlag { get; set; }
        public int? Reports { get; set; }
    }
}
