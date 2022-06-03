using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AktPrzelewy
    {
        public int IdAktPrzelewy { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string Uzytkownik { get; set; }
        public string NazwaStacji { get; set; }
        public string IpStacji { get; set; }
    }
}
