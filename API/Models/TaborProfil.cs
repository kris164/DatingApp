using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborProfil
    {
        public int IdTaborProfil { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public double? SrPredkoscK { get; set; }
        public double? SrPredkoscZ { get; set; }
        public double? MaxIlosc { get; set; }
        public double? MaxObj { get; set; }
        public double? MaxWaga { get; set; }
        public int? Cysterna { get; set; }
        public int? Chlodnia { get; set; }
        public int? IloscKomor { get; set; }
        public int? Optimization { get; set; }
        public int? Useferries { get; set; }
        public int? Usemotoways { get; set; }
        public int? Calculatemaut { get; set; }
        public int? Speed1 { get; set; }
        public int? Speed2 { get; set; }
        public int? Speed3 { get; set; }
        public int? Speed4 { get; set; }
        public int? Speed5 { get; set; }
        public int? Speed6 { get; set; }
        public int? Speed7 { get; set; }
        public int? Speed8 { get; set; }
        public int? Speed9 { get; set; }
        public int? Speed10 { get; set; }
        public int? Speed11 { get; set; }
        public int? Speed12 { get; set; }
        public double? Routecost { get; set; }
        public double? Timecost { get; set; }
        public double? Fixcost { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public double? Axleload { get; set; }
        public int? Axlecount { get; set; }
        public string Emissionclass { get; set; }
        public double? Trailerlength { get; set; }
        public double? Trailerweight { get; set; }
        public int? Domyslny { get; set; }
        public string Vehiclename { get; set; }
        public int? Osobowy { get; set; }
        public string Category { get; set; }
        public int? Calculatemautineuro { get; set; }
        public int? Eautostrady { get; set; }
        public int? Eautostradyp { get; set; }
        public double? Eautostradys { get; set; }
        public int? Eszybkie { get; set; }
        public int? Eszybkiep { get; set; }
        public double? Eszybkies { get; set; }
        public int? Ekrajowe { get; set; }
        public int? Ekrajowep { get; set; }
        public double? Ekrajowes { get; set; }
        public int? Eregionalne { get; set; }
        public int? Eregionalnep { get; set; }
        public double? Eregionalnes { get; set; }
        public int? Elokalne { get; set; }
        public int? Elokalnep { get; set; }
        public double? Elokalnes { get; set; }
        public int? Einne { get; set; }
        public int? Einnep { get; set; }
        public double? Einnes { get; set; }
        public int? Egruntowe { get; set; }
        public int? Egruntowep { get; set; }
        public double? Egruntowes { get; set; }
        public int? Eprzelotowe { get; set; }
        public int? Eprzelotowep { get; set; }
        public double? Eprzelotowes { get; set; }
        public int? Eglowne { get; set; }
        public int? Eglownep { get; set; }
        public double? Eglownes { get; set; }
        public int? Einneulice { get; set; }
        public int? Einneulicep { get; set; }
        public double? Einneulices { get; set; }
        public int? Epromy { get; set; }
        public int? Epromyp { get; set; }
        public double? Epromys { get; set; }
        public DateTime? Eczasrozpoczecia { get; set; }
        public DateTime? Eczaspracy { get; set; }
        public DateTime? Eczaspracybezprzerwy { get; set; }
        public DateTime? Eczasprzerwy { get; set; }
        public DateTime? Eczastankowania { get; set; }
        public DateTime? Eczasprzekroczenia { get; set; }
        public DateTime? Eczaswjazdu { get; set; }
        public double? Ekosztstaly { get; set; }
        public double? Ekosztzakm { get; set; }
        public double? Ekosztzagodz { get; set; }
        public double? Ekosztzakmk { get; set; }
        public double? Ekosztzagodzk { get; set; }
        public int? Einformacjeopaliwie { get; set; }
        public int? Epomijajkmpromy { get; set; }
        public int? Epomijajdrogiemyto { get; set; }
        public int? Epobierzszczegolytrasy { get; set; }
        public double? Epojemnosczbiornika { get; set; }
        public double? Ekosztpaliwa { get; set; }
        public int? Erodzajtrasy { get; set; }
        public int? Erodzajpojazdu { get; set; }
        public double? Epojemnoscm { get; set; }
        public double? Epojemnosct { get; set; }
        public int? Zaladunekczas { get; set; }
        public int? Rozladunekczas { get; set; }
        public int? Adr { get; set; }
        public int? AllowSegmentViolations { get; set; }
        public int? CostOfSegmentViolations { get; set; }
        public int? WypTaboruId { get; set; }
        public string WypTaboruOpis { get; set; }
        public string HereProfileName { get; set; }
        /// <summary>
        /// Średnia prędkość dla Autostrady
        /// </summary>
        public int? HereSpeed1 { get; set; }
        /// <summary>
        /// Średnia prędkość dla Ekspresowej
        /// </summary>
        public int? HereSpeed2 { get; set; }
        /// <summary>
        /// Średnia prędkość dla Krajowej
        /// </summary>
        public int? HereSpeed3 { get; set; }
        /// <summary>
        /// Średnia prędkość dla Wojewódzkiej
        /// </summary>
        public int? HereSpeed4 { get; set; }
        /// <summary>
        /// Średnia prędkość dla Lokalnej
        /// </summary>
        public int? HereSpeed5 { get; set; }
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
        public string HereCostCurrency { get; set; }
        /// <summary>
        /// towary niebezpieczne
        /// </summary>
        public string HereHazardous { get; set; }
        public int? TrailerAxleCount { get; set; }
        /// <summary>
        /// Licz myto: waluta bazowa
        /// </summary>
        public string HereTollCalculateBaseCurr { get; set; }
        /// <summary>
        /// Licz myto: waluty dodatkowe
        /// </summary>
        public string HereTollCalculateOtherCurr { get; set; }
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
        public string TypeOfPower { get; set; }
    }
}
