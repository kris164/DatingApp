using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WPracownicy
    {
        public int IdWPracownicy { get; set; }
        public int? Aktywny { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Stanowisko { get; set; }
        public string Telefon { get; set; }
        public string TelefonKom { get; set; }
        public string Email { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public string Uwagi { get; set; }
        public string Nip { get; set; }
        public string Pesel { get; set; }
        public string NumerDowodu { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public DateTime? DataUr { get; set; }
        public string MiejsceUr { get; set; }
        public string Umowa { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
