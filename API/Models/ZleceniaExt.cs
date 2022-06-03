using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaExt
    {
        public int IdZlecenia { get; set; }
        /// <summary>
        /// Informacje dla SFM-a
        /// </summary>
        public string InfoSfm { get; set; }
        /// <summary>
        /// Trasa zlecenia - id z mapy
        /// </summary>
        public string MapRouteid { get; set; }
        /// <summary>
        /// Relacja do profilu użytego do obliczeń trasy
        /// </summary>
        public int? MapProfilId { get; set; }
        /// <summary>
        /// Flaga, czy są dodatkowe pozycje kosztów
        /// </summary>
        public short? SaDodPozK { get; set; }
        /// <summary>
        /// Flaga, czy są dodatkowe pozycje przychodu
        /// </summary>
        public short? SaDodPozP { get; set; }
        public int? SfmVer { get; set; }
        /// <summary>
        /// Dedykowane: TARGOR
        /// </summary>
        public short? PotwPrzenWar { get; set; }
        /// <summary>
        /// Czas trwania zlecenia na potrzeby rozliczeń m-okresowych
        /// </summary>
        public double? CzasTrwaniaZlecenia { get; set; }
        /// <summary>
        /// Flaga, czy faktura na płatnika
        /// </summary>
        public short? FvNaPlatnika { get; set; }
        /// <summary>
        /// Flaga, czy jest niezgodnosc
        /// </summary>
        public short? Niezgodnosc { get; set; }
        /// <summary>
        /// Flaga, czy jest reklamacja
        /// </summary>
        public short? Reklamacja { get; set; }
        public int? PrzewoznikOddzialId { get; set; }
        public string PrzewoznikOddzialNazwa { get; set; }
        public string PrzewoznikOddzialAdres { get; set; }
        public string PrzewoznikOddzialMiasto { get; set; }
        public string PrzewoznikOddzialKod { get; set; }
        public string PrzewoznikOddzialKraj { get; set; }
        /// <summary>
        /// Ocena wykonania zlecenia przez przewoźnika
        /// </summary>
        public short? OcenaPrzewoznika { get; set; }
        public short? DoMorskiego { get; set; }
        /// <summary>
        /// procedura mycia
        /// </summary>
        public string ProceduraMycia { get; set; }
        public short? KorDoZera { get; set; }
        /// <summary>
        /// Dodatek paliwowy doliczany do frachtu
        /// </summary>
        public double? DodPaliwowy { get; set; }
        public int? GieldaPojazdowId { get; set; }
        public int? RhenusRozlTrasId { get; set; }
        public int? CennikKontrola { get; set; }
        public short? KorDoZeraK { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public double? TrasaMapOdlAutostrady { get; set; }
        public double? TrasaMapOdlEksprKraj { get; set; }
        public double? TrasaMapOdlPozostale { get; set; }
        public int? IsTeleroute { get; set; }
        public DateTime? IsTelerouteDt { get; set; }
        public int? IsTelerouteUserId { get; set; }
        /// <summary>
        /// Informacje dla kierowcy
        /// </summary>
        public string InfoKier { get; set; }
        /// <summary>
        /// Informacje dla spedytora
        /// </summary>
        public string InfoSped { get; set; }
        public string ClenieUwagi { get; set; }
        /// <summary>
        /// Flaga, czy nie fakturować
        /// </summary>
        public short? NieFakturuj { get; set; }
        public int? CelnaBezAutoZlecC { get; set; }
        public int? ZlecPalKlientId { get; set; }
        public int? BilansOpakLokPozId { get; set; }
        public int? IsTimocom { get; set; }
        public DateTime? IsTimocomDt { get; set; }
        public int? IsTimocomUserId { get; set; }
        public int? IsTranswide { get; set; }
        public DateTime? IsTranswideDt { get; set; }
        public int? IsTranswideUserId { get; set; }
        public int? IsTrans { get; set; }
        public DateTime? IsTransDt { get; set; }
        public int? IsTransUserId { get; set; }
        public string IsTransNumber { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na zlecenie z którego powstało bieżące zlecenie
        /// </summary>
        public int? MaszonskiMasterZlecId { get; set; }
        public int? IsZaladuj24 { get; set; }
        public DateTime? IsZaladuj24Dt { get; set; }
        public int? IsZaladuj24UserId { get; set; }
        public string IsZaladuj24Number { get; set; }
        public int? SentState { get; set; }
        public string SentRefNo { get; set; }
        public DateTime? SentDt { get; set; }
        public int? Sent { get; set; }
        public string TransporeonId { get; set; }
        public string TransporeonNumber { get; set; }
        public short? DoKolejowego { get; set; }
        public int? SzablonyZlecenId { get; set; }
        public string SentGeoLok { get; set; }
        public short? ZlecKoszerne { get; set; }
        public short? MycieKoszerne { get; set; }
        /// <summary>
        /// (0/1) czy procedura mycia określona na podstawie matrycy mycia
        /// </summary>
        public int? MatrycaMycia { get; set; }
        public int? ZlecPalKlientNadId { get; set; }
        public int? UbezpGrupaTowarowaId { get; set; }
        public int? UbezpKlauzulaSpecjalnaId { get; set; }
        public int? UbezpOswZgodnosci { get; set; }
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
        public string HereTollCalculateBaseCurr { get; set; }
        public string HereTollCalculateOtherCurr { get; set; }
        public string MapLink { get; set; }
        public int? Vip { get; set; }
        public string IsTransRefNumber { get; set; }
        public int? IsTransMethod { get; set; }
        public int? IsTransToSend { get; set; }
        public string IsTransOrderId { get; set; }
        public string IsTransOrderNumber { get; set; }
        public string IsTransAttach { get; set; }
        public int? UsrFldPoprzedniSamochodId { get; set; }
        public string UsrFldTeam { get; set; }
        public string RestrictedCountries { get; set; }
        public string RestrictedAreas { get; set; }
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
