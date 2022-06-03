using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpListyLiniowe
    {
        public int IdTmpListyLiniowe { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdListyLiniowe { get; set; }
        public string Kierunek { get; set; }
        public string NrListu { get; set; }
        public int? NrListuKolejny { get; set; }
        public int? NrListuRok { get; set; }
        public int? NrListuMies { get; set; }
        public int? RozlNaPrzes { get; set; }
        public double? RozlNaPKwFv { get; set; }
        public double? RozlNaPKw { get; set; }
        public double? RozlNaPKwFvP { get; set; }
        public double? RozlNaPKwP { get; set; }
        public int? Siec { get; set; }
        public int? Kolko { get; set; }
        public int? Dynamiczna { get; set; }
        public string NrBordero { get; set; }
        public string Rodzaj { get; set; }
        public string Typ { get; set; }
        public string Strefa { get; set; }
        public int? Tranzyt { get; set; }
        public int? Prom { get; set; }
        public DateTime? Data { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public double? WagaDekl { get; set; }
        public double? WagaObl { get; set; }
        public double? Obj { get; set; }
        public double? ObjDekl { get; set; }
        public double? MiejscaPal { get; set; }
        public double? MiejscaPalDekl { get; set; }
        public double? IloscPrzesylek { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Stan { get; set; }
        public string Status { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public int? KplDokum { get; set; }
        public int? ProfilPojId { get; set; }
        public int? SamochodId { get; set; }
        public int? NaczepaId { get; set; }
        public int? KierowcaId { get; set; }
        public int? Kierowca2Id { get; set; }
        public int? Zaplanowana { get; set; }
        public DateTime? PlanDataRozlad { get; set; }
        public DateTime? PlanGodzRozlad { get; set; }
        public DateTime? PlanDataZalad { get; set; }
        public DateTime? PlanGodzZalad { get; set; }
        public DateTime? FaktDataRozlad { get; set; }
        public DateTime? FaktGodzRozlad { get; set; }
        public DateTime? FaktDataZalad { get; set; }
        public DateTime? FaktGodzZalad { get; set; }
        public double? OdlegoscWgMapy { get; set; }
        public double? OdlegoscPusteWgMapy { get; set; }
        public double? OdlegoscWgPrz { get; set; }
        public double? OdlegoscPusteWgPrz { get; set; }
        public double? Odlegosc { get; set; }
        public double? OdlegoscPuste { get; set; }
        public double? LiczbaZawy { get; set; }
        public double? CenaZaKm { get; set; }
        public string CenaZaKmWal { get; set; }
        public double? CenaZaKmPuste { get; set; }
        public string CenaZaKmPusteWal { get; set; }
        public double? CenaZaMZawy { get; set; }
        public string CenaZaMZawyWal { get; set; }
        public double? InneKoszty { get; set; }
        public double? Kwota { get; set; }
        public string KwotaWal { get; set; }
        public string KwotaWalFv { get; set; }
        public double? KwotaOdc1 { get; set; }
        public string KwotaOdc1St { get; set; }
        public double? KwotaOdc2 { get; set; }
        public string KwotaOdc2St { get; set; }
        public double? KwotaOdc3 { get; set; }
        public string KwotaOdc3St { get; set; }
        public int? BezKalkulacji { get; set; }
        public int? TylkoCennik { get; set; }
        public string WalutaKalk { get; set; }
        public int? TabelaKursowKalkId { get; set; }
        public string TabelaKursowKalk { get; set; }
        public double? Przychod { get; set; }
        public string PrzychodWal { get; set; }
        public double? ProcentKosztow { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string LokalizacjaPosr { get; set; }
        public int? PartnerId { get; set; }
        public int? Rozliczona { get; set; }
        public int? StatusKoszty { get; set; }
        public string ZaMiejsce { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKraj { get; set; }
        public string ZaKod { get; set; }
        public string WyMiejsce { get; set; }
        public string WyMiasto { get; set; }
        public string WyKraj { get; set; }
        public string WyKod { get; set; }
        public int? GenZawyOk { get; set; }
        public int? SfmStatus { get; set; }
        public int? DyspozytorId { get; set; }
        public string Dyspozytor { get; set; }
        public int? StatusKalk { get; set; }
        public string PrzychodySp { get; set; }
        public string KosztySp { get; set; }
        public int? TempPlus { get; set; }
    }
}
