using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EmailCross
    {
        public int IdEmailCross { get; set; }
        /// <summary>
        /// id definicji parametrów skrzynki pocztowej
        /// </summary>
        public int? IdEmailSrv { get; set; }
        /// <summary>
        /// id obiektu SPEED
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id rekordu obiektu SPEED
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// (0-64) id funkcji skrzynki pocztowej pełnionej w ramach obiektu
        /// </summary>
        public short? Funkcja { get; set; }
    }
}
