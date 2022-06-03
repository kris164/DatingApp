using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagPrzyjecium
    {
        public int IdWMagPrzyjecia { get; set; }
        public string Status { get; set; }
        public string Magazyn { get; set; }
        public string RodzajPrzyjecia { get; set; }
        public string NrDok { get; set; }
        public int? NrDokKolejny { get; set; }
        public int? NrDokRok { get; set; }
        public int? NrDokMies { get; set; }
        public DateTime? DataPrzyjecia { get; set; }
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
        public string NrZewn { get; set; }
        public string Uwagi { get; set; }
        public double? WartoscNetto { get; set; }
        public double? WartoscVat { get; set; }
        public double? WartoscBrutto { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? WDoFkId { get; set; }
        public string MagazynZrodl { get; set; }
        public int? NrFakturyId { get; set; }
        public int? Korekta { get; set; }
        public string KorektaDoPz { get; set; }
        public int? KorektaDoPzId { get; set; }
        public int? MmagWzId { get; set; }
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
        public int? NrZamowieniaId { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public int? TypDokumentu { get; set; }
        public int? KorygowanyPrzezId { get; set; }
        public int? ZamykanyPrzezId { get; set; }
        public string ZamykanyPrzez { get; set; }
    }
}
