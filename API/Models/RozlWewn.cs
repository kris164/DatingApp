using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlWewn
    {
        public int IdRozlWewn { get; set; }
        public int? SpRejestracji { get; set; }
        public int? ProcesyOkrId { get; set; }
        public string RwNr { get; set; }
        public int? RwKolejny { get; set; }
        public int? RwRok { get; set; }
        public int? RwMies { get; set; }
        public string Status { get; set; }
        public string LokalizacjaNad { get; set; }
        public string DzialNad { get; set; }
        public int? AkceptNad { get; set; }
        public int? AkceptNadUzytkId { get; set; }
        public string AkceptNadUzytk { get; set; }
        public DateTime? AkceptNadData { get; set; }
        public DateTime? AkceptNadGodz { get; set; }
        public string LokalizacjaOdb { get; set; }
        public string DzialOdb { get; set; }
        public int? AkceptOdb { get; set; }
        public int? AkceptOdbUzytkId { get; set; }
        public string AkceptOdbUzytk { get; set; }
        public DateTime? AkceptOdbData { get; set; }
        public DateTime? AkceptOdbGodz { get; set; }
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
        public int? RozlWewnSieciPozId { get; set; }
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
        public string Uwagi { get; set; }
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
        public int? PromyId { get; set; }
        public string Promy { get; set; }
        public int? ZleceniaPozFaktId { get; set; }
        public int? KalkulacjaId { get; set; }
        public int? ZlecenieOdbId { get; set; }
        public string ZlecenieOdb { get; set; }
        public int? ZleceniaPozFaktOdbId { get; set; }
        public int? PrzesylkaOdbId { get; set; }
        public string PrzesylkaOdb { get; set; }
        public int? KalkulacjaOdbId { get; set; }
        public int? ListLiniowyOdbId { get; set; }
        public string ListLiniowyOdb { get; set; }
        public int? PromyOdbId { get; set; }
        public string PromyOdb { get; set; }
        public int? SzkodaId { get; set; }
        public string Szkoda { get; set; }
        public string RodzKosztow { get; set; }
        public string RodzPrzychodow { get; set; }
        public int? ZlecenieMId { get; set; }
        public string ZlecenieM { get; set; }
        public int? ZlecenieCId { get; set; }
        public string ZlecenieC { get; set; }
        public int? ZlecenieMOdbId { get; set; }
        public string ZlecenieMOdb { get; set; }
        public int? ZlecenieCOdbId { get; set; }
        public string ZlecenieCOdb { get; set; }
        public int? ZlecenieRailId { get; set; }
        public string ZlecenieRail { get; set; }
        public int? ZlecenieRailOdbId { get; set; }
        public string ZlecenieRailOdb { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
