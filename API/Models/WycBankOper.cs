using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WycBankOper
    {
        public int IdWycBankOper { get; set; }
        public int? NrOperacji { get; set; }
        public int? WycBankId { get; set; }
        public string Rodzaj { get; set; }
        public string RodzajPom { get; set; }
        public string Typ { get; set; }
        public string Konto { get; set; }
        public string TypListyK { get; set; }
        public string Waluta { get; set; }
        public double? Kwota { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientKod { get; set; }
        public string KlientMiasto { get; set; }
        public string Opis { get; set; }
        public DateTime? Data { get; set; }
        public int? KursyUzgodniony { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public double? KursWaluty { get; set; }
        public double? RoznKursowaP { get; set; }
        public double? RoznKursowaM { get; set; }
        public double? KwotaOplat { get; set; }
        public int? OplEksportFkId { get; set; }
    }
}
