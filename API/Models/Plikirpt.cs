using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Plikirpt
    {
        public int IdPlikirpt { get; set; }
        public string Plik { get; set; }
        public short Status { get; set; }
        public string Obiekt { get; set; }
        public string App { get; set; }
        public string Jezyk { get; set; }
        public string Opis { get; set; }
    }
}
