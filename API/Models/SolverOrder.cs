using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrder
    {
        public SolverOrder()
        {
            SolverFleet2OrdersMatricesValue = new HashSet<SolverFleet2OrdersMatrixValue>();
            SolverOrdersFeatures = new HashSet<SolverOrdersFeature>();
            SolverOrdersItems = new HashSet<SolverOrdersItem>();
            SolverOrdersRelationRestrictionSolverNavigations = new HashSet<SolverOrdersRelationRestriction>();
            SolverOrdersRelationRestrictionSolvers = new HashSet<SolverOrdersRelationRestriction>();
            SolverRouteEventOrders = new HashSet<SolverRouteEventOrder>();
        }

        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public int? SrcPoiId { get; set; }
        public int? DstPoiId { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public double? Amount { get; set; }
        public string AmountUnit { get; set; }
        public DateTime? LoadDate { get; set; }
        public int TypeId { get; set; }

        public virtual SolverPoi S { get; set; }
        public virtual SolverPoi SolverPoi { get; set; }
        public virtual SolverOrderType Type { get; set; }
        public virtual SolverOrderEquipmentRequirement SolverOrderEquipmentRequirement { get; set; }
        public virtual SolverOrderServiceTime SolverOrderServiceTime { get; set; }
        public virtual ICollection<SolverFleet2OrdersMatrixValue> SolverFleet2OrdersMatricesValue { get; set; }
        public virtual ICollection<SolverOrdersFeature> SolverOrdersFeatures { get; set; }
        public virtual ICollection<SolverOrdersItem> SolverOrdersItems { get; set; }
        public virtual ICollection<SolverOrdersRelationRestriction> SolverOrdersRelationRestrictionSolverNavigations { get; set; }
        public virtual ICollection<SolverOrdersRelationRestriction> SolverOrdersRelationRestrictionSolvers { get; set; }
        public virtual ICollection<SolverRouteEventOrder> SolverRouteEventOrders { get; set; }
    }
}
