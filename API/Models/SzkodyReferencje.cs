using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyReferencje
    {
        public int IdSzkodyReferencje { get; set; }
        public int SzkodyId { get; set; }
        public short Typ { get; set; }
        public int ObiektId { get; set; }
        public string Numer { get; set; }
    }
}
