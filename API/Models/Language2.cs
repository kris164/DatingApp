using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Language2
    {
        public int LanguageId { get; set; }
        public int DatabaseLanguageId { get; set; }
        public int Active { get; set; }
        public int DefaultLanguage { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
