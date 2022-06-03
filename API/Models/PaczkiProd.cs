using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Specyfikacja produktów znajdujących się w paczce
    /// </summary>
    public partial class PaczkiProd
    {
        public int IdPaczkiProd { get; set; }
        /// <summary>
        /// Relacja do paczki, tab: PACZKI
        /// </summary>
        public int PaczkiId { get; set; }
        /// <summary>
        /// Relacja do przesyłki, tab: PRZESYLKI
        /// </summary>
        public int PrzesylkiId { get; set; }
        /// <summary>
        /// Typ zamówienia
        /// </summary>
        public string TypZamowienia { get; set; }
        /// <summary>
        /// Numer zamówienia
        /// </summary>
        public string NrZamowienia { get; set; }
        /// <summary>
        /// Pozycja zamówienia
        /// </summary>
        public string PozZamowienia { get; set; }
        /// <summary>
        /// Sekwencja zamówienia
        /// </summary>
        public string SekwZamowienia { get; set; }
        /// <summary>
        /// Referencja klienta
        /// </summary>
        public string RefKlienta { get; set; }
        /// <summary>
        /// Kod towaru 1
        /// </summary>
        public string KodTowaru1 { get; set; }
        /// <summary>
        /// Kod towaru 2
        /// </summary>
        public string KodTowaru2 { get; set; }
        /// <summary>
        /// Data dostawy
        /// </summary>
        public DateTime? DataDostawy { get; set; }
        /// <summary>
        /// Godzina dostawy
        /// </summary>
        public DateTime? GodzDostawy { get; set; }
        /// <summary>
        /// Toreracja terminu dostawy
        /// </summary>
        public double? TolerTermDost { get; set; }
        /// <summary>
        /// Ilość towaru zamówiona
        /// </summary>
        public double? IloscZamowiona { get; set; }
        /// <summary>
        /// Tolerancja ilości -
        /// </summary>
        public double? TolerIlosciMinus { get; set; }
        /// <summary>
        /// Tolerancja ilości +
        /// </summary>
        public double? TolerIlosciPlus { get; set; }
        /// <summary>
        /// Ilość towaru wysłana
        /// </summary>
        public double? IloscWyslana { get; set; }
        /// <summary>
        /// Wymagana data dostawy
        /// </summary>
        public DateTime? WymaganaDataDostawy { get; set; }
        /// <summary>
        /// Data produkcji
        /// </summary>
        public DateTime? DataProdukcji { get; set; }
        /// <summary>
        /// Region sprzedaży
        /// </summary>
        public string RegionSprzedazy { get; set; }
        /// <summary>
        /// ADR - kod UN
        /// </summary>
        public string KodUn { get; set; }
        /// <summary>
        /// ADR - Klasa
        /// </summary>
        public string KlasaAdr { get; set; }
        /// <summary>
        /// ADR - Grupa
        /// </summary>
        public string GrupaAdr { get; set; }
        /// <summary>
        /// ADR - Opis
        /// </summary>
        public string OpisAdr { get; set; }
        /// <summary>
        /// Data klienta
        /// </summary>
        public DateTime? DataExt { get; set; }
        /// <summary>
        /// Godzina klienta
        /// </summary>
        public DateTime? GodzExt { get; set; }
    }
}
