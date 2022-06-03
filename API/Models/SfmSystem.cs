using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicje systemów telematycznych
    /// </summary>
    public partial class SfmSystem
    {
        public int IdSfmSystem { get; set; }
        /// <summary>
        /// =1 wyłącza obsługę operatora
        /// </summary>
        public short? Wylacz { get; set; }
        /// <summary>
        /// kod operatora
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// nazwa operatora
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// status operatora
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// użytkownik u operatora
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// hasło użytkownika u operatora
        /// </summary>
        public string Haslo { get; set; }
        /// <summary>
        /// QUA: id firmy
        /// </summary>
        public int? CompanyId { get; set; }
        /// <summary>
        /// Nazwa Provider&apos;a [SMTP_SERVER]
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// Nazwa lub IP
        /// </summary>
        public string Serwer { get; set; }
        /// <summary>
        /// port             [SMTP_PORT]
        /// </summary>
        public string Port { get; set; }
        /// <summary>
        /// Nazwa bazy danych
        /// </summary>
        public string Baza { get; set; }
        /// <summary>
        /// numer systemu
        /// </summary>
        public int? SystemNr { get; set; }
        /// <summary>
        /// startowy ID kom. przychodzącego
        /// </summary>
        public int? IdMsg { get; set; }
        /// <summary>
        /// startowy ID odpowiedzi kierowcy
        /// </summary>
        public int? IdReply { get; set; }
        /// <summary>
        /// DataSystem: pliki: data początkowa pobierania
        /// </summary>
        public DateTime? Startarch { get; set; }
        /// <summary>
        /// DataSystem: =1 włącza usuwanie wczytanych plików
        /// </summary>
        public short? Deletefiles { get; set; }
        /// <summary>
        /// DataSystem: min. częstotliwość pozycji [min]
        /// </summary>
        public int? Filtermintime { get; set; }
        /// <summary>
        /// DataSystem: min. zmiana poz. na postoju [m]
        /// </summary>
        public int? Filtermindistance0 { get; set; }
        /// <summary>
        /// DataSystem: min. zmiana poz. w ruchu [m]
        /// </summary>
        public int? Filtermindistance1 { get; set; }
        /// <summary>
        /// startowy licznik dla komentarzy
        /// </summary>
        public int? LComment { get; set; }
        /// <summary>
        /// startowy licznik stat. komunikatów
        /// </summary>
        public int? LMessage { get; set; }
        /// <summary>
        /// startowy licznik stat. zleceń
        /// </summary>
        public int? LPlace { get; set; }
        /// <summary>
        /// CMA/QHT: URL produkcyjny
        /// </summary>
        public string UrlProd { get; set; }
        /// <summary>
        /// CMA: URL testowy
        /// </summary>
        public string UrlTest { get; set; }
        /// <summary>
        /// CMA: URL inny
        /// </summary>
        public string UrlInny { get; set; }
        /// <summary>
        /// klucz dostępu klienta (np. dla TRONIK)
        /// </summary>
        public string Loginkey { get; set; }
        /// <summary>
        /// HourTRACS: Customer
        /// </summary>
        public string Customer { get; set; }
        /// <summary>
        /// QUA: Przypisanie akcji do numerów makr
        /// </summary>
        public string Macromap { get; set; }
        /// <summary>
        /// bramka SMS (Multiinfo): dane certyfikatru
        /// </summary>
        public byte[] Cert { get; set; }
        /// <summary>
        /// bramka SMS (Multiinfo): nazwa pliku certyfikatu
        /// </summary>
        public string Filename { get; set; }
        public string SmtpMail { get; set; }
        public int? SmtpAuth { get; set; }
        public short? CopyOdo2lkm { get; set; }
        /// <summary>
        /// aktywności dla zdarzeń JAZ - kody rozdzielone średnikiem
        /// </summary>
        public string Driveactivities { get; set; }
        /// <summary>
        /// =1 włącza funkcję odwrotnego geokodowania pozycji
        /// </summary>
        public short? Reversegeocode { get; set; }
        /// <summary>
        /// =1 wyłącza ustawianie statusu &quot;przeczytana&quot; dla wiad.syst.
        /// </summary>
        public short? SysmsgNotread { get; set; }
        /// <summary>
        /// żródło danych tacho 0-TRA_REG /1-BCI_TACHO
        /// </summary>
        public short? BciTacho { get; set; }
        /// <summary>
        /// =1 włącza pobieranie instrukcji TRA wg konfiguracji XML
        /// </summary>
        public short? UseConfigxml { get; set; }
        /// <summary>
        /// =1 wyłącza pobieranie zdarzeń ETA z nawigacji
        /// </summary>
        public short? DisableEta { get; set; }
        /// <summary>
        /// pobieranie zdarzeń JAZ z danymi 0-TACHO /1-osobnym kanałem
        /// </summary>
        public short? JazTraReg { get; set; }
        /// <summary>
        /// =1 włącza pobieranie plików (np. skanów od kierowców)
        /// </summary>
        public short? DownloadFiles { get; set; }
        /// <summary>
        /// =1 włącza alternatywny interfejs oparty o WebService
        /// </summary>
        public short? UseWebservice { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie alarmów
        /// </summary>
        public short? AltAlarms { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie pozycji GPS
        /// </summary>
        public short? AltLocations { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie wiadomości
        /// </summary>
        public short? AltMessages { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie statusów wiadomości
        /// </summary>
        public short? AltMsgstat { get; set; }
        /// <summary>
        /// =1 włącza alternatywne wysyłanie wiadomości
        /// </summary>
        public short? AltSendmsg { get; set; }
        /// <summary>
        /// =1 włącza alternatywne wysyłanie zleceń FTL
        /// </summary>
        public short? AltSendorder { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie skanów dokumentów
        /// </summary>
        public short? AltPoolfiles { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie raportów (IS - Instruction Set)
        /// </summary>
        public short? AltReports { get; set; }
        /// <summary>
        /// Kod dla &quot;Nowa karta drogowa&quot;
        /// </summary>
        public int? IsPwStart { get; set; }
        /// <summary>
        /// Kod dla &quot;Zakończ kartę drogową&quot;
        /// </summary>
        public int? IsPwStop { get; set; }
        /// <summary>
        /// dodatkowa konfiguracja systemu telematycznego
        /// </summary>
        public string Config { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie zdarzeń JAZDA
        /// </summary>
        public short? AltDrivingdata { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie statusów operacyjnych pojazdu
        /// </summary>
        public short? AltStatop { get; set; }
        /// <summary>
        /// =1 włącza alternatywne pobieranie danych TACHO
        /// </summary>
        public short? AltTachodata { get; set; }
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
        /// =1 włącza alternatywne wysyłanie trasy do nawigacji (kontrola korytarza)
        /// </summary>
        public short? AltCorridor { get; set; }
        /// <summary>
        /// kody pomijanych zdarzeń ZA/WY, np: &apos;NN&apos;,&apos;PW+&apos;,&apos;PW-&apos;
        /// </summary>
        public string IsSkipTasks { get; set; }
        public int? SmtpSsl { get; set; }
        /// <summary>
        /// Kod dla &quot;Załadunek&quot;
        /// </summary>
        public int? IsZa { get; set; }
        /// <summary>
        /// Kod dla &quot;Wyładunek&quot;
        /// </summary>
        public int? IsWy { get; set; }
        /// <summary>
        /// =1 włącza pobieranie danych aktywności PTO
        /// </summary>
        public short? AltActivitypto { get; set; }
        /// <summary>
        /// =1 włącza wyznaczanie ETA funkcją interLAN
        /// </summary>
        public short? UseInternaleta { get; set; }
        /// <summary>
        /// =1 oznacza, że system jest domyślny dla wysyłki wiadomości
        /// </summary>
        public short? IsDefault { get; set; }
        /// <summary>
        /// konfiguracja PROXY(typ|host|port|user|pass)
        /// </summary>
        public string Proxy { get; set; }
        /// <summary>
        /// =1 włącza wysyłanie plików/załączników (wiadomości/zlecenia)
        /// </summary>
        public short? AltSendFile { get; set; }
        /// <summary>
        /// max. wielkość pliku wysyłanego załącznika [B]
        /// </summary>
        public int? SendFileMaxSize { get; set; }
        /// <summary>
        /// np. API/Client Id
        /// </summary>
        public string ClientId { get; set; }
    }
}
