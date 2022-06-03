using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AnkietyOdp
    {
        public int IdAnkietyOdp { get; set; }
        public int AnkietyPytId { get; set; }
        public int ObjId { get; set; }
        public int RecId { get; set; }
        public string Odpowiedz { get; set; }
        public int UserId { get; set; }
        public DateTime DtOdp { get; set; }
    }
}
