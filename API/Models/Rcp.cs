using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Rcp
    {
        public int IdRcp { get; set; }
        public int IdFirma { get; set; }
        public int IdKierowcy { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public DateTime? Data { get; set; }
        public int? TypDnia { get; set; }
        public int? NrTygodnia { get; set; }
        public int? NrDniaTygodnia { get; set; }
        public string Nieobecnosc { get; set; }
        public double? Harmonogram { get; set; }
        public DateTime? GRozpoczecia { get; set; }
        public DateTime? GRobocze { get; set; }
        public DateTime? GNocne { get; set; }
        public DateTime? GDyzur { get; set; }
        public DateTime? GDyzur100 { get; set; }
        public DateTime? Nadgodziny { get; set; }
        public DateTime? Nadgodziny100 { get; set; }
        public DateTime? NadgodzinyZreduk { get; set; }
        public DateTime? Nadgodziny100Zreduk { get; set; }
        public DateTime? GUdzielonewolne { get; set; }
        public short? Przekierowany { get; set; }
        public DateTime? PrzekierowanyData { get; set; }
        public int? IdTacho { get; set; }
        public string Uwagi { get; set; }
        public int IdRcpNag { get; set; }
        public string Dzial { get; set; }
        public int? MRobocze { get; set; }
        public int? MNocne { get; set; }
        public int? MDyzur { get; set; }
        public int? MDyzur100 { get; set; }
        public int? MNadgodziny { get; set; }
        public int? MNadgodziny100 { get; set; }
        public int? MNadgodzinyZreduk { get; set; }
        public int? MNadgodziny100Zreduk { get; set; }
        public string KodNieobecnosci { get; set; }
        public DateTime? GZakonczenia { get; set; }
        public int? MniejNiz24h { get; set; }
        public int? MUdzielonewolne { get; set; }
        public int? MOdebrane { get; set; }
        public int? MNadgodzinyodebrane50 { get; set; }
        public int? MNadgodzinyodebrane100 { get; set; }
    }
}
