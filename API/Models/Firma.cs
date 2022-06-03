using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Firma
    {
        public int IdFirma { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Ulica { get; set; }
        public string NrDom { get; set; }
        public string NrLok { get; set; }
        public string Miejscowosc { get; set; }
        public string Kod { get; set; }
        public string Poczta { get; set; }
        public string Kraj { get; set; }
        public string Regon { get; set; }
        public string Pesel { get; set; }
        public string Nip { get; set; }
        public short Deleted { get; set; }
    }
}
