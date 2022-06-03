using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Kolejka wydruków w trybie serwerowym
    /// </summary>
    public partial class KolejkaWydrukow
    {
        public int IdKolejkaWydrukow { get; set; }
        /// <summary>
        /// Nr serwera
        /// </summary>
        public int? SerwerId { get; set; }
        /// <summary>
        /// Flaga wstrzymania wydruku
        /// </summary>
        public int? Stop { get; set; }
        /// <summary>
        /// Relacja do użytkownika
        /// </summary>
        public int UzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Data/Godz
        /// </summary>
        public DateTime DataGodz { get; set; }
        /// <summary>
        /// Kod wydruku - LP - list przewozowy
        /// </summary>
        public string KodWydruku { get; set; }
        /// <summary>
        /// Relacja do przesyłki
        /// </summary>
        public int PrzesylkiId { get; set; }
        /// <summary>
        /// Numer przesyłki
        /// </summary>
        public string Przesylki { get; set; }
        /// <summary>
        /// Relacja do trasy
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Numer trasy
        /// </summary>
        public string ListyLiniowe { get; set; }
        /// <summary>
        /// Data/Godz wydruku
        /// </summary>
        public DateTime? WydrukDt { get; set; }
        /// <summary>
        /// Flaga, czy wydrukowany
        /// </summary>
        public int WydrukOk { get; set; }
        /// <summary>
        /// Flaga, czy skanować
        /// </summary>
        public int CzySkan { get; set; }
        /// <summary>
        /// Data/Godz skanu
        /// </summary>
        public DateTime? SkanDt { get; set; }
        /// <summary>
        /// Flaga, czy zeskanowany
        /// </summary>
        public int? SkanOk { get; set; }
        /// <summary>
        /// Flaga, czy drukować etykiety
        /// </summary>
        public int CzyEtykiety { get; set; }
        /// <summary>
        /// Flaga, czy etykiety wydrukowane
        /// </summary>
        public int? EtykietyOk { get; set; }
        /// <summary>
        /// Data/Godz wydruku etykiet
        /// </summary>
        public DateTime? EtykietyDt { get; set; }
        /// <summary>
        /// Zeskanowany numer
        /// </summary>
        public string KodKreskowy { get; set; }
        /// <summary>
        /// W jakie pole wskanowywać numer
        /// </summary>
        public string SkanLpDoPola { get; set; }
    }
}
