using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// wynik wykonania np. procedury składowanej dla makra SMS
    /// </summary>
    public partial class SfmMsgOut
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// wynik w postaci XML
        /// </summary>
        public string Xml { get; set; }
    }
}
