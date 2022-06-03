using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppNewAction
    {
        public AppNewAction()
        {
            AppNewActionsUses = new HashSet<AppNewActionsUse>();
        }

        public int IdAppNewActions { get; set; }
        public string WindowClassName { get; set; }
        public string ActionName { get; set; }
        public DateTime DtCreate { get; set; }

        public virtual ICollection<AppNewActionsUse> AppNewActionsUses { get; set; }
    }
}
