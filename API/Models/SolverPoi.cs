using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoi
    {
        public SolverPoi()
        {
            SolverFleetPositions = new HashSet<SolverFleetPosition>();
            SolverFleets = new HashSet<SolverFleet>();
            SolverOrderSolverPois = new HashSet<SolverOrder>();
            SolverOrders = new HashSet<SolverOrder>();
            SolverPerPoiBorderCrossingSolvers = new HashSet<SolverPerPoiBorderCrossing>();
            SolverPerPoiFlatRates = new HashSet<SolverPerPoiFlatRate>();
            SolverPoi2PoiMatricesValueS = new HashSet<SolverPoi2PoiMatrixValue>();
            SolverPoi2PoiMatricesValueSolverPoi = new HashSet<SolverPoi2PoiMatrixValue>();
            SolverPoiGates = new HashSet<SolverPoiGate>();
            SolverPoiPairFlatRatePricelistSolverPois = new HashSet<SolverPoiPairFlatRatePricelist>();
            SolverPoiPairFlatRatePricelists = new HashSet<SolverPoiPairFlatRatePricelist>();
            SolverPoiRelationSolverPois = new HashSet<SolverPoiRelation>();
            SolverPoiRelations = new HashSet<SolverPoiRelation>();
        }

        public int SolverTaskId { get; set; }
        public int SolverPoiId { get; set; }
        public string CountryCode2 { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double ServiceTimeAdm { get; set; }
        public double ServiceTimePerWeightUnit { get; set; }
        public int? PricelistId { get; set; }

        public virtual SolverCountry SolverCountry { get; set; }
        public virtual SolverPricelist SolverPricelist { get; set; }
        public virtual SolverPerPoiBorderCrossing SolverPerPoiBorderCrossingSolverNavigation { get; set; }
        public virtual SolverPoiEquipmentRequirement SolverPoiEquipmentRequirement { get; set; }
        public virtual ICollection<SolverFleetPosition> SolverFleetPositions { get; set; }
        public virtual ICollection<SolverFleet> SolverFleets { get; set; }
        public virtual ICollection<SolverOrder> SolverOrderSolverPois { get; set; }
        public virtual ICollection<SolverOrder> SolverOrders { get; set; }
        public virtual ICollection<SolverPerPoiBorderCrossing> SolverPerPoiBorderCrossingSolvers { get; set; }
        public virtual ICollection<SolverPerPoiFlatRate> SolverPerPoiFlatRates { get; set; }
        public virtual ICollection<SolverPoi2PoiMatrixValue> SolverPoi2PoiMatricesValueS { get; set; }
        public virtual ICollection<SolverPoi2PoiMatrixValue> SolverPoi2PoiMatricesValueSolverPoi { get; set; }
        public virtual ICollection<SolverPoiGate> SolverPoiGates { get; set; }
        public virtual ICollection<SolverPoiPairFlatRatePricelist> SolverPoiPairFlatRatePricelistSolverPois { get; set; }
        public virtual ICollection<SolverPoiPairFlatRatePricelist> SolverPoiPairFlatRatePricelists { get; set; }
        public virtual ICollection<SolverPoiRelation> SolverPoiRelationSolverPois { get; set; }
        public virtual ICollection<SolverPoiRelation> SolverPoiRelations { get; set; }
    }
}
