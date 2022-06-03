using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik tekstów do wydruków
    /// </summary>
    public partial class TekstyDoWydrukow
    {
        public int IdTekstyDoWydrukow { get; set; }
        /// <summary>
        /// Kod tekstu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Rodzaj tekstu: Zlecenia, Faktury, Oferty
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Treść
        /// </summary>
        public string Tekst { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy zmienić może tylko admin
        /// </summary>
        public int? TylkoAdmin { get; set; }
        /// <summary>
        /// Flaga, czy pochodzi z WWW
        /// </summary>
        public int? Www { get; set; }
        /// <summary>
        /// Relacja do tab. KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Relacja do tab. KONTRAHENCI
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Obiekt powiązany
        /// </summary>
        public string Obiekt { get; set; }
    }
}
