using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Promy
    {
        public int IdPromy { get; set; }
        public string Typ { get; set; }
        public string Status { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public int? RelacjaId { get; set; }
        public string Relacja { get; set; }
        public string RelacjaSymbol { get; set; }
        public string DzienTyg { get; set; }
        public DateTime? DataWypl { get; set; }
        public DateTime? GodzWypl { get; set; }
        public DateTime? MaxDataBukingu { get; set; }
        public DateTime? MaxGodzBukingu { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public DateTime? DataWjazd { get; set; }
        public DateTime? GodzWjazd { get; set; }
        public DateTime? DataZjazd { get; set; }
        public DateTime? GodzZjazd { get; set; }
        public int? Wl { get; set; }
        public int? WlNr { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public int? Tydzien { get; set; }
        public int? PromyAlotyId { get; set; }
        public int? PromyAlotyPozId { get; set; }
        public string TaborNrB { get; set; }
        public string NrBookingu { get; set; }
        public int? PromyAlotyKorId { get; set; }
        public int? PromyAlotyKorPozId { get; set; }
        public double? DlugoscMb { get; set; }
        public int? Kierowcy { get; set; }
        public double? PonadgabarytDl { get; set; }
        public double? PonadgabarytWy { get; set; }
        public double? PonadgabarytSz { get; set; }
        public int? Agregat { get; set; }
        public double? CenaZaMb { get; set; }
        public string CenaZaMbWal { get; set; }
        public double? CenaZa2Kier { get; set; }
        public string CenaZa2KierWal { get; set; }
        public double? CenaZaTone { get; set; }
        public string CenaZaToneWal { get; set; }
        public double? KosztAgr { get; set; }
        public string KosztAgrWal { get; set; }
        public double? KosztyPromu { get; set; }
        public string KosztyPromuWal { get; set; }
        public double? Koszty2Kier { get; set; }
        public string Koszty2KierWal { get; set; }
        public double? IloscTon { get; set; }
        public double? KosztyTony { get; set; }
        public string KosztyTonyWal { get; set; }
        public double? KosztyRazem { get; set; }
        public string KosztyRazemWal { get; set; }
        public int? FakturaPromowaId { get; set; }
        public string FakturaPromowa { get; set; }
        public DateTime? FakturaPromowaData { get; set; }
        public int? Odsprzedane { get; set; }
        public string KlientKontakt { get; set; }
        public string KlientTel { get; set; }
        public string KlientZlecenie { get; set; }
        public double? KlientMarza { get; set; }
        public double? KlientKwota { get; set; }
        public string KlientKwotaWal { get; set; }
        public int? KlientFakturaId { get; set; }
        public string KlientFaktura { get; set; }
        public DateTime? KlientFakturaData { get; set; }
        public string Uwagi { get; set; }
        public double? KosztyDod { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public DateTime? Data { get; set; }
        public string Numer { get; set; }
        public int? NumerKolejny { get; set; }
        public int? NumerRok { get; set; }
        public int? NumerMies { get; set; }
        public int? Anulowany { get; set; }
        public int? SamOsob { get; set; }
        public int? Adr { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrB { get; set; }
        public string KlientFakturaPf { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public int? Zalaczniki { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? JestRw { get; set; }
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
        public string KlientKwotaWalFv { get; set; }
        public string KlientVatId { get; set; }
        public double? KlientVatStawka { get; set; }
        public string ArmatorCennikSp { get; set; }
        public string KlientCennikSp { get; set; }
        public int? LiniaId { get; set; }
        public string Linia { get; set; }
        public string KlasaAdr { get; set; }
        public int? TylkoNaczepa { get; set; }
        public string SrTransp { get; set; }
        public int? Zafakturowane { get; set; }
        public DateTime? CzasPlyniecia { get; set; }
        public int? StatusKoszty { get; set; }
        public int? Nieodebrany { get; set; }
        public string KosztyRazemWalFv { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public int? PlatnikId { get; set; }
        public string PlatnikSymbol { get; set; }
        public string PlatnikNazwa { get; set; }
        public string PlatnikAdres { get; set; }
        public string PlatnikMiasto { get; set; }
        public string PlatnikKod { get; set; }
        public string PlatnikKraj { get; set; }
        public string PlatnikNip { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? Termin { get; set; }
        /// <summary>
        /// Flaga, czy faktura na płatnika
        /// </summary>
        public short? FvNaPlatnika { get; set; }
        /// <summary>
        /// Flaga, czy nie fakturować
        /// </summary>
        public short? NieFakturuj { get; set; }
        public int? PromId { get; set; }
        public string Prom { get; set; }
        public string NrBiletu { get; set; }
        public DateTime? DataWyk { get; set; }
        public int? CennikId { get; set; }
        public int? PromyHarmonogramId { get; set; }
        public int? Osobowy { get; set; }
        public double? DlugoscMb2 { get; set; }
        public string Usluga { get; set; }
        public int? Papier { get; set; }
    }
}
