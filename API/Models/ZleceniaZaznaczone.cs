using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaZaznaczone
    {
        public int Id { get; set; }
        public DateTime? Dt { get; set; }
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdZlecenia { get; set; }
        public string OpisTowaru { get; set; }
        public int? Vip { get; set; }
        public int? Fix { get; set; }
        public double? TrasaOdl { get; set; }
        public int? IdZleceniaZaWy { get; set; }
        public int? Lp { get; set; }
        public string ZaWyTyp { get; set; }
        public double? CzasTrwania { get; set; }
        public int? ZaWyMiejsceId { get; set; }
        public string ZaWyMiejsce { get; set; }
        public double? ZaWyLon { get; set; }
        public double? ZaWyLat { get; set; }
        public DateTime? ZaWyData { get; set; }
        public DateTime? ZaWyGodz { get; set; }
        public DateTime? ZaWyGodzOd { get; set; }
        public DateTime? ZaWyGodzDo { get; set; }
        public double? ZaWyObj { get; set; }
        public double? ZaWyWaga { get; set; }
        public int? Palety { get; set; }
        public int? IloscRz { get; set; }
        public double? Dlugosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Wysokosc { get; set; }
        public int? AwizacjaPrzed { get; set; }
        public int? IloscWy { get; set; }
        public string Ref5 { get; set; }
    }
}
