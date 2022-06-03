using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRoute
    {
        public SfmRoute()
        {
            SfmRouteViaPoints = new HashSet<SfmRouteViaPoint>();
        }

        public int IdSfmRoute { get; set; }
        /// <summary>
        /// ID taboru
        /// </summary>
        public int IdTabor { get; set; }
        /// <summary>
        /// 0/1 - Corridor Control
        /// </summary>
        public short? Corridor { get; set; }
        /// <summary>
        /// DT początku trasy
        /// </summary>
        public DateTime? DtStart { get; set; }
        /// <summary>
        /// DT końca trasy
        /// </summary>
        public DateTime? DtStop { get; set; }
        /// <summary>
        /// DT ostatniego alarmu CC
        /// </summary>
        public DateTime? DtAlert { get; set; }
        /// <summary>
        /// długość trasy [km]
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// typ serwera mapy
        /// </summary>
        public string Maptype { get; set; }
        /// <summary>
        /// ID wyznaczonej trasy
        /// </summary>
        public string RouteId { get; set; }
        /// <summary>
        /// 0/1 - wysłana do pojazdu
        /// </summary>
        public short? Issend { get; set; }
        /// <summary>
        /// 0/1 - wymagana ponowna kalkulacja
        /// </summary>
        public short? Istoupdate { get; set; }
        /// <summary>
        /// profil pojazdu do wyznaczania trasy
        /// </summary>
        public string Vehprofile { get; set; }
        /// <summary>
        /// 0/1 - do usunięcia na terminalu
        /// </summary>
        public short? Istodelete { get; set; }
        public string RouteDetails { get; set; }

        public virtual ICollection<SfmRouteViaPoint> SfmRouteViaPoints { get; set; }
    }
}
