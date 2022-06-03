using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmActivity
    {
        public int IdSfmActivity { get; set; }
        /// <summary>
        /// typ terminala
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// id pozycji GPS
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// id taboru SPEED
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id 1. kierowcy SPEED
        /// </summary>
        public int? IdKierowcy1 { get; set; }
        /// <summary>
        /// id 2. kierowcy SPEED
        /// </summary>
        public int? IdKierowcy2 { get; set; }
        /// <summary>
        /// czas utworzenia / zapisu do BD
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas początku aktywności
        /// </summary>
        public DateTime? DtStart { get; set; }
        /// <summary>
        /// czas końca aktywności
        /// </summary>
        public DateTime? DtStop { get; set; }
        /// <summary>
        /// unikalne ID aktywności w syst.zewn.
        /// </summary>
        public string Lid { get; set; }
        /// <summary>
        /// kod aktywności w syst.zewn.
        /// </summary>
        public string Activity { get; set; }
        /// <summary>
        /// ident. aktywności w syst.zewn.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// czas trwania jazdy [s]
        /// </summary>
        public int? DriveDuration { get; set; }
        /// <summary>
        /// początkowy licznik kilometrów [km]
        /// </summary>
        public int? LkmStart { get; set; }
        /// <summary>
        /// końcowy licznik kilometrów [km]
        /// </summary>
        public int? LkmStop { get; set; }
        /// <summary>
        /// początkowy stan zużytego paliwa [L]
        /// </summary>
        public int? TfuStart { get; set; }
        /// <summary>
        /// końcowy stan zużytego paliwa [L]
        /// </summary>
        public int? TfuStop { get; set; }
    }
}
