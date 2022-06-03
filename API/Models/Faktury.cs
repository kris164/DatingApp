using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Faktury
    {
        public int IdFaktury { get; set; }
        public int? FrmId { get; set; }
        public int? Paragon { get; set; }
        public string ParagonNr { get; set; }
        public int? ParagonKolejny { get; set; }
        public int? ParagonRok { get; set; }
        public int? ParagonMies { get; set; }
        public int? ParagonFiskalny { get; set; }
        public string ParagonFiskalnyNr { get; set; }
        public double? ParagonWplata { get; set; }
        public double? ParagonReszta { get; set; }
        public string Dekret { get; set; }
        public int? DekretKolejny { get; set; }
        public int? DekretRok { get; set; }
        public int? DekretMies { get; set; }
        public string NumerFaktury { get; set; }
        public string NumerFakturyKoryg { get; set; }
        public string NumerExt { get; set; }
        public int? Numer { get; set; }
        public string NumerFakturyPf { get; set; }
        public int? NumerPf { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public string RodzFv { get; set; }
        public string JezykFaktury { get; set; }
        public int? TypFv { get; set; }
        public int? Zbiorcza { get; set; }
        public int? RokFaktury { get; set; }
        public int? RokFakturyPf { get; set; }
        public int? MiesFaktury { get; set; }
        public int? MiesFakturyPf { get; set; }
        public int? FakturaOtrzymana { get; set; }
        public string RodzKosztow { get; set; }
        public string RodzKosztowExt { get; set; }
        public int? UwzglRozlKier { get; set; }
        public int? StrRozlKier { get; set; }
        public string TypKosztow { get; set; }
        public string KrajKosztow { get; set; }
        public string RodzPrzychodow { get; set; }
        public int KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? DataSprzedazy { get; set; }
        public DateTime? DataOtrzymania { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public int Zaplacono { get; set; }
        public int? StatusZaplaty { get; set; }
        public string FormaPlatnosci { get; set; }
        public int TerminPlatnosci { get; set; }
        public double? NettoPln { get; set; }
        public double? VatPln { get; set; }
        public double? BruttoPln { get; set; }
        public double NettoRazem { get; set; }
        public double PodatekRazem { get; set; }
        public double BruttoRazem { get; set; }
        public double? NettoPlnKor { get; set; }
        public double? VatPlnKor { get; set; }
        public double? BruttoPlnKor { get; set; }
        public double? NettoRazemKor { get; set; }
        public double? PodatekRazemKor { get; set; }
        public double? BruttoRazemKor { get; set; }
        public double? IloscRazem { get; set; }
        public double? IloscRazemKor { get; set; }
        public string Uwagi { get; set; }
        public string Uwagi2 { get; set; }
        public string TrInfo { get; set; }
        public int? RozneKursy { get; set; }
        public int? KursyWalutId { get; set; }
        public int? KursyWalutTyp { get; set; }
        public string KursyWalutRodz { get; set; }
        public int FakturaWalutowa { get; set; }
        public double KursWaluty { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public string Waluta { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? PrzesylkaId { get; set; }
        public string Przesylka { get; set; }
        public int? ListLiniowyId { get; set; }
        public string ListLiniowy { get; set; }
        public string Tabor { get; set; }
        public int? TaborId { get; set; }
        public string Kierowca { get; set; }
        public int? KierowcaId { get; set; }
        public int? KartaId { get; set; }
        public string KartaTyp { get; set; }
        public string KartaNr { get; set; }
        public double? StanLicznika { get; set; }
        public int? DelegacjaId { get; set; }
        public string Delegacja { get; set; }
        public int? ZaliczkaId { get; set; }
        public string Zaliczka { get; set; }
        public int? KorektaId { get; set; }
        public int Korekta { get; set; }
        public string KorektaPowod { get; set; }
        public int? Zaksiegowana { get; set; }
        public DateTime? DataZaksiegowania { get; set; }
        public int? JestUstawa { get; set; }
        public string Ustawa { get; set; }
        public string NrZlecK { get; set; }
        public int? KontoId { get; set; }
        public string Konto { get; set; }
        public int? Iban { get; set; }
        public string WydrukSporzadzil { get; set; }
        public string WydrukPodpisal { get; set; }
        public string WydrukOdebral { get; set; }
        public int? WydrukProforma { get; set; }
        public int? WydrukDuplikat { get; set; }
        public int? LOrg { get; set; }
        public int? LKop { get; set; }
        public string OpisTrasyDoFz { get; set; }
        public int? WystawionoDuplikat { get; set; }
        public DateTime? DataDuplikatu { get; set; }
        public string Lokalizacja { get; set; }
        public string DotLokalizacji { get; set; }
        public int? KomunikacjaFkId { get; set; }
        public int? KomunikacjaFkRkId { get; set; }
        public string NrSped { get; set; }
        public string KontoFk { get; set; }
        public string KontoFkMa { get; set; }
        public string Mpk { get; set; }
        public int? EmisjaDoFk { get; set; }
        public int? GotowaDoFk { get; set; }
        public int? Status { get; set; }
        public string StatusMail { get; set; }
        public int? Anulowana { get; set; }
        public int? PomijajNaRap { get; set; }
        /// <summary>
        /// Waluta z tabeli B
        /// </summary>
        public string WalutaB { get; set; }
        /// <summary>
        /// Relacja do tabeli kursów B
        /// </summary>
        public int? KursyWalutBId { get; set; }
        /// <summary>
        /// Numer tabeli kursó B
        /// </summary>
        public string NrTabeliKursowB { get; set; }
        /// <summary>
        /// Data tabeli kursów B
        /// </summary>
        public DateTime? DataTabeliKursowB { get; set; }
        /// <summary>
        /// Kurs waluty B
        /// </summary>
        public double? KursWalutyB { get; set; }
        /// <summary>
        /// Razem NETTO dla waluty B
        /// </summary>
        public double? NettoRazemB { get; set; }
        /// <summary>
        /// Relacja do raportu kasowego - RAP_KAS
        /// </summary>
        public int? RapKasId { get; set; }
        /// <summary>
        /// Numer raportu kasowego
        /// </summary>
        public string RapKas { get; set; }
        /// <summary>
        /// Kod operatora kasy
        /// </summary>
        public string KodOperKas { get; set; }
        /// <summary>
        /// Znacznik, czy tankowanie do pełna
        /// </summary>
        public int? TankDoPelna { get; set; }
        /// <summary>
        /// Relacja do pozycji rejestru kosztów ogólnych - REJ_KOSZT_OG_POZ
        /// </summary>
        public int? RejKosztOgPozId { get; set; }
        /// <summary>
        /// Znacznik, czy drukować zbiorczą jako pojedynczą
        /// </summary>
        public int? WydrZbStd { get; set; }
        /// <summary>
        /// Znacznik, czy koszt pochodzi z warsztatu
        /// </summary>
        public int? ZWarsztatu { get; set; }
        /// <summary>
        /// Numer zlecenia warsztatowego
        /// </summary>
        public string WZlecenie { get; set; }
        /// <summary>
        /// Relacja do zlecenia warsztatowego - W_ZLECENIA
        /// </summary>
        public int? WZlecenieId { get; set; }
        /// <summary>
        /// Liczba załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
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
        public int? LicznikId { get; set; }
        public int? StatusWindykacji { get; set; }
        public int? ZaplGot { get; set; }
        public int? VKursyWalutId { get; set; }
        public int? VKursyWalutTyp { get; set; }
        public string VKursyWalutRodz { get; set; }
        public double? VKursWaluty { get; set; }
        public string VNrTabeliKursow { get; set; }
        public DateTime? VDataTabeliKursow { get; set; }
        public int? WDoFkId { get; set; }
        public string RodzFvOtrz { get; set; }
        public DateTime? DataWyslania { get; set; }
        public DateTime? DataKsiegowa1 { get; set; }
        public int? ImpUslug { get; set; }
        public int? StatusDoZapl { get; set; }
        public int? StatusWyslana { get; set; }
        public DateTime? DataWyslaniaFk { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? FrmWydrVat { get; set; }
        public int? PaliwoFvZb { get; set; }
        /// <summary>
        /// Informacje od opiekuna
        /// </summary>
        public string InfoOpiekuna { get; set; }
        public string Wewn { get; set; }
        public int? WewnKolejny { get; set; }
        public int? WewnRok { get; set; }
        public int? WewnMies { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        /// <summary>
        /// Znacznik, czy koszt międzyokresowy
        /// </summary>
        public int? KosztyMo { get; set; }
        /// <summary>
        /// Numer PZ w warsztacie
        /// </summary>
        public string WPz { get; set; }
        /// <summary>
        /// Relacja do PZ w warsztacie - W_PW
        /// </summary>
        public int? WPzId { get; set; }
        /// <summary>
        /// Numer WZ w warsztacie
        /// </summary>
        public string WWz { get; set; }
        /// <summary>
        /// Relacja do WZ w warsztacie - W_WZ
        /// </summary>
        public int? WWzId { get; set; }
        /// <summary>
        /// Flaga, czy faktura utworzona na podstawie zleceń trashowych
        /// </summary>
        public int? ZTrash { get; set; }
        public string Dzial { get; set; }
        public int? StatDokumOtrz { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public DateTime? GodzSprzedazy { get; set; }
        public int? PlatnikId { get; set; }
        public string Platnik { get; set; }
        public int? Zaliczkowa { get; set; }
        public int? VatWPln { get; set; }
        public int? SzkodaId { get; set; }
        public string Szkoda { get; set; }
        public int? BezImpPlatZFk { get; set; }
        public int? ImpTowarow { get; set; }
        public int? Konto2Id { get; set; }
        public string Konto2 { get; set; }
        public int? Iban2 { get; set; }
        public string StatusEmisja { get; set; }
        /// <summary>
        /// Znacznik, czy koszt powstał z rozliczenia
        /// </summary>
        public int? ZRozliczenia { get; set; }
        /// <summary>
        /// Relacja do transakcji GPS w warsztacie - SFM_Costs
        /// </summary>
        public int? SfmCostsId { get; set; }
        /// <summary>
        /// Flaga, czy transakcja GPS zostałą zweryfikowana pomyślnie
        /// </summary>
        public int? SfmCostsOk { get; set; }
        /// <summary>
        /// Flaga, czy są podpięte jakies kontakty
        /// </summary>
        public int? SaKontakty { get; set; }
        /// <summary>
        /// Relacja do pozycji wynagrodzenia - WYNAGR_LP
        /// </summary>
        public int? WynagrLpId { get; set; }
        /// <summary>
        /// Relacja do rozliczenia miedzyokresowego - dla faktury źródłowej
        /// </summary>
        public int? RozlMOkresoweId { get; set; }
        /// <summary>
        /// Relacja do pozycji rozliczenia miedzyokresowego - dla dekretów
        /// </summary>
        public int? RozlMOkresowePozId { get; set; }
        public int? Bufor { get; set; }
        public string GrupaDok { get; set; }
        public DateTime? DataWstrzZapl { get; set; }
        public int? ZaplWTerminie { get; set; }
        public int? ZaliczkowaId { get; set; }
        public string ZaliczkowaNr { get; set; }
        public int? StatusZwrPodp { get; set; }
        public DateTime? DataZwrPodp { get; set; }
        public int? PodlicznikId { get; set; }
        public string ZbGrupujWg { get; set; }
        /// <summary>
        /// Relacja do karty z modułu EnergoFleet - EF_KARTY
        /// </summary>
        public int? EfKartyId { get; set; }
        /// <summary>
        /// Relacja do tankowania z modułu EnergoFleet - EF_KARTY_TANKOWANIA
        /// </summary>
        public int? EfKartyTankowaniaId { get; set; }
        public int? KomunikacjaFkIdLp { get; set; }
        public DateTime? ZaplWstrzKiedy { get; set; }
        public string ZaplWstrzKto { get; set; }
        public string StatusNew { get; set; }
        public int? ZlecenieMId { get; set; }
        public string ZlecenieM { get; set; }
        public int? EFakturaStatus { get; set; }
        /// <summary>
        /// Nazwa pliku pdf wygenerowanego podczas drukowania - na potrzeby ePodpisu
        /// </summary>
        public string PdfFileName { get; set; }
        public int? AlgorytmSum { get; set; }
        public int? EdycjaSum { get; set; }
        public DateTime? TrigTimestamp { get; set; }
        public int? Skonto { get; set; }
        public int? SkontoId { get; set; }
        public double? ZaliczkaKursRozl { get; set; }
        public string KomunikacjaFkInfo { get; set; }
        public int? GsmFvZb { get; set; }
        public string ZaliczkaKursRozlWal { get; set; }
        /// <summary>
        /// Flaga, czy rekord jest NOTĄ a nie FV
        /// </summary>
        public int? Nota { get; set; }
        /// <summary>
        /// Flaga, czy rekord jest NOTĄ uznaniową
        /// </summary>
        public int? NotaUznaniowa { get; set; }
        /// <summary>
        /// Flaga, czy rekord jest NOTĄ rozliczeniem COD
        /// </summary>
        public int? NotaRozlCod { get; set; }
        /// <summary>
        /// Nagłówek noty
        /// </summary>
        public string NotaNaglowek { get; set; }
        /// <summary>
        /// Stopka noty
        /// </summary>
        public string NotaStopka { get; set; }
        public int? KorektaPowodSymbolId { get; set; }
        public string KorektaPowodSymbol { get; set; }
        /// <summary>
        /// Flaga, czy rekord jest NOTĄ rozliczeniem KWIT_PAL
        /// </summary>
        public int? NotaRozlKwitPal { get; set; }
        /// <summary>
        /// Relacja do faktury zaliczkowej utworzonej z faktury PF
        /// </summary>
        public int? PfZaliczkowaId { get; set; }
        public double? NettoDocel { get; set; }
        public double? VatDocel { get; set; }
        public double? BruttoDocel { get; set; }
        public int? ZlecenieZbId { get; set; }
        public string ZlecenieZb { get; set; }
        public int? MetodaKasowa { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public int? ParagonDrFisk { get; set; }
        public int? KontrahNipViesOk { get; set; }
        public int? ZlecenieCId { get; set; }
        public string ZlecenieC { get; set; }
        public int? PrefakturyId { get; set; }
        public int? Rabat { get; set; }
        public double? RabatWart { get; set; }
        /// <summary>
        /// Flaga, czy rekord jest NOTĄ wewnętrzną
        /// </summary>
        public int? NotaWewn { get; set; }
        public int? ReklamacjeId { get; set; }
        public string Reklamacje { get; set; }
        /// <summary>
        /// Adr. koresp. - Nazwa
        /// </summary>
        public string NazwaK { get; set; }
        /// <summary>
        /// Adr. koresp. - Adres (ulica i numery)
        /// </summary>
        public string UlicaK { get; set; }
        /// <summary>
        /// Adr. koresp. - Miejscowość
        /// </summary>
        public string MiejscowoscK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kod pocztowy
        /// </summary>
        public string KodK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kraj
        /// </summary>
        public string KrajK { get; set; }
        public DateTime? DataPlatnosciUsr { get; set; }
        public int? TerminPlatnosciUsr { get; set; }
        public int? StatusFaktoring { get; set; }
        public int? EmiOrgId { get; set; }
        public int? EdycjaSumPln { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public DateTime? ZbOkresOd { get; set; }
        public DateTime? ZbOkresDo { get; set; }
        public int? EFaktura { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na fakturę sprzedaży z której powstałą bieżąca faktura sprzedaży
        /// </summary>
        public int? MaszonskiMasterFvSId { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na fakturę sprzedaży z której powstałą bieżąca faktura kosztowa
        /// </summary>
        public int? MaszonskiMasterFvKId { get; set; }
        public int? Samofakturowanie { get; set; }
        public DateTime? DataWystawieniaParag { get; set; }
        public int? ZlecenieRailId { get; set; }
        public string ZlecenieRail { get; set; }
        public int? SplitPayment { get; set; }
        public DateTime? DataKontrCzynnyVat { get; set; }
        /// <summary>
        /// 1-podatnik czynny, 0-podatnik nieczynny
        /// </summary>
        public int? CzynnyVat { get; set; }
        public DateTime? DataKontrWykazWl { get; set; }
        public int? WynikKontrWykazWl { get; set; }
        public string RequestId { get; set; }
        public DateTime? DataKsiegowania { get; set; }
        public int? KontoFaktorId { get; set; }
    }
}
