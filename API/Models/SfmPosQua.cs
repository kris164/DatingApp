using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosQua
    {
        public int IdSfmPos { get; set; }
        public string Hmn { get; set; }
        public string Gmh { get; set; }
        public string Mct { get; set; }
        public short? Positiontype { get; set; }
        public short? Placetype { get; set; }
        public string Placealias { get; set; }
        public string Placecity { get; set; }
        public string Placeid { get; set; }
        public string Placename { get; set; }
        public string Placepostalcode { get; set; }
        public string Placestate { get; set; }
        public string Tripstatus { get; set; }
        public string Distance { get; set; }
        public string DistanceUnit { get; set; }
        public string Direction { get; set; }
    }
}
