using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CarrierDataAttachment
    {
        public int CarrierDataAttachmentId { get; set; }
        public int? CarrierDataId { get; set; }
        public string Name { get; set; }
        public byte[] Attachment { get; set; }
    }
}
