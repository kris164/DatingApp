using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaRail
    {
        public int IdZleceniaRail { get; set; }
        public int? FrmId { get; set; }
        public string Numer { get; set; }
        public int? NumerKolejny { get; set; }
        public int? NumerRok { get; set; }
        public int? NumerMies { get; set; }
        public string NumerZewn { get; set; }
        public string JezykZlecenia { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? DataCutoff { get; set; }
        public DateTime? DataCutoffDok { get; set; }
        public DateTime? DataCutoffVgm { get; set; }
        public DateTime? DataWyk { get; set; }
        public DateTime? DataDoCennika { get; set; }
        public int? Tydz { get; set; }
        public string Inco { get; set; }
        public string IncoMiejsce { get; set; }
        public string Typ { get; set; }
        public string Kierunek { get; set; }
        public string Status { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public string StatusEmisja { get; set; }
        public int? Anulowane { get; set; }
        public int? Zafakturowane { get; set; }
        public int? DokumOk { get; set; }
        public int? StatusKoszty { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientTel { get; set; }
        public string KlientFax { get; set; }
        public string KlientKont { get; set; }
        public int? PlatnikId { get; set; }
        public string PlatnikSymbol { get; set; }
        public string PlatnikNazwa { get; set; }
        public string PlatnikAdres { get; set; }
        public string PlatnikMiasto { get; set; }
        public string PlatnikKod { get; set; }
        public string PlatnikKraj { get; set; }
        public string PlatnikNip { get; set; }
        public int? FvNaPlatnika { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public int? ZalUNadawcy { get; set; }
        public int? NadawcaId { get; set; }
        public string NadawcaSymbol { get; set; }
        public string NadawcaNazwa { get; set; }
        public string NadawcaAdres { get; set; }
        public string NadawcaMiasto { get; set; }
        public string NadawcaKod { get; set; }
        public string NadawcaKraj { get; set; }
        public string NadawcaNip { get; set; }
        public string NadawcaTel { get; set; }
        public string NadawcaFax { get; set; }
        public string NadawcaKont { get; set; }
        public int? RozlUOdbiorcy { get; set; }
        public int? OdbiorcaId { get; set; }
        public string OdbiorcaSymbol { get; set; }
        public string OdbiorcaNazwa { get; set; }
        public string OdbiorcaAdres { get; set; }
        public string OdbiorcaMiasto { get; set; }
        public string OdbiorcaKod { get; set; }
        public string OdbiorcaKraj { get; set; }
        public string OdbiorcaNip { get; set; }
        public string OdbiorcaTel { get; set; }
        public string OdbiorcaFax { get; set; }
        public string OdbiorcaKont { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public string Opiekun { get; set; }
        public string OpiekunHandl { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public int? PolMiejsceId { get; set; }
        public string PolMiejsce { get; set; }
        public string PolMiasto { get; set; }
        public string PolKraj { get; set; }
        public string PolPortNazwa { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Rtd { get; set; }
        public int? PodMiejsceId { get; set; }
        public string PodMiejsce { get; set; }
        public string PodMiasto { get; set; }
        public string PodKraj { get; set; }
        public string PodPortNazwa { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Rta { get; set; }
        public DateTime? DataDostOdb { get; set; }
        public int? MiejsceDostOdbId { get; set; }
        public string MiejsceDostOdb { get; set; }
        public DateTime? DataRozlStatku { get; set; }
        public int? ZwolnKontDlaId { get; set; }
        public string ZwolnKontDla { get; set; }
        public string Trasa { get; set; }
        public string OpisLadunku { get; set; }
        public string Opakowanie { get; set; }
        public string TypKontenera { get; set; }
        public string Kontener { get; set; }
        public double? Ilosc { get; set; }
        public double? IloscTeu { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public string Faktura { get; set; }
        public string FakturaPf { get; set; }
        public string FakturaK { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public int? UbezpCargo { get; set; }
        public double? UbezpProcStawka { get; set; }
        public double? UbezpProc { get; set; }
        public int? UbezpAllIn { get; set; }
        public int? UbezpieczycielId { get; set; }
        public string Ubezpieczyciel { get; set; }
        public double? WartoscLadunku { get; set; }
        public string WartoscLadunkuWal { get; set; }
        public double? UbezpWartosc { get; set; }
        public int? Clenie { get; set; }
        public int? StatusCelnyId { get; set; }
        public int? PotwOdpr { get; set; }
        public string ClenieTypOdpr { get; set; }
        public string ClenieKontrah { get; set; }
        public int? ClenieKontrahId { get; set; }
        public string ClenieKontrahKont { get; set; }
        public string ClenieMiejsce { get; set; }
        public int? ClenieMiejsceId { get; set; }
        public DateTime? ClenieDataWej { get; set; }
        public DateTime? ClenieDataWyj { get; set; }
        public string ClenieUwagi { get; set; }
        public int? ClenieDemurrage { get; set; }
        public int? CleniePotwOdpr { get; set; }
        public string ClenieNrDok { get; set; }
        public DateTime? ClenieDataWaznDok { get; set; }
        public string CelnaNrPrzejsciaGr { get; set; }
        public int? CelnaBezAutoZlecC { get; set; }
        public int? OdprawaCelnaId { get; set; }
        public string OdprawaCelna { get; set; }
        public int? OdroczonyVat { get; set; }
        public int? VatNaSadzie { get; set; }
        public string LokalizacjaCloWw { get; set; }
        public string LokalizacjaCloWy { get; set; }
        public int? CelnaImport { get; set; }
        public int? MiejsceCZaAgencjaId { get; set; }
        public string MiejsceCZaAgencja { get; set; }
        public int? MiejsceCZaId { get; set; }
        public string MiejsceCZaNazwa { get; set; }
        public string MiejsceCZaAdres { get; set; }
        public string MiejsceCZaMiasto { get; set; }
        public string MiejsceCZaKod { get; set; }
        public string MiejsceCZaKraj { get; set; }
        public string MiejsceCZaTel { get; set; }
        public string MiejsceCZaKont { get; set; }
        public string MiejsceCZaStrefa { get; set; }
        public int? CelnaExport { get; set; }
        public int? MiejsceCWyAgencjaId { get; set; }
        public string MiejsceCWyAgencja { get; set; }
        public string MiejsceCWy { get; set; }
        public int? MiejsceCWyId { get; set; }
        public string MiejsceCWyNazwa { get; set; }
        public string MiejsceCWyAdres { get; set; }
        public string MiejsceCWyMiasto { get; set; }
        public string MiejsceCWyKod { get; set; }
        public string MiejsceCWyKraj { get; set; }
        public string MiejsceCWyTel { get; set; }
        public string MiejsceCWyKont { get; set; }
        public string MiejsceCWyStrefa { get; set; }
        public int? OperatorId { get; set; }
        public string Operator { get; set; }
        public string OperatorKont { get; set; }
        public string NazwaPociagu { get; set; }
        public string AwizacjaRail { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Uwagi { get; set; }
        public string UwagiPod { get; set; }
        public string UwagiPotw { get; set; }
        public string Ustalenia { get; set; }
        public string UstaleniaPotw { get; set; }
        public string InfoDlaKsieg { get; set; }
        public int? Konosament { get; set; }
        public int? Ok { get; set; }
        public int? SaKontakty { get; set; }
        public int? SaPodzlecenia { get; set; }
        public int? Zalaczniki { get; set; }
        public int? CheckListOk { get; set; }
        public int? PozycjaOferty { get; set; }
        public int? OfertaId { get; set; }
        public int? OfertaPozycjaId { get; set; }
        public string Oferta { get; set; }
        public int? KopiaZId { get; set; }
        /// <summary>
        /// Nazwa cennika SP dla przychodów
        /// </summary>
        public string PrzychodySp { get; set; }
        /// <summary>
        /// Nazwa cennika SP dla kosztów
        /// </summary>
        public string KosztySp { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public int? UbezpGrupaTowarowaId { get; set; }
        public int? UbezpKlauzulaSpecjalnaId { get; set; }
        public int? UbezpOswZgodnosci { get; set; }
    }
}
