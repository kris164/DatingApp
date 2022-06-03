using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MagazynZdarzenium
    {
        public int IdMagazynZdarzenia { get; set; }
        public int? FrmId { get; set; }
        public string NrPwz { get; set; }
        public int? NrPwzKolejny { get; set; }
        public int? NrPwzRok { get; set; }
        public int? NrPwzMies { get; set; }
        public string Zdarzenie { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Czas { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public int? UzytkownikMagId { get; set; }
        public string UzytkownikMag { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public int? PartnerId { get; set; }
        public string Partner { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string Kierowca { get; set; }
        public string NrExt { get; set; }
        public double? Ile { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public int? Liniowy { get; set; }
        public int? TaborWlasny { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? ListLiniowyId { get; set; }
        public int? Psd { get; set; }
        public string ListLiniowy { get; set; }
        public DateTime? DataStart { get; set; }
        public DateTime? CzasStart { get; set; }
        public DateTime? DataStop { get; set; }
        public DateTime? CzasStop { get; set; }
        public string Stan { get; set; }
        public string StatusMail { get; set; }
        public string Lokalizacja { get; set; }
        public int? Techniczne { get; set; }
        public double? WagaDekl { get; set; }
        public double? ObjDekl { get; set; }
        public double? WagaObl { get; set; }
        public string Dzial { get; set; }
        public string MagLokBrama { get; set; }
        public int? MagLokStat { get; set; }
        public int? WymusPz { get; set; }
        public int? KierowcaId { get; set; }
        public string KierowcaTel { get; set; }
        public int? ZatwPoSkan { get; set; }
        public int? Zalaczniki { get; set; }
        public double? IleRz { get; set; }
        public double? MpDekl { get; set; }
        public double? MpRz { get; set; }
        public string StatusEmisja { get; set; }
    }
}
