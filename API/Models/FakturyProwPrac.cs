using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Kwoty do prowizji pracowników - detal do tabeli FAKTURY
    /// </summary>
    public partial class FakturyProwPrac
    {
        public int IdFakturyProwPrac { get; set; }
        /// <summary>
        /// Relacja do faktury - tab: FAKTURY
        /// </summary>
        public int FakturyId { get; set; }
        /// <summary>
        /// Kwota do prowizji
        /// </summary>
        public double? Kwota { get; set; }
        /// <summary>
        /// Waluta
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Retacja do pracownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Nazwa pracownika
        /// </summary>
        public string Uzytkownik { get; set; }
        public int? InspInlan { get; set; }
    }
}
