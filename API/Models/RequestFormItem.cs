using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestFormItem
    {
        public int RequestFormItemId { get; set; }
        public int? RequestFormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? RequestFormSectionId { get; set; }
        public string Type { get; set; }
        public string Attribute { get; set; }
        public int? RequestFormItemTypeId { get; set; }
        public int? ItemOrder { get; set; }
        public int? ReadOnly { get; set; }
        public int? Required { get; set; }
        public string Columns { get; set; }
        public string Data { get; set; }
        public string EmptyData { get; set; }
        public string Action { get; set; }
        public int? Disabled { get; set; }
        public string Constraints { get; set; }
        public int? DisableEdit { get; set; }
    }
}
