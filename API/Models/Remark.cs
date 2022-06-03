using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Remark
    {
        public int RemarksId { get; set; }
        public int ObjId { get; set; }
        public int RecId { get; set; }
        public int? Type { get; set; }
        public string RemarkText { get; set; }
    }
}
