using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Paczki drobnicowe - detal do tabeli PRZESYLKI_RAIL
    /// </summary>
    public partial class PaczkiRail
    {
        public int IdPaczkiRail { get; set; }
        /// <summary>
        /// *** na potrzeby wewnętrzne ***
        /// </summary>
        public int? TworzWieleId { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI_RAIL
        /// </summary>
        public int? PrzesylkiRailId { get; set; }
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
        /// NHM
        /// </summary>
        public string Nhm { get; set; }
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
        /// Kod opakowania towaru
        /// </summary>
        public string KodOpakT { get; set; }
        /// <summary>
        /// Symbol opakowania towaru
        /// </summary>
        public string OpakowanieT { get; set; }
        /// <summary>
        /// Ilość opakowań na JT
        /// </summary>
        public int? IloscNaJt { get; set; }
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
        /// Metry ładowne deklarowane
        /// </summary>
        public double? LdmDekl { get; set; }
        /// <summary>
        /// Metry ładowne rzeczywiste
        /// </summary>
        public double? Ldm { get; set; }
        /// <summary>
        /// Miejsca paletowe deklarowane
        /// </summary>
        public double? MpalDekl { get; set; }
        /// <summary>
        /// Miejsca paletowe rzeczywiste
        /// </summary>
        public double? Mpal { get; set; }
        /// <summary>
        /// Metry ładowne deklarowane
        /// </summary>
        public double? MetryLadowneDekl { get; set; }
        /// <summary>
        /// Metry ładowne rzeczywiste
        /// </summary>
        public double? MetryLadowne { get; set; }
        /// <summary>
        /// Czy ADR
        /// </summary>
        public int? Adr { get; set; }
        public double? WagaObj { get; set; }
        public double? WagaObl { get; set; }
    }
}
