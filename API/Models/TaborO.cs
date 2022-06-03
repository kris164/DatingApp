using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborO
    {
        public int IdTaboruO { get; set; }
        public string NrRej { get; set; }
        public string NrRejNaczepy { get; set; }
        public string NrInwent { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public int? IdNaczepy { get; set; }
        public int? IsAdr { get; set; }
        public int? IsWinda { get; set; }
        public int? Aktywny { get; set; }
        public string Marka { get; set; }
        public int? RokProdukcji { get; set; }
        public string TypPojazduId { get; set; }
        public string TypPojazdu { get; set; }
        public double? MasaWlasna { get; set; }
        public double? Ladownosc { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public int? MiejscaPaletowe { get; set; }
        public double? Szerokosc { get; set; }
        public string WypDod { get; set; }
        public string CennikDomyslny { get; set; }
        public string RodzPaliwa { get; set; }
        public int? LiczbaKomor { get; set; }
        public int? AdrZestawId { get; set; }
        public string AdrZestaw { get; set; }
        public string AdrZestawSymbol { get; set; }
        public string Lokalizacja { get; set; }
        public int? Zalaczniki { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? MarkaId { get; set; }
        public string Model { get; set; }
        public int? ModelId { get; set; }
        public string Wersja { get; set; }
        public int? WersjaId { get; set; }
        public string Dzial { get; set; }
    }
}
