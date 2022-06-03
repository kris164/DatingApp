using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Rezerwy
    {
        public int IdRezerwy { get; set; }
        public string Typ { get; set; }
        public int? SpRejestracji { get; set; }
        public int? ProcesyOkrId { get; set; }
        public string RezerwyNr { get; set; }
        public int? RezerwyKolejny { get; set; }
        public int? RezerwyRok { get; set; }
        public int? RezerwyMies { get; set; }
        public string Status { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? TeczkaOdbId { get; set; }
        public string TeczkaOdb { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? PrzesylkaId { get; set; }
        public string Przesylka { get; set; }
        public int? ListLiniowyId { get; set; }
        public string ListLiniowy { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public string Waluta { get; set; }
        public int? KursyWalutId { get; set; }
        public int? KursyWalutTyp { get; set; }
        public string KursyWalutRodz { get; set; }
        public double KursWaluty { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public double? KwotaWWal { get; set; }
        public double? KwotaWPln { get; set; }
        public int? OpisId { get; set; }
        public string Opis { get; set; }
        public string OpisDod { get; set; }
        public string RodzKosztow { get; set; }
        public string RodzPrzychodow { get; set; }
        public string Uwagi { get; set; }
        public int? Rozwiazanie { get; set; }
        public DateTime? DataRozwiazania { get; set; }
        public int? RozwiazanieRezerwyId { get; set; }
        public string Info { get; set; }
        public int? KomunikacjaFkId { get; set; }
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
        public int? ZlecPozFaktId { get; set; }
        public int? KalkulacjaId { get; set; }
        public int? PromId { get; set; }
        public string Prom { get; set; }
        public string KomunikacjaFkInfo { get; set; }
        public int? ZlecenieZbId { get; set; }
        public string ZlecenieZb { get; set; }
        public int? ZlecenieMId { get; set; }
        public string ZlecenieM { get; set; }
        public int? ZlecenieRailId { get; set; }
        public string ZlecenieRail { get; set; }
    }
}
