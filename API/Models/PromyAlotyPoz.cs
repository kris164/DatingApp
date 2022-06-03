using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyAlotyPoz
    {
        public int IdPromyAlotyPoz { get; set; }
        public int? PromyAlotyId { get; set; }
        public int? DzienTygNr { get; set; }
        public string DzienTyg { get; set; }
        public DateTime? GodzWypl { get; set; }
        public DateTime? GodzPrzypl { get; set; }
        public int? LMiejsc { get; set; }
        public double? CenaZaMiejsce { get; set; }
        public string CenaZaMiejsceWal { get; set; }
        public int? BukingIleHPrzed { get; set; }
        public double? CenaZaMb { get; set; }
        public string CenaZaMbWal { get; set; }
        public double? CenaZa2Kier { get; set; }
        public string CenaZa2KierWal { get; set; }
        public double? CenaZaTone { get; set; }
        public string CenaZaToneWal { get; set; }
        public DateTime? CzasPlyniecia { get; set; }
        public int? CennikId { get; set; }
    }
}
