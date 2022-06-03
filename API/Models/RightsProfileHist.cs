using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RightsProfileHist
    {
        public RightsProfileHist()
        {
            RightsProfileItemHists = new HashSet<RightsProfileItemHist>();
        }

        public int IdRightsProfileHist { get; set; }
        public int? ProfileType { get; set; }
        public int? ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string RightsAppName { get; set; }
        public int? RightsBlobVer { get; set; }
        public byte[] RightsData { get; set; }
        public string RightsHash { get; set; }
        public string ModifyAction { get; set; }
        public DateTime? ModifyDt { get; set; }
        public int? ModifyUserId { get; set; }
        public string ModifyAppVersion { get; set; }
        public string ModifyNotes { get; set; }

        public virtual ICollection<RightsProfileItemHist> RightsProfileItemHists { get; set; }
    }
}
