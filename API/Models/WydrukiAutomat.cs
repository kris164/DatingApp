using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// lista pozycji dla serwera wydruków
    /// </summary>
    public partial class WydrukiAutomat
    {
        public int IdWydrukiAutomat { get; set; }
        /// <summary>
        /// opis obiektu (np. &quot;Fakt.nr DCX4125/0015&quot;)
        /// </summary>
        public string ObjInfo { get; set; }
        /// <summary>
        /// id obiektu SPEED
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// id rekordu obiektu SPEED
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// nazwa formatki raportu (plik *.rpt)
        /// </summary>
        public string LayoutName { get; set; }
        /// <summary>
        /// pole grupujące pakiet wydruków
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 0-gotowy do wydruku /1-wydrukowany /2-wykonany PostProcess /99-błąd
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// treść błędu podczas wydruku
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// DT dodania do listy
        /// </summary>
        public DateTime? CreateDt { get; set; }
        /// <summary>
        /// DT statusu po wydruku
        /// </summary>
        public DateTime? PrintDt { get; set; }
        /// <summary>
        /// wartość &gt;0 oznacza IdUserSesion
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// wyróżnik dla listy mailingowej
        /// </summary>
        public int? Wyroznik { get; set; }
        /// <summary>
        /// formatka użyta do wydruku (plik *.rpt)
        /// </summary>
        public string LayoutNameUse { get; set; }
    }
}
