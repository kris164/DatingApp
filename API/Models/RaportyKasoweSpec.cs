using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RaportyKasoweSpec
    {
        public int IdRaportyKasoweSpec { get; set; }
        public int? RaportKasowyId { get; set; }
        public double? Nominal { get; set; }
        public int? Ilosc { get; set; }
        public double? Suma { get; set; }
    }
}
