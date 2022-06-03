using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rejestr kontrahentów
    /// </summary>
    public partial class Kontrahenci
    {
        public int IdKontrah { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent jest aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Sygnatura { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string RodzKon { get; set; }
        /// <summary>
        /// Typ kontrahenta - mapa bitowa
        /// </summary>
        public string TypKontr { get; set; }
        /// <summary>
        /// Kod grupy
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Dodatkowe opcje kontrahenta - mapa bitowa
        /// </summary>
        public string OpcjeKontr { get; set; }
        /// <summary>
        /// Nazwa kontrahenta
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Adres (ulica i numery)
        /// </summary>
        public string Ulica { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string NrDom { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string NrLok { get; set; }
        /// <summary>
        /// Miejscowość
        /// </summary>
        public string Miejscowosc { get; set; }
        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Poczta
        /// </summary>
        public string Poczta { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Adr. koresp. - Nazwa
        /// </summary>
        public string NazwaK { get; set; }
        /// <summary>
        /// Adr. koresp. - Adres (ulica i numery)
        /// </summary>
        public string UlicaK { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string NrDomK { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string NrLokK { get; set; }
        /// <summary>
        /// Adr. koresp. - Miejscowość
        /// </summary>
        public string MiejscowoscK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kod pocztowy
        /// </summary>
        public string KodK { get; set; }
        /// <summary>
        /// Adr. koresp. - Poczta
        /// </summary>
        public string PocztaK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kraj
        /// </summary>
        public string KrajK { get; set; }
        /// <summary>
        /// Numer REGON
        /// </summary>
        public string Regon { get; set; }
        /// <summary>
        /// Numer PESEL
        /// </summary>
        public string Pesel { get; set; }
        /// <summary>
        /// Numer NIP
        /// </summary>
        public string Nip { get; set; }
        /// <summary>
        /// Numer NIP 2
        /// </summary>
        public string Nip2 { get; set; }
        /// <summary>
        /// Numer NIP - bez znaków rozdzielających
        /// </summary>
        public string NipCzysty { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string BankNazwa { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string BankKonto { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Osobafin1 { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Osobafin2 { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Oszglasz { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Nrwpisu { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public DateTime? Datawpisu { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int IdKlient { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int IdPlik { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Prefix NIP - symbol kraju
        /// </summary>
        public string PrefixNip { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem
        /// </summary>
        public string WalutaRozliczen { get; set; }
        /// <summary>
        /// Waluta w jakiej podawany jest fracht na zleceniach
        /// </summary>
        public string WalutaFrachtu { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosci { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosci { get; set; }
        /// <summary>
        /// Zakup - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciDost { get; set; }
        /// <summary>
        /// Zakup - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciDost { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string RozbKoszty { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string FvProForma { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string JestOsw { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Oswiadczenie { get; set; }
        /// <summary>
        /// Informacja dla operatora - pojawia sie zawsze w momencie wybrania klienta na zlecenie, fakture etc.
        /// </summary>
        public string InfoDlaOperatora { get; set; }
        /// <summary>
        /// Dowolne uwagi do klienta
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Uwagi drukowane na fakturach
        /// </summary>
        public string UwagiNaFv { get; set; }
        /// <summary>
        /// Numer telefonu do siedziby klienta 1
        /// </summary>
        public string Telefon1 { get; set; }
        /// <summary>
        /// Numer telefonu do siedziby klienta 2
        /// </summary>
        public string Telefon2 { get; set; }
        /// <summary>
        /// Numer faksu do siedziby klienta
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Główny adres email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Osoba kontaktowa
        /// </summary>
        public string OsobaKontakt { get; set; }
        /// <summary>
        /// Adres strony WWW
        /// </summary>
        public string Www { get; set; }
        /// <summary>
        /// Domyślny język dla wystawianych faktur
        /// </summary>
        public string JezykFaktury { get; set; }
        /// <summary>
        /// Kwota maksymalnego zadłużenia przeteminowanego klienta
        /// </summary>
        public double? MaxDlug { get; set; }
        /// <summary>
        /// Maksymalna ilość dni po terminie
        /// </summary>
        public double? MaxPrzeterm { get; set; }
        /// <summary>
        /// Relacja do cennika - dostawa drobnicowa - tab: CENNIKI
        /// </summary>
        public int? CennikId { get; set; }
        /// <summary>
        /// Nazwa cennika - dostawa drobnicowa
        /// </summary>
        public string Cennik { get; set; }
        /// <summary>
        /// Relacja do cennika - zleceniodawca FTL - tab: CENNIKI
        /// </summary>
        public int? CennikFtlId { get; set; }
        /// <summary>
        /// Nazwa cennika - zleceniodawca FTL
        /// </summary>
        public string CennikFtl { get; set; }
        /// <summary>
        /// Relacja do cennika - przewoźnik FTL - tab: CENNIKI
        /// </summary>
        public int? CennikFtlPId { get; set; }
        /// <summary>
        /// Nazwa cennika - przewoźnik FTL
        /// </summary>
        public string CennikFtlP { get; set; }
        /// <summary>
        /// Sprzedaż - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWg { get; set; }
        /// <summary>
        /// Sprzedaż - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaP { get; set; }
        /// <summary>
        /// Sprzedaż - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursK { get; set; }
        /// <summary>
        /// Zakup - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursP { get; set; }
        /// <summary>
        /// Standardowy upust dla klienta
        /// </summary>
        public double? StdUpust { get; set; }
        /// <summary>
        /// Szablon opisu pozycji faktu klienta
        /// </summary>
        public string SzablOpisuPozFakt { get; set; }
        /// <summary>
        /// Etykiety na potrzeby generatora opisu faktur klienta
        /// </summary>
        public string EtykOpisuPozFakt { get; set; }
        /// <summary>
        /// Data ważnosci ubezpieczenia OC przewoźnika
        /// </summary>
        public DateTime? DataOcp { get; set; }
        /// <summary>
        /// Wartość ubezpieczenia OC przewoźnika
        /// </summary>
        public double? WartoscOcp { get; set; }
        /// <summary>
        /// Waluta wartości ubezpieczenia OC przewoźnika
        /// </summary>
        public string WartoscOcpWaluta { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada ubezpieczenia OC spedytora
        /// </summary>
        public int? DataOcpBlokada { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Rejestrowanie dokumentów na inną lokalizację niz lokalizacja kontrahenta
        /// </summary>
        public string DotyczyLokalizacji { get; set; }
        /// <summary>
        /// Relacja do opiekuna klienta - tab: UZYTKOWNIK
        /// </summary>
        public int? OpiekunId { get; set; }
        /// <summary>
        /// Symbol opiekuna klienta
        /// </summary>
        public string Opiekun { get; set; }
        /// <summary>
        /// Konto księgowe 1
        /// </summary>
        public string KontoFk { get; set; }
        /// <summary>
        /// Konto księgowe 2
        /// </summary>
        public string KontoFk2 { get; set; }
        /// <summary>
        /// Data eksportu do systemu FK
        /// </summary>
        public DateTime? ExpFkData { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent wyeksportowany do systemu FK
        /// </summary>
        public int? ExpFk { get; set; }
        /// <summary>
        /// Relacja do pliku eksportu do FK - tab: KOMUNIKACJA_FK
        /// </summary>
        public int? ExpFkId { get; set; }
        /// <summary>
        /// Relacja do domyślnego konta bankowego do faktur - tab: KONTRAHENCI_KONTA
        /// </summary>
        public int? KontoId { get; set; }
        /// <summary>
        /// Numer domyślnego konta bankowego do faktur
        /// </summary>
        public string Konto { get; set; }
        /// <summary>
        /// Flaga, czy numer domyślnego konta w formacie IBAN
        /// </summary>
        public int? Iban { get; set; }
        /// <summary>
        /// Osoba odbierająca wydruk faktury
        /// </summary>
        public string WydrukOdebral { get; set; }
        /// <summary>
        /// Domyślna liczba oryginałów faktur
        /// </summary>
        public int? LOrg { get; set; }
        /// <summary>
        /// Domyślna liczba kopii faktur
        /// </summary>
        public int? LKop { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? GeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? GeoLat { get; set; }
        /// <summary>
        /// Adres e-mail powiazany z modułem EI
        /// </summary>
        public string EmailSpeeda { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent używa systemu SPEED
        /// </summary>
        public int? UzywaSpeeda { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent został zweryfikowany
        /// </summary>
        public int? Zweryfikowany { get; set; }
        /// <summary>
        /// Liczba załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
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
        /// <summary>
        /// Waluta maksymalnego zadłużenia przeteminowanego klienta
        /// </summary>
        public string MaxDlugWal { get; set; }
        /// <summary>
        /// Numer KRS
        /// </summary>
        public string DodOpisNagl { get; set; }
        /// <summary>
        /// Zakup - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWgP { get; set; }
        /// <summary>
        /// Zakup - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaPP { get; set; }
        /// <summary>
        /// Kapitał zakładowy
        /// </summary>
        public string DodOpisNagl2 { get; set; }
        /// <summary>
        /// Numer komunikatora GG
        /// </summary>
        public string Gg { get; set; }
        /// <summary>
        /// Numer komunikatora SKYPE
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// Województwo
        /// </summary>
        public string Wojewodztwo { get; set; }
        /// <summary>
        /// Adr. koresp. - Województwo
        /// </summary>
        public string WojewodztwoK { get; set; }
        /// <summary>
        /// Opis preferowanego sposobu kontaktu
        /// </summary>
        public string PrefKontakt { get; set; }
        /// <summary>
        /// Flaga, czy jest zgoda na przetwarzanie danych osobowych
        /// </summary>
        public int? ZgodaNaPrzetwarzanie { get; set; }
        /// <summary>
        /// Flaga, czy jest zgoda na przetwarzanie w celach marketingowych
        /// </summary>
        public int? ZgodaNaPrzetwarzanieMarket { get; set; }
        /// <summary>
        /// Flaga, czy jest zgoda na przesyłanie e-maili
        /// </summary>
        public int? ZgodaNaOtrzEmail { get; set; }
        /// <summary>
        /// Opis sposobu pozyskania klienta
        /// </summary>
        public string SposobPozyskania { get; set; }
        /// <summary>
        /// Kwota maksymalnego zadłużenia całkowitego klienta
        /// </summary>
        public double? MaxDlugCalk { get; set; }
        /// <summary>
        /// Waluta maksymalnego zadłużenia całkowitego klienta
        /// </summary>
        public string MaxDlugCalkWal { get; set; }
        /// <summary>
        /// Kwota ustalonej wpłaty
        /// </summary>
        public double? UstalonaWplata { get; set; }
        /// <summary>
        /// Waluta ustalonej wpłaty
        /// </summary>
        public string UstalonaWplataWal { get; set; }
        /// <summary>
        /// Data ważności ustalonej wpłaty
        /// </summary>
        public DateTime? UstalonaWplataWaznosc { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWg { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaP { get; set; }
        /// <summary>
        /// Zakup VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWgP { get; set; }
        /// <summary>
        /// Zakup VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaPP { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursK { get; set; }
        /// <summary>
        /// Zakup VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursP { get; set; }
        /// <summary>
        /// Relacja do grupy kontrahenta - tab: KONTRAHENCI_GRUPY
        /// </summary>
        public int? GrupaId { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciOd { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciDostOd { get; set; }
        /// <summary>
        /// Relacja do cennika - podjęcie drobnicowe - tab: CENNIKI
        /// </summary>
        public int? CennikPId { get; set; }
        /// <summary>
        /// Nazwa cennika - podjęcie drobnicowe
        /// </summary>
        public string CennikP { get; set; }
        /// <summary>
        /// Standardowa prowizja spedycyjna dla klienta
        /// </summary>
        public double? StdProwizjaSpedycyjna { get; set; }
        /// <summary>
        /// Relacja do płatnika - tab: KONTRAHENCI
        /// </summary>
        public int? PlatnikId { get; set; }
        /// <summary>
        /// Symbol płatnika
        /// </summary>
        public string Platnik { get; set; }
        /// <summary>
        /// Minimalna wartość szkody - dla modułu UBEZPIECZEŃ
        /// </summary>
        public double? SzkodaMinWartosc { get; set; }
        /// <summary>
        /// Waluta minimalnej wartości szkody - dla modułu UBEZPIECZEŃ
        /// </summary>
        public string SzkodaMinWaluta { get; set; }
        /// <summary>
        /// Wartość samolikwidacji szkody - dla modułu UBEZPIECZEŃ
        /// </summary>
        public double? SamolikwidacjaWartosc { get; set; }
        /// <summary>
        /// Waluta wartości samolikwidacji - dla modułu UBEZPIECZEŃ
        /// </summary>
        public string SamolikwidacjaWaluta { get; set; }
        /// <summary>
        /// Flaga, czy liczyć zadłużenie również z niezafakturowanych zleceń
        /// </summary>
        public int? MaxDlugZlec { get; set; }
        /// <summary>
        /// Numer licencji przewoźnika
        /// </summary>
        public string LicencjaNr { get; set; }
        /// <summary>
        /// Data ważności licencji przewoźnika
        /// </summary>
        public DateTime? LicencjaWaznosc { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada licencji przewoźnika
        /// </summary>
        public int? LicencjaBlokada { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent jest zablokowany
        /// </summary>
        public int? Zablokowany { get; set; }
        /// <summary>
        /// Kto zablokował kontrahenta
        /// </summary>
        public string ZablokowanyPrzez { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Numer polisy ubezpieczenia przewoźnika
        /// </summary>
        public string OcpNr { get; set; }
        /// <summary>
        /// Numer polisy ubezpieczenia przewoźnika
        /// </summary>
        public string OcpUbezp { get; set; }
        /// <summary>
        /// Relacja do ubezpieczenia przewoźnika - tab: POLISY
        /// </summary>
        public int? OcpUbezpId { get; set; }
        /// <summary>
        /// Flaga, czy ubezpieczenie OC przewoźnika obejmuje kraj
        /// </summary>
        public int? OcpKraj { get; set; }
        /// <summary>
        /// Flaga, czy ubezpieczenie OC przewoźnika obejmuje zagranicę
        /// </summary>
        public int? OcpZagr { get; set; }
        /// <summary>
        /// Uwagi do ubezpieczenia OC przewoźnika
        /// </summary>
        public string OcpUwagi { get; set; }
        /// <summary>
        /// Flaga, czy przewoźnik jest również spedycją
        /// </summary>
        public int? Spedytor { get; set; }
        /// <summary>
        /// Numer polisy ubezpieczenia spedytora
        /// </summary>
        public string OcsNr { get; set; }
        /// <summary>
        /// Numer polisy ubezpieczenia spedytora
        /// </summary>
        public string OcsUbezp { get; set; }
        /// <summary>
        /// Relacja do ubezpieczenia spedytora - tab: POLISY
        /// </summary>
        public int? OcsUbezpId { get; set; }
        /// <summary>
        /// Data ważnosci ubezpieczenia OC spedytora
        /// </summary>
        public DateTime? DataOcs { get; set; }
        /// <summary>
        /// Wartość ubezpieczenia OC spedytora
        /// </summary>
        public double? WartoscOcs { get; set; }
        /// <summary>
        /// Waluta wartości ubezpieczenia OC spedytora
        /// </summary>
        public string WartoscOcsWaluta { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada ubezpieczenia OC spedytora
        /// </summary>
        public int? DataOcsBlokada { get; set; }
        /// <summary>
        /// Flaga, czy ubezpieczenie OC spedytora obejmuje kraj
        /// </summary>
        public int? OcsKraj { get; set; }
        /// <summary>
        /// Flaga, czy ubezpieczenie OC spedytora obejmuje zagranicę
        /// </summary>
        public int? OcsZagr { get; set; }
        /// <summary>
        /// Uwagi do ubezpieczenia OC spedytora
        /// </summary>
        public string OcsUwagi { get; set; }
        /// <summary>
        /// &lt;nieużywane&gt;
        /// </summary>
        public int? LicencjaKraj { get; set; }
        /// <summary>
        /// &lt;nieużywane&gt;
        /// </summary>
        public int? LicencjaZagr { get; set; }
        /// <summary>
        /// Symbol klienta w systemie zewnetrznym 1
        /// </summary>
        public string SymbolEx { get; set; }
        /// <summary>
        /// Flaga, czy płatnik jest odbiorcą faktury
        /// </summary>
        public int? PlatnikOdbFv { get; set; }
        /// <summary>
        /// Symbol klienta w sieci
        /// </summary>
        public string SymbolWSieci { get; set; }
        /// <summary>
        /// Symbol klienta w systemie zewnetrznym 2
        /// </summary>
        public string SymbolEx2 { get; set; }
        /// <summary>
        /// Relacja do systemów wymiany danych - tab: SYST_WYM_DANYCH
        /// </summary>
        public int? SystWymDanychId { get; set; }
        /// <summary>
        /// Symbol systemu wymiany danych
        /// </summary>
        public string SystWymDanych { get; set; }
        /// <summary>
        /// Relacja do cennika - inne drobnicowe - tab: CENNIKI
        /// </summary>
        public int? CennikIId { get; set; }
        /// <summary>
        /// Nazwa cennika - inne drobnicowe
        /// </summary>
        public string CennikI { get; set; }
        /// <summary>
        /// Symbol klienta w systemie zewnetrznym 3
        /// </summary>
        public string SymbolEx3 { get; set; }
        /// <summary>
        /// Flaga, jak wyliczać wagę obliczeniową dla przesyłek drobnicowych
        /// </summary>
        public int? SpWyliczWagiObl { get; set; }
        /// <summary>
        /// Rejon kraju
        /// </summary>
        public string Rejon { get; set; }
        /// <summary>
        /// Wartosć marży dodawanej do ceny wyliczonej z cennika - dostawa drobnicowa
        /// </summary>
        public double? CennikMarza { get; set; }
        /// <summary>
        /// Wartosć marży dodawanej do ceny wyliczonej z cennika - podjęcie drobnicowe
        /// </summary>
        public double? CennikPMarza { get; set; }
        /// <summary>
        /// Wartosć marży dodawanej do ceny wyliczonej z cennika - inne drobnicowe
        /// </summary>
        public double? CennikIMarza { get; set; }
        /// <summary>
        /// Numer umowy z kontrahentem
        /// </summary>
        public string UmowaNr { get; set; }
        /// <summary>
        /// Ważność umowy od
        /// </summary>
        public DateTime? UmowaOd { get; set; }
        /// <summary>
        /// Ważność umowy do
        /// </summary>
        public DateTime? UmowaDo { get; set; }
        /// <summary>
        /// Flaga, czy jest umowa z kontrahentem
        /// </summary>
        public int? Umowa { get; set; }
        /// <summary>
        /// Zgoda na wystawianie faktur w imieniu kontrahenta
        /// </summary>
        public int? ZgodaNaWystFaktur { get; set; }
        /// <summary>
        /// Data ostatniej weryfikacji
        /// </summary>
        public DateTime? DataWeryfikacji { get; set; }
        /// <summary>
        /// Flaga, czy scalać odcinki na fakturach dla zlecenń FTL
        /// </summary>
        public int? ScalajOdcinki { get; set; }
        /// <summary>
        /// Flaga, czy dodawać dodatki paliwowe
        /// </summary>
        public int? DodatkiPaliwowe { get; set; }
        /// <summary>
        /// EI - Flaga, jak wczytywać lok. nazdorującą (0-z pliku, 1-z bieżącej, 2-inna)
        /// </summary>
        public int? MiDrLokNadz { get; set; }
        /// <summary>
        /// EI - Inna lokalizacja nazdorująca
        /// </summary>
        public string MiDrLokNadzInna { get; set; }
        /// <summary>
        /// EI - Flaga, jak wczytywać lok. wyjścia (0-z pliku, 1-z bieżącej, 2-inna)
        /// </summary>
        public int? MiDrLokWej { get; set; }
        /// <summary>
        /// EI - Inna lokalizacja wejścia
        /// </summary>
        public string MiDrLokWejInna { get; set; }
        /// <summary>
        /// EI - Flaga, jak wczytywać lok. wejścia (0-z pliku, 1-z bieżącej, 2-inna)
        /// </summary>
        public int? MiDrLokWyj { get; set; }
        /// <summary>
        /// EI - Inna lokalizacja wyjścia
        /// </summary>
        public string MiDrLokWyjInna { get; set; }
        /// <summary>
        /// EI - Flaga, czy przeliczać przesyłkę po wczytaniu
        /// </summary>
        public int? MiDrPrzelicz { get; set; }
        /// <summary>
        /// Data ważności KRS
        /// </summary>
        public DateTime? WaznoscKrs { get; set; }
        /// <summary>
        /// Relacja do POI - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaWyId { get; set; }
        /// <summary>
        /// EI - Flaga, czy ustawić na sztywno zleceniodawcę na przesyłkach wczytywanych
        /// </summary>
        public int? MiZlec { get; set; }
        /// <summary>
        /// EI - Relacja do zlecenodawcy - tab: KONTRAHENCI
        /// </summary>
        public int? MiZleceniodawcaId { get; set; }
        /// <summary>
        /// EI - Symbol zleceniodawcy
        /// </summary>
        public string MiZleceniodawca { get; set; }
        /// <summary>
        /// EI - Flaga, czy przenosić tablice lokalizacji
        /// </summary>
        public int? MiDrBezTabLok { get; set; }
        /// <summary>
        /// EI - Flaga, jak wczytywać nr zewnętrzny (0-nr źródłowy speed-a, 1-nr zlec. kl)
        /// </summary>
        public int? MiDrNrZewn { get; set; }
        /// <summary>
        /// EI - Flaga, jak wczytywać partnera (0-z pliku, 1-inny)
        /// </summary>
        public int? MiDrPartner { get; set; }
        /// <summary>
        /// EI - Relacja do innego partnera - tab: KONTRAHENCI
        /// </summary>
        public string MiDrPartnerInny { get; set; }
        /// <summary>
        /// EI - Symbol innego partnera
        /// </summary>
        public int? MiDrPartnerInnyId { get; set; }
        /// <summary>
        /// EI - Flaga, czy kontrolowaćduplikaty
        /// </summary>
        public int? MiKontrolaDuplikatow { get; set; }
        /// <summary>
        /// Relacja do kontrahenta powiazanego/nadrzędnego - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Uwagi drukowane na zleceniach
        /// </summary>
        public string UwagiNaZlec { get; set; }
        /// <summary>
        /// Data/Godz zablokowania
        /// </summary>
        public DateTime? ZablokowanyDnia { get; set; }
        /// <summary>
        /// Adres www do mapy internetowej
        /// </summary>
        public string AdresMapaWww { get; set; }
        /// <summary>
        /// Numer licencji zagr. przewoźnika
        /// </summary>
        public string LicencjaZagrNr { get; set; }
        /// <summary>
        /// Data ważności licencji zagr. przewoźnika
        /// </summary>
        public DateTime? LicencjaZagrWaznosc { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada licencji zagr. przewoźnika
        /// </summary>
        public int? LicencjaZagrBlokada { get; set; }
        /// <summary>
        /// Flaga, czy wyłączyc aktualizacje POI-a automatycznego
        /// </summary>
        public int? BezAktPoi { get; set; }
        /// <summary>
        /// Sprzedaż - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabK { get; set; }
        /// <summary>
        /// Zakup - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabP { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabK { get; set; }
        /// <summary>
        /// Zakup VAT- Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabP { get; set; }
        /// <summary>
        /// Relacja do cennika - koszty trasy - tab: CENNIKI_SQL
        /// </summary>
        public int? CennikKId { get; set; }
        /// <summary>
        /// Nazwa cennika - koszty trasy
        /// </summary>
        public string CennikK { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem - promy
        /// </summary>
        public string WalutaRozliczenProm { get; set; }
        /// <summary>
        /// Sprz. prom - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciProm { get; set; }
        /// <summary>
        /// Sprz. prom - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciProm { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciPromOd { get; set; }
        /// <summary>
        /// Sprzedaż promów - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWgProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaPProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWgProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaPProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursProm { get; set; }
        /// <summary>
        /// Flaga, czy ostrzegac o końcu OC na X dni przed
        /// </summary>
        public int? OstrzOc { get; set; }
        /// <summary>
        /// Ilość dni ostrzegania o końcu OC
        /// </summary>
        public int? OstrzOcDni { get; set; }
        /// <summary>
        /// Relacja do opiekuna handlowego klienta - tab: UZYTKOWNIK
        /// </summary>
        public int? OpiekunHandlId { get; set; }
        /// <summary>
        /// Symbol opiekuna handlowego klienta
        /// </summary>
        public string OpiekunHandl { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać eFaktury
        /// </summary>
        public int? EFaktury { get; set; }
        /// <summary>
        /// Licz cennik km wg km ładownych albo całkowitych
        /// </summary>
        public int? CennikKmWg { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent jest osobą fizyczną nie prowadzącą działalności
        /// </summary>
        public int? OsFizNpd { get; set; }
        /// <summary>
        /// Relacja do cennika - koszty promu - tab: CENNIKI_SQL
        /// </summary>
        public int? CennikPromKId { get; set; }
        /// <summary>
        /// Nazwa cennika - koszty promu
        /// </summary>
        public string CennikPromK { get; set; }
        /// <summary>
        /// Relacja do cennika - sprzedaż promu - tab: CENNIKI_SQL
        /// </summary>
        public int? CennikPromPId { get; set; }
        /// <summary>
        /// Nazwa cennika - sprzedaż promu
        /// </summary>
        public string CennikPromP { get; set; }
        /// <summary>
        /// Flaga, czy przewoźnik nie ma włąsnej floty
        /// </summary>
        public int? SpedytorBezFloty { get; set; }
        /// <summary>
        /// Flaga, czy dodawać dodatki paliwowe do frachtu
        /// </summary>
        public int? DodatkiPaliwoweDoFr { get; set; }
        /// <summary>
        /// Flaga czy subkonto z generatora
        /// </summary>
        public int? SubGener { get; set; }
        /// <summary>
        /// Relacja do definicji subkont - tab: SUBKONTO_MNEMONIC
        /// </summary>
        public int? SubkontoMnemonicId { get; set; }
        /// <summary>
        /// Delta dla terminarza
        /// </summary>
        public int? TerminarzDelta { get; set; }
        /// <summary>
        /// Delta dla terminarza dla dokumentów
        /// </summary>
        public int? TerminarzDeltaDok { get; set; }
        /// <summary>
        /// Nazwa cennika SQL - przychod
        /// </summary>
        public string CennikSpP { get; set; }
        /// <summary>
        /// Nazwa cennika SQL - koszty
        /// </summary>
        public string CennikSpK { get; set; }
        /// <summary>
        /// Standardowa stawka za ubezpoieczenie w promilach
        /// </summary>
        public double? StdStawkaUbezp { get; set; }
        /// <summary>
        /// Wystawianie faktur w naszym imieniu
        /// </summary>
        public int? WystawiaNaszeFv { get; set; }
        /// <summary>
        /// Adres mailowy do eFaktur
        /// </summary>
        public string EFakturyEmail { get; set; }
        /// <summary>
        /// Flaga, czy są duplikaty po NIP
        /// </summary>
        public int? DuplikatyNip { get; set; }
        /// <summary>
        /// Flaga, czy są duplikaty po SYMBOL-u
        /// </summary>
        public int? DuplikatySym { get; set; }
        /// <summary>
        /// Flaga, czy nadrżedny dla duplikatów
        /// </summary>
        public int? DuplikatyNadrz { get; set; }
        /// <summary>
        /// Uwagi dla dyspozytora
        /// </summary>
        public string UwagiDlaDysp { get; set; }
        /// <summary>
        /// Rodzaj przewoźnika - relacja do tab. : RODZ_PRZEW
        /// </summary>
        public int? RodzPrzewId { get; set; }
        /// <summary>
        /// Rodzaj przewoźnika
        /// </summary>
        public string RodzPrzew { get; set; }
        /// <summary>
        /// Nazwa procedury BD do tworzenia rozliczeń przewoźnika
        /// </summary>
        public string RozlPrzewSp { get; set; }
        /// <summary>
        /// Co jaki czas nastepuje auto rozl. przewoźnika
        /// </summary>
        public string RozlPrzewTyp { get; set; }
        /// <summary>
        /// Cykl, w jakim następuje auto rozl. przewoźnika
        /// </summary>
        public int? RozlPrzewCykl { get; set; }
        public int? Jezyk { get; set; }
        /// <summary>
        /// Dostęp do e-SPEED
        /// </summary>
        public int? Espeed { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_OD
        /// </summary>
        public int? TerminPlatnosciOdKmie { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_DOST_OD
        /// </summary>
        public int? TerminPlatnosciDostOdKmie { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_PROM_OD
        /// </summary>
        public int? TerminPlatnosciPromOdKmie { get; set; }
        /// <summary>
        /// Data wydania licencji przewoźnika
        /// </summary>
        public DateTime? LicencjaDataWyd { get; set; }
        /// <summary>
        /// Data wydania licencji zagr. przewoźnika
        /// </summary>
        public DateTime? LicencjaZagrDataWyd { get; set; }
        /// <summary>
        /// Język komunikacji
        /// </summary>
        public string JezykKomunikacji { get; set; }
        /// <summary>
        /// Status kontrahenta
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Status kontrahenta - SLOT 1
        /// </summary>
        public string Slot1 { get; set; }
        /// <summary>
        /// Status kontrahenta - SLOT 2
        /// </summary>
        public string Slot2 { get; set; }
        /// <summary>
        /// Status kontrahenta - SLOT 3
        /// </summary>
        public string Slot3 { get; set; }
        /// <summary>
        /// Status kontrahenta - SLOT 4
        /// </summary>
        public string Slot4 { get; set; }
        /// <summary>
        /// Status kontrahenta - SLOT 5
        /// </summary>
        public string Slot5 { get; set; }
        /// <summary>
        /// Zleceniodawca - COD - zgoda
        /// </summary>
        public int? CodZgoda { get; set; }
        /// <summary>
        /// Zleceniodawca - COD - forma zwrotu
        /// </summary>
        public string CodFormaPlatn { get; set; }
        /// <summary>
        /// Zleceniodawca - COD - terin zwrotu
        /// </summary>
        public int? CodTermin { get; set; }
        /// <summary>
        /// Zleceniodawca - Opak. zwrotne - zgoda
        /// </summary>
        public int? OpakZwrZgoda { get; set; }
        /// <summary>
        /// Zleceniodawca - Opak. zwrotne - zgoda
        /// </summary>
        public int? AdrZgoda { get; set; }
        /// <summary>
        /// Flaga, czy VIP
        /// </summary>
        public int? Vip { get; set; }
        /// <summary>
        /// Flaga, czy przewoxnik posiada możliwosć SKONTA
        /// </summary>
        public int? SkontoP { get; set; }
        /// <summary>
        /// Nazwa procedury generującej PREIFAKTURA
        /// </summary>
        public string PrefakturaSp { get; set; }
        /// <summary>
        /// Co jaki okres ma być generowany PREFAKTURA
        /// </summary>
        public int? PrefakturaDelta { get; set; }
        /// <summary>
        /// Typ okresu co jaki ma być generowany PREFAKTURA
        /// </summary>
        public string PrefakturaPeriod { get; set; }
        /// <summary>
        /// Start PREFAKTURA od dnia/godz
        /// </summary>
        public DateTime? PrefakturaStart { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem - koszty
        /// </summary>
        public string WalutaRozliczenKoszty { get; set; }
        /// <summary>
        /// Waluta w jakiej podawany jest fracht na zleceniach - koszty
        /// </summary>
        public string WalutaFrachtuKoszty { get; set; }
        /// <summary>
        /// ROD - jako skany
        /// </summary>
        public int? RodSkan { get; set; }
        /// <summary>
        /// Numer kontrahenta u faktora
        /// </summary>
        public string FaktorNr { get; set; }
        /// <summary>
        /// Symbol kontrahenta-faktora
        /// </summary>
        public string Faktor { get; set; }
        /// <summary>
        /// Relacja do kontrahenta-faktora - tab: KONTRAHENCI
        /// </summary>
        public int? FaktorId { get; set; }
        /// <summary>
        /// Przewoźnik - COD - zgoda
        /// </summary>
        public int? CodZgodaP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - limit w PLN
        /// </summary>
        public double? CodLimitNaTraseP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - rozl. okresowe SID
        /// </summary>
        public int? CodRozlOkresoweP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - czy godz rozl kierowca po doreczeniu
        /// </summary>
        public int? CodCzyGodzRozlKierP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - godz rozl kierowca po doreczeniu
        /// </summary>
        public DateTime? CodGodzRozlKierP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - czy blok. po X dniach, gdy nierozl kier.
        /// </summary>
        public int? CodCzyDniBlokNierozlP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - blok. po X dniach, gdy nierozl kier.
        /// </summary>
        public int? CodDniBlokNierozlP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - czy auto nota po X dniach, gdy nierozl kier.
        /// </summary>
        public int? CodCzyDniNotaNierozlP { get; set; }
        /// <summary>
        /// Przewoźnik - COD - auto nota po X dniach, gdy nierozl kier.
        /// </summary>
        public int? CodDniNotaNierozlP { get; set; }
        public int? Demurrage { get; set; }
        public int? Detention { get; set; }
        /// <summary>
        /// Przewoźnik - COD - ilosć dni
        /// </summary>
        public int? CodDniRozlKierP { get; set; }
        /// <summary>
        /// Warsztat - rabat na towary
        /// </summary>
        public double? WaRabatTow { get; set; }
        /// <summary>
        /// Warsztat - rabat na usługi
        /// </summary>
        public double? WaRabatUsl { get; set; }
        /// <summary>
        /// Flaga, jak fakturowac drobnicowe przesyłki zbiuorcze
        /// </summary>
        public int? DrobnFaktZb { get; set; }
        /// <summary>
        /// Korekta - maksymalna ilość dni po terminie
        /// </summary>
        public double? UstaloneMaxPrzeterm { get; set; }
        /// <summary>
        /// Data ważności korekty max dni
        /// </summary>
        public DateTime? UstaloneMaxPrzetermWaznosc { get; set; }
        /// <summary>
        /// Flaga, czy flota do 3.5 T
        /// </summary>
        public int? LicDo35T { get; set; }
        /// <summary>
        /// Flaga, czy odroczony VAT
        /// </summary>
        public int? OdroczonyVat { get; set; }
        /// <summary>
        /// ROD - jako skany - jak dostarczać
        /// </summary>
        public int? RodSkanDostawa { get; set; }
        /// <summary>
        /// ROD - do kogo zwrot
        /// </summary>
        public int? RodZwrotDoId { get; set; }
        /// <summary>
        /// ROD - do kogo zwrot
        /// </summary>
        public string RodZwrotDo { get; set; }
        /// <summary>
        /// ROD - oznaczenie szuflady na dokumenty
        /// </summary>
        public int? RodSzufladaId { get; set; }
        /// <summary>
        /// ROD - oznaczenie szuflady na dokumenty
        /// </summary>
        public string RodSzuflada { get; set; }
        public int? MetodaKasowa { get; set; }
        /// <summary>
        /// Standardowa stawka za ubezpoieczenie w promilach - AIR
        /// </summary>
        public double? StdStawkaUbezpAir { get; set; }
        /// <summary>
        /// Standardowa stawka za ubezpoieczenie w promilach - SEA
        /// </summary>
        public double? StdStawkaUbezpSea { get; set; }
        /// <summary>
        /// Numer umowy z kontrahentem
        /// </summary>
        public string UmowaNrZlec { get; set; }
        /// <summary>
        /// Ważność umowy od
        /// </summary>
        public DateTime? UmowaOdZlec { get; set; }
        /// <summary>
        /// Ważność umowy do
        /// </summary>
        public DateTime? UmowaDoZlec { get; set; }
        /// <summary>
        /// Flaga, czy jest umowa z kontrahentem
        /// </summary>
        public int? UmowaZlec { get; set; }
        /// <summary>
        /// Zleceniodawca - COD - max COD
        /// </summary>
        public double? CodMaxKwota { get; set; }
        /// <summary>
        /// ROD - typ przesyłki zwrotnej
        /// </summary>
        public string RodTypZlecenia { get; set; }
        public int? MixDd { get; set; }
        public int? Potencjalny { get; set; }
        public string AirIataCode { get; set; }
        public string AirAccountNo { get; set; }
        public string AirIataCarrierCode { get; set; }
        public string AirAwbPrefix { get; set; }
        public string SeaScacCode { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciClo { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciClo { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciCloOd { get; set; }
        /// <summary>
        /// Adres strony WWW ubezpieczyciela
        /// </summary>
        public string WwwUbezpieczyciela { get; set; }
        /// <summary>
        /// Relacja do odpowiedzialnego za realizację reklamacji
        /// </summary>
        public int? OpiekunReklamId { get; set; }
        /// <summary>
        /// Symbol odpowiedzialnego za realizację reklamacji
        /// </summary>
        public string OpiekunReklam { get; set; }
        /// <summary>
        /// EI - Wersja interfejsu
        /// </summary>
        public int? MiVer { get; set; }
        public int? EmiOrgId { get; set; }
        /// <summary>
        /// Informacja z systemu wymiany danych
        /// </summary>
        public string KomunikacjaInfo { get; set; }
        /// <summary>
        /// Ubezpieczyciel - min. wart ubezp.
        /// </summary>
        public double? UbezpMinWart { get; set; }
        /// <summary>
        /// Ubezpieczyciel - min. wart ubezp. - waluta
        /// </summary>
        public string UbezpMinWartWal { get; set; }
        public int? VatWPln { get; set; }
        public int? VatWPlnKoszty { get; set; }
        public int? TerminarzNmies { get; set; }
        public int? TerminarzNmiesD { get; set; }
        /// <summary>
        /// Zleceniodawca - Opak. zwrotne - zgoda - FTL
        /// </summary>
        public int? OpakZwrZgodaFtl { get; set; }
        public int? BezPropagacjiPowiad { get; set; }
        public string Powiat { get; set; }
        public string Gmina { get; set; }
        /// <summary>
        /// Data ważności weryfikacji
        /// </summary>
        public DateTime? DataWaznosciWeryfikacji { get; set; }
        /// <summary>
        /// Przewoźnik - ADR - zgoda
        /// </summary>
        public int? AdrZgodaP { get; set; }
        /// <summary>
        /// Konto księgowe 3
        /// </summary>
        public string KontoFk3 { get; set; }
        /// <summary>
        /// Zleceniodawca - SENT - zgoda
        /// </summary>
        public int? Sent { get; set; }
        /// <summary>
        /// Flaga, czy jest umowa RODO z kontrahentem
        /// </summary>
        public int? UmowaRodo { get; set; }
        public string StatusEmisja { get; set; }
        public int? WeightConversionId { get; set; }
        public int? SplitPayment { get; set; }
        /// <summary>
        /// Nr zezwolenia albo pozwolenia uprawniającego do obrotu produktami leczniczymi
        /// </summary>
        public string NumberOfLicense { get; set; }
        /// <summary>
        /// Nazwa organu wydającego zezwolenie albo pozwolenie uprawniające do obrotu produktami leczniczymi
        /// </summary>
        public string AuthorityName { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciDniRob { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciDostDniRob { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciPromDniRob { get; set; }
        /// <summary>
        /// Data ważności maksymalnego zadłużenia
        /// </summary>
        public DateTime? MaxDlugWaznosc { get; set; }
        public int? ViesGusState { get; set; }
        public DateTime? ViesGusStateDate { get; set; }
        /// <summary>
        /// Czy jest zezwolenie weterynaryjne
        /// </summary>
        public int? VetPermit { get; set; }
        /// <summary>
        /// Organ wystawiający zezwolenie weterynaryjne
        /// </summary>
        public string VetPermitAuthorityName { get; set; }
        /// <summary>
        /// Nr zezwolenia weterynaryjnego
        /// </summary>
        public string VetPermitNumber { get; set; }
        /// <summary>
        /// Flaga, czy SKONTO wyłączone
        /// </summary>
        public int? SkontoDisabled { get; set; }
        public DateTime? DataKontrWykazWl { get; set; }
        public int? WynikKontrWykazWl { get; set; }
        public string RequestId { get; set; }
        /// <summary>
        /// Czy kontrahent sezonowy
        /// </summary>
        public int? Sezonowy { get; set; }
        /// <summary>
        /// Relacja do zdefiniowanego sezonu
        /// </summary>
        public int? SezonId { get; set; }
        /// <summary>
        /// Nazwa zdefiniowanego sezonu
        /// </summary>
        public string Sezon { get; set; }
        /// <summary>
        /// Flaga, czy zadłuzenie definiujemy i liczymy per oddział własny
        /// </summary>
        public int? MaxDlugNaOddzialWl { get; set; }
        /// <summary>
        /// Faktoring nie dotyczy not księgowych
        /// </summary>
        public int? FaktorBezNot { get; set; }
        /// <summary>
        /// Nr BDO - gospodarka odpadami
        /// </summary>
        public string Bdo { get; set; }
        public string ViesGusRequestId { get; set; }
        public double? SrWagaPal { get; set; }
        public double? SrIloscPal { get; set; }
        public string Branza { get; set; }
        public string TypUslugi { get; set; }
        public string Eori { get; set; }
        /// <summary>
        /// Wyłączenie analizy ETA
        /// </summary>
        public int? DisableEta { get; set; }
        /// <summary>
        /// Relacja do ubezpieczyciela należności - tab: KONTRAHENCI
        /// </summary>
        public int? UbezpieczycielId { get; set; }
        /// <summary>
        /// Symbol ubezpieczyciela należności
        /// </summary>
        public string Ubezpieczyciel { get; set; }
    }
}
