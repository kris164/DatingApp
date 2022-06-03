using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Blokady obiektów - logi
    /// </summary>
    public partial class BlokadyLog
    {
        public int IdBlokadyLog { get; set; }
        /// <summary>
        /// Relacja do BLOKADY
        /// </summary>
        public int BlokadyId { get; set; }
        /// <summary>
        /// Relacja do BLOKADY_TYPY
        /// </summary>
        public int? BlokadyTypyId { get; set; }
        /// <summary>
        /// Relacja do BLOKADY_PK
        /// </summary>
        public int? BlokadyPkId { get; set; }
        /// <summary>
        /// Typ logu
        /// </summary>
        public int TypLogu { get; set; }
        /// <summary>
        /// DT zdarzenia
        /// </summary>
        public DateTime LogDt { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Użytkownik
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// ID Użytkownika
        /// </summary>
        public int UzytkownikId { get; set; }
        /// <summary>
        /// ID kontrahenta
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Typ obiektu 1
        /// </summary>
        public int? Obj1Id { get; set; }
        /// <summary>
        /// ID obiektu 1
        /// </summary>
        public int? Rec1Id { get; set; }
        /// <summary>
        /// Typ obiektu 2
        /// </summary>
        public int? Obj2Id { get; set; }
        /// <summary>
        /// ID obiektu 2
        /// </summary>
        public int? Rec2Id { get; set; }
        /// <summary>
        /// Info
        /// </summary>
        public string Info { get; set; }
    }
}
