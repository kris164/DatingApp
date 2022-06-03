using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataProcessorModule
    {
        public int IdDataProcessorModule { get; set; }
        public int? SrcDataKindId { get; set; }
        public int? SrcDataTypeId { get; set; }
        public int? DstDataKindId { get; set; }
        public int? DstDataTypeId { get; set; }
        public int? Enabled { get; set; }
        public string ModuleName { get; set; }
        public string ModulePath { get; set; }
        public string ModuleFileName { get; set; }
        public string Description { get; set; }
    }
}
