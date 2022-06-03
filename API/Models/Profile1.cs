using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Profile1
    {
        public Profile1()
        {
            AppNewActionsUses = new HashSet<AppNewActionsUse>();
        }

        public int IdProfile { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Program { get; set; }
        public byte[] Prawa { get; set; }
        public int? Blobver { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }

        public virtual ICollection<AppNewActionsUse> AppNewActionsUses { get; set; }
    }
}
