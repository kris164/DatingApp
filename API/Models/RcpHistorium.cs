using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RcpHistorium
    {
        public int IdRcpHistoria { get; set; }
        public int IdRcpNag { get; set; }
        public DateTime? Data { get; set; }
        public int? UzytkownikId { get; set; }
        public string AppVer { get; set; }
        public string Opis { get; set; }
        public DateTime? Dt { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
    }
}
