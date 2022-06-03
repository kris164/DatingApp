using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciOpak
    {
        public int IdKontrahenciOpak { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do opakowania - tab: OPAKOWANIA
        /// </summary>
        public int OpakowaniaId { get; set; }
        /// <summary>
        /// Zwrotne
        /// </summary>
        public int? Zwrotne { get; set; }
        /// <summary>
        /// Wymagane
        /// </summary>
        public int? Wymagane { get; set; }
        public double? DlMin { get; set; }
        public double? DlMax { get; set; }
        public double? DlDef { get; set; }
        public double? SzMin { get; set; }
        public double? SzMax { get; set; }
        public double? SzDef { get; set; }
        public double? WyMin { get; set; }
        public double? WyMax { get; set; }
        public double? WyDef { get; set; }
        public double? WagaMin { get; set; }
        public double? WagaMax { get; set; }
        public double? WagaDef { get; set; }
        public double? ObjMin { get; set; }
        public double? ObjMax { get; set; }
        public double? ObjDef { get; set; }
        public double? MpalMin { get; set; }
        public double? MpalMax { get; set; }
        public double? MpalDef { get; set; }
        public string GrupaCen { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Opis { get; set; }
        public string Dzial { get; set; }
        public string Dzialy { get; set; }
        public string Produkty { get; set; }
    }
}
