using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRouteEvent
    {
        public int IdSfmRouteEvent { get; set; }
        /// <summary>
        /// ID wyznaczonej trasy
        /// </summary>
        public int IdSfmRoute { get; set; }
        /// <summary>
        /// ID pozycji na wyznaczonej trasie
        /// </summary>
        public int IdSfmRoutePoi { get; set; }
        /// <summary>
        /// typ obiektu SPEED
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id obiektu SPEED (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
    }
}
