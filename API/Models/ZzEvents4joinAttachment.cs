using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzEvents4joinAttachment
    {
        public int IdzzEvents4joinAttachment { get; set; }
        public DateTime? InsertDt { get; set; }
        public DateTime? DoneDt { get; set; }
        public int? Done { get; set; }
        public string DoneInfo { get; set; }
        public string AttObject { get; set; }
        public int? AttObjectId { get; set; }
        public string AttType { get; set; }
        public string AttDescription { get; set; }
        public string AttFileName { get; set; }
        public int? AttEdycja { get; set; }
        public int? AttFileStream { get; set; }
        public int? UseAttFileNameAsAttachmentFileName { get; set; }
    }
}
