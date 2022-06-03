using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyTypyPlikow
    {
        public int IdPrzelewyTypyPlikow { get; set; }
        public string Nazwa { get; set; }
        public int? Kraj { get; set; }
        public int? Zagr { get; set; }
    }
}
