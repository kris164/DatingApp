using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Normy
    {
        public int IdNormy { get; set; }
        public int? ObiektId { get; set; }
        public int? Typ { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public double? NormaKwotowa { get; set; }
        public string NormaKwotowaWaluta { get; set; }
        public double? NormaKm { get; set; }
    }
}
