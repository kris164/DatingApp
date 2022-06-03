using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontenery
    {
        public int IdTmpKontenery { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Unikalny identyfikator kontrenera
        /// </summary>
        public int? IdKontenery { get; set; }
        /// <summary>
        /// Typ kontenera
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Numer kontenera
        /// </summary>
        public string Numer { get; set; }
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
        /// Waga towaru w kontenerze
        /// </summary>
        public double? WagaVgm { get; set; }
        /// <summary>
        /// Waga towaru w kontenerze
        /// </summary>
        public double? WagaTara { get; set; }
        /// <summary>
        /// Obj towaru w kontenerze
        /// </summary>
        public double? Obj { get; set; }
        /// <summary>
        /// Temperatura od
        /// </summary>
        public double? TempMin { get; set; }
        /// <summary>
        /// Temperatura do
        /// </summary>
        public double? TempMax { get; set; }
        /// <summary>
        /// Numer HBL
        /// </summary>
        public string NumerHbl { get; set; }
        /// <summary>
        /// NUmer MBL
        /// </summary>
        public string NumerMbl { get; set; }
        /// <summary>
        /// Numer plomby
        /// </summary>
        public string NumerPlomby { get; set; }
        /// <summary>
        /// Numer plomby
        /// </summary>
        public string NumerPlomby2 { get; set; }
        /// <summary>
        /// Numer plomby
        /// </summary>
        public string NumerPlomby3 { get; set; }
        /// <summary>
        /// Numer deklaracji
        /// </summary>
        public string NumerDeklaracji { get; set; }
        /// <summary>
        /// Ilość TEU
        /// </summary>
        public double? Teu { get; set; }
        public int? OpisujacyId { get; set; }
        public string Opisujacy { get; set; }
        public int? Demurrage { get; set; }
        public int? Detention { get; set; }
        public int? MixDD { get; set; }
        /// <summary>
        /// Flaga, czy są załączniki
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        public DateTime? DataPodjecia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public DateTime? DataZwrotu { get; set; }
        public DateTime? DataGateIn { get; set; }
        public DateTime? DataDostOdb { get; set; }
        public DateTime? DataRozladunku { get; set; }
        public int? MiejscePodId { get; set; }
        public string MiejscePod { get; set; }
        public int? MiejsceZwrId { get; set; }
        public string MiejsceZwr { get; set; }
        public string Uwagi { get; set; }
        /// <summary>
        /// Ref 1
        /// </summary>
        public string Ref1 { get; set; }
        /// <summary>
        /// Ref 2
        /// </summary>
        public string Ref2 { get; set; }
        /// <summary>
        /// Ref 3
        /// </summary>
        public string Ref3 { get; set; }
        /// <summary>
        /// Ref 4
        /// </summary>
        public string Ref4 { get; set; }
        /// <summary>
        /// Ref 5
        /// </summary>
        public string Ref5 { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KNumber { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KType { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KSize { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KSteamCo { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KVessel { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KDestPort { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KDest { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KSerialNo { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KBookNo { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KVoyageNo { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public string KSealNo { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public double? KItems { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public double? KWeightLbs { get; set; }
        /// <summary>
        /// * nie używać *
        /// </summary>
        public double? KWeightKg { get; set; }
        public string StanPod { get; set; }
        public string StanZwr { get; set; }
        public int? RailType { get; set; }
        public int? TypyWagonowId { get; set; }
        public string Operator { get; set; }
        public string Nhm { get; set; }
        public int? Fumigacja { get; set; }
        public int? RampaFitosan { get; set; }
        public int? Prywatny { get; set; }
        public int? OperatorId { get; set; }
    }
}
