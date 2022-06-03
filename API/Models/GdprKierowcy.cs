using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprKierowcy
    {
        public int IdGdprKierowcy { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Telefon { get; set; }
        public string TelefonKom { get; set; }
        public string TelSluzbowy2 { get; set; }
        public string TelSluzbowy { get; set; }
        public string Email { get; set; }
        public string Nip { get; set; }
        public string Pesel { get; set; }
        public string Konto { get; set; }
        public string NumerDowodu { get; set; }
        public string Paszport { get; set; }
        public string PrawoJazdy { get; set; }
        public string SwiadKwalif { get; set; }
        public string KursPrzewozRzeczy { get; set; }
        public string KursPrzewozOsob { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        public DateTime? DataUr { get; set; }
        public string MiejsceUr { get; set; }
        public string Uzytkownik { get; set; }
        public int? UzytkownikId { get; set; }
        public string ZatrudnionyW { get; set; }
        public int? ZatrudnionyWId { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? IdKierowcy { get; set; }
        public int? GdprOblivionId { get; set; }
        public int? Pseudonim { get; set; }
        public int? Anonim { get; set; }
        public int? PseudonimCancel { get; set; }
        public int? AnonimCancel { get; set; }
        public int? OrgIdGdprKierowcy { get; set; }
    }
}
