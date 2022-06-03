using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagTowary
    {
        public int IdWMagTowary { get; set; }
        public string SymbolTowaru { get; set; }
        public string Nazwa1 { get; set; }
        public string Nazwa2 { get; set; }
        public string Jm { get; set; }
        public string Pkwiu { get; set; }
        public string Grupa { get; set; }
        public string Producent { get; set; }
        public string Magazyn { get; set; }
        public double? CenaZakupuN { get; set; }
        public double? MarzaProcent { get; set; }
        public double? MarzaKwota { get; set; }
        public int? StalaCenaSprzedazy { get; set; }
        public double? StalaCenaSprzedazyN { get; set; }
        public double? CenaSprzedazyN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? CenaSprzedazyV { get; set; }
        public double? CenaSprzedazyB { get; set; }
        public string Waluta { get; set; }
        public double? IloscMin { get; set; }
        public double? IloscMax { get; set; }
        public string Lokalizacja { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int? ModelId { get; set; }
        public string Model { get; set; }
        public int? WersjaId { get; set; }
        public string Wersja { get; set; }
        public string RodzKosztow { get; set; }
        public double? Przyjeto { get; set; }
        public double? Wydano { get; set; }
        public double? Rezerwacje { get; set; }
        public double? Stan { get; set; }
        public double? Wartosc { get; set; }
        public string KontoFk { get; set; }
        public int? Opona { get; set; }
        public string OponaNrSeryjny { get; set; }
        public string OponaRodzaj { get; set; }
        public string OponaRozmiar { get; set; }
        public string OponaMarka { get; set; }
        public string OponaBieznik { get; set; }
        public string OponaParamDod { get; set; }
        public string OponaUwagiDod { get; set; }
        public int? OponaNormaPrzebiegu { get; set; }
        public string Dzial { get; set; }
        public string NrKatalog { get; set; }
        public int? InnaJmP { get; set; }
        public string JmP { get; set; }
        public double? JmPrzelicznik { get; set; }
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
        public string Dostawca { get; set; }
        public int? DostawcaId { get; set; }
        public int? RecVer { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public int? DopiszDoWypPoj { get; set; }
        public int? OpisFvId { get; set; }
        public string OpisFv { get; set; }
        public string KodKreskowy { get; set; }
        public int? Wlasny { get; set; }
        public int? Obcy { get; set; }
        public string NazwaDrukFisk { get; set; }
        public double? NarzutProcent { get; set; }
        public int? DopiszDoWypPrac { get; set; }
        public double? CenaDoOferty { get; set; }
        public int? Aktywny { get; set; }
        public int? SplitPayment { get; set; }
        public int? VatJpkOznId { get; set; }
    }
}
