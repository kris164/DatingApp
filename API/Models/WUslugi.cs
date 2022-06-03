using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WUslugi
    {
        public int IdWUslugi { get; set; }
        public string SymbolUslugi { get; set; }
        public string Nazwa1 { get; set; }
        public string Nazwa2 { get; set; }
        public string Jm { get; set; }
        public string Pkwiu { get; set; }
        public string Grupa { get; set; }
        public string TypOperacji { get; set; }
        public string OpisOperacji { get; set; }
        public int? StalaCenaSprzedazy { get; set; }
        public double? StalaCenaSprzedazyN { get; set; }
        public double? NormaCzasowa { get; set; }
        public int? CennikId { get; set; }
        public string Cennik { get; set; }
        public double? CenaSprzedazyN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? CenaSprzedazyV { get; set; }
        public double? CenaSprzedazyB { get; set; }
        public string Waluta { get; set; }
        public string RodzKosztow { get; set; }
        public string KontoFk { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
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
        public int? Wlasna { get; set; }
        public int? Obca { get; set; }
        public string NazwaDrukFisk { get; set; }
        public int? CenaZaUsluge { get; set; }
        public int? Niefiskalna { get; set; }
        public int? SplitPayment { get; set; }
        public int? VatJpkOznId { get; set; }
    }
}
