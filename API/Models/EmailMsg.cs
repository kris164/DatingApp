using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EmailMsg
    {
        public int IdEmailMsg { get; set; }
        public int IdEmailSrv { get; set; }
        /// <summary>
        /// rodzaj wiadomości (0:IN; 1:OUT)
        /// </summary>
        public short Inout { get; set; }
        /// <summary>
        /// status wiadomości (0:nowa/nieprzeczytana; 1:wysłana/przeczytana; 2:błąd)
        /// </summary>
        public short Status { get; set; }
        public short? Attach { get; set; }
        public short? Folder { get; set; }
        public string MailType { get; set; }
        public DateTime? MailDate { get; set; }
        public string Subject { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string MailId { get; set; }
        public string MailFormat { get; set; }
        public string MailHash { get; set; }
        public string MailBody { get; set; }
        /// <summary>
        /// oryginał wiadomości
        /// </summary>
        public string Eml { get; set; }
        /// <summary>
        /// błędy komunikacji
        /// </summary>
        public string MailError { get; set; }
        /// <summary>
        /// 0 - OK; 1 - wystapiły błędy
        /// </summary>
        public int? ProcessStat { get; set; }
        public string ProcessInfo { get; set; }
        public string ProcessLog { get; set; }
        /// <summary>
        /// 0/1 - wymagaj potwierdzenia przeczytania
        /// </summary>
        public short? Confirm { get; set; }
    }
}
