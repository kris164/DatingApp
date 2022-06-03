using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlKierPozZlec
    {
        public int IdRozlKierPozZlec { get; set; }
        public int? RozlKierPozId { get; set; }
        public int? Typ { get; set; }
        public int? ZleceniaId { get; set; }
        public int? WyjazdyId { get; set; }
        public DateTime? Data { get; set; }
        public double? Km { get; set; }
        public double? KwotaWal { get; set; }
        public string Waluta { get; set; }
        public double? KwotaKurs { get; set; }
        public DateTime? KursData { get; set; }
        public double? KwotaPln { get; set; }
        public double? KwotaOdlPln { get; set; }
        public double? ProcentUdzialu { get; set; }
        public double? DoProwizji { get; set; }
        public double? Procent { get; set; }
        public double? Prowizja { get; set; }
        public int? FakturyId { get; set; }
        public int? Przeladunek { get; set; }
        public int? ProcentRecznie { get; set; }
        public int? Spr { get; set; }
    }
}
