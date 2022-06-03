using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KwitPalPoz
    {
        public int IdKwitPalPoz { get; set; }
        /// <summary>
        /// Relacja do kwitu
        /// </summary>
        public int? KwitPalId { get; set; }
        /// <summary>
        /// Relacja PZ/WZ
        /// </summary>
        public int? MagazynZdarzeniaId { get; set; }
        /// <summary>
        /// Nr PZ/WZ
        /// </summary>
        public string MagazynZdarzenia { get; set; }
        /// <summary>
        /// Relacja do trasy
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Nr trasy
        /// </summary>
        public string ListyLiniowe { get; set; }
        /// <summary>
        /// Relacja do przesyłki
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Nr przesyłki
        /// </summary>
        public string Przesylki { get; set; }
        /// <summary>
        /// Relacja do paczki
        /// </summary>
        public int? PaczkiId { get; set; }
        /// <summary>
        /// Nr paczki
        /// </summary>
        public string Paczki { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Opakowanie
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Typ kwitu 0 - uznanie (na +), 1 - obciążenie (na -)
        /// </summary>
        public int? Typ { get; set; }
        /// <summary>
        /// Ilość opakowań
        /// </summary>
        public int? Ilosc { get; set; }
        /// <summary>
        /// Opis do pozycji
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Lokalizacja nadzorująca z przesyłki
        /// </summary>
        public string LokalizacjaNadz { get; set; }
        /// <summary>
        /// Ilość opakowań - rozliczono
        /// </summary>
        public int? IloscRozl { get; set; }
        /// <summary>
        /// Flaga, czy rozliczenie odb. na adnotacji na LP
        /// </summary>
        public int? WgLp { get; set; }
        /// <summary>
        /// Relacja do zlecenia FTL
        /// </summary>
        public int? ZleceniaId { get; set; }
        /// <summary>
        /// Nr zlecenia FTL
        /// </summary>
        public string Zlecenia { get; set; }
        /// <summary>
        /// Relacja do pozycji ZA/WY zlecenia FTL
        /// </summary>
        public int? ZleceniaZaWyId { get; set; }
        public int? BilansOpakPozId { get; set; }
    }
}
