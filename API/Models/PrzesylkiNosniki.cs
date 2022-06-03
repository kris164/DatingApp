using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiNosniki
    {
        public int IdPrzesylkiNosniki { get; set; }
        public int PrzesylkiId { get; set; }
        public int OpakowaniaId { get; set; }
        public string Etap { get; set; }
        public int Ilosc { get; set; }
    }
}
