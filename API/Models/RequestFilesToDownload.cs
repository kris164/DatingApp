using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestFilesToDownload
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public int? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyData { get; set; }
        public string Language { get; set; }
    }
}
