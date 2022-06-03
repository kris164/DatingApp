using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WinFrmCalcFld
    {
        public int IdWinFrmCalcFld { get; set; }
        public int WinFrmCalcSpId { get; set; }
        public string TblName { get; set; }
        public string FldName { get; set; }
        public int FldType { get; set; }
        public int FldSize { get; set; }
        public string FldLbl { get; set; }
        public int FldOk { get; set; }
        public string FldSource { get; set; }
    }
}
