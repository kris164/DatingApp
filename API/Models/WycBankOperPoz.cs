using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WycBankOperPoz
    {
        public int IdWycBankOperPoz { get; set; }
        public int? WycBankOperId { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public double? Kwota { get; set; }
        public int? KursyWalut1Id { get; set; }
        public DateTime? DataTabeliKursow1 { get; set; }
        public double? KursWaluty1 { get; set; }
        public int? KursyWalut2Id { get; set; }
        public DateTime? DataTabeliKursow2 { get; set; }
        public double? KursWaluty2 { get; set; }
        public double? RoznKursowa { get; set; }
    }
}
