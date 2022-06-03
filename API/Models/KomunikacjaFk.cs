using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KomunikacjaFk
    {
        public int IdKomunikacjaFk { get; set; }
        public string Kierunek { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public string RodzajZakresu { get; set; }
        public int? NumerOd { get; set; }
        public int? NumerDo { get; set; }
        public string Rodzaj { get; set; }
        public int? NrKolejny { get; set; }
        public string Lokalizacja { get; set; }
        public int? IloscDok { get; set; }
        public string Uzytkownik { get; set; }
        public DateTime? DataGen { get; set; }
        public DateTime? GodzGen { get; set; }
        public string Format { get; set; }
        public string NazwaPliku { get; set; }
        public int? PNrSprzedazy { get; set; }
        public int? ONrSprzedazy { get; set; }
        public int? SortWg { get; set; }
        public int? SortKier { get; set; }
        public string Dzial { get; set; }
        public string ListaFaktur { get; set; }
        public DateTime? DataKsiegowania { get; set; }
        public int? TylkoSpeed { get; set; }
        public int? TylkoWarsztat { get; set; }
    }
}
