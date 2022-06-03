using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrDanePoz
    {
        public int IdWynagrDanePoz { get; set; }
        public int? WynagrDaneId { get; set; }
        public DateTime? Data { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string TypPoz { get; set; }
        public int? PozId { get; set; }
        public string PozNr { get; set; }
        public DateTime? WyjazdOd { get; set; }
        public DateTime? WyjazdDo { get; set; }
        public string LpKierowcy { get; set; }
        public string LpKierowcyOrg { get; set; }
        public int? Uczen { get; set; }
        public double? KmK { get; set; }
        public double? KmZ { get; set; }
        public double? KmLadK { get; set; }
        public double? KmLadZ { get; set; }
        public double? KmPustK { get; set; }
        public double? KmPustZ { get; set; }
        public double? KmAdr { get; set; }
        public double? KmPremiaTabor { get; set; }
        public double? KmPonadNorme { get; set; }
        public double? KgNiedowazone { get; set; }
        public double? KmWgMapy { get; set; }
        public double? KmPustWgMapy { get; set; }
        public double? KmLadWgMapy { get; set; }
        public double? MZaWyK { get; set; }
        public double? MZaWyZ { get; set; }
        public double? KmUznaneK { get; set; }
        public double? KmUznaneZ { get; set; }
        public double? KmDoPlacyK { get; set; }
        public double? KmDoPlacyZ { get; set; }
        public double? Dodatki { get; set; }
        public double? Obciazenia { get; set; }
        public double? Obciazenia2 { get; set; }
        public double? ObciazeniaN { get; set; }
        public double? Obciazenia2N { get; set; }
        public double? Diety { get; set; }
        public double? Fracht { get; set; }
        public double? FrachtFv { get; set; }
        public double? FrachtFvTr { get; set; }
        public double? FrachtFvSp { get; set; }
        public double? FrachtRozKier { get; set; }
        public double? IleZlec { get; set; }
        public double? DniZlec { get; set; }
        public double? DniWyjazdu { get; set; }
        public double? DniUrlopu { get; set; }
        public string KrajDocelowy { get; set; }
        public double? StKmSpecK { get; set; }
        public double? StKmSpecZ { get; set; }
        public double? Przepal { get; set; }
        public double? PrzepalC { get; set; }
        public double? PrzepalAc { get; set; }
        public double? PrzepalN { get; set; }
        public double? PrzepalAn { get; set; }
        public double? PrzepalAdblue { get; set; }
        public double? Rw { get; set; }
        public double? StZaOszcz { get; set; }
        public double? KmOszcz { get; set; }
        public string Parametry { get; set; }
    }
}
