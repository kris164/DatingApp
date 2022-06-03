using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SentMsgExt
    {
        public int SentMsgExtId { get; set; }
        public int SentMsgId { get; set; }
        public int Lp { get; set; }
        public string GoodsCodeEanClassification { get; set; }
        public string GoodsCodeEanClassificationDesc { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
