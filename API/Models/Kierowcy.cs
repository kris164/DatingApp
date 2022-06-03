using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Kierowcy
    {
        public int IdKierowcy { get; set; }
        public string Symbol { get; set; }
        public string Stanowisko { get; set; }
        public int? Kierowca { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public int? Aktywny { get; set; }
        public string Telefon { get; set; }
        public string TelefonKom { get; set; }
        public string Email { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public string Uwagi { get; set; }
        public string Nip { get; set; }
        public string Pesel { get; set; }
        public string NumerDowodu { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public DateTime? DataUr { get; set; }
        public string MiejsceUr { get; set; }
        public int? KlientId { get; set; }
        public string FormaZatrudnienia { get; set; }
        public string Umowa { get; set; }
        public double? PlacaPodstawowa { get; set; }
        public string Lokalizacja { get; set; }
        public string KontoFk { get; set; }
        public string KontoFk2 { get; set; }
        public int? Zagranica { get; set; }
        public string Uzytkownik { get; set; }
        public int? UzytkownikId { get; set; }
        public double? ProgFracht { get; set; }
        public double? Prowizja { get; set; }
        public double? ProwizjaMin { get; set; }
        public string TelSlOperator { get; set; }
        public string TelSlTaryfa { get; set; }
        public int? TelSlRoaming { get; set; }
        public DateTime? TelSlUmOd { get; set; }
        public DateTime? TelSlUmDo { get; set; }
        public string TelSlHaslo { get; set; }
        public string TelSluzbowy { get; set; }
        public string TelModel { get; set; }
        public string TelTyp { get; set; }
        public string TelNrSer { get; set; }
        public string Pin { get; set; }
        public string Puk1 { get; set; }
        public string Puk2 { get; set; }
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
        public int? Spedytor { get; set; }
        public int? SfmStatus { get; set; }
        public int? SfmTraId { get; set; }
        public string ETachoNumer { get; set; }
        public DateTime? ETachoDataWaznosci { get; set; }
        public int? SfmTraSysId { get; set; }
        public int? Obcy { get; set; }
        public int? Dyspozytor { get; set; }
        public string ZatrudnionyW { get; set; }
        public int? ZatrudnionyWId { get; set; }
        public double? StawkaZaKm { get; set; }
        public double? ProwizjaI { get; set; }
        public double? ProwizjaIi { get; set; }
        public double? ProwizjaUmzl { get; set; }
        public string NumerDowoduWyd { get; set; }
        public DateTime? NumerDowoduWazn { get; set; }
        public string Paszport { get; set; }
        public DateTime? PaszportWazn { get; set; }
        public string ProgFrachtWal { get; set; }
        public string PrawoJazdy { get; set; }
        public string PrawoJazdyKat { get; set; }
        public DateTime? PrawoJazdyWazn { get; set; }
        public string SwiadKwalif { get; set; }
        public int? Uczen { get; set; }
        public int? WynagrSchematId { get; set; }
        public string WynagrSchemat { get; set; }
        public byte[] Opt1 { get; set; }
        public byte[] Opt2 { get; set; }
        public DateTime? BadanieLekData { get; set; }
        public DateTime? BadanieLekWazn { get; set; }
        public DateTime? BadaniePsychData { get; set; }
        public DateTime? BadaniePsychWazn { get; set; }
        public string KursPrzewozRzeczy { get; set; }
        public DateTime? KursPrzewozRzeczyWazn { get; set; }
        public string KursPrzewozOsob { get; set; }
        public DateTime? KursPrzewozOsobWazn { get; set; }
        public string PdaUser { get; set; }
        public string PdaPass { get; set; }
        public string KodPocztowy { get; set; }
        public DateTime? DoKiedyBylUczen { get; set; }
        public string InfoDlaOperatora { get; set; }
        public DateTime? SwiadKwalifWazn { get; set; }
        public byte[] Zdjecie { get; set; }
        public int? SaUwagi { get; set; }
        public string Dzial { get; set; }
        public int? ObcyUmowa { get; set; }
        public string TelSluzbowy2 { get; set; }
        public string KontoFk3 { get; set; }
        public int? Adr { get; set; }
        public string KlasyAdr { get; set; }
        public DateTime? ETachoLastRead { get; set; }
        public string KodKreskowy { get; set; }
        public int? KierowcyGrupyId { get; set; }
        public string KierowcyGrupy { get; set; }
        public int? AdrCysterna { get; set; }
        public string Konto { get; set; }
        public int? ZakazCod { get; set; }
        public string ETachoKraj { get; set; }
        /// <summary>
        /// czy modyfikacja z INELO
        /// </summary>
        public int? IneloUpdate { get; set; }
        public int? Haccp { get; set; }
        public string Kraj { get; set; }
        public int? MobileActive { get; set; }
        public DateTime? AdrWazn { get; set; }
        public string MobilePassHash { get; set; }
        public int? MobileProfile { get; set; }
        public byte[] Password { get; set; }
        public string MobilePassword { get; set; }
        public int? IleDniPracyC { get; set; }
        public int? Heartbeat { get; set; }
        public int? Locked { get; set; }
        public int? ErrorCount { get; set; }
        public string StatusEmisja { get; set; }
        public int? WlWynagr { get; set; }
        public string MobilePassResetKey { get; set; }
        public string MobilePassResetInfo { get; set; }
        public string NrLokalizatoraGps { get; set; }
        public string MobileModule { get; set; }
        public int? KontoId { get; set; }
        public string Rejon { get; set; }
        /// <summary>
        /// Indywidualny klucz kierowcy podawany przez Przewoźnika w przypadku korzystania z aplikacji mobilnej SENT-OIL
        /// </summary>
        public string DriverKey { get; set; }
        public string KodKreskowyExt { get; set; }
        public string Obywatelstwo { get; set; }
        public int? ForcePasswordReset { get; set; }
        public DateTime? DtHaslo { get; set; }
        public DateTime? DataZjazdu { get; set; }
        public DateTime? LastRequest { get; set; }
        public DateTime? LastResponse { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Status - SLOT 1
        /// </summary>
        public string Slot1 { get; set; }
        /// <summary>
        /// Status - SLOT 2
        /// </summary>
        public string Slot2 { get; set; }
        /// <summary>
        /// Status - SLOT 3
        /// </summary>
        public string Slot3 { get; set; }
        /// <summary>
        /// Status - SLOT 4
        /// </summary>
        public string Slot4 { get; set; }
        /// <summary>
        /// Status - SLOT 5
        /// </summary>
        public string Slot5 { get; set; }
    }
}
