using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgPaczki
    {
        public int IdProtNiezgPaczki { get; set; }
        public int? ProtNiezgId { get; set; }
        public int? PaczkiId { get; set; }
    }
}
