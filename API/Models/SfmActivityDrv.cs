using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmActivityDrv
    {
        public int IdSfmActivityDrv { get; set; }
        /// <summary>
        /// id aktywności pojazdu
        /// </summary>
        public int? IdSfmActivity { get; set; }
        /// <summary>
        /// id kierowcy
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// czas dołączenia do aktywności
        /// </summary>
        public DateTime? DtStart { get; set; }
        /// <summary>
        /// czas wyłączenia z aktywności
        /// </summary>
        public DateTime? DtStop { get; set; }
        /// <summary>
        /// &quot;D&quot;-kierowca/&quot;P&quot;-pasażer
        /// </summary>
        public string Loginmode { get; set; }
    }
}
