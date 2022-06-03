using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZezwoleniaStrony
    {
        public int IdZezwoleniaStrony { get; set; }
        public int? ZezwoleniaId { get; set; }
        public int? NrStrony { get; set; }
        public int? Wydana { get; set; }
        public int? Zdana { get; set; }
        public int? Zwrocona { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
