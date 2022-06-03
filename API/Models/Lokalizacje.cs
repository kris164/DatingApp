using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Lokalizacje systemowe
    /// </summary>
    public partial class Lokalizacje
    {
        public int IdLokalizacje { get; set; }
        /// <summary>
        /// Kod lokalizacji - używany w tabelach systemowych do relacji
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis lokalizacji
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Miejscowość na wydruki
        /// </summary>
        public string MiastoNaWydruki { get; set; }
        /// <summary>
        /// Symbol używany w formacie numeracji w licznikach
        /// </summary>
        public string SymbolDoNumeracji { get; set; }
        /// <summary>
        /// Symbol używany w interfejsach do FK
        /// </summary>
        public string SymbolDoFk { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod1 { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod2 { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod3 { get; set; }
        /// <summary>
        /// Symbol lokalizacji w sieci dystrybucyjnej
        /// </summary>
        public string SymbolWSieci { get; set; }
        /// <summary>
        /// Dodatkowy tekst umieszczany w stopce wydruków faktur
        /// </summary>
        public string StopkaFv { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrah { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Serwer SMTP
        /// </summary>
        public string SmtpServer { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Port SMTP
        /// </summary>
        public int? SmtpPort { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Użytkownik SMTP
        /// </summary>
        public string SmtpUser { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Hasło SMTP
        /// </summary>
        public string SmtpPass { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Uwierzytelnianie SMTP
        /// </summary>
        public int? SmtpAuth { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Serwer POP3
        /// </summary>
        public string Pop3Server { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Port POP3
        /// </summary>
        public int? Pop3Port { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Użytkownik POP3
        /// </summary>
        public string Pop3User { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Hasło POP3
        /// </summary>
        public string Pop3Pass { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Adres mailowy dla SMTP
        /// </summary>
        public string SmtpMailAdres { get; set; }
        /// <summary>
        /// Flaga, czy wspólna lista kontrahentów
        /// </summary>
        public int? WspolnaListaKontrah { get; set; }
        /// <summary>
        /// Flaga, czy wspólna lista pojazdów
        /// </summary>
        public int? WspolnaListaTaboru { get; set; }
        /// <summary>
        /// Ścieżka do pliku graficznego zawierajacego logo do wydruków
        /// </summary>
        public string SciezkaLogo { get; set; }
        /// <summary>
        /// Relacja do POI-a - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejsceId { get; set; }
        /// <summary>
        /// Dane POI-a
        /// </summary>
        public string Miejsce { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. spedycyjne - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaSp { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. spedycyjne - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaSpP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. transportowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaTr { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. transportowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaTrP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. drobnicowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaDr { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. drobnicowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaDrP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na trasę drobnicową - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaLl { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na trasę drobnicową - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaLlZlec { get; set; }
        /// <summary>
        /// Relacja do lokalizacji nadrzędnej - tab: LOKALIZACJE
        /// </summary>
        public int? LokalizacjaNadrzId { get; set; }
        /// <summary>
        /// Kod lokalizacji nadrzędnej
        /// </summary>
        public string LokalizacjaNadrz { get; set; }
        /// <summary>
        /// Poziom w strukturze sieci
        /// </summary>
        public int? PoziomStruktury { get; set; }
        /// <summary>
        /// Flaga, czy uwzględniać w strukturze sieci
        /// </summary>
        public int? UwzglWStrukt { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja obca / zewnętrzna
        /// </summary>
        public int? LokalizacjaObca { get; set; }
        /// <summary>
        /// Dane koresp. - Nazwa
        /// </summary>
        public string NazwaK { get; set; }
        /// <summary>
        /// Dane koresp. - Adres
        /// </summary>
        public string AdresK { get; set; }
        /// <summary>
        /// Dane koresp. - Miejscowość
        /// </summary>
        public string MiastoK { get; set; }
        /// <summary>
        /// Dane koresp. - Kod pocztowy
        /// </summary>
        public string KodK { get; set; }
        /// <summary>
        /// Dane koresp. - Kraj
        /// </summary>
        public string KrajK { get; set; }
        /// <summary>
        /// Symbol używany w interfejsach do FK
        /// </summary>
        public string SymbolDoFk2 { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int? SmtpImap { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Rodzaj skrzynki odbiorczej - 0-POP3, 1-IMAP
        /// </summary>
        public int? Imap { get; set; }
        /// <summary>
        /// Konfig. EMAIL - Skrzynka IMAP
        /// </summary>
        public string ImapMailbox { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja jest aktywna
        /// </summary>
        public int? Aktywna { get; set; }
        /// <summary>
        /// Flaga, czy uwzględniać w wyznaczaniu tras
        /// </summary>
        public int? UwzglWWyznTras { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja wirtualna
        /// </summary>
        public int? Wirtualna { get; set; }
        /// <summary>
        /// Korekta czasu +/- godz
        /// </summary>
        public int? KorGodz { get; set; }
        /// <summary>
        /// Ustaw zlecającego na przesyłce drobnicowej
        /// </summary>
        public int? ZlecajacyDro { get; set; }
        /// <summary>
        /// Moduł EF - Korekta zużycia w mieście
        /// </summary>
        public double? EfKorZuzM { get; set; }
        /// <summary>
        /// Flaga, czy pokazywać tabor z lokalizacji podrzędnych
        /// </summary>
        public int? PokazTaborPodrz { get; set; }
        /// <summary>
        /// Flaga, czy pokazywać kontrahentów z lokalizacji podrzędnych
        /// </summary>
        public int? PokazKontrahPodrz { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja ma magazyn nośników
        /// </summary>
        public int? MagOpak { get; set; }
        /// <summary>
        /// Dane koresp. - Email
        /// </summary>
        public string EmailK { get; set; }
        /// <summary>
        /// Dane koresp. - Tel
        /// </summary>
        public string TelK { get; set; }
        /// <summary>
        /// Dane koresp. - Fax
        /// </summary>
        public string FaxK { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja partnerska
        /// </summary>
        public int? LokalizacjaPartnerska { get; set; }
        /// <summary>
        /// Konfig. EMAIL - połączenie szyfrowane dla SMTP
        /// </summary>
        public int? SmtpSsl { get; set; }
        /// <summary>
        /// Konfig. EMAIL - połączenie szyfrowane dla POP3_SSL
        /// </summary>
        public int? Pop3Ssl { get; set; }
        /// <summary>
        /// Moduł EF - Dostawca paliwa
        /// </summary>
        public string EfDostawcaPaliwa { get; set; }
        /// <summary>
        /// Moduł EF - Dostawca paliwa
        /// </summary>
        public int? EfDostawcaPaliwaId { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja jest sortownią
        /// </summary>
        public int? Sortownia { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahOperId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string KontrahOper { get; set; }
        /// <summary>
        /// Kraj prowadzenia działalności
        /// </summary>
        public string KrajProwDz { get; set; }
        /// <summary>
        /// Moduł CŁO - Symbol Izby Celnej
        /// </summary>
        public string IzbaCelna { get; set; }
        /// <summary>
        /// Moduł CŁO - Symbol Izby Celnej
        /// </summary>
        public int? IzbaCelnaId { get; set; }
        /// <summary>
        /// Kolor dla aktywnej lokalizacji
        /// </summary>
        public int? Kolor { get; set; }
        /// <summary>
        /// Kolejność punktów trasy 0=wg lp na trasie, 1=wg alg.komiwojażera
        /// </summary>
        public int? MSpeedPunktyTrasyWg { get; set; }
        /// <summary>
        /// Domyslny typ zlecenia warsztatowego
        /// </summary>
        public string RodzajZleceniaW { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja jest magazynem logistycznym
        /// </summary>
        public int? MagLog { get; set; }
        /// <summary>
        /// Wyłączenie COD
        /// </summary>
        public int? DisabledCod { get; set; }
        /// <summary>
        /// Domyslny język dla lokalizacji (code2)
        /// </summary>
        public string DefaultLanguage { get; set; }
    }
}
