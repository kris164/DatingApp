using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyBanki
    {
        public int IdPrzelewyBanki { get; set; }
        public string Nazwa { get; set; }
        public string Swift { get; set; }
        public string KrajIban { get; set; }
    }
}
