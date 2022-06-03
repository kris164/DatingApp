using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OpcjePrzewozow
    {
        public int IdOpcjePrzewozow { get; set; }
        public string Rodzaj { get; set; }
        public int? WymKwotaFrachtu { get; set; }
        public int? BlokRecznEdTrasy { get; set; }
        public int? BlokBezpEdycjiZdarzen { get; set; }
        public int? WymKmZdarzen { get; set; }
        public int? SpLiczKm { get; set; }
        public int? BlokZamknBezSkan { get; set; }
        public int? TylkoCennik { get; set; }
        public int? TrasaAutoZaWy { get; set; }
        public int? BlokTlDpGdyOtw { get; set; }
        public int? BlokTlDpGdySaWst { get; set; }
        public int? FvOtwarte { get; set; }
        public int? UstawP { get; set; }
        public int? UstawD { get; set; }
        public int? Aktywny { get; set; }
        public int? BlokZamGdySaWst { get; set; }
        public int? SumNaTraseWg { get; set; }
        public int? WlaczPrzychody { get; set; }
        public int? UstawPdDirect { get; set; }
    }
}
