using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiPowiadomienium
    {
        public int IdTmpPrzesylkiPowiadomienia { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? PrzesylkiId { get; set; }
        public string Kto { get; set; }
        public string Typ { get; set; }
        public string CoWyzwala { get; set; }
        public string Email { get; set; }
        public string Kraj { get; set; }
        public string TelPrefix { get; set; }
        public string Tel { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Dt { get; set; }
        public string Tresc { get; set; }
        public byte? ZrobioneN { get; set; }
        public byte? ZrobioneD { get; set; }
        public byte? ZrobioneK { get; set; }
    }
}
