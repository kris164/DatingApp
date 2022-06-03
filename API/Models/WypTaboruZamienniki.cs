using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WypTaboruZamienniki
    {
        public int IdWypTaboruZamienniki { get; set; }
        public int? WypTaboruId { get; set; }
        public int? ZamiennikId { get; set; }
    }
}
