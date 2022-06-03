using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabela do obsługi mechanizmu wysyłania załączników
    /// </summary>
    public partial class KontrahenciPod
    {
        public int IdKontrahenciPod { get; set; }
        public int KontrahId { get; set; }
        public short? UseEmail { get; set; }
        public short? UseFtp { get; set; }
        public string EmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string FtpHost { get; set; }
        public string FtpUser { get; set; }
        public string FtpPass { get; set; }
        public string FtpDirIn { get; set; }
        public string FtpDirOut { get; set; }
        public int? FtpPort { get; set; }
        public short? GdyZleceniodawca { get; set; }
        public short? GdyNadawca { get; set; }
        public short? GdyOdbiorca { get; set; }
        public short? GdyPartner { get; set; }
    }
}
