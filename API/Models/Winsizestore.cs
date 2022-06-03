using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Winsizestore
    {
        public int IdWinsizestore { get; set; }
        /// <summary>
        /// klasa okna
        /// </summary>
        public string Winclass { get; set; }
        /// <summary>
        /// podtyp okna
        /// </summary>
        public int? Wintype { get; set; }
        /// <summary>
        /// tryb wyświetlania
        /// </summary>
        public string Wintryb { get; set; }
        /// <summary>
        /// id użytkownika
        /// </summary>
        public int? IdUser { get; set; }
        /// <summary>
        /// pozycja: góra
        /// </summary>
        public int? Wintop { get; set; }
        /// <summary>
        /// pozycja: lewo
        /// </summary>
        public int? Winleft { get; set; }
        /// <summary>
        /// wysokość okna
        /// </summary>
        public int? Winheight { get; set; }
        /// <summary>
        /// szerokość okna
        /// </summary>
        public int? Winwidth { get; set; }
        /// <summary>
        /// skala okna względem standardu [%]
        /// </summary>
        public double? Winscale { get; set; }
    }
}
