using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaExt
    {
        public int IdTmpZleceniaExt { get; set; }
        public int? IdSesjiKalk { get; set; }
        public short? FvNaPlatnika { get; set; }
        public int? PrzewoznikOddzialId { get; set; }
        public short? DoMorskiego { get; set; }
        public short? KorDoZera { get; set; }
        public short? KorDoZeraK { get; set; }
        public int? GieldaPojazdowId { get; set; }
        public int? RhenusRozlTrasId { get; set; }
        public int? CennikKontrola { get; set; }
        public short? NieFakturuj { get; set; }
        public DateTime? SentDt { get; set; }
        public int? Sent { get; set; }
        public short? DoKolejowego { get; set; }
    }
}
