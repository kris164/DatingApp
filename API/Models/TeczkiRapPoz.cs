using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TeczkiRapPoz
    {
        public int IdTeczkiRapPoz { get; set; }
        public int? TeczkiRapId { get; set; }
        public string Trafik { get; set; }
        public string Teczka { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public string RodzObiektu { get; set; }
        public string Obiekt { get; set; }
        public DateTime? Data { get; set; }
        public string PK { get; set; }
        public string ZW { get; set; }
        public string Podmiot { get; set; }
        public string RodzajPK { get; set; }
        public string LokWej { get; set; }
        public string LokWyj { get; set; }
        public string LokNad { get; set; }
        public double? KwotaPrzZewn { get; set; }
        public string KwotaPrzZewnWal { get; set; }
        public double? KwotaKosztZewn { get; set; }
        public string KwotaKosztZewnWal { get; set; }
        public double? KwotaPrzWewn { get; set; }
        public string KwotaPrzWewnWal { get; set; }
        public double? KwotaKosztWewn { get; set; }
        public string KwotaKosztWewnWal { get; set; }
        public double? KwotaPrzZewnPln { get; set; }
        public double? KwotaKosztZewnPln { get; set; }
        public double? KwotaPrzWewnPln { get; set; }
        public double? KwotaKosztWewnPln { get; set; }
        public double? KwotaDochZewnPln { get; set; }
        public double? KwotaDochWewnPln { get; set; }
        public double? KwotaDochPln { get; set; }
        public string Zaksieg { get; set; }
        public string KF { get; set; }
    }
}
