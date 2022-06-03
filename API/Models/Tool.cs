using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Tool
    {
        public Tool()
        {
            ToolGroupDefinitions = new HashSet<ToolGroupDefinition>();
        }

        public int ToolId { get; set; }
        public int ToolTypeId { get; set; }
        public int? ToolCategoryId { get; set; }
        public string Name { get; set; }
        public string Sqldefinition { get; set; }
        public string Pkcolumn { get; set; }
        public string ParamsColumn { get; set; }
        public string ToolGroupColumn { get; set; }
        public string ReportGroupColumn { get; set; }
        public string CaptionColumn { get; set; }
        public string Plugin { get; set; }
        public string PluginParams { get; set; }
        public string PluginMethod { get; set; }
        public int? CustomToolId { get; set; }
        public int MultiExecute { get; set; }
        public int? SmallIconId { get; set; }
        public int? LargeIconId { get; set; }
        public int? DesktopIconId { get; set; }
        public int? AutoRefresh { get; set; }
        public int? AccessLevel { get; set; }
        public int? ObjectId { get; set; }
        public int? GridTypeId { get; set; }
        public int Autoprepare { get; set; }
        public int? EmptyToolGroupId { get; set; }
        public string QueryHint { get; set; }
        public string ReportSource { get; set; }
        public string CustomReportSource { get; set; }
        public string ReportParams { get; set; }
        public string CustomReportParams { get; set; }

        public virtual ICollection<ToolGroupDefinition> ToolGroupDefinitions { get; set; }
    }
}
