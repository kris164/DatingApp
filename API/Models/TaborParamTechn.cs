using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborParamTechn
    {
        public int IdTaboru { get; set; }
        public string SbIRodzaj { get; set; }
        public string SbIMarka { get; set; }
        public int? SbIIleBiegow { get; set; }
        public int? SbIMaPolbiegi { get; set; }
        public string SbIiRodzaj { get; set; }
        public string SbIiMarka { get; set; }
        public int? SbIiIleBiegow { get; set; }
        public int? SbIiMaPolbiegi { get; set; }
        public string ZawRodzaj { get; set; }
        public int? ZawMech { get; set; }
        public int? ZawPneumat { get; set; }
        public string ZawRodzPod { get; set; }
        public string SilRodzaj { get; set; }
        public string SilMarka { get; set; }
        public string SilWtryski { get; set; }
        public string KabZawieszenie { get; set; }
        public string KabRodzPod { get; set; }
        public int? KabRodzOgrz { get; set; }
        public string KabMarkaOgrzPost { get; set; }
        public int? SiodloRegul { get; set; }
        public double? SiodloWys { get; set; }
        public int? Napiecie12 { get; set; }
        public int? Napiecie24 { get; set; }
        public int? NapedPrzod { get; set; }
        public int? NapedTyl { get; set; }
        public string SystBezp { get; set; }
        public double? SiodloNacisk { get; set; }
        public int? PrzelTylMost { get; set; }
        public string PrzelTylMostInfo { get; set; }
    }
}
