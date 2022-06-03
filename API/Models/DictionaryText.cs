using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DictionaryText
    {
        public int DictionaryTextId { get; set; }
        public int DictionaryId { get; set; }
        public int TextId { get; set; }
        public int DatabaseLanguageId { get; set; }
        public string Text { get; set; }
        public string CustomText { get; set; }
    }
}
