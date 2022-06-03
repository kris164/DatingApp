using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOKierowcy
    {
        public int IdTaborOKierowcy { get; set; }
        public int? TaborOId { get; set; }
        public string ImieNazwisko { get; set; }
        public string Telefon { get; set; }
        public string InfoDod { get; set; }
    }
}
