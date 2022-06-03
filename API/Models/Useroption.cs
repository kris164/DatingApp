using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Useroption
    {
        public int IdUseroptions { get; set; }
        public int? IdUser { get; set; }
        public string Appname { get; set; }
        public int? Ver { get; set; }
        public string Options { get; set; }
    }
}
