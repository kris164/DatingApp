using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rezerwacja numerów AWB dla modułu lotniczego
    /// </summary>
    public partial class KontrahAirAwb
    {
        public int IdKontrahAirAwb { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Numer kolejny
        /// </summary>
        public int NrKolejny { get; set; }
        public string Nr { get; set; }
        /// <summary>
        /// 0 - wolny, 1 - użyty, 98 - zwrócony, 99 - anulowany
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Relacja do trasy lotniczej - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Dopisany recznie
        /// </summary>
        public int Recznie { get; set; }
    }
}
