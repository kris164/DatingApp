using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WolneZaNadgodz
    {
        public int IdWolneZaNadgodz { get; set; }
        public int IdRcpNag { get; set; }
        public int IdKierowcy { get; set; }
        public int IdFirma { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public DateTime? DataWniosku { get; set; }
        public int? LGodz { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public DateTime? DataOddania { get; set; }
        public DateTime? DataOddaniaRzecz { get; set; }
        public int? LMin { get; set; }
        public int? TypNadgodzin { get; set; }
        public int? Automat { get; set; }
    }
}
