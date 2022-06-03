using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BledyObiektow
    {
        public int IdBledyObiektow { get; set; }
        public int ObiektId { get; set; }
        public string ObiektTyp { get; set; }
        public string Zdarzenie { get; set; }
        public DateTime Kiedy { get; set; }
        public string Opis { get; set; }
    }
}
