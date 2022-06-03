using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTemperatureControl
    {
        public int IdSfmTemperatureControl { get; set; }
        public int? IdSfmSystem { get; set; }
        public int? IdTrailerSpeed { get; set; }
        public string IdTrailerExt { get; set; }
        public int? OrderType { get; set; }
        public int? OrderId { get; set; }
        public int? TaskType { get; set; }
        public int? TaskId { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtEvent { get; set; }
        public DateTime? DtStatus { get; set; }
        public string TemperatureZone { get; set; }
        public double? TemperatureMin { get; set; }
        public double? TemperatureMax { get; set; }
        public int? Status { get; set; }
        public string Error { get; set; }
    }
}
