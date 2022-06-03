using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyDzialanium
    {
        public int IdSzkodyDzialania { get; set; }
        public int SzkodyId { get; set; }
        public string Opis { get; set; }
        public int? Zamkniete { get; set; }
        public string Kod { get; set; }
        public DateTime? DataZam { get; set; }
        public int? ReklamacjeId { get; set; }
        public string UwagiDod { get; set; }
    }
}
