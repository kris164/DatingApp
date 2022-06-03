using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EmailAttach
    {
        public int IdEmailAttach { get; set; }
        public int IdEmailMsg { get; set; }
        public string Filename { get; set; }
        public byte[] Body { get; set; }
    }
}
