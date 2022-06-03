using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KonteneryRailLad
    {
        public int IdKonteneryRailLad { get; set; }
        /// <summary>
        /// Relacja do zlecenia, tab: ZLECENIA_RAIL_ID
        /// </summary>
        public int? ZleceniaRailId { get; set; }
        public int? KonteneryId { get; set; }
        public int? LadunekLp { get; set; }
        /// <summary>
        /// Relacja do opisu opakowania - tab: OPISY_TOWAROW
        /// </summary>
        public int? OpisId { get; set; }
        /// <summary>
        /// Opis towaru
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Relacja do opakowania - tab: OPAKOWANIA
        /// </summary>
        public int? OpakowanieId { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Symbol opakowania
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Ilość towaru w kontenerze
        /// </summary>
        public double? Ilosc { get; set; }
        /// <summary>
        /// Waga towaru w kontenerze
        /// </summary>
        public double? Waga { get; set; }
        /// <summary>
        /// Obj towaru w kontenerze
        /// </summary>
        public double? Obj { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Model { get; set; }
        public string Indeks { get; set; }
        public string Nhm { get; set; }
    }
}
