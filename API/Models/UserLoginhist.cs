using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// historia logowania użytkowników
    /// </summary>
    public partial class UserLoginhist
    {
        public int IdUserLoginhist { get; set; }
        /// <summary>
        /// czas próby logowania
        /// </summary>
        public DateTime? Dt { get; set; }
        /// <summary>
        /// login użytkownika
        /// </summary>
        public string Userlogin { get; set; }
        /// <summary>
        /// login użytkownika typu ADMIN
        /// </summary>
        public string Adminlogin { get; set; }
        /// <summary>
        /// numer próby logowania
        /// </summary>
        public short? TryNo { get; set; }
        /// <summary>
        /// (0/1) wynik próby logowania
        /// </summary>
        public short? TryOk { get; set; }
        /// <summary>
        /// id użytkownika
        /// </summary>
        public int? IdUser { get; set; }
        /// <summary>
        /// nazwa programu
        /// </summary>
        public string App { get; set; }
        /// <summary>
        /// IP stacji logowania
        /// </summary>
        public string PcIp { get; set; }
        /// <summary>
        /// nazwa stacji roboczej
        /// </summary>
        public string PcName { get; set; }
        /// <summary>
        /// info dodatkowe
        /// </summary>
        public string Info { get; set; }
    }
}
