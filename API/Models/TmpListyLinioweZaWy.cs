using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpListyLinioweZaWy
    {
        public int IdTmpListyLinioweZaWy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdListyLinioweZaWy { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? LpPw { get; set; }
        public int? LpKie { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public DateTime? DyspGodzOd { get; set; }
        public DateTime? DyspGodzDo { get; set; }
        public double? Waga { get; set; }
        public double? WagaRz { get; set; }
        public double? WagaZestawu { get; set; }
        public double? Palety { get; set; }
        public double? PaletyWym { get; set; }
        public string JednWagi { get; set; }
        public string Jm { get; set; }
        public DateTime? DataRz { get; set; }
        public DateTime? GodzRz { get; set; }
        public DateTime? DataRzK { get; set; }
        public DateTime? GodzRzK { get; set; }
        public DateTime? DataRzP { get; set; }
        public DateTime? GodzRzP { get; set; }
        public double? Opoznienie { get; set; }
        public int? LadunekId { get; set; }
        public string Ladunek { get; set; }
        public double? CzasTrwania { get; set; }
        public double? MaxOpozn { get; set; }
        public int? TrasaKm { get; set; }
        public int? TrasaKmExtra { get; set; }
        public int? TrasaKmRosn { get; set; }
        public int? Pietrowanie { get; set; }
        public string KodPoczt { get; set; }
        public DateTime? DataRzW { get; set; }
        public DateTime? GodzRzW { get; set; }
        public string Adres { get; set; }
    }
}
