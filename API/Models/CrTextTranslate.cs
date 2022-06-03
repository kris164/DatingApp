using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CrTextTranslate
    {
        public int IdCrTextTranslate { get; set; }
        public string RptName { get; set; }
        public string TextCode { get; set; }
        public string LangCode { get; set; }
        public string Text { get; set; }
    }
}
