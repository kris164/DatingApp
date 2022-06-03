using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZadaniaZaWy
    {
        public int IdZadaniaZaWy { get; set; }
        public int? ZadaniaId { get; set; }
        public int? ZlecenieId { get; set; }
        public int? ZlecenieZaId { get; set; }
        public int? ZlecenieWyId { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public short? Komora { get; set; }
        public string Zbiornik { get; set; }
        public int? KZaLkm { get; set; }
        public DateTime? KZaData { get; set; }
        public DateTime? KZaGodzod { get; set; }
        public DateTime? KZaGodzdo { get; set; }
        public int? KZaIlosc { get; set; }
        public int? KZaIlosc15 { get; set; }
        public double? KZaGestosc15 { get; set; }
        public double? KZaMasa { get; set; }
        public double? KZaTempZal { get; set; }
        public int? KWyLkm { get; set; }
        public DateTime? KWyData { get; set; }
        public DateTime? KWyGodzod { get; set; }
        public DateTime? KWyGodzdo { get; set; }
        public double? KWyTemp { get; set; }
        public double? KWyIlosc { get; set; }
        public double? KWyIlosc15 { get; set; }
        public double? ZTempprzed { get; set; }
        public double? ZIloscprzed { get; set; }
        public double? ZIloscprzed15 { get; set; }
        public double? ZTemppo { get; set; }
        public double? ZIloscpo { get; set; }
        public double? ZIloscpo15 { get; set; }
        public double? ZSprzedaz { get; set; }
        public double? ZDostawalitry { get; set; }
        public double? ZDostawalitry15 { get; set; }
        public double? ZRoznica { get; set; }
        public double? ZRoznica15 { get; set; }
        public string ZZbiornik { get; set; }
    }
}
