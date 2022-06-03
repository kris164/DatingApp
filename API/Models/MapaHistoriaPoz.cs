using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapaHistoriaPoz
    {
        public int IdMapaHistoriaPoz { get; set; }
        public int? MapaHistoriaId { get; set; }
        public int? Lp { get; set; }
        public int? OrgLp { get; set; }
        public int? IdObj { get; set; }
        public int? IdRec { get; set; }
        public int? Zazn { get; set; }
        public string Typ { get; set; }
        public string Nazwa { get; set; }
        public string KrajIso { get; set; }
        public string Kraj { get; set; }
        public string Kod { get; set; }
        public string Poczta { get; set; }
        public string Miejscowosc { get; set; }
        public string Adres { get; set; }
        public DateTime? Czaspostoju { get; set; }
        public int? Dx { get; set; }
        public int? Dy { get; set; }
        public double? Flon { get; set; }
        public double? Flat { get; set; }
        public int? Orgrecid { get; set; }
        public string Zlecenie { get; set; }
        public short? Blokada { get; set; }
        public int? IdStart { get; set; }
        public int? IdStop { get; set; }
        public short? Oblicz { get; set; }
        public int? Zgeokodowany { get; set; }
        public int? Powielony { get; set; }
        public DateTime? DataRz { get; set; }
        public DateTime? GodzRz { get; set; }
        public int? Licznik { get; set; }
    }
}
