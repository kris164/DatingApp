using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RhenusRozlTra
    {
        public int IdRhenusRozlTras { get; set; }
        public string Przewoznik { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Faktura { get; set; }
        public int? FakturaId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? Status { get; set; }
        public string StatusNew { get; set; }
        public int? Zamkniete { get; set; }
        public double? Frachty { get; set; }
        public double? KosztyInne { get; set; }
        public double? Suma { get; set; }
        public double? SumaF { get; set; }
        public double? Roznica { get; set; }
        public double? IloscTras { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public double? WagaDekl { get; set; }
        public double? WagaObl { get; set; }
        public double? Obj { get; set; }
        public double? ObjDekl { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? WgDat { get; set; }
        public string TypyTras { get; set; }
        public int? ZmianyNaTrasach { get; set; }
        public string ProceduraSql { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public string WalutaFv { get; set; }
        public int? Skonto { get; set; }
        public int? SkontoId { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? TerminPlatnosci { get; set; }
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
        public int? Rabat { get; set; }
        public double? RabatWart { get; set; }
        public int? ZlecenieZb { get; set; }
        public string NrRozlTras { get; set; }
        public int? NrRozlTrasKolejny { get; set; }
        public int? NrRozlTrasRok { get; set; }
        public int? NrRozlTrasMies { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
