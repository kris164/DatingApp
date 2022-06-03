using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Logi systemowe
    /// </summary>
    public partial class Logi
    {
        public int IdLogi { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Typ operacji: C-Nowy, E-Edycja, D-Usunięcie, P-Wydruk, L-Logowanie, O-Wylogowanie, X-Zmiana opcji, R-Czyscz. logów, Z-Błąd
        /// </summary>
        public string TypOperacji { get; set; }
        /// <summary>
        /// Nazwa stacji/komputera
        /// </summary>
        public string NazwaStacji { get; set; }
        /// <summary>
        /// IP stacji/komputera
        /// </summary>
        public string IpStacji { get; set; }
        /// <summary>
        /// Nazwa obiektu na którym wykonywano operację (nazwa tabeli)
        /// </summary>
        public string NazwaObiektu { get; set; }
        /// <summary>
        /// ID obiektu na którym wykonywano operację
        /// </summary>
        public int? IdObiektu { get; set; }
        /// <summary>
        /// Dodatkowy opis operacji
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina
        /// </summary>
        public DateTime? Godz { get; set; }
        /// <summary>
        /// Nazwa aplikacji
        /// </summary>
        public string Appname { get; set; }
        /// <summary>
        /// Wersja aplikacji
        /// </summary>
        public string Appver { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
    }
}
