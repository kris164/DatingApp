using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportLanguage
    {
        public int ReportLanguageId { get; set; }
        public string PrintOut { get; set; }
        public string PrintOutInfo { get; set; }
        public string Language { get; set; }
        public string Reference { get; set; }
        public string Label { get; set; }
    }
}
