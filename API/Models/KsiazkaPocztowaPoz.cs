using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje książki pocztowej wychodzącej
    /// </summary>
    public partial class KsiazkaPocztowaPoz
    {
        public int IdKsiazkaPocztowaPoz { get; set; }
        /// <summary>
        /// Typ obiektu - tab: KS_POCZT_DOKUM
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// Systemowy ID obiektu
        /// </summary>
        public int? ObiektId { get; set; }
        /// <summary>
        /// Systemowy numer obiektu
        /// </summary>
        public string Obiekt { get; set; }
        /// <summary>
        /// Data utworzenia koperty
        /// </summary>
        public DateTime? DataUtw { get; set; }
        /// <summary>
        /// Flaga, czy wysłano
        /// </summary>
        public int? Wyslane { get; set; }
        /// <summary>
        /// Data wysłania
        /// </summary>
        public DateTime? DataWyslania { get; set; }
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
        /// Relacja do adresata - tab: KONTRAHENCI
        /// </summary>
        public int? AdresatId { get; set; }
        /// <summary>
        /// Symbol adresata
        /// </summary>
        public string AdresatSymbol { get; set; }
        /// <summary>
        /// Adres odbiorcy
        /// </summary>
        public string AdresatAdres { get; set; }
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
        /// Opis przesyłki
        /// </summary>
        public string OpisPrzesylki { get; set; }
        /// <summary>
        /// Numer własny
        /// </summary>
        public string NrWlasny { get; set; }
        /// <summary>
        /// Dowolne uwagi do przesyłki
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Uwago od poczty
        /// </summary>
        public string UwagiPoczty { get; set; }
        /// <summary>
        /// Opłata pocztowa
        /// </summary>
        public double? Oplata { get; set; }
        /// <summary>
        /// Waluta opłaty pocztowej
        /// </summary>
        public string OplataWal { get; set; }
        /// <summary>
        /// Flaga, czy wydrukowano książkę pocztową
        /// </summary>
        public int? Wydrukowane { get; set; }
        /// <summary>
        /// Data wydruku książki pocztowej
        /// </summary>
        public DateTime? DataWydruku { get; set; }
        /// <summary>
        /// Godzina wydruku książki pocztowej
        /// </summary>
        public DateTime? GodzWydruku { get; set; }
        /// <summary>
        /// Godzina wysłania
        /// </summary>
        public DateTime? GodzWyslania { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Rodzaj dokumentów
        /// </summary>
        public string RodzajDok { get; set; }
        /// <summary>
        /// Numer segregatora
        /// </summary>
        public string Segregator { get; set; }
        /// <summary>
        /// Kwota pobrania
        /// </summary>
        public double? Pobranie { get; set; }
        /// <summary>
        /// Waluta kwoty pobrania
        /// </summary>
        public string PobranieWal { get; set; }
        /// <summary>
        /// Opłata za pobranie
        /// </summary>
        public double? PobranieOplata { get; set; }
        /// <summary>
        /// Waluta opłaty za pobranie
        /// </summary>
        public string PobranieOplataWal { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka wewnętrzna
        /// </summary>
        public int? Wewn { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka wewnętrzna wysłana pocztą
        /// </summary>
        public int? WewnWysPoczta { get; set; }
        /// <summary>
        /// Lokalziacja odbiorcza
        /// </summary>
        public string LokalizacjaOdb { get; set; }
        /// <summary>
        /// Dział odbiorczy
        /// </summary>
        public string DzialOdb { get; set; }
        /// <summary>
        /// Kod kreskowy dla koperty
        /// </summary>
        public string KodKreskowy { get; set; }
        /// <summary>
        /// Flaga, czy koperta jest otwarta - tylko jedna otwarta w jednej lokalizacji
        /// </summary>
        public int? Otwarta { get; set; }
        /// <summary>
        /// Kraj odbiorcy
        /// </summary>
        public string AdresatKraj { get; set; }
        /// <summary>
        /// Waga przesyłki
        /// </summary>
        public double? Waga { get; set; }
        /// <summary>
        /// K-raj / Z-agranica
        /// </summary>
        public string KrajZagr { get; set; }
        /// <summary>
        /// Flaga, czy za potw. odb.
        /// </summary>
        public int? PotwDorecz { get; set; }
        /// <summary>
        /// Flaga, czy doreczona
        /// </summary>
        public int? Doreczona { get; set; }
        /// <summary>
        /// Data doręczenia
        /// </summary>
        public DateTime? DoreczonaData { get; set; }
        /// <summary>
        /// Nr potwierdzenia
        /// </summary>
        public string DoreczonaNrPotw { get; set; }
        /// <summary>
        /// Odbiorca przesyłki
        /// </summary>
        public string DoreczonaOdbiorca { get; set; }
        /// <summary>
        /// Flaga, czy priorytet
        /// </summary>
        public int? Priorytet { get; set; }
        /// <summary>
        /// Flaga, czy koperta jest zamknieta
        /// </summary>
        public int? Zamknieta { get; set; }
        /// <summary>
        /// Relacja do oddziału adresata - tab: KONTRAHENCI_ODDZIALY
        /// </summary>
        public int? AdresatOddzialId { get; set; }
        /// <summary>
        /// Załaczniki
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Relacja do oddziału adresata - tab: KONTRAHENCI_REPREZ
        /// </summary>
        public int? AdresatPracId { get; set; }
        /// <summary>
        /// Pracownik
        /// </summary>
        public string AdresatPrac { get; set; }
        /// <summary>
        /// Nr nadania w PP
        /// </summary>
        public string PpNumernadania { get; set; }
        /// <summary>
        /// Nr guid w PP
        /// </summary>
        public string PpGuid { get; set; }
        /// <summary>
        /// Nazwa odbiorcy
        /// </summary>
        public string AdresatNazwa { get; set; }
        /// <summary>
        /// Ulica odbiorcy
        /// </summary>
        public string AdresatUlica { get; set; }
        /// <summary>
        /// Kod poczt. odbiorcy
        /// </summary>
        public string AdresatKod { get; set; }
        /// <summary>
        /// Miasto odbiorcy
        /// </summary>
        public string AdresatMiasto { get; set; }
        public string StatusEmisja { get; set; }
        /// <summary>
        /// Format listu PP
        /// </summary>
        public string PpFormat { get; set; }
        /// <summary>
        /// Flaga, czy EPO
        /// </summary>
        public int? Epo { get; set; }
    }
}
