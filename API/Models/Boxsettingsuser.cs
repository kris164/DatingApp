using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Boxsettingsuser
    {
        public int IdBoxsettingsuser { get; set; }
        /// <summary>
        /// id głównych ustawień dla kontrolki
        /// </summary>
        public int IdBoxsettings { get; set; }
        /// <summary>
        /// id użytkownika
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (EDYCJA)
        /// </summary>
        public short? CtrlState { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (NOWY)
        /// </summary>
        public short? NewctrlState { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (INNY)
        /// </summary>
        public short? ExtctrlState { get; set; }
        /// <summary>
        /// id profilu
        /// </summary>
        public int IdProfile { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (EDYCJA)
        /// </summary>
        public short? Readonly { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (NOWY)
        /// </summary>
        public short? Newreadonly { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (INNY)
        /// </summary>
        public short? Extreadonly { get; set; }
    }
}
