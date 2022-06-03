using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Obiektyrpt
    {
        public int IdObiektyrpt { get; set; }
        public string Obiekt { get; set; }
        public short Status { get; set; }
        public DateTime? Data { get; set; }
        public string App { get; set; }
        public string Jezyk { get; set; }
        public string Plik { get; set; }
        public string Opis { get; set; }
    }
}
