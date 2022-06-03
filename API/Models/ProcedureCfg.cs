using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProcedureCfg
    {
        public int IdProcedureCfg { get; set; }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string StdProcedure { get; set; }
        public string UserProcedure { get; set; }
        public int Standard { get; set; }
        public int Obligatory { get; set; }
        public int? Enabled { get; set; }
        public string ActivityGroup { get; set; }
        /// <summary>
        /// 0 - procedura, 1 - sql
        /// </summary>
        public int? Type { get; set; }
        public int? EnabledSql { get; set; }
        public string StdSql { get; set; }
        public string UserSql { get; set; }
        public string OptSql { get; set; }
        public string UserCountSql { get; set; }
        public string OptCountSql { get; set; }
        public string ParamsDesc { get; set; }
        public string ParamsProcedure { get; set; }
    }
}
