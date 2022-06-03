using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AttachmentToJoin
    {
        public int Id { get; set; }
        public int? IdRec { get; set; }
        public string Obiekt { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public byte? Done { get; set; }
        public int? IdZalaczniki { get; set; }
        public string Rodzaj { get; set; }
    }
}
