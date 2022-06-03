using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Załączniki systemowe
    /// </summary>
    public partial class Zalaczniki
    {
        public int IdZalaczniki { get; set; }
        /// <summary>
        /// Nazwa tabeli do której odnosi się relacja
        /// </summary>
        public string Obiekt { get; set; }
        /// <summary>
        /// Nazwa pola po którym zbudowana jest relacja
        /// </summary>
        public string ObiektIdFldName { get; set; }
        /// <summary>
        /// Relacja do obiektu
        /// </summary>
        public int? ObiektId { get; set; }
        /// <summary>
        /// Rodzaj załącznika
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Status załącznika
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Oryginalny katalog skąd pobrany został załącznik
        /// </summary>
        public string OrgKatalog { get; set; }
        /// <summary>
        /// Oryginalna nazwa pliku załącznika
        /// </summary>
        public string OrgNazwaPliku { get; set; }
        /// <summary>
        /// Wewnętrzny katalog gdzie zapisany został załącznik
        /// </summary>
        public string WewnKatalog { get; set; }
        /// <summary>
        /// Wewnętrzna nazwa pliku załącznika
        /// </summary>
        public string WewnNazwaPliku { get; set; }
        /// <summary>
        /// Rozszerzenie pliku
        /// </summary>
        public string Rozszezenie { get; set; }
        /// <summary>
        /// Opis załacznika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Użytkownik który dodał załącznik
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Data dodania załącznika
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina dodania załącznika
        /// </summary>
        public DateTime? Godz { get; set; }
        /// <summary>
        /// Flaga, czy załącznik jest edytowany
        /// </summary>
        public int? Edycja { get; set; }
        /// <summary>
        /// Relacja dla rejestrowania załaczników dla detali
        /// </summary>
        public int? Obiekt2Id { get; set; }
        /// <summary>
        /// Flaga, czy dokument http
        /// </summary>
        public int? Http { get; set; }
        /// <summary>
        /// Adres do załacznikia http
        /// </summary>
        public string HttpAdres { get; set; }
        /// <summary>
        /// Czy załącznik został wyeksportowany
        /// </summary>
        public int? IsExported { get; set; }
        /// <summary>
        /// Dataczas eksportu
        /// </summary>
        public DateTime? IsExportedDt { get; set; }
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
        /// Dataczas skanu poza systemem
        /// </summary>
        public DateTime? ExtScanDt { get; set; }
        /// <summary>
        /// Nazwa formatki CR - wydruku
        /// </summary>
        public string CrFormatka { get; set; }
        /// <summary>
        /// Dataczas modyfikacji obiektu
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// Lokalizacja gdzie odkładane są dokumenty papierowe
        /// </summary>
        public string NrPudla { get; set; }
        /// <summary>
        /// Lokalizacja zapisu pliku
        /// </summary>
        public int? Filelocation { get; set; }
        /// <summary>
        /// Czy wysłany emailem
        /// </summary>
        public int? Email { get; set; }
        /// <summary>
        /// Nazwa tabeli do której odnosi się relacja dla detali
        /// </summary>
        public string Obiekt2 { get; set; }
        /// <summary>
        /// Nazwa pola po którym zbudowana jest relacja dla detali
        /// </summary>
        public string Obiekt2IdFldName { get; set; }
        public int? MaszonskiMasterZalacznikId { get; set; }
        /// <summary>
        /// Czy wysłany na serwer ftp
        /// </summary>
        public int? Ftp { get; set; }
    }
}
