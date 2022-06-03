using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DictionaryText1
    {
        public int DictionaryTextId { get; set; }
        public int DictionaryId { get; set; }
        public int TextId { get; set; }
        public int? TextTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }
        public string CustomText { get; set; }

        public virtual Dictionary2 Dictionary { get; set; }
    }
}
