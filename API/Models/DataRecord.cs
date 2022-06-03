using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataRecord
    {
        public int IdDataRecord { get; set; }
        public int? DataKindId { get; set; }
        public int? DataTypeId { get; set; }
        public int? Status { get; set; }
        public string DataTxt { get; set; }
        public string DataXml { get; set; }
        public byte[] DataBin { get; set; }
        public string ExtInfo { get; set; }
        public DateTime? DtCreate { get; set; }
        public long? CalcDataLen { get; set; }
    }
}
