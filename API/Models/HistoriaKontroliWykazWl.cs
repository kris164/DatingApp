using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HistoriaKontroliWykazWl
    {
        public int IdHistoriaKontroliWykazWl { get; set; }
        public int KontrahId { get; set; }
        /// <summary>
        /// Kontrolowany NIP
        /// </summary>
        public string Nip { get; set; }
        /// <summary>
        /// Kontrolowany r-k
        /// </summary>
        public string Rachunek { get; set; }
        /// <summary>
        /// Kontrolowany r-k
        /// </summary>
        public int? RachunekId { get; set; }
        /// <summary>
        /// Typ obiektu w kontekście którego dokonana była kontrola
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// ID obiektu w kontekście którego dokonana była kontrola
        /// </summary>
        public int ObiektId { get; set; }
        /// <summary>
        /// Obiekt w kontekście którego dokonana była kontrola
        /// </summary>
        public string ObiektNr { get; set; }
        public DateTime? DataKontrWykazWl { get; set; }
        public int? WynikKontrWykazWl { get; set; }
        public string RequestId { get; set; }
        public string Json { get; set; }
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
    }
}
