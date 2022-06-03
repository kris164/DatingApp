using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPaczki
    {
        public int IdTmpPaczki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? Lp { get; set; }
        public int? Ilosc { get; set; }
        public string KodOpak { get; set; }
        public double? WagaJedn { get; set; }
        public double? ObjJedn { get; set; }
        public double? WagaDekl { get; set; }
        public double? ObjDekl { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public double? DlugoscDekl { get; set; }
        public double? WysokoscDekl { get; set; }
        public double? SzerokoscDekl { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? MetryLadowneDekl { get; set; }
        public double? MetryLadowne { get; set; }
        public double? MetryDluzyca { get; set; }
        public double? WagaKubaturowa { get; set; }
        public double? WagaLadowna { get; set; }
        public int? DluzycaDod { get; set; }
        public double? DluzycaDodKg { get; set; }
        public double? WagaObl { get; set; }
        public int? IdPaczki { get; set; }
        public int? PrzesylkaId { get; set; }
        public double? MiejscaPalDekl { get; set; }
        public double? MiejscaPal { get; set; }
    }
}
