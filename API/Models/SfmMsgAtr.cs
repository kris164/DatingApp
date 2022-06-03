using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgAtr
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// ID wiadomości ATROM
        /// </summary>
        public int? Msgid { get; set; }
        /// <summary>
        /// ID wiadomości, na którą odpowiedziano
        /// </summary>
        public int? Msgorgid { get; set; }
        /// <summary>
        /// typ wiadomości (I-info/ T-trasa/ P-/ S-system)
        /// </summary>
        public string Msgtyp { get; set; }
        /// <summary>
        /// ID terminala ATROM
        /// </summary>
        public int? Vehid { get; set; }
        /// <summary>
        /// ID użytkownika ATROM
        /// </summary>
        public int? Usrid { get; set; }
    }
}
