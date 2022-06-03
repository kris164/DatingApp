using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapWidokiUsr
    {
        public int IdOlapWidokiUsr { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public int? Widok { get; set; }
        public int? UserId { get; set; }
        public string Dane { get; set; }
        public int? DataArea { get; set; }
        public string DaneChart { get; set; }
    }
}
