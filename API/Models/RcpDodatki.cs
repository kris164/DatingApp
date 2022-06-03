using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RcpDodatki
    {
        public int IdRcpDodatki { get; set; }
        public int IdFirma { get; set; }
        public int IdKierowcy { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public int IdRcpNag { get; set; }
        public DateTime? OkresOd { get; set; }
        public DateTime? OkresDo { get; set; }
        public DateTime? NocneGodz { get; set; }
        public double? NocneStawka { get; set; }
        public double? NocneKwota { get; set; }
        public DateTime? Dyzur50Godz { get; set; }
        public double? Dyzur50Stawka { get; set; }
        public double? Dyzur50Kwota { get; set; }
        public DateTime? Dyzur100Godz { get; set; }
        public double? Dyzur100Stawka { get; set; }
        public double? Dyzur100Kwota { get; set; }
        public DateTime? Nadgodziny50Godz { get; set; }
        public double? Nadgodziny50Stawka { get; set; }
        public double? Nadgodziny50Kwota { get; set; }
        public DateTime? Nadgodziny100Godz { get; set; }
        public double? Nadgodziny100Stawka { get; set; }
        public double? Nadgodziny100Kwota { get; set; }
        public DateTime? PonadnormaGodz { get; set; }
        public double? PonadnormaStawka { get; set; }
        public double? PonadnormaKwota { get; set; }
        public DateTime? NormaDone { get; set; }
        public int? NormaGodzin { get; set; }
        public double? AllKwota { get; set; }
        public double? RyczaltDyzur { get; set; }
        public double? RyczaltNocki { get; set; }
        public double? RyczaltNadgodziny { get; set; }
        public double? WyplataDyzur { get; set; }
        public double? WyplataNocki { get; set; }
        public double? WyplataNadgodziny { get; set; }
        public int? NormaDniDone { get; set; }
    }
}
