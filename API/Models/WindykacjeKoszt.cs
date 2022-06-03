using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindykacjeKoszt
    {
        public int IdWindykacjeKoszt { get; set; }
        public int? WindykacjeId { get; set; }
        public DateTime? DataPowstania { get; set; }
        public double? Kwota { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public string Rodzaj { get; set; }
        public int? CzyObciazyc { get; set; }
        public string DokumObciazenia { get; set; }
        public int? DokumObciazeniaId { get; set; }
        public string DokumObciazeniaTyp { get; set; }
    }
}
