using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WDoFk
    {
        public int IdWDoFk { get; set; }
        public string TypDok { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public int? NrKolejny { get; set; }
        public string Zakres { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? NrOd { get; set; }
        public int? NrDo { get; set; }
        public int? IloscDok { get; set; }
        public string Uzytkownik { get; set; }
        public DateTime? DataGen { get; set; }
        public DateTime? GodzGen { get; set; }
        public string Format { get; set; }
        public string ListaFaktur { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
