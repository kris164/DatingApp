using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzEspeedPorady
    {
        public string Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string CreateDate { get; set; }
        public string ShortDescription { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public string A { get; set; }
        public int? Wie { get; set; }
        public int? Kol { get; set; }
        public string Wynik { get; set; }
    }
}
