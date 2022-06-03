using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpBankTransferPrepare
    {
        public int IdTmpBankTransferPrepare { get; set; }
        public int? SessionId { get; set; }
        public string RecType { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string RecNo { get; set; }
        public string Loc { get; set; }
        public int? ClientFromId { get; set; }
        public int? AccountFromId { get; set; }
        public int? ClientToId { get; set; }
        public int? AccountToId { get; set; }
        public string Curr { get; set; }
        public double? Value { get; set; }
        public int? State { get; set; }
        public int? UserAction { get; set; }
        public int? TransferType { get; set; }
        public string InfoForUser { get; set; }
        public int? CheckPointReq { get; set; }
        public int? Correction { get; set; }
        public int? CorrectionId { get; set; }
        public int? SplitPayment { get; set; }
        public int? CorrectionSourceId { get; set; }
    }
}
