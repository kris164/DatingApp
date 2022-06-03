using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprUzytkownik
    {
        public int IdGdprUzytkownik { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Telefon { get; set; }
        public string TelKom { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? IdUzytkownik { get; set; }
        public int? GdprOblivionId { get; set; }
        public int? Pseudonim { get; set; }
        public int? Anonim { get; set; }
        public int? PseudonimCancel { get; set; }
        public int? AnonimCancel { get; set; }
        public int? OrgIdGdprUzytkownik { get; set; }
    }
}
