using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyBankiTypyPlikow
    {
        public int IdPrzelewyBankiTypyPlikow { get; set; }
        public int? PrzelewyBankiId { get; set; }
        public int? PrzelewyTypyPlikowId { get; set; }
        public int? Kraj { get; set; }
        public int? Zagr { get; set; }
    }
}
