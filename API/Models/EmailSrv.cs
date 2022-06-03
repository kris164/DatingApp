using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EmailSrv
    {
        public int IdEmailSrv { get; set; }
        /// <summary>
        /// adres konta
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// nazwa konta
        /// </summary>
        public string EmailName { get; set; }
        public string SmtpServer { get; set; }
        public int? SmtpPort { get; set; }
        public string SmtpLogin { get; set; }
        public string SmtpPassword { get; set; }
        public short? SmtpAuthentication { get; set; }
        public string Pop3Server { get; set; }
        public int? Pop3Port { get; set; }
        public string Pop3Login { get; set; }
        public string Pop3Password { get; set; }
        /// <summary>
        /// właściciel konta
        /// </summary>
        public int? IdUser { get; set; }
        /// <summary>
        /// 0/1 - aktywne
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// 0/1 - usuwaj z serwera
        /// </summary>
        public short? DelSrc { get; set; }
        /// <summary>
        /// 0/1 - serwer IMAP
        /// </summary>
        public short? SerwerImap { get; set; }
        public string ImapMailbox { get; set; }
        /// <summary>
        /// 0/1 - połączenie szyfrowane SSL/TLS
        /// </summary>
        public short? SmtpSsl { get; set; }
        /// <summary>
        /// 0/1 - połączenie szyfrowane SSL/TLS
        /// </summary>
        public short? Pop3Ssl { get; set; }
        /// <summary>
        /// 0/1 - blokada automatycznego przetwarzania wiadomości
        /// </summary>
        public short? Lockprocessing { get; set; }
        /// <summary>
        /// funkcje jakie może pełnić konto e-mail
        /// </summary>
        public string Funkcja { get; set; }
        public int? Sslstartmode { get; set; }
        public int? SslenabledProtocols { get; set; }
    }
}
