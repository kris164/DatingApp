using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Wyjazdy
    {
        public int IdWyjazdy { get; set; }
        public string NrWyjazdu { get; set; }
        public int? NrWyjazduKolejny { get; set; }
        public int? NrWyjazduRok { get; set; }
        public int? NrWyjazduMies { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public DateTime? DataWyjazdu { get; set; }
        public DateTime? GodzWyjazdu { get; set; }
        public double? StanLicznikaWyjazd { get; set; }
        public double? StanLicznikaNWyjazd { get; set; }
        public double? StanPaliwaWyjazd { get; set; }
        public double? StanPaliwaAgrWyjazd { get; set; }
        public double? StanPaliwaNWyjazd { get; set; }
        public DateTime? DataPrzyjazdu { get; set; }
        public DateTime? GodzPrzyjazdu { get; set; }
        public double? StanLicznikaPrzyjazd { get; set; }
        public double? StanLicznikaNPrzyjazd { get; set; }
        public double? StanPaliwaPrzyjazd { get; set; }
        public double? StanPaliwaAgrPrzyjazd { get; set; }
        public double? StanPaliwaNPrzyjazd { get; set; }
        public double? CzasTrwaniaWyjazdu { get; set; }
        public double? CzasPracyAgregatu { get; set; }
        public double? CzasPracyAgregatuN { get; set; }
        public double? CzasPracyOgrzewania { get; set; }
        public double? KmLacznie { get; set; }
        public double? KmLadowne { get; set; }
        public double? KmPuste { get; set; }
        public double? KmMiasto { get; set; }
        public double? ZakupPaliwa { get; set; }
        public double? ZakupPaliwaAgr { get; set; }
        public double? ZakupPaliwaAgrN { get; set; }
        public double? ZuzRPaliwa { get; set; }
        public double? ZuzRPaliwaAgr { get; set; }
        public double? ZuzRPaliwaAgrN { get; set; }
        public double? ZuzRPaliwaOgrz { get; set; }
        public double? ZuzTPaliwa { get; set; }
        public double? ZuzTPaliwaAgr { get; set; }
        public double? ZuzTPaliwaAgrN { get; set; }
        public double? ZuzTPaliwaOgrz { get; set; }
        public double? PrzekrZuzPaliwa { get; set; }
        public double? PrzekrZuzPaliwaAgr { get; set; }
        public double? PrzekrZuzPaliwaAgrN { get; set; }
        public double? PrzekrZuzPaliwaOgrz { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string SamochodNrBoczny { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrBoczny { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public double? Kierowca1Km { get; set; }
        public double? Kierowca1KmUz { get; set; }
        public double? Kierowca1KmPlaca { get; set; }
        public string Kierowca1Ocena { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public double? Kierowca2Km { get; set; }
        public double? Kierowca2KmUz { get; set; }
        public double? Kierowca2KmPlaca { get; set; }
        public string Kierowca2Ocena { get; set; }
        public int? Kierowca3Id { get; set; }
        public string Kierowca3 { get; set; }
        public double? Kierowca3Km { get; set; }
        public double? Kierowca3KmUz { get; set; }
        public double? Kierowca3KmPlaca { get; set; }
        public string Kierowca3Ocena { get; set; }
        public int? KarnetTirId { get; set; }
        public string KarnetTir { get; set; }
        public string Trasa { get; set; }
        public string Uwagi { get; set; }
        public string KrajDocelowy { get; set; }
        public int? JestTachograf { get; set; }
        public int? Adr { get; set; }
        public string Status { get; set; }
        public string Lokalizacja { get; set; }
        public double? TonoKm { get; set; }
        public double? SrSpalWgKarty { get; set; }
        public int? LiczAutoKm { get; set; }
        public int? LiczAutoCzas { get; set; }
        public int? LiczAutoPrcK { get; set; }
        public int? LiczAutoOdlZ { get; set; }
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
        public double? CzasPracyAgrGps { get; set; }
        public double? CzasPracyAgrNGps { get; set; }
        public double? KmGps { get; set; }
        public double? StanAdblueWyjazd { get; set; }
        public double? StanAdbluePrzyjazd { get; set; }
        public double? ZakupAdblue { get; set; }
        public double? ZuzRAdblue { get; set; }
        public double? ZuzTAdblue { get; set; }
        public double? ZuzGpsPaliwa { get; set; }
        public double? ZuzGpsPaliwaAgr { get; set; }
        public double? ZuzGpsPaliwaAgrN { get; set; }
        public double? ZuzGpsPaliwaOgrz { get; set; }
        public double? ZuzGpsAdblue { get; set; }
        public double? PrzekrZuzAdblue { get; set; }
        public double? KmLacznieWgZlec { get; set; }
        public double? KmLadowneWgZlec { get; set; }
        public double? KmPusteWgZlec { get; set; }
        public string Kind { get; set; }
        public string Strefa { get; set; }
        public double? StanLicznikaMtgNWyjazd { get; set; }
        public double? StanLicznikaMtgNPrzyjazd { get; set; }
        public double? KmLacznieWgMapy { get; set; }
        public double? KmLadowneWgMapy { get; set; }
        public double? KmPusteWgMapy { get; set; }
        public int? ZwiekszNorme { get; set; }
        public double? ZwiekszNormeSam { get; set; }
        public int? ZwiekszNormeL { get; set; }
        public double? ZwiekszNormeSamL { get; set; }
        public int? IlMZawyKierowca1 { get; set; }
        public int? IlMZawyKierowca2 { get; set; }
        public int? IlMZawyKierowca3 { get; set; }
        public int? IlMZawySuma { get; set; }
        public string Dzial { get; set; }
        public double? MthWgKarty { get; set; }
        public int? PaliwoRozl { get; set; }
        public double? SrCenaPaliwaStart { get; set; }
        public double? SrCenaPaliwaStop { get; set; }
        public double? SrCenaAdblueStart { get; set; }
        public double? SrCenaAdblueStop { get; set; }
        public string StatusPom { get; set; }
        public int? WyjazdPoprzedniId { get; set; }
        public string WyjazdPoprzedni { get; set; }
        public int? WyjazdKolejnyId { get; set; }
        public string WyjazdKolejny { get; set; }
        public int? NieLicz1Dnia { get; set; }
        public int? OkrRozlRok { get; set; }
        public int? OkrRozlMies { get; set; }
        public DateTime? DataZamkn { get; set; }
        public double? KmPustyKontener { get; set; }
        public int? BlokTelematyke { get; set; }
        public double? LicznikPaliwaWyjazd { get; set; }
        public double? LicznikPaliwaPrzyjazd { get; set; }
        public double? PrzekrZuzGpsPal { get; set; }
        public double? PrzekrZuzGpsPalAgr { get; set; }
        public double? PrzekrZuzGpsPalAgrN { get; set; }
        public double? PrzekrZuzGpsPalOgrz { get; set; }
        public double? PrzekrZuzGpsAdblue { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public double? KmSerwis { get; set; }
        public double? ZwiekszZuzRz { get; set; }
        public string SrCenaWaluta { get; set; }
    }
}
