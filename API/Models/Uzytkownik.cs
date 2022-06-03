using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Uzytkownik
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Haslo { get; set; }
        public int? Kategoria { get; set; }
        public short? Poziom { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Lokalizacja { get; set; }
        public short? WszystkieLok { get; set; }
        public short? TylkoPodglad { get; set; }
        public string Prawa { get; set; }
        public string Info { get; set; }
        public string Opcje { get; set; }
        public DateTime? DtHaslo { get; set; }
        public short? Zablokowany { get; set; }
        public string Dzial { get; set; }
        public short? WszystkieDzialy { get; set; }
        public int? PrawaWww { get; set; }
        /// <summary>
        /// użytkownik aplikacji WWW
        /// </summary>
        public short? Www { get; set; }
        /// <summary>
        /// adres konta
        /// </summary>
        public string SmtpMail { get; set; }
        /// <summary>
        /// serwer poczty wychodzącej
        /// </summary>
        public string SmtpServer { get; set; }
        /// <summary>
        /// port serwera poczty wychodzącej
        /// </summary>
        public int? SmtpPort { get; set; }
        /// <summary>
        /// login
        /// </summary>
        public string SmtpLogin { get; set; }
        /// <summary>
        /// hasło
        /// </summary>
        public string SmtpPassword { get; set; }
        /// <summary>
        /// 0/1 - serwer wymaga uwierzytelniania
        /// </summary>
        public short? SmtpAuth { get; set; }
        /// <summary>
        /// serwer poczty przychodzącej
        /// </summary>
        public string Pop3Server { get; set; }
        /// <summary>
        /// port serwera poczty przychodzącej
        /// </summary>
        public int? Pop3Port { get; set; }
        /// <summary>
        /// login
        /// </summary>
        public string Pop3Login { get; set; }
        /// <summary>
        /// hasło
        /// </summary>
        public string Pop3Password { get; set; }
        /// <summary>
        /// =1 oznacza serwer IMAP
        /// </summary>
        public short? Imap { get; set; }
        /// <summary>
        /// IMAP Mailbox
        /// </summary>
        public string ImapMailbox { get; set; }
        public string TelKom { get; set; }
        /// <summary>
        /// domyślny profil dla konfiguracji kontrolek formularzy
        /// </summary>
        public int? DefprofileId { get; set; }
        /// <summary>
        /// liczba nieudanych logowań użytkownika
        /// </summary>
        public int? Lcnt { get; set; }
        /// <summary>
        /// funkcje jakie może pełnić użytkownik
        /// </summary>
        public string Funkcja { get; set; }
        /// <summary>
        /// 0/1 - połączenie szyfrowane SSL/TLS
        /// </summary>
        public short? SmtpSsl { get; set; }
        /// <summary>
        /// 0/1 - połączenie szyfrowane SSL/TLS
        /// </summary>
        public short? Pop3Ssl { get; set; }
        public int? Applicationprofileid { get; set; }
        public string Domainaccount { get; set; }
        public int? Activedirectory { get; set; }
        /// <summary>
        /// data ważności hasła tymczasowego
        /// </summary>
        public DateTime? DtValid { get; set; }
        /// <summary>
        /// prawo do wszystkich oddziałów klienta
        /// </summary>
        public short? WszystkieOddzialy { get; set; }
        /// <summary>
        /// hasło jednorazowe
        /// </summary>
        public short? Singleusepassword { get; set; }
        /// <summary>
        /// id klienta
        /// </summary>
        public int? Klientid { get; set; }
        /// <summary>
        /// id oddziału klienta
        /// </summary>
        public int? Oddzialid { get; set; }
        /// <summary>
        /// data utworzenia użytkownika
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// data zablokowania użytkownika
        /// </summary>
        public DateTime? DtBlock { get; set; }
        /// <summary>
        /// prawo do wszystkich miejsc ZA klienta
        /// </summary>
        public short? WszystkieMiejsceaZa { get; set; }
        /// <summary>
        /// id POI klienta
        /// </summary>
        public int? MiejsceZaId { get; set; }
        /// <summary>
        /// Token używany w eSPEED
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// id konfiguracji instalacji eSPEED
        /// </summary>
        public int? KontrahenciInstalacjeId { get; set; }
        public string Prawa2 { get; set; }
        public string Prawa3 { get; set; }
        public byte[] Password { get; set; }
        public string StatusEmisja { get; set; }
        public int? Gdpr { get; set; }
        public int? GdprVer { get; set; }
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
        public byte[] GdprKey { get; set; }
        /// <summary>
        /// tryb rejestracji debug info w bazie danych
        /// </summary>
        public int? DiMode { get; set; }
        /// <summary>
        /// czas rozpoczęcia rejestracji debug info
        /// </summary>
        public DateTime? DiStart { get; set; }
        /// <summary>
        /// czas zakończenia rejestracji debug info
        /// </summary>
        public DateTime? DiStop { get; set; }
        /// <summary>
        /// id domyślnego języka dla użytkownika ([sys].[syslanguages].[langid])
        /// </summary>
        public int? DatabaseLanguageId { get; set; }
        public int? AdminWww { get; set; }
        public short? WwwWelcomeMailSend { get; set; }
    }
}
