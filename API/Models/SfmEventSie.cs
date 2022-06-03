using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmEventSie
    {
        public int IdSfmEvent { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public long? Recid { get; set; }
        public int? Vehid { get; set; }
        public int? Driverid { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtStop { get; set; }
        public short? Eventtype { get; set; }
        public int? Distance { get; set; }
        public int? Startposid { get; set; }
        public int? Startodometer { get; set; }
        public int? Endposid { get; set; }
        public int? Endodometer { get; set; }
        public string Descriptionid { get; set; }
        public string Description { get; set; }
        public int? Fuelused { get; set; }
        public int? Occurrances { get; set; }
        public int? Totalduration { get; set; }
        public string Valuestr { get; set; }
        public string Valuefmt { get; set; }
    }
}
