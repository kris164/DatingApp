using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy kontenerów
    /// </summary>
    public partial class TypyKontenerow
    {
        public int IdTypyKontenerow { get; set; }
        public string Typ { get; set; }
        public double? Teu { get; set; }
        public double? Waga { get; set; }
        public double? Poj { get; set; }
        public string Uwagi { get; set; }
        public double? NormaPaliwowa { get; set; }
        public double? JednObj { get; set; }
        public int IleKomor { get; set; }
    }
}
