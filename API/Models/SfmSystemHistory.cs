using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmSystemHistory
    {
        public int IdSfmSystemHistory { get; set; }
        public DateTime RegisterDate { get; set; }
        public string CommandType { get; set; }
        public string SessionInfo { get; set; }
        public int? IdSfmSystem { get; set; }
        public short? Wylacz { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public int? Status { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public int? CompanyId { get; set; }
        public string Provider { get; set; }
        public string Serwer { get; set; }
        public string Port { get; set; }
        public string Baza { get; set; }
        public int? SystemNr { get; set; }
        public int? IdMsg { get; set; }
        public int? IdReply { get; set; }
        public DateTime? Startarch { get; set; }
        public short? Deletefiles { get; set; }
        public int? Filtermintime { get; set; }
        public int? Filtermindistance0 { get; set; }
        public int? Filtermindistance1 { get; set; }
        public int? LComment { get; set; }
        public int? LMessage { get; set; }
        public int? LPlace { get; set; }
        public string UrlProd { get; set; }
        public string UrlTest { get; set; }
        public string UrlInny { get; set; }
        public string Loginkey { get; set; }
        public string Customer { get; set; }
        public string Macromap { get; set; }
        public byte[] Cert { get; set; }
        public string Filename { get; set; }
        public string SmtpMail { get; set; }
        public int? SmtpAuth { get; set; }
        public short? CopyOdo2lkm { get; set; }
        public string Driveactivities { get; set; }
        public short? Reversegeocode { get; set; }
        public short? SysmsgNotread { get; set; }
        public short? BciTacho { get; set; }
        public short? UseConfigxml { get; set; }
        public short? DisableEta { get; set; }
        public short? JazTraReg { get; set; }
        public short? DownloadFiles { get; set; }
        public short? UseWebservice { get; set; }
        public short? AltAlarms { get; set; }
        public short? AltLocations { get; set; }
        public short? AltMessages { get; set; }
        public short? AltMsgstat { get; set; }
        public short? AltSendmsg { get; set; }
        public short? AltSendorder { get; set; }
        public short? AltPoolfiles { get; set; }
        public short? AltReports { get; set; }
        public int? IsPwStart { get; set; }
        public int? IsPwStop { get; set; }
        public string Config { get; set; }
        public short? AltDrivingdata { get; set; }
        public short? AltStatop { get; set; }
        public short? AltTachodata { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public short? AltCorridor { get; set; }
        public string IsSkipTasks { get; set; }
        public int? SmtpSsl { get; set; }
        public int? IsZa { get; set; }
        public int? IsWy { get; set; }
        public short? AltActivitypto { get; set; }
        public short? UseInternaleta { get; set; }
        public short? IsDefault { get; set; }
        public string Proxy { get; set; }
    }
}
