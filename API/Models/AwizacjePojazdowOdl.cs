using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AwizacjePojazdowOdl
    {
        public int IdAwizacjePojazdowOdl { get; set; }
        public int? AwizacjePojazdowId { get; set; }
        public int? IdSesji { get; set; }
        public int? Odleglosc { get; set; }
    }
}
