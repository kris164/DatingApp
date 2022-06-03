using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileUpdate
    {
        public int MobileUpdateId { get; set; }
        public string Sql { get; set; }
        public string CustomSql { get; set; }
        public int? DatabaseVersion { get; set; }
        public int? System { get; set; }
        public int? Enabled { get; set; }
        public int? MobileApplicationId { get; set; }
        public int? MasterDatabaseVersion { get; set; }
        public string Description { get; set; }
        public string ApplicationTitle { get; set; }
        public int? MasterMobileUpdateId { get; set; }
        public int? MobileApplicationListId { get; set; }
        public int? Version { get; set; }
        public int? Sequence { get; set; }
    }
}
