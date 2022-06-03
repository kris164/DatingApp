using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmCost
    {
        public int IdSfmCosts { get; set; }
        public int? IdSfmSystem { get; set; }
        public int? IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public int? IdTabor { get; set; }
        public string RecId { get; set; }
        public string Costtype { get; set; }
        public DateTime? DtEvent { get; set; }
        public DateTime? DtSave { get; set; }
        public double? Odometer { get; set; }
        public int? Duration { get; set; }
        public double? ArticleCnt { get; set; }
        public string ArticleUnit { get; set; }
        public string Costcur { get; set; }
        public double? Costval { get; set; }
        public string BaseCostcur { get; set; }
        public double? BaseCostval { get; set; }
        public string RodzPlatn { get; set; }
        public string Rachunek { get; set; }
        public string Info { get; set; }
        public int? Stan { get; set; }
        public int? TankDoPelna { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? KartaId { get; set; }
        public string KartaTyp { get; set; }
        public string KartaNr { get; set; }
        public int? DelegacjaId { get; set; }
        public string Delegacja { get; set; }
        public int? ZaliczkaId { get; set; }
        public string Zaliczka { get; set; }
        public short? Notready { get; set; }
        public string Costcode { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string KrajKosztu { get; set; }
        public int? IdSfmPos { get; set; }
        public int? OpStatus { get; set; }
        public string OpUwagi { get; set; }
        public string Dekret { get; set; }
        public int? RejReczna { get; set; }
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
        public int? ListyLinioweId { get; set; }
        public string ListyLiniowe { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public int? Fv { get; set; }
        public int? KartyTransakcjeId { get; set; }
        public int? ZatwUzytkId { get; set; }
        public DateTime? ZatwDt { get; set; }
        /// <summary>
        /// Liczba załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
    }
}
