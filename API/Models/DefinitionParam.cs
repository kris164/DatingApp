using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DefinitionParam
    {
        public int DefinitionParamId { get; set; }
        public int? DefinitionId { get; set; }
        public string Param { get; set; }
        public string Label { get; set; }
        public object DefaultValue { get; set; }
        public string Sqldefinition { get; set; }
        public int? ParameterTypeId { get; set; }
        public int System { get; set; }
    }
}
