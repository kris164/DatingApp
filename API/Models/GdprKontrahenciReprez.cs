using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprKontrahenciReprez
    {
        public int IdGdprKontrahenciReprez { get; set; }
        public int KontrahId { get; set; }
        public string Tytul { get; set; }
        public string NazwiskoImie { get; set; }
        public string Stanowisko { get; set; }
        public string Grupa { get; set; }
        public string Tel { get; set; }
        public string TelKom { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Gg { get; set; }
        public string Skype { get; set; }
        public string Gielda { get; set; }
        public string Opis { get; set; }
        public string Lokalizacja { get; set; }
        public string Oddzial { get; set; }
        public int? OddzialId { get; set; }
        public string Dzial { get; set; }
        public int? Mailing { get; set; }
        public int? Aktywny { get; set; }
        public int? Erod { get; set; }
        public int? Powiadomienie { get; set; }
        public string Produkt { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string StatusEmisja { get; set; }
        public int? Pseudonim { get; set; }
        public int? Anonim { get; set; }
        public int? PseudonimCancel { get; set; }
        public int? AnonimCancel { get; set; }
        public int? IdKontrahenciReprez { get; set; }
        public int? GdprOblivionId { get; set; }
        public int? OrgIdGdprKontrahenciReprez { get; set; }
    }
}
