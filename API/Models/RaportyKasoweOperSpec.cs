using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RaportyKasoweOperSpec
    {
        public int IdRaportyKasoweOperSpec { get; set; }
        public int? RaportyKasoweOperId { get; set; }
        public double? Nominal { get; set; }
        public int? Ilosc { get; set; }
        public double? Suma { get; set; }
    }
}
