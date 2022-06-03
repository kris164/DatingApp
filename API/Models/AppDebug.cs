using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppDebug
    {
        public int IdAppDebug { get; set; }
        public DateTime? Dt { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Czas { get; set; }
        public int? Lp { get; set; }
        public string Typterm { get; set; }
        public string Id { get; set; }
        public string Operacja { get; set; }
        public string Info { get; set; }
        public string Sql { get; set; }
    }
}
