using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Profiledomaingroup
    {
        public int Profiledomaingroupid { get; set; }
        public int? Profileid { get; set; }
        public string Domaingroup { get; set; }
    }
}
