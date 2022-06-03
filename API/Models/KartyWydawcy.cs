using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wystawcy plików z operacjami kartowymi
    /// </summary>
    public partial class KartyWydawcy
    {
        public int IdKartyWydawcy { get; set; }
        /// <summary>
        /// Symbol wydawcy kart
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Opis wydawcy
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahentId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrahent { get; set; }
        /// <summary>
        /// Tryb wiązania trans. - wg. typu, nr karty, daty, waluty oraz kwoty brutto
        /// </summary>
        public int? TypLaczenia1 { get; set; }
        /// <summary>
        /// Tryb wiązania trans. - wg. typu, nr karty, daty oraz ilości
        /// </summary>
        public int? TypLaczenia2 { get; set; }
        /// <summary>
        /// Tryb wiązania trans. - wg. typu, nr karty, daty, waluty oraz kwoty brutto przed rabatem
        /// </summary>
        public int? TypLaczenia3 { get; set; }
        /// <summary>
        /// Flaga, czy stosować cennik przy recznej rejestracji
        /// </summary>
        public int? LiczZCennika1 { get; set; }
        /// <summary>
        /// Flaga, czy stosować cennik przy wczytywaniu z pliku
        /// </summary>
        public int? LiczZCennika2 { get; set; }
        /// <summary>
        /// Flaga, czy wczytywac VAT z pliku
        /// </summary>
        public int? WczytujVat { get; set; }
        /// <summary>
        /// Domyślna stawka VAT
        /// </summary>
        public double? DomyslnyVat { get; set; }
        /// <summary>
        /// Domyślny rodzaj kosztów
        /// </summary>
        public string DomyslnyRodzKosztow { get; set; }
        /// <summary>
        /// Flaga, czy zaznaczać zawsze tankowanie do pełna
        /// </summary>
        public int? FullTank { get; set; }
        /// <summary>
        /// Flaga, czy aktualizować kwotę na podstawie pliku (dotyczy wiąz. trans. z dokum. wprowadz. ręcznie)
        /// </summary>
        public int? AktualizujKwote { get; set; }
        /// <summary>
        /// Flaga, czy aktywna
        /// </summary>
        public int? Aktywna { get; set; }
        /// <summary>
        /// Flaga, czy sprawdzać duplikaty
        /// </summary>
        public int? SprDupl { get; set; }
        /// <summary>
        /// Flaga, czy nie uwzgledniać GODZ w korzanieu transakcji ze zlec, PW etc
        /// </summary>
        public int? BezGodz { get; set; }
        /// <summary>
        /// Flaga, czy pobierać kurs z powiązanej FV
        /// </summary>
        public int? KursZPowiazFv { get; set; }
        /// <summary>
        /// Tryb zaokrąglania 0 - brak, 1 - w góre, 2 - w dół, 3 - obcinaj końcówke
        /// </summary>
        public int? TypLaczenia2Zaokr { get; set; }
        /// <summary>
        /// Flaga, czy szukac otwartych PW jak nie znajdzie zamkniętego
        /// </summary>
        public int? SzukajOtwPw { get; set; }
        /// <summary>
        /// Tryb wiązania trans. - wg. rodzaju kosztów
        /// </summary>
        public int? TypLaczeniaRk { get; set; }
    }
}
