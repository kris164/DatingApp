using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppMsg
    {
        public int IdAppMsg { get; set; }
        public int IdUser { get; set; }
        public DateTime? Dt { get; set; }
        public string Typ { get; set; }
        public int? Sid { get; set; }
        public string Title { get; set; }
        public string Msg { get; set; }
    }
}
