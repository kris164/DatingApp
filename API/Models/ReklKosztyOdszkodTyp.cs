using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklKosztyOdszkodTyp
    {
        public int IdReklKosztyOdszkodTyp { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Systemowy { get; set; }
    }
}
