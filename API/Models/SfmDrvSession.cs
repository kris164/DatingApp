using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmDrvSession
    {
        public int IdSfmDrvSession { get; set; }
        /// <summary>
        /// 0-zalogowany/1-wylogowany
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// id kierowcy SPEED
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// id taboru SPEED
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// identyfikator kierowcy
        /// </summary>
        public string Driverid { get; set; }
        /// <summary>
        /// rodzaj logowania: &quot;PWD&quot;-hasło/&quot;ID&quot;-id_karty/&quot;AUTO&quot;/&quot;SWITCH&quot;
        /// </summary>
        public string Logintype { get; set; }
        /// <summary>
        /// &quot;D&quot;-kierowca/&quot;P&quot;-pasażer
        /// </summary>
        public string Loginmode { get; set; }
        /// <summary>
        /// czas zalogowania kierowcy
        /// </summary>
        public DateTime? DtLogin { get; set; }
        /// <summary>
        /// czas początku pracy w LoginMode
        /// </summary>
        public DateTime? DtStart { get; set; }
        /// <summary>
        /// czas końca pracy w LoginMode
        /// </summary>
        public DateTime? DtStop { get; set; }
    }
}
