using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagWydanium
    {
        public int IdWMagWydania { get; set; }
        public string Status { get; set; }
        public string Magazyn { get; set; }
        public string RodzajWydania { get; set; }
        public string NrDok { get; set; }
        public int? NrDokKolejny { get; set; }
        public int? NrDokRok { get; set; }
        public int? NrDokMies { get; set; }
        public DateTime? DataWydania { get; set; }
        public int KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? DataSprzedazy { get; set; }
        public string NrFaktury { get; set; }
        public string NrZamowienia { get; set; }
        public string NrZlecenia { get; set; }
        public string Uwagi { get; set; }
        public double? WartoscNetto { get; set; }
        public double? WartoscVat { get; set; }
        public double? WartoscBrutto { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public string FormaPlatnosci { get; set; }
        public string Tabor { get; set; }
        public int? TaborId { get; set; }
        public string Kierowca { get; set; }
        public int? KierowcaId { get; set; }
        public int? WDoFkId { get; set; }
        public string TaborNrBoczny { get; set; }
        public string MagazynDocel { get; set; }
        public int? NrFakturyId { get; set; }
        public int? Korekta { get; set; }
        public string KorektaDoWz { get; set; }
        public int? KorektaDoWzId { get; set; }
        public int? MmagPzId { get; set; }
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
        public int? TaborLicznik { get; set; }
        public DateTime? GodzWydania { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public int? ZaksiegowanoSpeed { get; set; }
        public string Faktura { get; set; }
        public int? FakturaId { get; set; }
        public int? ParagonFiskalny { get; set; }
        public int? TypDokumentu { get; set; }
        public int? KorygowanyPrzezId { get; set; }
        public string NrParagonu { get; set; }
        public int? TypPracownika { get; set; }
        public int? ZamykanyPrzezId { get; set; }
        public string ZamykanyPrzez { get; set; }
    }
}
