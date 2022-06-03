using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprPerson
    {
        public int IdGdprPersons { get; set; }
        public int? GdprOblivionId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? OrgIdGdprPersons { get; set; }
    }
}
