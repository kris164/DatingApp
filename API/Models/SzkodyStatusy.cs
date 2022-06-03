using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyStatusy
    {
        public int IdSzkodyStatusy { get; set; }
        public int? SzkodyId { get; set; }
        public int? Lp { get; set; }
        public string Status { get; set; }
        public DateTime? Data { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public string Uwagi { get; set; }
        public string StatusKod { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
