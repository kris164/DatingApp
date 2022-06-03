using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Lokalizacje przez które przejdzie/przeszła przesyłka - detal do tabeli PRZESYLKI
    /// </summary>
    public partial class PrzesylkiLokalizacje
    {
        public int IdPrzesylkiLokalizacje { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Ostatni status dla lokalizacji
        /// </summary>
        public string OstStatus { get; set; }
        /// <summary>
        /// Slot 1 dla statusu lokalizacji
        /// </summary>
        public string Slot1 { get; set; }
        /// <summary>
        /// Slot 2 dla statusu lokalizacji
        /// </summary>
        public string Slot2 { get; set; }
        /// <summary>
        /// Slot 3 dla statusu lokalizacji
        /// </summary>
        public string Slot3 { get; set; }
        /// <summary>
        /// Slot 4 dla statusu lokalizacji
        /// </summary>
        public string Slot4 { get; set; }
        /// <summary>
        /// Slot 5 dla statusu lokalizacji
        /// </summary>
        public string Slot5 { get; set; }
        /// <summary>
        /// Relacja do przewozu - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka została juz zaplanowana w danej lokalizacji
        /// </summary>
        public int? Zaplanowana { get; set; }
        /// <summary>
        /// Flaga, czy zapis pochodzi z procesu wyznaczania trasy
        /// </summary>
        public int? Automat { get; set; }
        /// <summary>
        /// Flaga, czy dana lokalizacja zostałą pominięta
        /// </summary>
        public int? Pominieta { get; set; }
        /// <summary>
        /// Lokalizacja następna
        /// </summary>
        public string LokalizacjaNast { get; set; }
        /// <summary>
        /// Lokalizacja następna
        /// </summary>
        public string LokalizacjaPoprz { get; set; }
    }
}
