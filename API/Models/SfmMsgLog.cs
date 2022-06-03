using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// log przebiegu wykonania procedury składowanej dla makra SMS
    /// </summary>
    public partial class SfmMsgLog
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// treść logu
        /// </summary>
        public string Txt { get; set; }
    }
}
