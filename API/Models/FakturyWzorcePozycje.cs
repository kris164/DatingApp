using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FakturyWzorcePozycje
    {
        public int IdFakturyWzorcePozycje { get; set; }
        public int FakturyWzorceId { get; set; }
        public int? Lp { get; set; }
        public string RodzKosztow { get; set; }
        public int? UwzglRozlKier { get; set; }
        public int? StrRozlKier { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string Pkwiu { get; set; }
        public string Jm { get; set; }
        public double Ilosc { get; set; }
        public double NettoJednWal { get; set; }
        public double NettoJednPln { get; set; }
        public double Rabat { get; set; }
        public double RabatWartoscPln { get; set; }
        public double NettoWartoscPln { get; set; }
        public string VatId { get; set; }
        public double VatStawka { get; set; }
        public double VatWartoscPln { get; set; }
        public double BruttoWartoscPln { get; set; }
        public string Waluta { get; set; }
        public double KursWaluty { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public double? VKursWaluty { get; set; }
        public int? VKursyWalutId { get; set; }
        public string VNrTabeliKursow { get; set; }
        public DateTime? VDataTabeliKursow { get; set; }
        public string KontoFk { get; set; }
        public string WalutaPrzewal { get; set; }
        public double? KursPrzewal { get; set; }
        public double? NettoJednPrzewal { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
    }
}
