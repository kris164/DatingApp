using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylki
    {
        public int IdTmpPrzesylki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Lokalizacja { get; set; }
        public string LokalizacjaNadz { get; set; }
        public string LokalizacjaPosr { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public string TrasaKod { get; set; }
        public int? Celna { get; set; }
        public int? JestPobranie { get; set; }
        public string LokalizacjaCloWw { get; set; }
        public string LokalizacjaCloWy { get; set; }
        public double? WagaDekl { get; set; }
        public double? ObjDekl { get; set; }
        public double? LdmDekl { get; set; }
        public double? DluzycaDekl { get; set; }
        public double? IloscDekl { get; set; }
        public double? WagaRzeczywista { get; set; }
        public double? ObjRzeczywista { get; set; }
        public double? Ldm { get; set; }
        public double? Dluzyca { get; set; }
        public double? IloscRzeczywista { get; set; }
        public double? WagaDoObl { get; set; }
        public double? WagaKubaturowa { get; set; }
        public double? WagaLadowna { get; set; }
        public double? DluzycaDodKg { get; set; }
        public int? DluzycaDod { get; set; }
        public double? WagaMax { get; set; }
        public double? WagaObl { get; set; }
        public int? IdPrzesylki { get; set; }
        public string NrPrzesylki { get; set; }
    }
}
