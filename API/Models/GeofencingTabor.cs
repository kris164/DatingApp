using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// tabela do łączenia geofencingu z pojazdami
    /// </summary>
    public partial class GeofencingTabor
    {
        public int IdGeofencingTabor { get; set; }
        public int IdGeofencing { get; set; }
        public int IdTabor { get; set; }
    }
}
