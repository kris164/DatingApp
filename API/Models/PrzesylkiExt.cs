using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli PRZESYLKI - relacja 1:1 z tabelą PRZESYLKI
    /// </summary>
    public partial class PrzesylkiExt
    {
        public int IdPrzesylki { get; set; }
        /// <summary>
        /// Status weryfikacji kodów pocztowych (0 - OK, 1 - błędy kodów, 2 - błędy GPS kodów)
        /// </summary>
        public int? WeryfKodow { get; set; }
        /// <summary>
        /// Pole na potrzeby interfejsu Whirpool
        /// </summary>
        public int? Blokada { get; set; }
        /// <summary>
        /// Pole na potrzeby interfejsu Whirpool
        /// </summary>
        public DateTime? BlokadaDt { get; set; }
        /// <summary>
        /// Flaga, czy aktywna usługa potwierdzenia SMS
        /// </summary>
        public int? PotwSms { get; set; }
        /// <summary>
        /// Flaga, czy aktywna usługa potwierdzenia EMAIL
        /// </summary>
        public int? PotwEmail { get; set; }
        /// <summary>
        /// Flaga, czy jest protokół niezgodnosci
        /// </summary>
        public int? JestProtNiezg { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka jest anulowana
        /// </summary>
        public int? Anulowana { get; set; }
        /// <summary>
        /// Kategoria przesyłki
        /// </summary>
        public string KatPrzesylki { get; set; }
        /// <summary>
        /// Relacja do przesyłki skonsolidowanej - tab: PRZESYLKI
        /// </summary>
        public int? KonsolidacjaId { get; set; }
        /// <summary>
        /// Flaga, czy należy zaktualizowac parametry logistyczne
        /// </summary>
        public int? AktParamLog { get; set; }
        /// <summary>
        /// Właściciel opakowań wymiennych (ZL, NAD, ODB, MZA, MWY, L_NAD, L_WE, L_WY + ew. inne)
        /// </summary>
        public string WlascPalet { get; set; }
        /// <summary>
        /// Relacja do własciciela opakowań wymiennych - tab: KONTRAHENCI
        /// </summary>
        public int? WlascPaletId { get; set; }
        /// <summary>
        /// Informacja, gdzie należy zwrócicć opakowania wymienne (ZL, NAD, ODB, MZA, MWY, L_NAD, L_WE, L_WY + ew. inne)
        /// </summary>
        public string GdzieZwr { get; set; }
        /// <summary>
        /// Relacja gdzie zwrócic palety - POI - gdy inne miejsce niz to wynikajace z WLASC_PALET) - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? GdzieZwrId { get; set; }
        /// <summary>
        /// Informacja, która lokalizacja ma zwrócić opakowania wymienne nadawcy
        /// </summary>
        public string LokZwrPal { get; set; }
        /// <summary>
        /// Flaga, czy odebrano opakowania od odbiorcy
        /// </summary>
        public int? OdebranoPalety { get; set; }
        /// <summary>
        /// Ilość opakowań odebranych od odbiorcy
        /// </summary>
        public int? OdebranoPaletyIle { get; set; }
        /// <summary>
        /// Ilość opakowań na kwicie paletowym
        /// </summary>
        public int? OdebranoPaletyIleKp { get; set; }
        /// <summary>
        /// Informacja o lokalizacji, która odebrała opakowania od odbiorcy
        /// </summary>
        public string OdebranoPaletyLok { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int? OdebranoPaletyKpId { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string OdebranoPaletyKp { get; set; }
        /// <summary>
        /// Flaga, czy rozliczono opakowania wymiene w sieci
        /// </summary>
        public int? RozlWSieci { get; set; }
        /// <summary>
        /// Flaga, czy rozliczono opakowania wymiene z właścicielem
        /// </summary>
        public int? RozlZWlasc { get; set; }
        /// <summary>
        /// Ilość opakowań rozliczonych z właścicielem
        /// </summary>
        public int? RozlZWlascIle { get; set; }
        /// <summary>
        /// Ilość opakowań rozliczonych kwitem paletowym z właścicielem
        /// </summary>
        public int? RozlZWlascIleKp { get; set; }
        /// <summary>
        /// Informacja o lokalizacji, która rozliczyła opakowania z włascicielem
        /// </summary>
        public string RozlZWlascLok { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int? RozlZWlascKpId { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string RozlZWlascKp { get; set; }
        /// <summary>
        /// Uwagi do rozliczenia opakowań
        /// </summary>
        public string RozlPaletUwagi { get; set; }
        /// <summary>
        /// Flaga, czy należy podstawic własne opakowania wymienne
        /// </summary>
        public int? PodstawOpakowan { get; set; }
        /// <summary>
        /// Flaga, czy faktura jest wystawiana na płatnika
        /// </summary>
        public int? FvNaPlatnika { get; set; }
        /// <summary>
        /// Relacja do danych oddziału zleceniodawcy - tab. KONTRAHENCI_ODDZIAL
        /// </summary>
        public int? OddzialId { get; set; }
        /// <summary>
        /// Oddział - nazwa
        /// </summary>
        public string OddzialNazwa { get; set; }
        /// <summary>
        /// Oddział - adres
        /// </summary>
        public string OddzialAdres { get; set; }
        /// <summary>
        /// Oddział - miasto
        /// </summary>
        public string OddzialMiasto { get; set; }
        /// <summary>
        /// Oddział - kod pocztowy
        /// </summary>
        public string OddzialKod { get; set; }
        /// <summary>
        /// Oddział - kraj
        /// </summary>
        public string OddzialKraj { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka pochodzi z systemu WWW
        /// </summary>
        public int? PrzesylkaWww { get; set; }
        /// <summary>
        /// Flaga, czy możliwe piętrowanie
        /// </summary>
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// GPS - Długość geogr. - załadunek
        /// </summary>
        public double? MiejsceWyLon { get; set; }
        /// <summary>
        /// GPS - Szerokość geogr. - załadunek
        /// </summary>
        public double? MiejsceWyLat { get; set; }
        /// <summary>
        /// GPS - Długość geogr. - rozładunek
        /// </summary>
        public double? MiejsceZaLon { get; set; }
        /// <summary>
        /// GPS - Szerokość geogr. - rozładunek
        /// </summary>
        public double? MiejsceZaLat { get; set; }
        /// <summary>
        /// Flaga, czy zmieiono zaplanowaną trasę
        /// </summary>
        public int? ZmTrasy { get; set; }
        /// <summary>
        /// Flaga, czy jest ROD
        /// </summary>
        public int? Rod { get; set; }
        /// <summary>
        /// Flaga, czy wykonano ROD
        /// </summary>
        public int? Wrod { get; set; }
        /// <summary>
        /// Relacja do partnera 2 - tab: KONTRAHENCI
        /// </summary>
        public int? Partner2Id { get; set; }
        /// <summary>
        /// Symbol partnera 2
        /// </summary>
        public string Partner2 { get; set; }
        /// <summary>
        /// Symbol trafiku partnera 2
        /// </summary>
        public string Partner2Trafik { get; set; }
        /// <summary>
        /// Flaga uzupełnienia danych na przesyłce
        /// </summary>
        public int? UzupDane { get; set; }
        /// <summary>
        /// Licznik planowań/odplanowań
        /// </summary>
        public int? LicznikPlanowan { get; set; }
        /// <summary>
        /// Flaga, czy jest niezgodnosc
        /// </summary>
        public short? Niezgodnosc { get; set; }
        /// <summary>
        /// Flaga, czy jest reklamacja
        /// </summary>
        public short? Reklamacja { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka szczególnej uwagi
        /// </summary>
        public short? SzczUwaga { get; set; }
        public string Ref6 { get; set; }
        public string Ref7 { get; set; }
        public string Ref8 { get; set; }
        public string Ref9 { get; set; }
        public string Ref10 { get; set; }
        /// <summary>
        /// Flaga, czy trasa ustalona ręcznie
        /// </summary>
        public int? TrasaReczna { get; set; }
        /// <summary>
        /// Flaga , czy przesyłka zbiorcza - wynikająca z konsolidacji
        /// </summary>
        public int? Zbiorcza { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka ma LP (list przewozowy)
        /// </summary>
        public short? JestLp { get; set; }
        /// <summary>
        /// Flaga, czy zaakceptowane zlecenie podjęcia
        /// </summary>
        public short? PrzesZlecAkc { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka wstępna
        /// </summary>
        public short? Wstepna { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka ma LP - Duplikat
        /// </summary>
        public short? JestLpDupl { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka wynika z braków
        /// </summary>
        public short? Braki { get; set; }
        /// <summary>
        /// Nazwa cennika SP dla przychodów
        /// </summary>
        public string PrzychodySp { get; set; }
        /// <summary>
        /// Nazwa cennika SP dla kosztów
        /// </summary>
        public string KosztySp { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka pochodząca z systemu WWW jest zaakceptowana
        /// </summary>
        public int? PrzesylkaWwwAkcept { get; set; }
        public int? CennikKontrola { get; set; }
        public int? PunktyAdrChk { get; set; }
        public double? PunktyAdr { get; set; }
        public int? CelnaExport { get; set; }
        public string CelnaNrPrzejsciaGr { get; set; }
        /// <summary>
        /// Flaga, czy należy podmienić opakowania wymienne
        /// </summary>
        public int? PodmianaPalet { get; set; }
        /// <summary>
        /// Flaga, czy należy podmienić opakowania wymienne
        /// </summary>
        public int? PodmienionoPalety { get; set; }
        public double? CodRozlPrzew { get; set; }
        public double? CodRozlZlec { get; set; }
        public int? CelnaImport { get; set; }
        public int? OdbWlasny { get; set; }
        public int? WalidacjaError { get; set; }
        public short? BrakBb { get; set; }
        /// <summary>
        /// Flaga, czy nie fakturować
        /// </summary>
        public short? NieFakturuj { get; set; }
        public string PDokStanWe { get; set; }
        public string PDokStanWy { get; set; }
        public string KlientTel { get; set; }
        public string KlientKont { get; set; }
        public int? OdroczonyVat { get; set; }
        public double? IloscCalkAdr { get; set; }
        public int? DowWlasny { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka kompletna
        /// </summary>
        public short? Niekompletna { get; set; }
        public int? TypUbezp { get; set; }
        public string KrajPocz { get; set; }
        public string KrajDocel { get; set; }
        public int? DepozytGdzieJestId { get; set; }
        public int? DatacarId { get; set; }
        public int? Plac { get; set; }
        public int? Haccp { get; set; }
        public int? ZwrDok { get; set; }
        public int? Rez { get; set; }
        public int? PrzekazanaDoKuriera { get; set; }
        /// <summary>
        /// Flaga, czy płatnik wskazany recznie
        /// </summary>
        public int? PlatnikRecznie { get; set; }
        public int? PAdrEnv { get; set; }
        public double? IloscLqAdr { get; set; }
        public string ClenieNrDok { get; set; }
        public DateTime? ClenieDataWaznDok { get; set; }
        public DateTime? ClenieDataWej { get; set; }
        public DateTime? ClenieDataWyj { get; set; }
        public string ClenieUwagi { get; set; }
        public int? MiejsceCZaAgencjaId { get; set; }
        public string MiejsceCZaAgencja { get; set; }
        public int? MiejsceCWyAgencjaId { get; set; }
        public string MiejsceCWyAgencja { get; set; }
        public string MiejsceCWyStrefa { get; set; }
        public string MiejsceCZaStrefa { get; set; }
        public string CodKonto { get; set; }
        public int? CodKontoId { get; set; }
        public string CodInfoDod { get; set; }
        public double? AirWagaKubaturowa { get; set; }
        public double? AirWagaObl { get; set; }
        public int? PrzesylkiAirId { get; set; }
        public int? PrzesylkiSeaId { get; set; }
        public int? KrajeRecznie { get; set; }
        public int? GotAutoFv { get; set; }
        /// <summary>
        /// Flaga, czy przesyłka jest bezpłatna
        /// </summary>
        public int? Bezplatna { get; set; }
        /// <summary>
        /// Obsługa siecią zewnetrzną
        /// </summary>
        public string Kurier { get; set; }
        /// <summary>
        /// Numer w zewnętrznej sieci
        /// </summary>
        public string KurierRef { get; set; }
        public int? TempPlus { get; set; }
        public int? VatNaSadzie { get; set; }
        public string SqlDebugInfo { get; set; }
        public int? CelnaBezAutoZlecC { get; set; }
        public int? EmiState { get; set; }
        public int? KopiaZId { get; set; }
        public int? Zamowienie { get; set; }
        public int? ZamowienieZId { get; set; }
        public int? OptTaskId { get; set; }
        public int? MapGeoCoding { get; set; }
        public int? MapRouting { get; set; }
        public string SentRefNo { get; set; }
        public int? Sent { get; set; }
        public string MiejsceWyEmail { get; set; }
        public string MiejsceZaEmail { get; set; }
        public string KlientNadEmail { get; set; }
        public string KlientOdbEmail { get; set; }
        public int? PrzesylkiRailId { get; set; }
        public int? ZleceniaRailId { get; set; }
        public string SiecZewnRef1 { get; set; }
        public string SiecZewnRef2 { get; set; }
        public int? BulkState { get; set; }
        public int? UbezpGrupaTowarowaId { get; set; }
        public int? UbezpKlauzulaSpecjalnaId { get; set; }
        public int? UbezpOswZgodnosci { get; set; }
        public int? WagaOblR { get; set; }
        public DateTime? PodDate { get; set; }
        public string PodInformation { get; set; }
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
        public int? PoiZaId { get; set; }
        public int? PoiWyId { get; set; }
        public int? PoiCZaId { get; set; }
        public int? PoiCWyId { get; set; }
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
