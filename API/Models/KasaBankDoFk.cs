using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KasaBankDoFk
    {
        public int IdKasaBankDoFk { get; set; }
        public string Typ { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public int? NrKolejny { get; set; }
        public string Zakres { get; set; }
        public int? RaportId { get; set; }
        public string Raport { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? IloscDok { get; set; }
        public string Uzytkownik { get; set; }
        public DateTime? DataGen { get; set; }
        public DateTime? GodzGen { get; set; }
        public string Format { get; set; }
    }
}
