using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Obiekty systemowe
    /// </summary>
    public partial class Object
    {
        public int IdObject { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int Anomaly { get; set; }
        public int Amount { get; set; }
        public int? ApplicationModuleId { get; set; }
    }
}
