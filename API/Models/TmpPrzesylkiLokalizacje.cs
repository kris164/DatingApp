using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiLokalizacje
    {
        public int IdTmpPrzesylkiLokalizacje { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? Lp { get; set; }
        public string Lokalizacja { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? Automat { get; set; }
        public int? Zaplanowana { get; set; }
        public int? Pominieta { get; set; }
        public string Dzial { get; set; }
        public string LokalizacjaNast { get; set; }
        public string LokalizacjaPoprz { get; set; }
        public string OstStatus { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
    }
}
