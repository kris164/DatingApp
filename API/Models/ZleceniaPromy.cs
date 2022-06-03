using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaPromy
    {
        public int IdZleceniaPromy { get; set; }
        public int? ZleceniaId { get; set; }
        public int? PromyId { get; set; }
    }
}
