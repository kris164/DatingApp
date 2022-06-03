using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprKontrahenci
    {
        public int IdGdprKontrah { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Ulica { get; set; }
        public string NrDom { get; set; }
        public string NrLok { get; set; }
        public string Miejscowosc { get; set; }
        public string Kod { get; set; }
        public string Poczta { get; set; }
        public string Kraj { get; set; }
        public string Wojewodztwo { get; set; }
        public string NazwaK { get; set; }
        public string UlicaK { get; set; }
        public string NrDomK { get; set; }
        public string NrLokK { get; set; }
        public string MiejscowoscK { get; set; }
        public string KodK { get; set; }
        public string PocztaK { get; set; }
        public string KrajK { get; set; }
        public string WojewodztwoK { get; set; }
        public string Regon { get; set; }
        public string Pesel { get; set; }
        public string Nip { get; set; }
        public string Nip2 { get; set; }
        public string NipCzysty { get; set; }
        public string BankNazwa { get; set; }
        public string BankKonto { get; set; }
        public string Osobafin1 { get; set; }
        public string Osobafin2 { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string OsobaKontakt { get; set; }
        public string Www { get; set; }
        public string Gg { get; set; }
        public string Skype { get; set; }
        public string Konto { get; set; }
        public int? Iban { get; set; }
        public double? GeoLongi { get; set; }
        public double? GeoLat { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? IdKontrahenci { get; set; }
        public int? GdprOblivionId { get; set; }
        public int? Pseudonim { get; set; }
        public int? Anonim { get; set; }
        public int? PseudonimCancel { get; set; }
        public int? AnonimCancel { get; set; }
        public int? OrgIdGdprKontrahenci { get; set; }
    }
}
