using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje książki pocztowej przychodzącej
    /// </summary>
    public partial class KsiazkaPocztowaOtrz
    {
        public int IdKsiazkaPocztowaOtrz { get; set; }
        /// <summary>
        /// Typ obiektu - tab: KS_POCZT_DOKUM
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// Data otrzymania
        /// </summary>
        public DateTime? DataOtrzymania { get; set; }
        /// <summary>
        /// Godzina otrzymania
        /// </summary>
        public DateTime? GodzOtrzymania { get; set; }
        /// <summary>
        /// Numer pozycji książki pocztowej
        /// </summary>
        public string NrKp { get; set; }
        /// <summary>
        /// Numer pozycji książki pocztowej - nr kolejny
        /// </summary>
        public int? NrKpKolejny { get; set; }
        /// <summary>
        /// Numer pozycji książki pocztowej - miesiąc
        /// </summary>
        public int? NrKpMies { get; set; }
        /// <summary>
        /// Numer pozycji książki pocztowej - rok
        /// </summary>
        public int? NrKpRok { get; set; }
        /// <summary>
        /// Relacja do nadawcy - tab: KONTRAHENCI
        /// </summary>
        public int? NadawcaId { get; set; }
        /// <summary>
        /// Symbol nadawcy
        /// </summary>
        public string NadawcaSymbol { get; set; }
        /// <summary>
        /// Adres nadawcy
        /// </summary>
        public string NadawcaAdres { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Opis przesyłki
        /// </summary>
        public string OpisPrzesylki { get; set; }
        /// <summary>
        /// Numer własny
        /// </summary>
        public string NrWlasny { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Opłata
        /// </summary>
        public double? Oplata { get; set; }
        /// <summary>
        /// Waluta opłaty
        /// </summary>
        public string OplataWal { get; set; }
        /// <summary>
        /// Liczba załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Rodzaj dokumentów
        /// </summary>
        public string RodzajDok { get; set; }
        /// <summary>
        /// Numer segregatora
        /// </summary>
        public string Segregator { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Numer obiektu
        /// </summary>
        public string Obiekt { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka wewnętrzna
        /// </summary>
        public int? Wewn { get; set; }
        /// <summary>
        /// Lokalizacja nadawcza
        /// </summary>
        public string LokalizacjaNad { get; set; }
        /// <summary>
        /// Dział nadawczy
        /// </summary>
        public string DzialNad { get; set; }
        /// <summary>
        /// Kod kreskowy dla koperty
        /// </summary>
        public string KodKreskowy { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public string StatusEmisja { get; set; }
        /// <summary>
        /// Relacja do oddziału nadawcy - tab: KONTRAHENCI_ODDZIALY
        /// </summary>
        public int? NadawcaOddzialId { get; set; }
    }
}
