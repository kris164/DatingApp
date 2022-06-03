using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLiniowe
    {
        public int IdListyLiniowe { get; set; }
        public string NrListu { get; set; }
        public int? NrListuKolejny { get; set; }
        public int? NrListuRok { get; set; }
        public int? NrListuMies { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public string NrBordero { get; set; }
        public string Rodzaj { get; set; }
        public DateTime? Data { get; set; }
        public double? Waga { get; set; }
        public double? Ilosc { get; set; }
        public double? Obj { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public string PrzewoznikAdres { get; set; }
        public string PrzewoznikMiasto { get; set; }
        public string PrzewoznikKod { get; set; }
        public string PrzewoznikKraj { get; set; }
        public string PrzewoznikNip { get; set; }
        public string Stan { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string Uwagi { get; set; }
        public string WalutaKalk { get; set; }
        public int? TabelaKursowKalkId { get; set; }
        public string TabelaKursowKalk { get; set; }
        public double? ProcentKosztow { get; set; }
        public string Lokalizacja { get; set; }
        public int? PartnerId { get; set; }
        public string Partner { get; set; }
        public int? Techniczne { get; set; }
        public string Ustalenia { get; set; }
        public string StatusMail { get; set; }
        public string Vessel { get; set; }
        public string Bill { get; set; }
        public string Placeofreceipt { get; set; }
        public string Portofloading { get; set; }
        public string Portofdischarge { get; set; }
        public string Portofdelivery { get; set; }
        public string Containerno { get; set; }
        public DateTime? Sailed { get; set; }
        public DateTime? Expected { get; set; }
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
        public string Kontener { get; set; }
        public string Typ { get; set; }
        public string Strefa { get; set; }
        public int? Tranzyt { get; set; }
        public DateTime? PlanDataRozlad { get; set; }
        public DateTime? PlanGodzRozlad { get; set; }
        public DateTime? PlanDataZalad { get; set; }
        public DateTime? PlanGodzZalad { get; set; }
        public int? PrzeslOdpr { get; set; }
        public int? KontenerId { get; set; }
        public string KontenerRozm { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public int? Zaplanowana { get; set; }
        public int? Zalaczniki { get; set; }
        public string Status { get; set; }
        public int? ProfilPojId { get; set; }
        public string ProfilPoj { get; set; }
        public string OpisLadunku { get; set; }
        public double? PlanMaxWaga { get; set; }
        public double? PlanMaxIlosc { get; set; }
        public double? PlanMaxObj { get; set; }
        public double? Odlegosc { get; set; }
        public double? CenaZaKm { get; set; }
        public string CenaZaKmWal { get; set; }
        public double? Kwota { get; set; }
        public string KwotaWal { get; set; }
        public string UstaleniaZlec { get; set; }
        public int? Prom { get; set; }
        public string PrzewoznikTel { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public int? KplDokum { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string KierowcaTel { get; set; }
        public DateTime? FaktDataRozlad { get; set; }
        public DateTime? FaktGodzRozlad { get; set; }
        public DateTime? FaktDataZalad { get; set; }
        public DateTime? FaktGodzZalad { get; set; }
        public double? OdlegoscPuste { get; set; }
        public double? LiczbaZawy { get; set; }
        public double? CenaZaKmPuste { get; set; }
        public string CenaZaKmPusteWal { get; set; }
        public double? CenaZaMZawy { get; set; }
        public string CenaZaMZawyWal { get; set; }
        public double? InneKoszty { get; set; }
        public double? KwotaOdc1 { get; set; }
        public string KwotaOdc1St { get; set; }
        public double? KwotaOdc2 { get; set; }
        public string KwotaOdc2St { get; set; }
        public double? KwotaOdc3 { get; set; }
        public string KwotaOdc3St { get; set; }
        public int? JestProm { get; set; }
        public int? OdprawaCelnaWywozId { get; set; }
        public string OdprawaCelnaWywoz { get; set; }
        public int? OdprawaCelnaWwozId { get; set; }
        public string OdprawaCelnaWwoz { get; set; }
        public int? OdprawaGranicznaId { get; set; }
        public string OdprawaGraniczna { get; set; }
        public string ZaMiejsce { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKraj { get; set; }
        public string WyMiejsce { get; set; }
        public string WyMiasto { get; set; }
        public string WyKraj { get; set; }
        public int? SfmStatus { get; set; }
        public int? SfmVer { get; set; }
        public int? SfmLZaWy { get; set; }
        public int? SfmWysl { get; set; }
        public int? ZleceniaId { get; set; }
        public string Zlecenia { get; set; }
        public int? Siec { get; set; }
        public string SamochodNrB { get; set; }
        public string NaczepaNrB { get; set; }
        public string LokalizacjaPosr { get; set; }
        public string Kierunek { get; set; }
        public int? RozlNaPrzes { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public int? Kolko { get; set; }
        public int? AwizoWewn { get; set; }
        public int? AwizoDoId { get; set; }
        public DateTime? DataOrg { get; set; }
        public double? WagaDekl { get; set; }
        public double? WagaObl { get; set; }
        public double? ObjDekl { get; set; }
        public double? IloscPrzesylek { get; set; }
        public int? UtworzonoImporty { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public int? BezSfm { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public string Kierowca2Tel { get; set; }
        public string Dzial { get; set; }
        public string PartnerTrafik { get; set; }
        public int? SaKontakty { get; set; }
        public int? Rozliczona { get; set; }
        public int? RhenusRozlTrasId { get; set; }
        public int? StatusKoszty { get; set; }
        public int? PrzeladNaKolach { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string ZaKod { get; set; }
        public string WyKod { get; set; }
        public int? WariantyGenZawyId { get; set; }
        public string WariantyGenZawy { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public string IsExportedFile { get; set; }
        public int? DyspozytorId { get; set; }
        public string Dyspozytor { get; set; }
        public string TrasaKod { get; set; }
        public int? SaKomunikaty { get; set; }
        public int? DrPlanId { get; set; }
        public int? Dynamiczna { get; set; }
        public double? MiejscaPal { get; set; }
        public int? StatusPda { get; set; }
        public int? IdPda { get; set; }
        public double? Przychod { get; set; }
        public string PrzychodWal { get; set; }
        public int? Niedoreczone { get; set; }
        public int? GenZawyOk { get; set; }
        /// <summary>
        /// Informacje dla SFM-a
        /// </summary>
        public string InfoSfm { get; set; }
        public int? TrasaPoprzedniaId { get; set; }
        /// <summary>
        /// Flaga, czy jest niezgodnosc
        /// </summary>
        public short? Niezgodnosc { get; set; }
        /// <summary>
        /// Flaga, czy jest reklamacja
        /// </summary>
        public short? Reklamacja { get; set; }
        public int? BezKalkulacji { get; set; }
        public string StatusEmisja { get; set; }
        public string StanPlan { get; set; }
        public double? OdlegoscWgMapy { get; set; }
        public int? TylkoCennik { get; set; }
        public int? StatusKalk { get; set; }
        public double? RozlNaPKwFv { get; set; }
        public double? RozlNaPKw { get; set; }
        public double? RozlNaPKwFvP { get; set; }
        public double? RozlNaPKwP { get; set; }
        public double? OdlegoscPusteWgMapy { get; set; }
        public double? OdlegoscWgPrz { get; set; }
        public double? OdlegoscPusteWgPrz { get; set; }
        public string KwotaWalFv { get; set; }
        public int? Niepodjete { get; set; }
        public int? GieldaPojazdowId { get; set; }
        public int? RouteTimetabId { get; set; }
        /// <summary>
        /// Oznaczenie relacji np. POZ-WAW
        /// </summary>
        public string Relacja { get; set; }
        /// <summary>
        /// Numer LH np. POZWAW1
        /// </summary>
        public string NrLinii { get; set; }
        public double? MiejscaPalDekl { get; set; }
        /// <summary>
        /// Ocena wykonania zlecenia przez przewoźnika
        /// </summary>
        public short? OcenaPrzewoznika { get; set; }
        public int? JestRw { get; set; }
        public DateTime? TrigTimestamp { get; set; }
        public int? Adr { get; set; }
        public double? PunktyAdr { get; set; }
        public int? CennikKontrola { get; set; }
        public int? PunktyAdrChk { get; set; }
        public int? Lamana { get; set; }
        public int? Direct { get; set; }
        public DateTime? LastPlanChange { get; set; }
        public DateTime? LastMagGen { get; set; }
        public int? Ow { get; set; }
        public int? ZPodlogi { get; set; }
        public int? ProfilNaczId { get; set; }
        public string ProfilNacz { get; set; }
        public string KosztySp { get; set; }
        public string PrzychodySp { get; set; }
        public DateTime? LastMagGenPz { get; set; }
        public string LokalizacjaNadz { get; set; }
        public int? RouteTimetabPozId { get; set; }
        public int? Dw { get; set; }
        public int? PojazdAdr { get; set; }
        public int? CmrId { get; set; }
        public string Cmr { get; set; }
        public string KatTrasy { get; set; }
        public double? PIlosc { get; set; }
        public double? PWaga { get; set; }
        public double? PObj { get; set; }
        public double? PMiejscaPal { get; set; }
        public double? DIlosc { get; set; }
        public double? DWaga { get; set; }
        public double? DObj { get; set; }
        public double? DMiejscaPal { get; set; }
        public double? OdlegoscWgMapyAutostrady { get; set; }
        public double? OdlegoscWgMapyEksprKraj { get; set; }
        public double? OdlegoscWgMapyPozostale { get; set; }
        public int? Bezkosztowa { get; set; }
        /// <summary>
        /// FV/NO/RW/--
        /// </summary>
        public string JakRozl { get; set; }
        public int? IloscLqAdrChk { get; set; }
        public double? IloscLqAdr { get; set; }
        public string PrzewoznikKont { get; set; }
        public int? Partner2Id { get; set; }
        public string Partner2 { get; set; }
        /// <summary>
        /// Flaga, czy skany są OK
        /// </summary>
        public short? SkanyZgodne { get; set; }
        public int? KplCod { get; set; }
        public int? TempPlus { get; set; }
        public string Kurier { get; set; }
        public int? KurierParametryZPartnera { get; set; }
        public string SqlDebugInfo { get; set; }
        public int? UpdtypePda { get; set; }
        public int? EmiState { get; set; }
        public int? Anulowana { get; set; }
        public int? EmiOrgId { get; set; }
        /// <summary>
        /// status wysyłki do mSPEED (10-do wysyłki / 20-odebrano)
        /// </summary>
        public int? Mobilestatus { get; set; }
        public int? Mobilesequence { get; set; }
        public int? KopiaZId { get; set; }
        public DateTime? DataWyk { get; set; }
        public int? PrzewoznikOddzialId { get; set; }
        public string PrzewoznikOddzialNazwa { get; set; }
        public string PrzewoznikOddzialAdres { get; set; }
        public string PrzewoznikOddzialMiasto { get; set; }
        public string PrzewoznikOddzialKod { get; set; }
        public string PrzewoznikOddzialKraj { get; set; }
        public int? PodwObsada { get; set; }
        public DateTime? DtJazdyStart { get; set; }
        public int? CzasJazdyGranica { get; set; }
        public int? MapRouting { get; set; }
        public int? OptTaskId { get; set; }
        public int? MapRoute { get; set; }
        public int? Source { get; set; }
        public int? Clenie { get; set; }
        public int? StatusCelnyId { get; set; }
        public int? PotwOdpr { get; set; }
        public int? WwozAgencjaId { get; set; }
        public int? WywozAgencjaId { get; set; }
        public int? CelnaBezAutoZlecC { get; set; }
        public DateTime? CzasJazdy { get; set; }
        public DateTime? CzasOper { get; set; }
        public DateTime? CzasCalk { get; set; }
        public int? KmOp { get; set; }
        public int? IsTrans { get; set; }
        public DateTime? IsTransDt { get; set; }
        public int? IsTransUserId { get; set; }
        public string IsTransNumber { get; set; }
        public int? Sent { get; set; }
        public string SentGeoLok { get; set; }
        public string InfoDlaKsieg { get; set; }
        public int? IsTeleroute { get; set; }
        public DateTime? IsTelerouteDt { get; set; }
        public int? IsTelerouteUserId { get; set; }
        public int? IsTimocom { get; set; }
        public DateTime? IsTimocomDt { get; set; }
        public int? IsTimocomUserId { get; set; }
        public int? IsTranswide { get; set; }
        public DateTime? IsTranswideDt { get; set; }
        public int? IsTranswideUserId { get; set; }
        public int? BezDodPaliwowego { get; set; }
        /// <summary>
        /// Średni koszt za km
        /// </summary>
        public double? HereAverageKmCost { get; set; }
        /// <summary>
        /// Średni koszt godziny
        /// </summary>
        public double? HereAverageHourCost { get; set; }
        /// <summary>
        /// Koszt stały na trasę
        /// </summary>
        public double? HereRouteCost { get; set; }
        public string HereCostCurrency { get; set; }
        /// <summary>
        /// Wyznaczenie trasy: 1=szybka, 2=krótka, 3=optymalna
        /// </summary>
        public int? HereRouteCalculateType { get; set; }
        /// <summary>
        /// Liczy myto: 1=EUR
        /// </summary>
        public int? HereTollCalculate { get; set; }
        /// <summary>
        /// Naruszanie ograniczeń: 1=zgoda, 0=brak zgody, 2=unikaj
        /// </summary>
        public int? HereViolation { get; set; }
        /// <summary>
        /// Unikaj promów
        /// </summary>
        public int? HereFerries { get; set; }
        /// <summary>
        /// Unikaj autostrad
        /// </summary>
        public int? HereHighways { get; set; }
        /// <summary>
        /// Unikaj płatności
        /// </summary>
        public int? HerePayments { get; set; }
        /// <summary>
        /// Unikaj tuneli
        /// </summary>
        public int? HereTunels { get; set; }
        /// <summary>
        /// towary niebezpieczne
        /// </summary>
        public string HereHazardous { get; set; }
        public DateTime? PcaDt { get; set; }
        public DateTime? PcaDtRz { get; set; }
        public int? NadrzedneId { get; set; }
        public int? Przeladunek { get; set; }
        public string HereTollCalculateBaseCurr { get; set; }
        public string HereTollCalculateOtherCurr { get; set; }
        public string MapLink { get; set; }
        public int? KplPal { get; set; }
        public string IsTransRefNumber { get; set; }
        public int? IsTransMethod { get; set; }
        /// <summary>
        /// Status wysyłki zgłoszenia do PORTBASE: -1=przekazane do wysyłki, -2=błędna struktura, 0=wysłane, 1=przyjęte, 2=odrzucone, 3=zaakceptowane
        /// </summary>
        public int? PortbaseState { get; set; }
        /// <summary>
        /// Kod błędu w przypadku odrzucenia
        /// </summary>
        public string PortbaseError { get; set; }
        /// <summary>
        /// Status obsługi zgłoszenia wysłanego do PORTBASE
        /// </summary>
        public string PortbaseProcessingState { get; set; }
    }
}
