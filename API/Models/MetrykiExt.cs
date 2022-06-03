using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MetrykiExt
    {
        public int IdMetrykiExt { get; set; }
        public string Tabela { get; set; }
        public int Id { get; set; }
        public string Zrodlo { get; set; }
        public string Wersja { get; set; }
        public string Schemat { get; set; }
        public string Uwagi { get; set; }
        public int? GdprSourceId { get; set; }
    }
}
