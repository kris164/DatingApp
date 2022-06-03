using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyRelacjeArmator
    {
        public int IdPromyRelacjeArmator { get; set; }
        public int? PromyRelacjeId { get; set; }
        public string RelacjeNazwa { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
    }
}
