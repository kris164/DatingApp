using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaM
    {
        public int IdTmpZleceniaM { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? FrmId { get; set; }
        public string Numer { get; set; }
        public int? NumerKolejny { get; set; }
        public int? NumerRok { get; set; }
        public int? NumerMies { get; set; }
        public string NumerZewn { get; set; }
        public string NumerHbl { get; set; }
        public string NumerMbl { get; set; }
        public string NumerRejsu { get; set; }
        public string JezykZlecenia { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? DataCutoff { get; set; }
        public int? Tydz { get; set; }
        public string Inco { get; set; }
        public string IncoMiejsce { get; set; }
        public string Typ { get; set; }
        public string Kierunek { get; set; }
        public string Status { get; set; }
        public string StatusEmisja { get; set; }
        public int? Anulowane { get; set; }
        public int? Zafakturowane { get; set; }
        public int? DokumOk { get; set; }
        public int? KlientId { get; set; }
        public int? PlatnikId { get; set; }
        public int? FvNaPlatnika { get; set; }
        public int? OddzialId { get; set; }
        public int? ZalUNadawcy { get; set; }
        public int? NadawcaId { get; set; }
        public int? RozlUOdbiorcy { get; set; }
        public int? OdbiorcaId { get; set; }
        public int? ArmatorId { get; set; }
        public int? AgentId { get; set; }
        public string ServiceContract { get; set; }
        public string NumerSc { get; set; }
        public int? TerminalId { get; set; }
        public int? SpedytorId { get; set; }
        public string Opiekun { get; set; }
        public string OpiekunHandl { get; set; }
        public int? PolMiejsceId { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Rtd { get; set; }
        public int? PodMiejsceId { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Rta { get; set; }
        public DateTime? DataDostOdb { get; set; }
        public int? MiejsceDostOdbId { get; set; }
        public DateTime? DataRozlStatku { get; set; }
        public int? ZwolnKontDlaId { get; set; }
        public string NazwaStatku { get; set; }
        public string Trasa { get; set; }
        public string OpisLadunku { get; set; }
        public string Opakowanie { get; set; }
        public string TypKontenera { get; set; }
        public string Kontener { get; set; }
        public double? Ilosc { get; set; }
        public double? IloscTeu { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public int? UbezpCargo { get; set; }
        public double? UbezpProcStawka { get; set; }
        public double? UbezpProc { get; set; }
        public int? UbezpAllIn { get; set; }
        public double? WartoscLadunku { get; set; }
        public string WartoscLadunkuWal { get; set; }
        public double? UbezpWartosc { get; set; }
        public int? Clenie { get; set; }
        public int? StatusCelnyId { get; set; }
        public string ClenieTypOdpr { get; set; }
        public int? ClenieKontrahId { get; set; }
        public int? ClenieMiejsceId { get; set; }
        public DateTime? ClenieDataWej { get; set; }
        public DateTime? ClenieDataWyj { get; set; }
        public int? ClenieDemurrage { get; set; }
        public int? CleniePotwOdpr { get; set; }
        public string ClenieNrDok { get; set; }
        public int? OdprawaCelnaId { get; set; }
        public int? OdroczonyVat { get; set; }
        public string LokalizacjaCloWw { get; set; }
        public string LokalizacjaCloWy { get; set; }
        public int? CelnaImport { get; set; }
        public int? MiejsceCZaAgencjaId { get; set; }
        public int? MiejsceCZaId { get; set; }
        public int? CelnaExport { get; set; }
        public int? MiejsceCWyAgencjaId { get; set; }
        public string MiejsceCWy { get; set; }
        public int? MiejsceCWyId { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? Konosament { get; set; }
        public int? Ok { get; set; }
    }
}
