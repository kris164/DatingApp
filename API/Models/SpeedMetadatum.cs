using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SpeedMetadatum
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int? FieldSize { get; set; }
        public int? IsIdentity { get; set; }
        public object FieldDesc { get; set; }
    }
}
