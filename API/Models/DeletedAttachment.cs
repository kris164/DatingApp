using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DeletedAttachment
    {
        public int DeletedAttachmentsId { get; set; }
        public string FileName { get; set; }
        public string TerminalType { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
