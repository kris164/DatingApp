using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenciReprez
    {
        public int IdTmpKontrahenciReprez { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Tytuł
        /// </summary>
        public string Tytul { get; set; }
        /// <summary>
        /// Nazwisko i imię
        /// </summary>
        public string NazwiskoImie { get; set; }
        /// <summary>
        /// Stanowisko
        /// </summary>
        public string Stanowisko { get; set; }
        /// <summary>
        /// Grupa
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Telefon
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Telefon komórkowy
        /// </summary>
        public string TelKom { get; set; }
        /// <summary>
        /// Faks
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Numer Gadu-Gadu
        /// </summary>
        public string Gg { get; set; }
        /// <summary>
        /// Numer SKYPE
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// Link do giełdy
        /// </summary>
        public string Gielda { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Oddzial { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać wiadomości mailingowe
        /// </summary>
        public int? Mailing { get; set; }
        /// <summary>
        /// Flaga, czy pracownik aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy eROD
        /// </summary>
        public int? Erod { get; set; }
        /// <summary>
        /// Flaga, czy brać do powiadomienia
        /// </summary>
        public int? Powiadomienie { get; set; }
        /// <summary>
        /// Produkt
        /// </summary>
        public string Produkt { get; set; }
        public int? IdKontrahenciReprez { get; set; }
    }
}
