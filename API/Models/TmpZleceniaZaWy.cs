using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaZaWy
    {
        public int IdTmpZleceniaZaWy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? MiejsceId { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public double? Waga { get; set; }
        public double? WagaRz { get; set; }
        public double? WagaZestawu { get; set; }
        public string JednWagi { get; set; }
        public double? Palety { get; set; }
        public double? PaletyWym { get; set; }
        public string Jm { get; set; }
        public int? LadunekId { get; set; }
        public string Ladunek { get; set; }
        public string TempPrzewozuO { get; set; }
        public string TempPrzewozuORz { get; set; }
        public string Miejsce { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public int? IdZleceniaZaWy { get; set; }
        public DateTime? AwizacjaPrzed { get; set; }
        public DateTime? Eta { get; set; }
    }
}
