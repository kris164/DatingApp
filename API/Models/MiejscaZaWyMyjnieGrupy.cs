using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MiejscaZaWyMyjnieGrupy
    {
        public int IdMiejscaZaWyMyjnieGrupy { get; set; }
        public int MiejscaZaRozladunkuId { get; set; }
        public int GrupyLadunkowId { get; set; }
    }
}
