using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Language
    {
        public int LanguageId { get; set; }
        public int DatabaseLanguageId { get; set; }
        public int Active { get; set; }
        public int DefaultLanguage { get; set; }
    }
}
