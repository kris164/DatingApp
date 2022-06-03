using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenciOddzialy
    {
        public int IdTmpKontrahenciOddzialy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Relacja do POI - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        /// <summary>
        /// Relacja do kontrahenta powiązanego - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahenciId { get; set; }
        /// <summary>
        /// Typ powiązania
        /// </summary>
        public string TypPowiazania { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Adres
        /// </summary>
        public string Adres { get; set; }
        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Miejscowość
        /// </summary>
        public string Miasto { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Numer telefonu
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Numer faksu
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Adres e-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Osoba kontaktowa
        /// </summary>
        public string Osoba { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? GeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? GeoLat { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać wiadomości mailingowe
        /// </summary>
        public int? Mailing { get; set; }
        /// <summary>
        /// Konto księgowe 1
        /// </summary>
        public string KontoFk { get; set; }
        public string OpisDod { get; set; }
        public int? IdKontrahenciOddzialy { get; set; }
    }
}
