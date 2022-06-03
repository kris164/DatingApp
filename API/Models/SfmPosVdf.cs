using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosVdf
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? DevId { get; set; }
        public double? Wysokosc { get; set; }
        public double? Kierunek { get; set; }
        public int? Licznik { get; set; }
        public int? Zuzytepaliwo { get; set; }
        public int? Temp1 { get; set; }
        public int? Temp2 { get; set; }
        public int? Temp3 { get; set; }
        public int? Temp4 { get; set; }
        public int? Temp5 { get; set; }
        public int? Temp6 { get; set; }
        public int? Temp7 { get; set; }
        public int? Temp8 { get; set; }
        public string Driveractiv { get; set; }
        public int? DriverId { get; set; }
        public int? CzasJ { get; set; }
        public int? CzasO { get; set; }
        public int? CzasP { get; set; }
        public int? CzasC { get; set; }
        public int? Osprzod { get; set; }
        public int? Ostyl { get; set; }
        public int? Masa { get; set; }
        public int? NaczOsprzod { get; set; }
        public int? NaczOstyl { get; set; }
        public int? NaczMasa { get; set; }
    }
}
