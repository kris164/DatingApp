using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AktFakturowane
    {
        public int IdAktFakturowane { get; set; }
        public int? KalkulacjeId { get; set; }
        public int? ZlecPozFaktId { get; set; }
        public int? ZlecenieId { get; set; }
        public int? ListLiniowyId { get; set; }
        public int? PozKorektaId { get; set; }
        public int? PromyId { get; set; }
        public string Uzytkownik { get; set; }
        public string NazwaStacji { get; set; }
        public string IpStacji { get; set; }
    }
}
