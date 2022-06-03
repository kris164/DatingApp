using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DictionaryText2
    {
        public int DictionaryTextId { get; set; }
        public int MultilingualTextId { get; set; }
        public int DatabaseLanguageId { get; set; }
        public string Text { get; set; }
        public string CustomText { get; set; }
    }
}
