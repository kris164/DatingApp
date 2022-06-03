using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RcpNag
    {
        public int IdRcpNag { get; set; }
        public int IdFirma { get; set; }
        public int IdKierowcy { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string AppVer { get; set; }
        public DateTime? GWypracowane { get; set; }
        public string RozliczenieUwagi { get; set; }
        public byte[] AnalizaDane { get; set; }
        public DateTime? GPozostale { get; set; }
        public int? Zakonczone { get; set; }
        public DateTime? ZakonczoneDt { get; set; }
        public int? ZakonczoneUserId { get; set; }
        public string ZakonczoneUserName { get; set; }
    }
}
