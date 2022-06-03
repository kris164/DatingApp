using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BoxSettingsUserHist
    {
        public int IdBoxSettingsUserHist { get; set; }
        /// <summary>
        /// id rekordu głównego w tabeli [BoxSettingsHist]
        /// </summary>
        public int IdBoxSettingsHist { get; set; }
        /// <summary>
        /// id głównych ustawień dla kontrolki
        /// </summary>
        public int IdBoxSettings { get; set; }
        /// <summary>
        /// id użytkownika
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// id profilu
        /// </summary>
        public int IdProfile { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (EDYCJA)
        /// </summary>
        public short? CtrlState { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (NOWY)
        /// </summary>
        public short? NewCtrlState { get; set; }
        /// <summary>
        /// 0-disable /1-hide /2-required /-2-ust. ogólne (INNY)
        /// </summary>
        public short? ExtCtrlState { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (EDYCJA)
        /// </summary>
        public short? ReadOnly { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (NOWY)
        /// </summary>
        public short? NewReadOnly { get; set; }
        /// <summary>
        /// 0/1 - wyłączenie edycji &quot;ręcznej&quot; (INNY)
        /// </summary>
        public short? ExtReadOnly { get; set; }
    }
}
