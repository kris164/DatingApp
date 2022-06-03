using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Filtry
    {
        public int IdFiltry { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string BoxClass { get; set; }
        public string WinClass { get; set; }
        public int? WinWintype { get; set; }
        public string Filtr { get; set; }
        public int? IdUser { get; set; }
    }
}
