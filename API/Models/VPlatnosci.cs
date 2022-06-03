using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VPlatnosci
    {
        public string KeyId { get; set; }
        public short? Typ { get; set; }
        public string Zlecenie { get; set; }
        public string Wyjazd { get; set; }
        public int? Id { get; set; }
        public string Numer { get; set; }
        public string Lokalizacja { get; set; }
        public string Kontrahent { get; set; }
        public string KontrahentNazwa { get; set; }
        public string KontrahentNip { get; set; }
        public int? KontrahentId { get; set; }
        public DateTime? DataWyst { get; set; }
        public DateTime? DataSprzed { get; set; }
        public DateTime? DataPlatn { get; set; }
        public string FormaPl { get; set; }
        public double? Brutto { get; set; }
        public string Waluta { get; set; }
        public double? Splata { get; set; }
        public double? DoZaplaty { get; set; }
        public int? Ile { get; set; }
        public short? BezKsiegowania { get; set; }
        public int? StatusWindykacji { get; set; }
        public int IsInfo { get; set; }
        public string Opiekun { get; set; }
        public short? Zaksiegowana { get; set; }
        public DateTime? DataOtrzym { get; set; }
        public int? TerminPl { get; set; }
        public int? VatWPln { get; set; }
        public DateTime? DataWysl { get; set; }
        public int? Korekta { get; set; }
        public string NrKorekty { get; set; }
        public string ZaplWstrzKto { get; set; }
        public DateTime? ZaplWstrzKiedy { get; set; }
        public string StatusNew { get; set; }
        public string ZlecenieKl { get; set; }
        public string NumerPf { get; set; }
        public int? Pf { get; set; }
    }
}
