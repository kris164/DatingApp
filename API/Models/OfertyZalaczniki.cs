using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyZalaczniki
    {
        public int IdOfertyZalaczniki { get; set; }
        public int OfertaId { get; set; }
        public string Rodzaj { get; set; }
        public string OpisPliku { get; set; }
        public string NazwaPliku { get; set; }
        public int? TypPliku { get; set; }
        public byte[] Plik { get; set; }
        public DateTime? DataWprowadzenia { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
