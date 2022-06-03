using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozdzielniki dla książki pocztowej przychodzącej
    /// </summary>
    public partial class KsiazkaPocztowaOtrzRozdz
    {
        public int IdKsiazkaPocztowaOtrzRozdz { get; set; }
        /// <summary>
        /// Relacja do nagłówka książki - tab: KSIAZKA_POCZTOWA_OTRZ
        /// </summary>
        public int? KsiazkaPocztowaOtrzId { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Opis rozdzielnika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy otrzymuje oryginał czy kopię
        /// </summary>
        public int? Oryginal { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina
        /// </summary>
        public DateTime? Godz { get; set; }
    }
}
