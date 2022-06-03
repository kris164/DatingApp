using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Produkty za/wyładowywane na danym POI-i
    /// </summary>
    public partial class ZleceniaZaWyProd
    {
        public int IdZleceniaZaWyProd { get; set; }
        /// <summary>
        /// Relacja do zlecenia, tab: ZLECENIA
        /// </summary>
        public int ZleceniaId { get; set; }
        /// <summary>
        /// Relacja do POI-a ZA na zleceniu, tab: ZLECENIA_ZA_WY
        /// </summary>
        public int? ZleceniaZaId { get; set; }
        /// <summary>
        /// Relacja do POI-a WY na zleceniu, tab: ZLECENIA_ZA_WY
        /// </summary>
        public int? ZleceniaWyId { get; set; }
        public int? Lp { get; set; }
        public int? OpisTowaruId { get; set; }
        public string OpisTowaru { get; set; }
        public double? Ilosc { get; set; }
        public string OpakowanieKod { get; set; }
        public string Opakowanie { get; set; }
        public double? Waga { get; set; }
        public string JednWagi { get; set; }
        public double? Obj { get; set; }
        public string NrZewn1 { get; set; }
        public string NrZewn2 { get; set; }
        public string NrZewn3 { get; set; }
        public string NrZewn4 { get; set; }
        public string NrZewn5 { get; set; }
        public int? Adr { get; set; }
        public string AdrUn { get; set; }
        public string AdrKlasa { get; set; }
        /// <summary>
        /// ADR - Grupa
        /// </summary>
        public string GrupaAdr { get; set; }
        /// <summary>
        /// ADR - Opis
        /// </summary>
        public string OpisAdr { get; set; }
        /// <summary>
        /// ADR - Ograniczenia tuneli
        /// </summary>
        public string AdrOgrTunele { get; set; }
        /// <summary>
        /// ADR - Ilosć i rodzaj
        /// </summary>
        public string AdrIloscIRodz { get; set; }
        /// <summary>
        /// ADR - Ilość całkowita
        /// </summary>
        public string AdrIloscCalk { get; set; }
        public double? AdrWagaNetto { get; set; }
        public int? AdrWylLq { get; set; }
        public double? MetryLadowne { get; set; }
        public int? Pietrowanie { get; set; }
        public int? AdrEnv { get; set; }
        public double? Gestosc { get; set; }
        public string Temp { get; set; }
        /// <summary>
        /// Relacja do POI-a &lt;&gt; ZA/WY na zleceniu, tab: ZLECENIA_ZA_WY
        /// </summary>
        public int? ZleceniaPoiId { get; set; }
    }
}
