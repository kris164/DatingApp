using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Blokady obiektów systemowych (kontrahenci, kierowcy etc)
    /// </summary>
    public partial class Blokady
    {
        public int IdBlokady { get; set; }
        /// <summary>
        /// Relacja do BLOKADY_TYPY
        /// </summary>
        public int BlokadyTypyId { get; set; }
        /// <summary>
        /// Nazwa tabeli w bazie której dotyczy blokada
        /// </summary>
        public string Tabela { get; set; }
        /// <summary>
        /// Relacja do obiektu którego dotyczy blokada
        /// </summary>
        public int RecId { get; set; }
        /// <summary>
        /// Opis blokowanego rekordy, np symbol kierowcy, symbol kontrahenta etc
        /// </summary>
        public string RecOpis { get; set; }
        /// <summary>
        /// Dodatkowy opis blokady
        /// </summary>
        public string DodOpis { get; set; }
        /// <summary>
        /// Lokalizacja zakładająca blokadę
        /// </summary>
        public string BlokLokalizacja { get; set; }
        /// <summary>
        /// Dział zakładający blokadę
        /// </summary>
        public string BlokDzial { get; set; }
        /// <summary>
        /// Użytkownik zakładajacy blokadę
        /// </summary>
        public string BlokUzytkownik { get; set; }
        /// <summary>
        /// ID Użytkownika
        /// </summary>
        public int BlokUzytkownikId { get; set; }
        /// <summary>
        /// DT założenia blokady
        /// </summary>
        public DateTime BlokDt { get; set; }
        /// <summary>
        /// Lokalizacja zdejmująca blokadę
        /// </summary>
        public string OdblokLokalizacja { get; set; }
        /// <summary>
        /// Dział zdejmujący blokadę
        /// </summary>
        public string OdblokDzial { get; set; }
        /// <summary>
        /// Użytkownik zdejmujący blokadę
        /// </summary>
        public string OdblokUzytkownik { get; set; }
        /// <summary>
        /// ID Użytkownika
        /// </summary>
        public int? OdblokUzytkownikId { get; set; }
        /// <summary>
        /// DT zdjęcia blokady
        /// </summary>
        public DateTime? OdblokDt { get; set; }
        /// <summary>
        /// Typ obiektu którego dotyczy blokada
        /// </summary>
        public int ObjId { get; set; }
    }
}
