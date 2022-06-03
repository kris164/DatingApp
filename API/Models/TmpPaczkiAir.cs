using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPaczkiAir
    {
        public int IdTmpPaczkiAir { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdPaczkiAir { get; set; }
        /// <summary>
        /// *** na potrzeby wewnętrzne ***
        /// </summary>
        public int? TworzWieleId { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI_AIR
        /// </summary>
        public int? PrzesylkiAirId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Ilość rzeczywista
        /// </summary>
        public int? Ilosc { get; set; }
        /// <summary>
        /// Numer zewnętrzny paczki
        /// </summary>
        public string NrPaczkiEx { get; set; }
        /// <summary>
        /// Kod kreskowy paczki
        /// </summary>
        public string KodKreskowy { get; set; }
        /// <summary>
        /// ID opisu towaru
        /// </summary>
        public int? OpisId { get; set; }
        /// <summary>
        /// Opis towaru
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Opis towaru - dodatkowy
        /// </summary>
        public string OpisDod { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Symbol opakowania
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Flaga, czy możliwe piętrowanie
        /// </summary>
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// Waga deklarowana
        /// </summary>
        public double? WagaDekl { get; set; }
        /// <summary>
        /// Objętość deklarowana
        /// </summary>
        public double? ObjDekl { get; set; }
        /// <summary>
        /// Waga rzeczywista
        /// </summary>
        public double? Waga { get; set; }
        /// <summary>
        /// Objętość rzeczywista
        /// </summary>
        public double? Obj { get; set; }
        /// <summary>
        /// Długość deklarowana
        /// </summary>
        public double? DlugoscDekl { get; set; }
        /// <summary>
        /// Wysokość deklarowana
        /// </summary>
        public double? WysokoscDekl { get; set; }
        /// <summary>
        /// Szerokość deklarowana
        /// </summary>
        public double? SzerokoscDekl { get; set; }
        /// <summary>
        /// Długość rzeczywista
        /// </summary>
        public double? Dlugosc { get; set; }
        /// <summary>
        /// Wysokość rzeczywista
        /// </summary>
        public double? Wysokosc { get; set; }
        /// <summary>
        /// Szerokość rzeczywista
        /// </summary>
        public double? Szerokosc { get; set; }
        /// <summary>
        /// Czy ADR
        /// </summary>
        public int? Adr { get; set; }
        public double? WagaObj { get; set; }
    }
}
