using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rejestr kontaktów z kontrahentem - CRM
    /// </summary>
    public partial class KontrahenciCrm
    {
        public int IdKontrahenciCrm { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do użytkownika odpowiedzialnego - tab: UZYTKOWNIK
        /// </summary>
        public int? KontUzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika odpowiedzialnego
        /// </summary>
        public string KontUzytkownik { get; set; }
        /// <summary>
        /// Data kontaktu
        /// </summary>
        public DateTime? KontData { get; set; }
        /// <summary>
        /// Godzina kontaktu
        /// </summary>
        public DateTime? KontGodz { get; set; }
        /// <summary>
        /// Z kim kontakt
        /// </summary>
        public string KontOsoba { get; set; }
        /// <summary>
        /// Cel kontaktu - słownik: TEKSTY_CRM
        /// </summary>
        public string KontCel { get; set; }
        /// <summary>
        /// Status kontaktu
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Data następnego kontaktu
        /// </summary>
        public DateTime? NastKontData { get; set; }
        /// <summary>
        /// Godz następnego kontaktu
        /// </summary>
        public DateTime? NastKontGodz { get; set; }
        /// <summary>
        /// Z kim następny kontakt
        /// </summary>
        public string NastKontOsoba { get; set; }
        /// <summary>
        /// Cel następnego kontaktu
        /// </summary>
        public string NastKontCel { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Typ obiektu, którego dotyczy kontakt
        /// </summary>
        public string ObjTyp { get; set; }
        /// <summary>
        /// Identyfikatro systemowy obiektu
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// Numer obiektu w systemie
        /// </summary>
        public string ObjNr { get; set; }
        /// <summary>
        /// Relacja do teczki - tab: TECZKI
        /// </summary>
        public int? TeczkaId { get; set; }
        /// <summary>
        /// Numer teczki
        /// </summary>
        public string Teczka { get; set; }
        /// <summary>
        /// Forma kontaktu
        /// </summary>
        public string KontForma { get; set; }
        /// <summary>
        /// Adres e-mail
        /// </summary>
        public string KontEmail { get; set; }
        /// <summary>
        /// Telefon
        /// </summary>
        public string KontTel { get; set; }
        /// <summary>
        /// Forma następnego kontaktu
        /// </summary>
        public string NastKontForma { get; set; }
        /// <summary>
        /// Adres następnego kontaktu
        /// </summary>
        public string NastKontEmail { get; set; }
        /// <summary>
        /// Telefon następnego kontaktu
        /// </summary>
        public string NastKontTel { get; set; }
        /// <summary>
        /// Treść wiadomości
        /// </summary>
        public string Tresc { get; set; }
        /// <summary>
        /// Numer kontaktu
        /// </summary>
        public string NrCrm { get; set; }
        /// <summary>
        /// Numer kontaktu - nr kolejny
        /// </summary>
        public int? NrCrmKolejny { get; set; }
        /// <summary>
        /// Numer kontaktu - miesiąc
        /// </summary>
        public int? NrCrmMies { get; set; }
        /// <summary>
        /// Numer kontaktu - rok
        /// </summary>
        public int? NrCrmRok { get; set; }
        /// <summary>
        /// Kto zainicjował kontakt
        /// </summary>
        public string KontStrona { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string KontrahSymbol { get; set; }
        /// <summary>
        /// Nazwa kontrahenta
        /// </summary>
        public string KontrahNazwa { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Czas trwania kontaktu
        /// </summary>
        public DateTime? KontCzasTrwania { get; set; }
        /// <summary>
        /// Typ kontaktu
        /// </summary>
        public string KontTyp { get; set; }
        /// <summary>
        /// Podtyp kontaktu
        /// </summary>
        public string KontPodtyp { get; set; }
        /// <summary>
        /// Treść wiadomości
        /// </summary>
        public string TrescDod { get; set; }
        /// <summary>
        /// Relacja do poprzedniej wiadomosci CRM w wątku
        /// </summary>
        public int? KontynuacjaCrmId { get; set; }
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
        public int? KontCelId { get; set; }
        public int? NastKontCelId { get; set; }
        /// <summary>
        /// Adres e-mail DW
        /// </summary>
        public string KontEmailDw { get; set; }
        /// <summary>
        /// Priorytet
        /// </summary>
        public string Priorytet { get; set; }
        /// <summary>
        /// Treść wiadomości RTF
        /// </summary>
        public string TrescRtf { get; set; }
        /// <summary>
        /// Treść wiadomości HTML
        /// </summary>
        public string TrescHtml { get; set; }
        /// <summary>
        /// Status emisji
        /// </summary>
        public string StatusEmisja { get; set; }
        /// <summary>
        /// Relacja do pierwszej wiadomosci CRM w wątku
        /// </summary>
        public int? WatekCrmId { get; set; }
    }
}
