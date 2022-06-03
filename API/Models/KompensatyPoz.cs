using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KompensatyPoz
    {
        public int IdKompensatyPoz { get; set; }
        public int? KompensatyId { get; set; }
        public int? Typ { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? DniPo { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? Data { get; set; }
        public double? Kwota { get; set; }
        public string Rodz { get; set; }
        public int? VatWPln { get; set; }
        public int? Lp { get; set; }
        public string Waluta { get; set; }
        public double? Kurs { get; set; }
        public double? KwotaWWalKomp { get; set; }
    }
}
