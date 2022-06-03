using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprOblivion
    {
        public int IdGdprOblivion { get; set; }
        public int OblivionTypeId { get; set; }
        public int? SubjectObjId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Passport { get; set; }
        public string Idcard { get; set; }
        public int? CompanyId { get; set; }
        public string CompanySymbol { get; set; }
        public string CompanyName { get; set; }
        public int? ReferenceObjId { get; set; }
        public int? ReferenceRecId { get; set; }
        public string ReferenceRec { get; set; }
        public int? SubObjId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Canceled { get; set; }
        public int? Disable { get; set; }
        public int? Active { get; set; }
        public int? Analysis { get; set; }
        public int? OrgIdGdprOblivion { get; set; }
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
    }
}
