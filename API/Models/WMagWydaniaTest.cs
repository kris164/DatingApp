using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagWydaniaTest
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
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
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
    }
}
